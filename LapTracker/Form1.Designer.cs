namespace LapTracker
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.runnersTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lapGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.importButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lapsTabPage = new System.Windows.Forms.TabPage();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.runnersTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lapGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.runnersTabPage);
            this.tabControl1.Controls.Add(this.lapsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 573);
            this.tabControl1.TabIndex = 0;
            // 
            // runnersTabPage
            // 
            this.runnersTabPage.Controls.Add(this.groupBox2);
            this.runnersTabPage.Controls.Add(this.groupBox1);
            this.runnersTabPage.Location = new System.Drawing.Point(4, 22);
            this.runnersTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.runnersTabPage.Name = "runnersTabPage";
            this.runnersTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.runnersTabPage.Size = new System.Drawing.Size(751, 547);
            this.runnersTabPage.TabIndex = 0;
            this.runnersTabPage.Text = "Laps";
            this.runnersTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lapGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(2, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(747, 437);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Contents";
            // 
            // lapGridView
            // 
            this.lapGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lapGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lapGridView.Location = new System.Drawing.Point(2, 15);
            this.lapGridView.Name = "lapGridView";
            this.lapGridView.Size = new System.Drawing.Size(743, 420);
            this.lapGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.importButton);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.fileNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(747, 106);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Import";
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(12, 68);
            this.importButton.Margin = new System.Windows.Forms.Padding(2);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(299, 26);
            this.importButton.TabIndex = 11;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(286, 41);
            this.browseButton.Margin = new System.Windows.Forms.Padding(2);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(26, 23);
            this.browseButton.TabIndex = 10;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(92, 42);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.ReadOnly = true;
            this.fileNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.fileNameTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Barcode File:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 15);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Running Date:";
            // 
            // lapsTabPage
            // 
            this.lapsTabPage.Location = new System.Drawing.Point(4, 22);
            this.lapsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.lapsTabPage.Name = "lapsTabPage";
            this.lapsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.lapsTabPage.Size = new System.Drawing.Size(751, 547);
            this.lapsTabPage.TabIndex = 1;
            this.lapsTabPage.Text = "Runners";
            this.lapsTabPage.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 573);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.runnersTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lapGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage runnersTabPage;
        private System.Windows.Forms.TabPage lapsTabPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView lapGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

