namespace DVLD_System
{
    partial class LocalDrivingLicenseApplicationInfoForm
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
            this.userControl_DrivingLicenseApplicationInfo1 = new DVLD_System.UserControl_DrivingLicenseApplicationInfo();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControl_DrivingLicenseApplicationInfo1
            // 
            this.userControl_DrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.userControl_DrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(9, 12);
            this.userControl_DrivingLicenseApplicationInfo1.Name = "userControl_DrivingLicenseApplicationInfo1";
            this.userControl_DrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(704, 322);
            this.userControl_DrivingLicenseApplicationInfo1.TabIndex = 0;
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
            this.ButtonClose.Location = new System.Drawing.Point(606, 331);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(103, 39);
            this.ButtonClose.TabIndex = 16;
            this.ButtonClose.Text = "      Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LocalDrivingLicenseApplicationInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 379);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.userControl_DrivingLicenseApplicationInfo1);
            this.Name = "LocalDrivingLicenseApplicationInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Local Driving License Application Info";
            this.Load += new System.EventHandler(this.LocalDrivingLicenseApplicationInfoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_DrivingLicenseApplicationInfo userControl_DrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Button ButtonClose;
    }
}