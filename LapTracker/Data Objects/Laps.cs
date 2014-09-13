using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LapTracker.Properties;

namespace LapTracker
{
    public class Laps : DataTable
    {
        private const string tableName = "Laps";
        private static readonly TimeSpan minimumLapTime;

        static Laps()
        {
            int secondsSetting;
            if (!int.TryParse(Settings.Default.MinimumLapSeconds, out secondsSetting))
            {
                secondsSetting = 60;
            }

            minimumLapTime = TimeSpan.FromSeconds(secondsSetting);
        }

        public Laps()
        {
           
            TableName = tableName;
            Columns.Add(new DataColumn("Id", typeof (long)){AutoIncrement = true, AutoIncrementSeed = 0, AutoIncrementStep = 1, ReadOnly = true});
            Columns.Add(new DataColumn("Time", typeof (DateTime)));
            Columns.Add(new DataColumn("BarcodeId", typeof (string)));
            Columns.Add(new DataColumn("ScannerId", typeof (int)));
        }

        public DateTime MinDate
        {
            get
            {
                return (from Lap row in Rows select row.Time).Min();
            }
            
        }

        public DateTime MaxDate
        {
            get
            {
                return (from Lap row in Rows select row.Time).Max();
            }
        }

        public bool AddLapsFromReader(string fileName)
        {          
            if (!File.Exists(fileName))
            {
                return false;
            }
            try
            {
                using (var reader = File.OpenText(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        AddLapFromReaderLine(line);
                    }
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        private void AddLapFromReaderLine(string line)
        {          
            try
            {
                var lap = CreateNewRow();
                var lines = line.Split(',');
                var dateString = String.Format("{0} {1}", lines[0], lines[1]);
                lap.Time = DateTime.Parse(dateString);
                lap.ScannerId = int.Parse(lines[3]);
                lap.BarcodeId = lines[4];
				var rowCount = Rows.Count;
                Rows.Add(lap);
				while (Rows.Count > rowCount + 1)
				{
					Rows.RemoveAt(Rows.Count - 1);
				}
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return;
            }
        }

        public void Add(Laps lapsToAdd)
        {
            foreach (Lap row in lapsToAdd.Rows)
            {
				if (row.IsNull("BarcodeId")) {
					continue;
				}
                var lap = CreateNewRow();
                lap.Time = row.Time;
                lap.ScannerId = row.ScannerId;
                lap.BarcodeId = row.BarcodeId;
                Rows.Add(lap);
            }
        }

        private void AddLapFromDatabaseLine(string line)
        {
            var lap = CreateNewRow();
            try
            {
                var lines = line.Split(',');
                lap.Id = long.Parse(lines[0]);
                lap.Time = DateTime.Parse(lines[1]);
                lap.ScannerId = int.Parse(lines[2]);
                lap.BarcodeId = lines[3];
                Rows.Add(lap);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return;
            }
        }

        private Lap CreateNewRow()
        {
            return (Lap) NewRow();
        }

        protected override Type GetRowType()
        {
            return typeof (Lap);
        }

        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new Lap(builder);
        }

        public bool Load(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return false;
            }

            try
            {
                using (var reader = File.OpenText(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (line.StartsWith("#"))
                        {
                            continue;                            
                        }
                        AddLapFromDatabaseLine(line);
                    }
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        // Note that this overwrites the file, you should load the existing contents before saving
        public bool Save(string fileName)
        {
            try
            {
                using (var writer = File.CreateText(fileName))
                {
                    foreach (var line in from Lap row in Rows select string.Format("{0},{1},{2},{3}", row.Id, row.Time, row.ScannerId, row.BarcodeId))
                    {
                        writer.WriteLine(line);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }         
        }

        public void RemoveDuplicates()
        {
            var rowsToRemove = GetRowsToRemove();
            RemoveRows(rowsToRemove);
        }

        private static void RemoveRows(IEnumerable<Lap> rowsToRemove)
        {
            foreach (var row in rowsToRemove)
            {
                row.Delete();
            }
        }

        private IEnumerable<Lap> GetRowsToRemove()
        {
            var rowsToRemove = new List<Lap>();
            var barcodeIds = (from Lap row in Rows select row.BarcodeId).Distinct();
            foreach (string id in barcodeIds)
            {
                var id1 = id;
                var lapsForId = (from Lap row in Rows where row.BarcodeId == id1 orderby row.Time ascending select row);
                rowsToRemove.AddRange(FilterLapsTooCloseInTime(lapsForId, minimumLapTime));
            }
            return rowsToRemove;
        }

        private static IEnumerable<Lap> FilterLapsTooCloseInTime(IEnumerable<Lap> lapsForId, TimeSpan minInterval)
        {
            var rowsToRemove = new List<Lap>();
            var lastTime = DateTime.MinValue;
            foreach (var lap in lapsForId)
            {
                if (lap.Time - lastTime < minInterval)
                {
                    rowsToRemove.Add(lap);
                }
                lastTime = lap.Time;
            }
            return rowsToRemove;
        }
    }
}
