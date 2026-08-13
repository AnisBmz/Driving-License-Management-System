namespace DVLD_System
{
    partial class AddUpdateLocalDrivingLicenseApplicationForm
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPagePersonalInfo = new System.Windows.Forms.TabPage();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.userControl_Search_Person1 = new DVLD_System.UserControl_Search_Person();
            this.TabPageApplicationInfo = new System.Windows.Forms.TabPage();
            this.ComboBoxLicenseClass = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.LabelCreatedBy = new System.Windows.Forms.Label();
            this.LabelApplicatioFees = new System.Windows.Forms.Label();
            this.LabelApolicationDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabPagePersonalInfo.SuspendLayout();
            this.TabPageApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LabelTitle.Location = new System.Drawing.Point(154, 19);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(390, 30);
            this.LabelTitle.TabIndex = 4;
            this.LabelTitle.Text = "New Local Driving License Application";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPagePersonalInfo);
            this.tabControl1.Controls.Add(this.TabPageApplicationInfo);
            this.tabControl1.Location = new System.Drawing.Point(10, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 404);
            this.tabControl1.TabIndex = 5;
            // 
            // TabPagePersonalInfo
            // 
            this.TabPagePersonalInfo.BackColor = System.Drawing.Color.White;
            this.TabPagePersonalInfo.Controls.Add(this.ButtonNext);
            this.TabPagePersonalInfo.Controls.Add(this.userControl_Search_Person1);
            this.TabPagePersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.TabPagePersonalInfo.Name = "TabPagePersonalInfo";
            this.TabPagePersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagePersonalInfo.Size = new System.Drawing.Size(679, 378);
            this.TabPagePersonalInfo.TabIndex = 0;
            this.TabPagePersonalInfo.Text = "Personal Info";
            // 
            // ButtonNext
            // 
            this.ButtonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.Image = global::DVLD_System.Properties.Resources.Next_32;
            this.ButtonNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonNext.Location = new System.Drawing.Point(566, 335);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(103, 33);
            this.ButtonNext.TabIndex = 44;
            this.ButtonNext.Text = "      Next";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // userControl_Search_Person1
            // 
            this.userControl_Search_Person1.BackColor = System.Drawing.Color.White;
            this.userControl_Search_Person1.Location = new System.Drawing.Point(5, 7);
            this.userControl_Search_Person1.Name = "userControl_Search_Person1";
            this.userControl_Search_Person1.Size = new System.Drawing.Size(668, 324);
            this.userControl_Search_Person1.TabIndex = 0;
            // 
            // TabPageApplicationInfo
            // 
            this.TabPageApplicationInfo.BackColor = System.Drawing.Color.White;
            this.TabPageApplicationInfo.Controls.Add(this.ComboBoxLicenseClass);
            this.TabPageApplicationInfo.Controls.Add(this.pictureBox6);
            this.TabPageApplicationInfo.Controls.Add(this.pictureBox5);
            this.TabPageApplicationInfo.Controls.Add(this.LabelCreatedBy);
            this.TabPageApplicationInfo.Controls.Add(this.LabelApplicatioFees);
            this.TabPageApplicationInfo.Controls.Add(this.LabelApolicationDate);
            this.TabPageApplicationInfo.Controls.Add(this.label2);
            this.TabPageApplicationInfo.Controls.Add(this.label8);
            this.TabPageApplicationInfo.Controls.Add(this.LabelID);
            this.TabPageApplicationInfo.Controls.Add(this.label3);
            this.TabPageApplicationInfo.Controls.Add(this.label4);
            this.TabPageApplicationInfo.Controls.Add(this.label5);
            this.TabPageApplicationInfo.Controls.Add(this.pictureBox4);
            this.TabPageApplicationInfo.Controls.Add(this.pictureBox3);
            this.TabPageApplicationInfo.Controls.Add(this.pictureBox2);
            this.TabPageApplicationInfo.Location = new System.Drawing.Point(4, 22);
            this.TabPageApplicationInfo.Name = "TabPageApplicationInfo";
            this.TabPageApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageApplicationInfo.Size = new System.Drawing.Size(679, 378);
            this.TabPageApplicationInfo.TabIndex = 1;
            this.TabPageApplicationInfo.Text = "Application Info";
            // 
            // ComboBoxLicenseClass
            // 
            this.ComboBoxLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLicenseClass.FormattingEnabled = true;
            this.ComboBoxLicenseClass.Location = new System.Drawing.Point(227, 117);
            this.ComboBoxLicenseClass.Name = "ComboBoxLicenseClass";
            this.ComboBoxLicenseClass.Size = new System.Drawing.Size(291, 21);
            this.ComboBoxLicenseClass.TabIndex = 64;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD_System.Properties.Resources.calendar;
            this.pictureBox6.Location = new System.Drawing.Point(170, 82);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 63;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD_System.Properties.Resources.driving_license;
            this.pictureBox5.Location = new System.Drawing.Point(170, 187);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 62;
            this.pictureBox5.TabStop = false;
            // 
            // LabelCreatedBy
            // 
            this.LabelCreatedBy.AutoSize = true;
            this.LabelCreatedBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCreatedBy.Location = new System.Drawing.Point(224, 187);
            this.LabelCreatedBy.Name = "LabelCreatedBy";
            this.LabelCreatedBy.Size = new System.Drawing.Size(32, 17);
            this.LabelCreatedBy.TabIndex = 61;
            this.LabelCreatedBy.Text = "????";
            // 
            // LabelApplicatioFees
            // 
            this.LabelApplicatioFees.AutoSize = true;
            this.LabelApplicatioFees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApplicatioFees.Location = new System.Drawing.Point(224, 154);
            this.LabelApplicatioFees.Name = "LabelApplicatioFees";
            this.LabelApplicatioFees.Size = new System.Drawing.Size(32, 17);
            this.LabelApplicatioFees.TabIndex = 60;
            this.LabelApplicatioFees.Text = "????";
            // 
            // LabelApolicationDate
            // 
            this.LabelApolicationDate.AutoSize = true;
            this.LabelApolicationDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApolicationDate.Location = new System.Drawing.Point(224, 84);
            this.LabelApolicationDate.Name = "LabelApolicationDate";
            this.LabelApolicationDate.Size = new System.Drawing.Size(32, 17);
            this.LabelApolicationDate.TabIndex = 59;
            this.LabelApolicationDate.Text = "????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Created By:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "Application Fees:";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelID.Location = new System.Drawing.Point(224, 45);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(32, 17);
            this.LabelID.TabIndex = 50;
            this.LabelID.Text = "????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "License Class:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Application Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "D.L.Application ID:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_System.Properties.Resources.coin;
            this.pictureBox4.Location = new System.Drawing.Point(170, 152);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 53;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_System.Properties.Resources.id;
            this.pictureBox3.Location = new System.Drawing.Point(170, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_System.Properties.Resources.certificate__1_;
            this.pictureBox2.Location = new System.Drawing.Point(170, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.Enabled = false;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Image = global::DVLD_System.Properties.Resources.Save_32;
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSave.Location = new System.Drawing.Point(592, 489);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(103, 33);
            this.ButtonSave.TabIndex = 44;
            this.ButtonSave.Text = "      Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.Image = global::DVLD_System.Properties.Resources.Close_32;
            this.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new System.Drawing.Point(481, 489);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(103, 33);
            this.ButtonClose.TabIndex = 43;
            this.ButtonClose.Text = "      Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // AddUpdateLocalDrivingLicenseApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 538);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LabelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(330, 110);
            this.Name = "AddUpdateLocalDrivingLicenseApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "New Local Driving License Application";
            this.Activated += new System.EventHandler(this.AddUpdateLocalDrivingLicenseApplicationForm_Activated);
            this.Load += new System.EventHandler(this.AddUpdateLocalDrivingLicenseApplicationForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabPagePersonalInfo.ResumeLayout(false);
            this.TabPageApplicationInfo.ResumeLayout(false);
            this.TabPageApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPagePersonalInfo;
        private UserControl_Search_Person userControl_Search_Person1;
        private System.Windows.Forms.TabPage TabPageApplicationInfo;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label LabelCreatedBy;
        private System.Windows.Forms.Label LabelApplicatioFees;
        private System.Windows.Forms.Label LabelApolicationDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ComboBox ComboBoxLicenseClass;
    }
}