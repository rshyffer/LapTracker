using System;

namespace LapTracker
{
    public class Lap
    {
        private static long nextId;
        private long id;
        private DateTime time;
        private string barcodeId;
        private int scannerId;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }


        public string BarcodeId
        {
            get { return barcodeId; }
            set { barcodeId = value; }
        }

        public int ScannerId
        {
            get { return scannerId; }
            set { scannerId = value; }
        }

        public static Lap CreateFromLine(string line)
        {
            try
            {
                var lines = line.Split(',');
                var dateString = String.Format("{0} {1}", lines[0], lines[1]);
                var time = DateTime.Parse(dateString);
                var scannerId = int.Parse(lines[3]);
                var barcodeId = lines[4];
                return new Lap() { Time = time, BarcodeId = barcodeId, ScannerId = scannerId, Id = Lap.nextId++ };
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
