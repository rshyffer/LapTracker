using System;
using System.Data;

namespace LapTracker
{
    public class Lap : DataRow
    {
       
        protected internal Lap(DataRowBuilder builder) : base(builder)
        {
        }

        public long Id
        {
            get { return (long)base["Id"]; }
            set { base["Id"] = value; }
        }

        public DateTime Time
        {
            get { return (DateTime)base["Time"]; }
            set { base["Time"] = value; }
        }


        public string BarcodeId
        {
            get { return (string)base["BarcodeId"]; }
            set { base["BarcodeId"] = value; }
        }

        public int ScannerId
        {
            get { return (int)base["ScannerId"]; }
            set { base["ScannerId"] = value; }
        }
       
    }
}
