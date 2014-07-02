using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTracker
{
    public partial class ImportWizard : Form
    {
        string scannerFilePath;
        private Laps laps;

        public ImportWizard()
        {
            InitializeComponent();
            laps = new Laps();
            lapsGridView.DataSource = Laps;
           
        }

        public Laps Laps
        {
            get { return laps; }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            scannerFilePath = findScanner();
            if (string.IsNullOrEmpty(scannerFilePath))
            {
                showScannerNotFound();
            }
            else
            {
                showScannerFound();
            }
        }

        private void showScannerFound()
        {
            foundLocationLabel.Text = string.Format("Scanner found at \"{0}\"",
                scannerFilePath);
            scannerFoundPanel.Visible = true;
            scannerNotFoundPanel.Visible = false;
        }

        private void showScannerNotFound()
        {
            scannerFoundPanel.Visible = false;
            scannerNotFoundPanel.Visible = true;
        }

        private string findScanner()
        {
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadLaps(scannerFilePath);
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
                this.sourceFileTextBox.Text = openFileDialog.FileName;
            }
        }

        private void importButton2_Click(object sender, EventArgs e)
        {
            scannerFilePath = sourceFileTextBox.Text;
            LoadLaps();
        }

        private void LoadLaps()
        {
            Laps.AddLapsFromReader(scannerFilePath);
            lapViewPanel.Visible = true;
            lapsGridView.AutoResizeColumns();
            var idColumn = lapsGridView.Columns["Id"];
            if (idColumn != null) idColumn.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lapsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            reanameImportedFile()
            this.DialogResult = DialogResult.OK;
        }
    }
}
