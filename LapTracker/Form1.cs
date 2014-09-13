using System;
using System.IO;
using System.Windows.Forms;

namespace LapTracker
{
    public partial class Form1 : Form
    {
        private Laps _laps;
        private Runners _runners;
        private const string RunnersFile = "runners.csv";
        private const string LapsFile = "laps.csv";
        public Form1()
        {
            InitializeComponent();
            SetLapsDatasource();
            SetRunnersDatasource();
        }

        private void SetRunnersDatasource()
        {
            _runners = new Runners();
            _runners.Load(RunnersFile);
        }

        private void SetLapsDatasource()
        {
            _laps = new Laps();
            _laps.Load(LapsFile);
        }

        private void importLapsButton_Click(object sender, EventArgs e)
        {
            var window = new ImportWizard();
            var result = window.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                _laps.Add(window.Laps);
                _laps.RemoveDuplicates();
                SaveLaps();
            }
        }

        private void manageRunnersButton_Click(object sender, EventArgs e)
        {
            var window = new RunnersWizard(_runners);
            var result = window.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                _runners.Dispose();
                _runners = window.Runners;
                SaveRunners();
               
            }
            else
            {
                _runners.Dispose();
                SetRunnersDatasource();
            }
        }

        private void SaveRunners()
        {
            if (File.Exists(RunnersFile))
            {
                var backupFile = String.Format("runners-{0}.csv", DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss"));
                File.Move(RunnersFile, backupFile);
            }
            _runners.Save(RunnersFile);
        }

        private void SaveLaps()
        {
            if (File.Exists(LapsFile))
            {
                var backupFile = String.Format("laps-{0}.csv", DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss"));
                File.Move(LapsFile, backupFile);
            }
            _laps.Save(LapsFile);
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            var window = new ReportWizard(_laps, _runners);
            window.ShowDialog(this);
        }
    }
}
