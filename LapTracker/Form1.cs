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
            runners.Load("runners.csv");
        }

        private void SetLapsDatasource()
        {
            laps = new Laps();
            laps.Load("laps.csv");
        }

        private void importLapsButton_Click(object sender, EventArgs e)
        {
            var window = new ImportWizard();
            var result = window.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                laps.Add(window.Laps);
                laps.RemoveDuplicates();
                laps.Save("laps.csv");
            }
        }

        private void manageRunnersButton_Click(object sender, EventArgs e)
        {
            var window = new RunnersWizard(runners);
            var result = window.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                runners.Dispose();
                runners = window.Runners;
                runners.Save("runners.csv");
            }
            else
            {
                runners.Dispose();
                SetRunnersDatasource();
            }
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            var window = new ReportWizard(laps, runners);
            window.ShowDialog(this);
        }
    }
}
