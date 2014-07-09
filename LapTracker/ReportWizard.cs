using System;
using System.Windows.Forms;

namespace LapTracker
{
    public partial class ReportWizard : Form
    {
        private Report _report;
        private readonly Laps _laps;
        private readonly Runners _runners;

        public ReportWizard(Laps laps, Runners runners)
        {
            _laps = laps;
            _runners = runners;
            InitializeComponent();
            SetDateRange();
        }

        private void SetDateRange()
        {
            startDatePicker.Value = _laps.MinDate;
            endDatePicker.Value = _laps.MaxDate;
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            var startDate = startDatePicker.Value;
            var endDate = endDatePicker.Value;
            _report = new Report();
            _report.Create(startDate, endDate, _laps, _runners);
            reportDataGridView.DataSource = _report;

            var idColumn = reportDataGridView.Columns["Id"];
            if (idColumn != null) idColumn.Visible = false;

            
            reportDataGridView.Dock = DockStyle.Fill;
            reportDataGridView.BringToFront();

            reportDataGridView.AutoResizeColumns();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.CheckPathExists = true;
            dialog.DefaultExt = ".csv";
            dialog.FileName = _report.DefaultName();
            dialog.Filter = "Comma Separated Values (.csv)|.csv";
            dialog.FilterIndex = 0;
            dialog.OverwritePrompt = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _report.Save(dialog.FileName);
            }
        }
    }
}
