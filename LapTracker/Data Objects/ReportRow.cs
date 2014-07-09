using System.Data;

namespace LapTracker
{
    class ReportRow : DataRow
    {
        protected internal ReportRow(DataRowBuilder builder) : base(builder)
        {

        }

        public long Id
        {
            get { return (long)base["Id"]; }
            set { base["Id"] = value; }
        }

        public string FirstName
        {
            get { return (string)base["FirstName"]; }
            set { base["FirstName"] = value; }
        }

        public string LastName
        {
            get { return (string)base["LastName"]; }
            set { base["LastName"] = value; }
        }

        public string TeacherName
        {
            get { return (string)base["TeacherName"]; }
            set { base["TeacherName"] = value; }
        }

        public string Grade
        {
            get { return (string)base["Grade"]; }
            set { base["Grade"] = value; }
        }

        public int Laps
        {
            get { return (int)base["Laps"]; }
            set { base["Laps"] = value; }
        }

        public int ParticipationDays
        {
            get { return (int)base["ParticipationDays"]; }
            set { base["ParticipationDays"] = value; }

        }
    }
}