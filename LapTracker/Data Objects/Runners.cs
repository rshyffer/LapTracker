using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LapTracker
{
    public class Runners : DataTable
    {
        private const string tableName = "Runners";

        public Runners()
        {
            TableName = tableName;
            Columns.Add(new DataColumn("Id", typeof(long)) { AutoIncrement = true, AutoIncrementSeed = 0, AutoIncrementStep = 1, ReadOnly = true});
            Columns.Add(new DataColumn("BarcodeId", typeof(string)) {Unique = true});
            Columns.Add(new DataColumn("FirstName", typeof(string)));
            Columns.Add(new DataColumn("LastName", typeof(string)));
            Columns.Add(new DataColumn("TeacherName", typeof(string)));
            Columns.Add(new DataColumn("Grade", typeof(string))); 
        }

        private void AddRunnerFromDatabaseLine(string line)
        {
            var runner = CreateNewRow();
            try
            {
                var lines = line.Split(',');
                runner.Id = long.Parse(lines[0]);
                runner.BarcodeId = lines[1];
                runner.FirstName = lines[2];
                runner.LastName = lines[3];
                runner.TeacherName = lines[4];
                runner.Grade = lines[5];

                Rows.Add(runner);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return;
            }
        }

        private Runner CreateNewRow()
        {
            return (Runner)NewRow();
        }

        protected override Type GetRowType()
        {
            return typeof(Runner);
        }

        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new Runner(builder);
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
                        AddRunnerFromDatabaseLine(line);
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
                    foreach (var line in from Runner row in Rows select string.Format("{0},{1},{2},{3},{4},{5}", 
                                             row.Id, row.BarcodeId, row.FirstName, 
                                             row.LastName, row.TeacherName, row.Grade))
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
    }
}
