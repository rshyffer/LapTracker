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
        private LapDatabase lapDatabase = new LapDatabase();

        public Form1()
        {
            InitializeComponent();
            lapGridView.BindingContext = this.BindingContext;
        }
        
        private void importButton_Click(object sender, EventArgs e)
        {
            string fileName = this.fileNameTextBox.Text;
            if (!File.Exists(fileName))
            {
                return;
            }

            var laps = new List<Lap>();
            using (var reader = File.OpenText(fileName))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var lap = Lap.CreateFromLine(line);
                    if (lap != null)
                    {
                        laps.Add(lap);
                    }
                }
            }
            
            //lapDatabase.AddLaps(laps);

            //var dataTable = lapDatabase.GetAllLaps();
            lapGridView.DataSource = laps;// dataTable.Tables[0].DefaultView;
           
           // bindingSource1.DataMember = "laps";
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
    }
}
