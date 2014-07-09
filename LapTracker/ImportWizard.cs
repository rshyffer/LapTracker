using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LapTracker
{
    public partial class ImportWizard : Form
    {
        string _scannerFilePath;
        const string BarcodeFile = "BARCODES.TXT";
        private readonly Laps _laps;

        public ImportWizard()
        {
            InitializeComponent();
            _laps = new Laps();
            lapsGridView.DataSource = Laps;
           
        }

        public Laps Laps
        {
            get { return _laps; }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            _scannerFilePath = findScanner();
            if (string.IsNullOrEmpty(_scannerFilePath))
            {
                ShowScannerNotFound();
            }
            else
            {
                ShowScannerFound();
            }
        }

        private void ShowScannerFound()
        {
            foundLocationLabel.Text = string.Format("Scanner found at \"{0}\"",
                _scannerFilePath);
            scannerFoundPanel.Visible = true;
            scannerNotFoundPanel.Visible = false;
        }

        private void ShowScannerNotFound()
        {
            scannerFoundPanel.Visible = false;
            scannerNotFoundPanel.Visible = true;
        }

        private string findScanner()
        {
            var usbDrives = from driveInfo in DriveInfo.GetDrives()
                where driveInfo.DriveType == DriveType.Removable
                select driveInfo.RootDirectory.FullName;
            foreach (var drive in usbDrives)
            {
                var path = drive + BarcodeFile;
                if (File.Exists(path))
                {
                    return path;
                }
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadLaps();
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
                sourceFileTextBox.Text = openFileDialog.FileName;
            }
        }

        private void importButton2_Click(object sender, EventArgs e)
        {
            _scannerFilePath = sourceFileTextBox.Text;
            LoadLaps();
        }

        private void LoadLaps()
        {
            Laps.AddLapsFromReader(_scannerFilePath);
            lapViewPanel.Visible = true;
            lapsGridView.AutoResizeColumns();
            var idColumn = lapsGridView.Columns["Id"];
            if (idColumn != null) idColumn.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void lapsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ReanameImportedFile();
            DialogResult = DialogResult.OK;
        }

        private void ReanameImportedFile()
        {
            var newName = Path.ChangeExtension(_scannerFilePath, "imported");
            File.Move(_scannerFilePath, newName);
        }
    }
}
