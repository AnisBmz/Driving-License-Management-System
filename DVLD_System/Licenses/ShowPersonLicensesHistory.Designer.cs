namespace DVLD_System
{
    partial class ShowPersonLicensesHistoryForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ContextMenuLocalLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripInternationalLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userControl_DriverLicenses = new DVLD_System.Licenses.UserControlDriverLicenses();
            this.userControl_Person_Details1 = new DVLD_System.UserControl_Person_Details();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ContextMenuLocalLicense.SuspendLayout();
            this.ContextMenuStripInternationalLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "License History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_System.Properties.Resources.history;
            this.pictureBox1.Location = new System.Drawing.Point(51, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.Image = global::DVLD_System.Properties.Resources.Close_32;
            this.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new System.Drawing.Point(817, 554);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(103, 36);
            this.ButtonClose.TabIndex = 18;
            this.ButtonClose.Text = "      Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ContextMenuLocalLicense
            // 
            this.ContextMenuLocalLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowLicenseInfoToolStripMenuItem});
            this.ContextMenuLocalLicense.Name = "ContextMenuLocalLicense";
            this.ContextMenuLocalLicense.Size = new System.Drawing.Size(186, 42);
            // 
            // ShowLicenseInfoToolStripMenuItem
            // 
            this.ShowLicenseInfoToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.driving_license__1_;
            this.ShowLicenseInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLicenseInfoToolStripMenuItem.Name = "ShowLicenseInfoToolStripMenuItem";
            this.ShowLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.ShowLicenseInfoToolStripMenuItem.Text = "Show License Info";
            // 
            // ContextMenuStripInternationalLicense
            // 
            this.ContextMenuStripInternationalLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.ContextMenuStripInternationalLicense.Name = "ContextMenuLocalLicense";
            this.ContextMenuStripInternationalLicense.Size = new System.Drawing.Size(186, 42);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::DVLD_System.Properties.Resources.driving_license__1_;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 38);
            this.toolStripMenuItem1.Text = "Show License Info";
            // 
            // userControl_DriverLicenses
            // 
            this.userControl_DriverLicenses.BackColor = System.Drawing.Color.White;
            this.userControl_DriverLicenses.Location = new System.Drawing.Point(9, 267);
            this.userControl_DriverLicenses.Name = "userControl_DriverLicenses";
            this.userControl_DriverLicenses.Size = new System.Drawing.Size(919, 281);
            this.userControl_DriverLicenses.TabIndex = 19;
            // 
            // userControl_Person_Details1
            // 
            this.userControl_Person_Details1.BackColor = System.Drawing.Color.White;
            this.userControl_Person_Details1.Location = new System.Drawing.Point(246, 27);
            this.userControl_Person_Details1.Name = "userControl_Person_Details1";
            this.userControl_Person_Details1.Size = new System.Drawing.Size(661, 241);
            this.userControl_Person_Details1.TabIndex = 7;
            // 
            // ShowPersonLicensesHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 599);
            this.Controls.Add(this.userControl_DriverLicenses);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.userControl_Person_Details1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowPersonLicensesHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "License History";
            this.Load += new System.EventHandler(this.LicenseHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ContextMenuLocalLicense.ResumeLayout(false);
            this.ContextMenuStripInternationalLicense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private UserControl_Person_Details userControl_Person_Details1;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.ContextMenuStrip ContextMenuLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Licenses.UserControlDriverLicenses userControl_DriverLicenses;
    }
}