using System;
using System.Windows.Forms;

namespace LapTracker
{
    public partial class Form1 : Form
    {
        private Laps laps;
        private Runners runners;
        private Report report;

        public Form1()
        {
            InitializeComponent();
            SetLapsDatasource();
            SetRunnersDatasource();
        }

        private void SetRunnersDatasource()
        {
            runners = new Runners();
            runnerGridView.DataSource = runners;
            runnerGridView.AutoResizeColumns();
            runners.Load("runners.csv");
            
            var idColumn = runnerGridView.Columns["Id"];
            if (idColumn != null) idColumn.Visible = false;
        }

        private void SetLapsDatasource()
        {
            laps = new Laps();
            lapGridView.DataSource = laps;
            lapGridView.AutoResizeColumns();
            laps.Load("laps.csv");

            var idColumn = lapGridView.Columns["Id"];
            if (idColumn != null) idColumn.Visible = false;
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

        private void saveRunnersButton_Click(object sender, EventArgs e)
        {
            runners.Save("runners.csv");
        }

        private void createReport_Click(object sender, EventArgs e)
        {
            var startDate = startDatePicker.Value;           
            var endDate = endDatePicker.Value;
            report = new Report();
            report.Create(startDate, endDate, laps, runners);
            reportDataGridView.DataSource = report;
           
            var idColumn = reportDataGridView.Columns["Id"];
            if (idColumn != null) idColumn.Visible = false;

            reportDataGridView.AutoResizeColumns();
        }

        private void saveReportButton_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.CheckPathExists = true;
            dialog.DefaultExt = ".csv";
            dialog.FileName = report.DefaultName();
            dialog.Filter = "Comma Separated Values (.csv)|.csv";
            dialog.FilterIndex = 0;
            dialog.OverwritePrompt = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                report.Save(dialog.FileName);
            }
        }
    }
}
