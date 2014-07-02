namespace LapTracker
{
    partial class ImportWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scannerFoundPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.foundLocationLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.findButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scannerNotFoundPanel = new System.Windows.Forms.Panel();
            this.importButton2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sourceFileTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cancelButton = new System.Windows.Forms.Button();
            this.lapViewPanel = new System.Windows.Forms.Panel();
            this.lapsGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.scannerFoundPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.scannerNotFoundPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.lapViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lapsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // scannerFoundPanel
            // 
            this.scannerFoundPanel.Controls.Add(this.button1);
            this.scannerFoundPanel.Controls.Add(this.foundLocationLabel);
            this.scannerFoundPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.scannerFoundPanel.Location = new System.Drawing.Point(0, 99);
            this.scannerFoundPanel.Name = "scannerFoundPanel";
            this.scannerFoundPanel.Padding = new System.Windows.Forms.Padding(10);
            this.scannerFoundPanel.Size = new System.Drawing.Size(600, 93);
            this.scannerFoundPanel.TabIndex = 2;
            this.scannerFoundPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(10, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(580, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // foundLocationLabel
            // 
            this.foundLocationLabel.AutoSize = true;
            this.foundLocationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.foundLocationLabel.Location = new System.Drawing.Point(10, 10);
            this.foundLocationLabel.Name = "foundLocationLabel";
            this.foundLocationLabel.Padding = new System.Windows.Forms.Padding(10);
            this.foundLocationLabel.Size = new System.Drawing.Size(226, 37);
            this.foundLocationLabel.TabIndex = 0;
            this.foundLocationLabel.Text = "Scanner Found at {file location}";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.findButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(600, 99);
            this.panel1.TabIndex = 3;
            // 
            // findButton
            // 
            this.findButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.findButton.Location = new System.Drawing.Point(10, 47);
            this.findButton.Margin = new System.Windows.Forms.Padding(10);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(580, 36);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(590, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make sure the scanner is attached to the computer\'s USB port and press the Find b" +
    "utton.";
            // 
            // scannerNotFoundPanel
            // 
            this.scannerNotFoundPanel.Controls.Add(this.importButton2);
            this.scannerNotFoundPanel.Controls.Add(this.flowLayoutPanel1);
            this.scannerNotFoundPanel.Controls.Add(this.label2);
            this.scannerNotFoundPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.scannerNotFoundPanel.Location = new System.Drawing.Point(0, 192);
            this.scannerNotFoundPanel.Name = "scannerNotFoundPanel";
            this.scannerNotFoundPanel.Padding = new System.Windows.Forms.Padding(10);
            this.scannerNotFoundPanel.Size = new System.Drawing.Size(600, 131);
            this.scannerNotFoundPanel.TabIndex = 4;
            this.scannerNotFoundPanel.Visible = false;
            // 
            // importButton2
            // 
            this.importButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.importButton2.Location = new System.Drawing.Point(10, 82);
            this.importButton2.Name = "importButton2";
            this.importButton2.Size = new System.Drawing.Size(580, 35);
            this.importButton2.TabIndex = 1;
            this.importButton2.Text = "Load";
            this.importButton2.UseVisualStyleBackColor = true;
            this.importButton2.Click += new System.EventHandler(this.importButton2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.sourceFileTextBox);
            this.flowLayoutPanel1.Controls.Add(this.browseButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 47);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(580, 35);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // sourceFileTextBox
            // 
            this.sourceFileTextBox.Location = new System.Drawing.Point(3, 3);
            this.sourceFileTextBox.Name = "sourceFileTextBox";
            this.sourceFileTextBox.Size = new System.Drawing.Size(313, 23);
            this.sourceFileTextBox.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(322, 3);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 26);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(394, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Scanner Not Found.  Press Find again or browse for a file.";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cancelButton.Location = new System.Drawing.Point(0, 566);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(600, 35);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // lapViewPanel
            // 
            this.lapViewPanel.Controls.Add(this.lapsGridView);
            this.lapViewPanel.Controls.Add(this.addButton);
            this.lapViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lapViewPanel.Location = new System.Drawing.Point(0, 323);
            this.lapViewPanel.Name = "lapViewPanel";
            this.lapViewPanel.Size = new System.Drawing.Size(600, 243);
            this.lapViewPanel.TabIndex = 7;
            this.lapViewPanel.Visible = false;
            // 
            // lapsGridView
            // 
            this.lapsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lapsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lapsGridView.Location = new System.Drawing.Point(0, 0);
            this.lapsGridView.Name = "lapsGridView";
            this.lapsGridView.Size = new System.Drawing.Size(600, 208);
            this.lapsGridView.TabIndex = 6;
            this.lapsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lapsGridView_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addButton.Location = new System.Drawing.Point(0, 208);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(600, 35);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Import";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ImportWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 601);
            this.Controls.Add(this.lapViewPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.scannerNotFoundPanel);
            this.Controls.Add(this.scannerFoundPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportWizard";
            this.Text = "Import Laps";
            this.scannerFoundPanel.ResumeLayout(false);
            this.scannerFoundPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.scannerNotFoundPanel.ResumeLayout(false);
            this.scannerNotFoundPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.lapViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lapsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel scannerFoundPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label foundLocationLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel scannerNotFoundPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox sourceFileTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button importButton2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel lapViewPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView lapsGridView;

    }
}