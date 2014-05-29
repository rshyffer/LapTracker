
using System.Data;

namespace LapTracker
{
    public class Runner : DataRow
    {
       
        protected internal Runner(DataRowBuilder builder) : base(builder)
        {
        }

        public long Id
        {
            get { return (long)base["Id"]; }
            set { base["Id"] = value; }
        }

        public string BarcodeId
        {
            get { return (string)base["BarcodeId"]; }
            set { base["BarcodeId"] = value; }
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
       
    }
}
