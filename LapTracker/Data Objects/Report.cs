using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LapTracker
{
    class Report : DataTable
    {
        private const string tableName = "Report";
        private DateTime startDate;
        private DateTime endDate;

        public Report()
        {
            TableName = tableName;
            Columns.Add(new DataColumn("Id", typeof(long)) { AutoIncrement = true, AutoIncrementSeed = 0, AutoIncrementStep = 1, ReadOnly = true });
            Columns.Add(new DataColumn("FirstName", typeof(string)));
            Columns.Add(new DataColumn("LastName", typeof(string)));
            Columns.Add(new DataColumn("TeacherName", typeof(string)));
            Columns.Add(new DataColumn("Grade", typeof(string)));
            Columns.Add(new DataColumn("Laps", typeof(int)));
            Columns.Add(new DataColumn("ParticipationDays", typeof(int)));
        }

        private ReportRow CreateNewRow()
        {
            return (ReportRow)NewRow();
        }

        protected override Type GetRowType()
        {
            return typeof(ReportRow);
        }

        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new ReportRow(builder);
        }

        // Note that this overwrites the file, you should load the existing contents before saving
        public bool Save(string fileName)
        {
            try
            {
                using (var writer = File.CreateText(fileName))
                {
                    writer.WriteLine("Id,First Name, Last Name, Teacher Name, Grade, Laps");
                    foreach (var line in from ReportRow row in Rows
                                         select string.Format("{0},{1},{2},{3},{4},{5}",
                                             row.Id, row.FirstName, row.LastName, row.TeacherName, row.Grade, row.Laps))
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

        public void Create(DateTime startDate, DateTime endDate, Laps laps, Runners runners)
        {
            this.startDate = startDate;
            this.endDate = endDate;

            var relevantLaps = from Lap lap in laps.AsEnumerable()
                               where lap.Time >= startDate && lap.Time <= endDate
                               select lap;

            var barcodeIds = (from Lap row in relevantLaps select row.BarcodeId).Distinct();
            foreach (var id in barcodeIds)
            {
                var matchingRunner = (from Runner runner in runners.AsEnumerable()
                                      where runner.BarcodeId == id
                                      select runner).FirstOrDefault();
                if (matchingRunner != null)
                {
                    var runnerLaps = (from Lap lap in relevantLaps where lap.BarcodeId == id select lap);
                    var row = CreateNewRow();
                    row.FirstName = matchingRunner.FirstName.Trim();
                    row.LastName = matchingRunner.LastName.Trim();
                    row.Grade = matchingRunner.Grade.Trim();
                    row.TeacherName = matchingRunner.TeacherName.Trim();
                    row.Laps = runnerLaps.Count();
                    row.ParticipationDays = (from Lap lap in runnerLaps select lap.Time.Date).Distinct().Count(); 
                    Rows.Add(row);
                }
            }

        }

        public string DefaultName()
        {
            return string.Format("Report for {0} to {1}.csv", startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));
        }
    }
}
