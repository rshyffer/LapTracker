using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LapTracker
{
    public partial class Form1 : Form
    {
        private Laps laps;

        public Form1()
        {
            InitializeComponent();
            laps = new Laps();           
            lapGridView.DataSource = laps;
            lapGridView.AutoResizeColumns();
            laps.Load("laps.csv");
        }
        
        private void importButton_Click(object sender, EventArgs e)
        {
            string fileName = this.fileNameTextBox.Text;           
            laps.AddLapsFromReader(fileName);                        
           
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.AutoUpgradeEnabled = true;
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Load Barcode File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.fileNameTextBox.Text = openFileDialog.FileName; 
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            laps.RemoveDuplicates();
            laps.Save("laps.csv");
        }
    }
}
