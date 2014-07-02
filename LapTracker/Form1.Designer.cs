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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.runnersTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.lapGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.importButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lapsTabPage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.runnerGridView = new System.Windows.Forms.DataGridView();
            this.saveRunnersButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.saveReportButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.createReportButton = new System.Windows.Forms.Button();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.importLapsButton = new System.Windows.Forms.Button();
            this.manageRunnersButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.runnersTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lapGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.lapsTabPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runnerGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.runnersTabPage);
            this.tabControl1.Controls.Add(this.lapsTabPage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(366, 84);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1068, 796);
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
            this.runnersTabPage.Size = new System.Drawing.Size(1060, 770);
            this.runnersTabPage.TabIndex = 0;
            this.runnersTabPage.Text = "Laps";
            this.runnersTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(2, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1056, 687);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Contents";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lapGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1052, 670);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(2, 639);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(299, 28);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // lapGridView
            // 
            this.lapGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lapGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lapGridView.Location = new System.Drawing.Point(3, 3);
            this.lapGridView.Name = "lapGridView";
            this.lapGridView.Size = new System.Drawing.Size(1046, 631);
            this.lapGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.importButton);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.fileNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1056, 79);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Import";
            // 
            // importButton
            // 
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.importButton.Location = new System.Drawing.Point(12, 43);
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
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.browseButton.Location = new System.Drawing.Point(286, 16);
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
            this.fileNameTextBox.Location = new System.Drawing.Point(92, 17);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.ReadOnly = true;
            this.fileNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.fileNameTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Barcode File:";
            // 
            // lapsTabPage
            // 
            this.lapsTabPage.Controls.Add(this.groupBox4);
            this.lapsTabPage.Location = new System.Drawing.Point(4, 22);
            this.lapsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.lapsTabPage.Name = "lapsTabPage";
            this.lapsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.lapsTabPage.Size = new System.Drawing.Size(1060, 770);
            this.lapsTabPage.TabIndex = 1;
            this.lapsTabPage.Text = "Runners";
            this.lapsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.runnerGridView);
            this.groupBox4.Controls.Add(this.saveRunnersButton);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1056, 766);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Runners";
            // 
            // runnerGridView
            // 
            this.runnerGridView.AllowUserToResizeRows = false;
            this.runnerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.runnerGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runnerGridView.Location = new System.Drawing.Point(3, 16);
            this.runnerGridView.MultiSelect = false;
            this.runnerGridView.Name = "runnerGridView";
            this.runnerGridView.Size = new System.Drawing.Size(1050, 724);
            this.runnerGridView.TabIndex = 5;
            // 
            // saveRunnersButton
            // 
            this.saveRunnersButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveRunnersButton.Location = new System.Drawing.Point(3, 740);
            this.saveRunnersButton.Name = "saveRunnersButton";
            this.saveRunnersButton.Size = new System.Drawing.Size(1050, 23);
            this.saveRunnersButton.TabIndex = 4;
            this.saveRunnersButton.Text = "Save";
            this.saveRunnersButton.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1060, 770);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Reports";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.reportDataGridView);
            this.groupBox5.Controls.Add(this.saveReportButton);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 100);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1060, 670);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Results";
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.AllowUserToAddRows = false;
            this.reportDataGridView.AllowUserToDeleteRows = false;
            this.reportDataGridView.AllowUserToResizeRows = false;
            this.reportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.reportDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportDataGridView.Location = new System.Drawing.Point(3, 16);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.Size = new System.Drawing.Size(1054, 619);
            this.reportDataGridView.TabIndex = 0;
            // 
            // saveReportButton
            // 
            this.saveReportButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveReportButton.Location = new System.Drawing.Point(3, 635);
            this.saveReportButton.Name = "saveReportButton";
            this.saveReportButton.Size = new System.Drawing.Size(1054, 32);
            this.saveReportButton.TabIndex = 1;
            this.saveReportButton.Text = "Save Report...";
            this.saveReportButton.UseVisualStyleBackColor = true;
            this.saveReportButton.Click += new System.EventHandler(this.saveReportButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.createReportButton);
            this.groupBox3.Controls.Add(this.endDatePicker);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.startDatePicker);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1060, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Criteria";
            // 
            // createReportButton
            // 
            this.createReportButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.createReportButton.Location = new System.Drawing.Point(11, 64);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(269, 23);
            this.createReportButton.TabIndex = 6;
            this.createReportButton.Text = "Create Report";
            this.createReportButton.UseVisualStyleBackColor = true;
            this.createReportButton.Click += new System.EventHandler(this.createReport_Click);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(80, 38);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatePicker.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Date";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(80, 12);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatePicker.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start Date";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // importLapsButton
            // 
            this.importLapsButton.BackColor = System.Drawing.Color.White;
            this.importLapsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importLapsButton.Image = ((System.Drawing.Image)(resources.GetObject("importLapsButton.Image")));
            this.importLapsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importLapsButton.Location = new System.Drawing.Point(12, 12);
            this.importLapsButton.Name = "importLapsButton";
            this.importLapsButton.Size = new System.Drawing.Size(253, 85);
            this.importLapsButton.TabIndex = 1;
            this.importLapsButton.Text = "Import Laps";
            this.importLapsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importLapsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.importLapsButton.UseVisualStyleBackColor = false;
            this.importLapsButton.Click += new System.EventHandler(this.importLapsButton_Click);
            // 
            // manageRunnersButton
            // 
            this.manageRunnersButton.BackColor = System.Drawing.Color.White;
            this.manageRunnersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageRunnersButton.Image = ((System.Drawing.Image)(resources.GetObject("manageRunnersButton.Image")));
            this.manageRunnersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageRunnersButton.Location = new System.Drawing.Point(12, 103);
            this.manageRunnersButton.Name = "manageRunnersButton";
            this.manageRunnersButton.Size = new System.Drawing.Size(253, 85);
            this.manageRunnersButton.TabIndex = 2;
            this.manageRunnersButton.Text = "Manage Runners";
            this.manageRunnersButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.manageRunnersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageRunnersButton.UseVisualStyleBackColor = false;
            // 
            // reportsButton
            // 
            this.reportsButton.BackColor = System.Drawing.Color.White;
            this.reportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.Image = ((System.Drawing.Image)(resources.GetObject("reportsButton.Image")));
            this.reportsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.Location = new System.Drawing.Point(12, 194);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(253, 85);
            this.reportsButton.TabIndex = 3;
            this.reportsButton.Text = "Reports";
            this.reportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportsButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 765);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.manageRunnersButton);
            this.Controls.Add(this.importLapsButton);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Lap Tracker";
            this.tabControl1.ResumeLayout(false);
            this.runnersTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lapGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lapsTabPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.runnerGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView lapGridView;
        private System.Windows.Forms.DataGridView runnerGridView;
        private System.Windows.Forms.Button saveRunnersButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.Button saveReportButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button createReportButton;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button importLapsButton;
        private System.Windows.Forms.Button manageRunnersButton;
        private System.Windows.Forms.Button reportsButton;
    }
}

