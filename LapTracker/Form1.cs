using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LapTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private LapDatabase lapDatabase = new LapDatabase();
        private void importButton_Click(object sender, EventArgs e)
        {
            var laps = new List<Lap>
            {
                new Lap() {BarcodeId = "ABC123", Time = DateTime.Now - TimeSpan.FromMinutes(3)},
                new Lap() {BarcodeId = "ABC124", Time = DateTime.Now - TimeSpan.FromMinutes(2)},
                new Lap() {BarcodeId = "ABC125", Time = DateTime.Now - TimeSpan.FromMinutes(1)},
                new Lap() {BarcodeId = "ABC126", Time = DateTime.Now}
            };
            lapDatabase.AddLaps(laps);

            laps = lapDatabase.GetAllLaps();
        }
    }
}
