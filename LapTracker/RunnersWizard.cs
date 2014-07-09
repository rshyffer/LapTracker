using System;
using System.Windows.Forms;

namespace LapTracker
{
    public partial class RunnersWizard : Form
    {
        
        public RunnersWizard(Runners runners)
        {
            InitializeComponent();
            SetRunnersDatasource(runners);
        }

        public Runners Runners { get; private set; }

        private void SetRunnersDatasource(Runners runners)
        {
            Runners = (Runners)runners.Copy();
            runnerGridView.DataSource = Runners;
            runnerGridView.AutoResizeColumns();
            var idColumn = runnerGridView.Columns["Id"];
            if (idColumn != null) idColumn.Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
