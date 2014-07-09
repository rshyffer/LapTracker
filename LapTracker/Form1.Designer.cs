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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.importLapsButton = new System.Windows.Forms.Button();
            this.manageRunnersButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.manageRunnersButton.Click += new System.EventHandler(this.manageRunnersButton_Click);
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
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 294);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.manageRunnersButton);
            this.Controls.Add(this.importLapsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Lap Tracker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button importLapsButton;
        private System.Windows.Forms.Button manageRunnersButton;
        private System.Windows.Forms.Button reportsButton;
    }
}

