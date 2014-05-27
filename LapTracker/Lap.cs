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
            get { return (long)base["id"]; }
            set { base["id"] = value; }
        }

        public DateTime Time
        {
            get { return (DateTime)base["time"]; }
            set { base["time"] = value; }
        }


        public string BarcodeId
        {
            get { return (string)base["barcodeId"]; }
            set { base["barcodeId"] = value; }
        }

        public int ScannerId
        {
            get { return (int)base["scannerId"]; }
            set { base["scannerId"] = value; }
        }
       
    }
}
