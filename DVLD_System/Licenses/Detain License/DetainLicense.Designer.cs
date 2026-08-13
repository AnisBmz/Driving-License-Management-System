namespace DVLD_System
{
    partial class DetainLicenseForm
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
            this.GroupBoxDetainInfo = new System.Windows.Forms.GroupBox();
            this.TextBoxFees = new System.Windows.Forms.TextBox();
            this.LabelCreatedByUser = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.Label = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelDetainDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LabelLicenseID = new System.Windows.Forms.Label();
            this.LabelDetainID = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonDetain = new System.Windows.Forms.Button();
            this.LinkLabelShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.errorProviderFees = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.userControl_SearchDriverLicense1 = new DVLD_System.Licenses.Local_License.UserControl_SearchDriverLicense();
            this.LinkLabelShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.GroupBoxDetainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFees)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxDetainInfo
            // 
            this.GroupBoxDetainInfo.Controls.Add(this.TextBoxFees);
            this.GroupBoxDetainInfo.Controls.Add(this.LabelCreatedByUser);
            this.GroupBoxDetainInfo.Controls.Add(this.pictureBox10);
            this.GroupBoxDetainInfo.Controls.Add(this.label5);
            this.GroupBoxDetainInfo.Controls.Add(this.pictureBox8);
            this.GroupBoxDetainInfo.Controls.Add(this.Label);
            this.GroupBoxDetainInfo.Controls.Add(this.pictureBox3);
            this.GroupBoxDetainInfo.Controls.Add(this.pictureBox1);
            this.GroupBoxDetainInfo.Controls.Add(this.LabelDetainDate);
            this.GroupBoxDetainInfo.Controls.Add(this.label10);
            this.GroupBoxDetainInfo.Controls.Add(this.LabelLicenseID);
            this.GroupBoxDetainInfo.Controls.Add(this.LabelDetainID);
            this.GroupBoxDetainInfo.Controls.Add(this.pictureBox6);
            this.GroupBoxDetainInfo.Controls.Add(this.label8);
            this.GroupBoxDetainInfo.Controls.Add(this.label9);
            this.GroupBoxDetainInfo.Location = new System.Drawing.Point(15, 407);
            this.GroupBoxDetainInfo.Name = "GroupBoxDetainInfo";
            this.GroupBoxDetainInfo.Size = new System.Drawing.Size(716, 133);
            this.GroupBoxDetainInfo.TabIndex = 117;
            this.GroupBoxDetainInfo.TabStop = false;
            this.GroupBoxDetainInfo.Text = "Detain Info";
            // 
            // TextBoxFees
            // 
            this.TextBoxFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxFees.Location = new System.Drawing.Point(151, 101);
            this.TextBoxFees.Name = "TextBoxFees";
            this.TextBoxFees.Size = new System.Drawing.Size(157, 20);
            this.TextBoxFees.TabIndex = 118;
            this.TextBoxFees.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxFees_Validating);
            // 
            // LabelCreatedByUser
            // 
            this.LabelCreatedByUser.AutoSize = true;
            this.LabelCreatedByUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCreatedByUser.Location = new System.Drawing.Point(501, 65);
            this.LabelCreatedByUser.Name = "LabelCreatedByUser";
            this.LabelCreatedByUser.Size = new System.Drawing.Size(32, 17);
            this.LabelCreatedByUser.TabIndex = 117;
            this.LabelCreatedByUser.Text = "????";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::DVLD_System.Properties.Resources.driving_license;
            this.pictureBox10.Location = new System.Drawing.Point(469, 63);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(22, 19);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 116;
            this.pictureBox10.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 115;
            this.label5.Text = "Created By:";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD_System.Properties.Resources.coin;
            this.pictureBox8.Location = new System.Drawing.Point(114, 100);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(22, 19);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 114;
            this.pictureBox8.TabStop = false;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(13, 101);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(69, 17);
            this.Label.TabIndex = 112;
            this.Label.Text = "Fine Fees:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_System.Properties.Resources.id;
            this.pictureBox3.Location = new System.Drawing.Point(469, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 77;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_System.Properties.Resources.calendar;
            this.pictureBox1.Location = new System.Drawing.Point(114, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // LabelDetainDate
            // 
            this.LabelDetainDate.AutoSize = true;
            this.LabelDetainDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDetainDate.Location = new System.Drawing.Point(148, 65);
            this.LabelDetainDate.Name = "LabelDetainDate";
            this.LabelDetainDate.Size = new System.Drawing.Size(32, 17);
            this.LabelDetainDate.TabIndex = 60;
            this.LabelDetainDate.Text = "????";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 58;
            this.label10.Text = "Detain Date:";
            // 
            // LabelLicenseID
            // 
            this.LabelLicenseID.AutoSize = true;
            this.LabelLicenseID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLicenseID.Location = new System.Drawing.Point(501, 30);
            this.LabelLicenseID.Name = "LabelLicenseID";
            this.LabelLicenseID.Size = new System.Drawing.Size(32, 17);
            this.LabelLicenseID.TabIndex = 56;
            this.LabelLicenseID.Text = "????";
            // 
            // LabelDetainID
            // 
            this.LabelDetainID.AutoSize = true;
            this.LabelDetainID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDetainID.Location = new System.Drawing.Point(149, 29);
            this.LabelDetainID.Name = "LabelDetainID";
            this.LabelDetainID.Size = new System.Drawing.Size(32, 17);
            this.LabelDetainID.TabIndex = 55;
            this.LabelDetainID.Text = "????";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD_System.Properties.Resources.id;
            this.pictureBox6.Location = new System.Drawing.Point(114, 28);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 52;
            this.pictureBox6.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(380, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "License ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Detain ID:";
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
            this.ButtonClose.Location = new System.Drawing.Point(510, 552);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(103, 33);
            this.ButtonClose.TabIndex = 119;
            this.ButtonClose.Text = "      Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // ButtonDetain
            // 
            this.ButtonDetain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDetain.Enabled = false;
            this.ButtonDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDetain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonDetain.Image = global::DVLD_System.Properties.Resources.credit_card_bug;
            this.ButtonDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDetain.Location = new System.Drawing.Point(628, 552);
            this.ButtonDetain.Name = "ButtonDetain";
            this.ButtonDetain.Size = new System.Drawing.Size(103, 33);
            this.ButtonDetain.TabIndex = 118;
            this.ButtonDetain.Text = "        Detain";
            this.ButtonDetain.UseVisualStyleBackColor = true;
            this.ButtonDetain.Click += new System.EventHandler(this.ButtonDetain_Click);
            // 
            // LinkLabelShowLicensesHistory
            // 
            this.LinkLabelShowLicensesHistory.AutoSize = true;
            this.LinkLabelShowLicensesHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLabelShowLicensesHistory.Enabled = false;
            this.LinkLabelShowLicensesHistory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LinkLabelShowLicensesHistory.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkLabelShowLicensesHistory.Location = new System.Drawing.Point(21, 561);
            this.LinkLabelShowLicensesHistory.Name = "LinkLabelShowLicensesHistory";
            this.LinkLabelShowLicensesHistory.Size = new System.Drawing.Size(130, 15);
            this.LinkLabelShowLicensesHistory.TabIndex = 120;
            this.LinkLabelShowLicensesHistory.TabStop = true;
            this.LinkLabelShowLicensesHistory.Text = "Show Licenses History";
            this.LinkLabelShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelShowLicensesHistory_LinkClicked);
            // 
            // errorProviderFees
            // 
            this.errorProviderFees.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(492, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 123;
            this.label1.Text = "Detain License";
            // 
            // userControl_SearchDriverLicense1
            // 
            this.userControl_SearchDriverLicense1.BackColor = System.Drawing.Color.White;
            this.userControl_SearchDriverLicense1.GroupBoxSearchEnabled = true;
            this.userControl_SearchDriverLicense1.Location = new System.Drawing.Point(11, 16);
            this.userControl_SearchDriverLicense1.Name = "userControl_SearchDriverLicense1";
            this.userControl_SearchDriverLicense1.Size = new System.Drawing.Size(721, 382);
            this.userControl_SearchDriverLicense1.TabIndex = 121;
            // 
            // LinkLabelShowLicenseInfo
            // 
            this.LinkLabelShowLicenseInfo.AutoSize = true;
            this.LinkLabelShowLicenseInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLabelShowLicenseInfo.Enabled = false;
            this.LinkLabelShowLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LinkLabelShowLicenseInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkLabelShowLicenseInfo.Location = new System.Drawing.Point(175, 561);
            this.LinkLabelShowLicenseInfo.Name = "LinkLabelShowLicenseInfo";
            this.LinkLabelShowLicenseInfo.Size = new System.Drawing.Size(108, 15);
            this.LinkLabelShowLicenseInfo.TabIndex = 124;
            this.LinkLabelShowLicenseInfo.TabStop = true;
            this.LinkLabelShowLicenseInfo.Text = "Show License Info";
            this.LinkLabelShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelShowLicenseInfo_LinkClicked);
            // 
            // DetainLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 594);
            this.Controls.Add(this.LinkLabelShowLicenseInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControl_SearchDriverLicense1);
            this.Controls.Add(this.LinkLabelShowLicensesHistory);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonDetain);
            this.Controls.Add(this.GroupBoxDetainInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(310, 85);
            this.Name = "DetainLicenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Detain License";
            this.Load += new System.EventHandler(this.DetainLicenseForm_Load);
            this.GroupBoxDetainInfo.ResumeLayout(false);
            this.GroupBoxDetainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupBoxDetainInfo;
        private System.Windows.Forms.TextBox TextBoxFees;
        private System.Windows.Forms.Label LabelCreatedByUser;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelDetainDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LabelLicenseID;
        private System.Windows.Forms.Label LabelDetainID;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonDetain;
        private System.Windows.Forms.LinkLabel LinkLabelShowLicensesHistory;
        private System.Windows.Forms.ErrorProvider errorProviderFees;
        private System.Windows.Forms.Label label1;
        private Licenses.Local_License.UserControl_SearchDriverLicense userControl_SearchDriverLicense1;
        private System.Windows.Forms.LinkLabel LinkLabelShowLicenseInfo;
    }
}