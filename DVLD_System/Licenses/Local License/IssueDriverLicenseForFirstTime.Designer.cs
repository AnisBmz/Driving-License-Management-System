namespace DVLD_System
{
    partial class IssueDriverLicenseForFirstTimeForm
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
            this.TextBoxNotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonIssue = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // userControl_DrivingLicenseApplicationInfo1
            // 
            this.userControl_DrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.userControl_DrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(16, 27);
            this.userControl_DrivingLicenseApplicationInfo1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userControl_DrivingLicenseApplicationInfo1.Name = "userControl_DrivingLicenseApplicationInfo1";
            this.userControl_DrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(939, 384);
            this.userControl_DrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // TextBoxNotes
            // 
            this.TextBoxNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxNotes.Location = new System.Drawing.Point(151, 428);
            this.TextBoxNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxNotes.Multiline = true;
            this.TextBoxNotes.Name = "TextBoxNotes";
            this.TextBoxNotes.Size = new System.Drawing.Size(798, 161);
            this.TextBoxNotes.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 431);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 106;
            this.label7.Text = "Notes:";
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
            this.ButtonClose.Location = new System.Drawing.Point(652, 601);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(137, 41);
            this.ButtonClose.TabIndex = 110;
            this.ButtonClose.Text = "      Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonIssue
            // 
            this.ButtonIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonIssue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonIssue.Image = global::DVLD_System.Properties.Resources.driver_license__2_;
            this.ButtonIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonIssue.Location = new System.Drawing.Point(812, 601);
            this.ButtonIssue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonIssue.Name = "ButtonIssue";
            this.ButtonIssue.Size = new System.Drawing.Size(137, 41);
            this.ButtonIssue.TabIndex = 109;
            this.ButtonIssue.Text = "     Issue";
            this.ButtonIssue.UseVisualStyleBackColor = true;
            this.ButtonIssue.Click += new System.EventHandler(this.ButtonIssue_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD_System.Properties.Resources.writing_tool;
            this.pictureBox7.Location = new System.Drawing.Point(93, 431);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(29, 23);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 107;
            this.pictureBox7.TabStop = false;
            // 
            // IssueDriverLicenseForFirstTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 651);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonIssue);
            this.Controls.Add(this.TextBoxNotes);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userControl_DrivingLicenseApplicationInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IssueDriverLicenseForFirstTimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Issue Driver License For The First Time";
            this.Load += new System.EventHandler(this.IssueDriverLicenseForFirstTimeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl_DrivingLicenseApplicationInfo userControl_DrivingLicenseApplicationInfo1;
        private System.Windows.Forms.TextBox TextBoxNotes;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonIssue;
        private System.Windows.Forms.Button ButtonClose;
    }
}