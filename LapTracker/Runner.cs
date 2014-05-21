using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LapTracker
{
    public class Runner
    {
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string BarcodeId
        {
            get { return barcodeId; }
            set { barcodeId = value; }
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        private long id;
        private string barcodeId;
        private string lastName;
        private string firstName;        
    }

    public class Lap
    {
        public string BarcodeId
        {
            get { return barcodeId; }
            set { barcodeId = value; }
        }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        private long id;
        private DateTime time;
        private string barcodeId;
    }
}
