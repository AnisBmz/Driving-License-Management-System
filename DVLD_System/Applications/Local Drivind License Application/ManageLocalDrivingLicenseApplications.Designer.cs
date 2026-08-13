namespace DVLD_System
{
    partial class ManageLocalDrivingLicenseApplicationsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxFilter = new System.Windows.Forms.TextBox();
            this.ComboBoxFilterApplications = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridViewLocalDrivingLicenseApplications = new System.Windows.Forms.DataGridView();
            this.LabelRecordsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ContextMenuStripManageLocalDrivingLicenseApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ScheduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleWrittenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.IssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboBoxStatus = new System.Windows.Forms.ComboBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonAddNewLocalDrivingLicenseApplication = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLocalDrivingLicenseApplications)).BeginInit();
            this.ContextMenuStripManageLocalDrivingLicenseApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(355, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Local Driving License Applications";
            // 
            // TextBoxFilter
            // 
            this.TextBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxFilter.Location = new System.Drawing.Point(230, 160);
            this.TextBoxFilter.MaxLength = 300;
            this.TextBoxFilter.Name = "TextBoxFilter";
            this.TextBoxFilter.Size = new System.Drawing.Size(165, 20);
            this.TextBoxFilter.TabIndex = 10;
            this.TextBoxFilter.Visible = false;
            this.TextBoxFilter.TextChanged += new System.EventHandler(this.TextBoxFilter_TextChanged);
            this.TextBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFilter_KeyPress);
            // 
            // ComboBoxFilterApplications
            // 
            this.ComboBoxFilterApplications.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ComboBoxFilterApplications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxFilterApplications.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilterApplications.FormattingEnabled = true;
            this.ComboBoxFilterApplications.Location = new System.Drawing.Point(73, 159);
            this.ComboBoxFilterApplications.Name = "ComboBoxFilterApplications";
            this.ComboBoxFilterApplications.Size = new System.Drawing.Size(139, 21);
            this.ComboBoxFilterApplications.TabIndex = 9;
            this.ComboBoxFilterApplications.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterApplications_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filter By:";
            // 
            // DataGridViewLocalDrivingLicenseApplications
            // 
            this.DataGridViewLocalDrivingLicenseApplications.AllowUserToAddRows = false;
            this.DataGridViewLocalDrivingLicenseApplications.AllowUserToDeleteRows = false;
            this.DataGridViewLocalDrivingLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewLocalDrivingLicenseApplications.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewLocalDrivingLicenseApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewLocalDrivingLicenseApplications.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewLocalDrivingLicenseApplications.Location = new System.Drawing.Point(10, 189);
            this.DataGridViewLocalDrivingLicenseApplications.MultiSelect = false;
            this.DataGridViewLocalDrivingLicenseApplications.Name = "DataGridViewLocalDrivingLicenseApplications";
            this.DataGridViewLocalDrivingLicenseApplications.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(20);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewLocalDrivingLicenseApplications.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewLocalDrivingLicenseApplications.RowHeadersVisible = false;
            this.DataGridViewLocalDrivingLicenseApplications.RowHeadersWidth = 57;
            this.DataGridViewLocalDrivingLicenseApplications.RowTemplate.Height = 45;
            this.DataGridViewLocalDrivingLicenseApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLocalDrivingLicenseApplications.Size = new System.Drawing.Size(1123, 294);
            this.DataGridViewLocalDrivingLicenseApplications.TabIndex = 11;
            this.DataGridViewLocalDrivingLicenseApplications.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            // 
            // LabelRecordsCount
            // 
            this.LabelRecordsCount.AutoSize = true;
            this.LabelRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRecordsCount.Location = new System.Drawing.Point(88, 491);
            this.LabelRecordsCount.Name = "LabelRecordsCount";
            this.LabelRecordsCount.Size = new System.Drawing.Size(0, 13);
            this.LabelRecordsCount.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "# Records:";
            // 
            // ContextMenuStripManageLocalDrivingLicenseApplications
            // 
            this.ContextMenuStripManageLocalDrivingLicenseApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowApplicationDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.EditApplicationToolStripMenuItem,
            this.DeleteApplicationToolStripMenuItem,
            this.toolStripSeparator3,
            this.CancelApplicationToolStripMenuItem,
            this.toolStripSeparator1,
            this.ScheduleTestsToolStripMenuItem,
            this.toolStripSeparator4,
            this.IssueToolStripMenuItem,
            this.toolStripSeparator5,
            this.ShowLicenseToolStripMenuItem,
            this.toolStripSeparator6,
            this.ShowPersonLicenseHistoryToolStripMenuItem});
            this.ContextMenuStripManageLocalDrivingLicenseApplications.Name = "contextMenuStrip";
            this.ContextMenuStripManageLocalDrivingLicenseApplications.Size = new System.Drawing.Size(263, 366);
            this.ContextMenuStripManageLocalDrivingLicenseApplications.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip_Opening);
            // 
            // ShowApplicationDetailsToolStripMenuItem
            // 
            this.ShowApplicationDetailsToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.file;
            this.ShowApplicationDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowApplicationDetailsToolStripMenuItem.Name = "ShowApplicationDetailsToolStripMenuItem";
            this.ShowApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.ShowApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.ShowApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(259, 6);
            // 
            // EditApplicationToolStripMenuItem
            // 
            this.EditApplicationToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.edit1;
            this.EditApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditApplicationToolStripMenuItem.Name = "EditApplicationToolStripMenuItem";
            this.EditApplicationToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.EditApplicationToolStripMenuItem.Text = "Edit Application";
            this.EditApplicationToolStripMenuItem.Click += new System.EventHandler(this.EditApplicationToolStripMenuItem_Click);
            // 
            // DeleteApplicationToolStripMenuItem
            // 
            this.DeleteApplicationToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.delete_document;
            this.DeleteApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteApplicationToolStripMenuItem.Name = "DeleteApplicationToolStripMenuItem";
            this.DeleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.DeleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.DeleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.DeleteApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(259, 6);
            // 
            // CancelApplicationToolStripMenuItem
            // 
            this.CancelApplicationToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.cancelation;
            this.CancelApplicationToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CancelApplicationToolStripMenuItem.Name = "CancelApplicationToolStripMenuItem";
            this.CancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.CancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.CancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.CancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // ScheduleTestsToolStripMenuItem
            // 
            this.ScheduleTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScheduleVisionTestToolStripMenuItem,
            this.ScheduleWrittenToolStripMenuItem,
            this.ScheduleStreetTestToolStripMenuItem});
            this.ScheduleTestsToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.test;
            this.ScheduleTestsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleTestsToolStripMenuItem.Name = "ScheduleTestsToolStripMenuItem";
            this.ScheduleTestsToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.ScheduleTestsToolStripMenuItem.Text = "Schedule Tests";
            // 
            // ScheduleVisionTestToolStripMenuItem
            // 
            this.ScheduleVisionTestToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.eye_test;
            this.ScheduleVisionTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleVisionTestToolStripMenuItem.Name = "ScheduleVisionTestToolStripMenuItem";
            this.ScheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(204, 38);
            this.ScheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.ScheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.ScheduleVisionTestToolStripMenuItem_Click_1);
            // 
            // ScheduleWrittenToolStripMenuItem
            // 
            this.ScheduleWrittenToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.exam__3_;
            this.ScheduleWrittenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleWrittenToolStripMenuItem.Name = "ScheduleWrittenToolStripMenuItem";
            this.ScheduleWrittenToolStripMenuItem.Size = new System.Drawing.Size(204, 38);
            this.ScheduleWrittenToolStripMenuItem.Text = "Schedule Written Test";
            this.ScheduleWrittenToolStripMenuItem.Click += new System.EventHandler(this.ScheduleWrittenToolStripMenuItem_Click);
            // 
            // ScheduleStreetTestToolStripMenuItem
            // 
            this.ScheduleStreetTestToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.test__1_;
            this.ScheduleStreetTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleStreetTestToolStripMenuItem.Name = "ScheduleStreetTestToolStripMenuItem";
            this.ScheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(204, 38);
            this.ScheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.ScheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.ScheduleStreetTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(259, 6);
            // 
            // IssueToolStripMenuItem
            // 
            this.IssueToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.driving_school__1_;
            this.IssueToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IssueToolStripMenuItem.Name = "IssueToolStripMenuItem";
            this.IssueToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.IssueToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.IssueToolStripMenuItem.Click += new System.EventHandler(this.IssueToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(259, 6);
            // 
            // ShowLicenseToolStripMenuItem
            // 
            this.ShowLicenseToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.driving_license__1_;
            this.ShowLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLicenseToolStripMenuItem.Name = "ShowLicenseToolStripMenuItem";
            this.ShowLicenseToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.ShowLicenseToolStripMenuItem.Text = "Show License";
            this.ShowLicenseToolStripMenuItem.Click += new System.EventHandler(this.ShowLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(259, 6);
            // 
            // ShowPersonLicenseHistoryToolStripMenuItem
            // 
            this.ShowPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.bio;
            this.ShowPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPersonLicenseHistoryToolStripMenuItem.Name = "ShowPersonLicenseHistoryToolStripMenuItem";
            this.ShowPersonLicenseHistoryToolStripMenuItem.ShowShortcutKeys = false;
            this.ShowPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.ShowPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // ComboBoxStatus
            // 
            this.ComboBoxStatus.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ComboBoxStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ComboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStatus.FormattingEnabled = true;
            this.ComboBoxStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "Completed",
            "Cancelled"});
            this.ComboBoxStatus.Location = new System.Drawing.Point(230, 160);
            this.ComboBoxStatus.Name = "ComboBoxStatus";
            this.ComboBoxStatus.Size = new System.Drawing.Size(122, 21);
            this.ComboBoxStatus.TabIndex = 17;
            this.ComboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.ComboBoxStatus_SelectedIndexChanged);
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
            this.ButtonClose.Location = new System.Drawing.Point(1030, 490);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(103, 39);
            this.ButtonClose.TabIndex = 15;
            this.ButtonClose.Text = "      Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonAddNewLocalDrivingLicenseApplication
            // 
            this.ButtonAddNewLocalDrivingLicenseApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddNewLocalDrivingLicenseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddNewLocalDrivingLicenseApplication.Image = global::DVLD_System.Properties.Resources.add_file__1_;
            this.ButtonAddNewLocalDrivingLicenseApplication.Location = new System.Drawing.Point(1083, 130);
            this.ButtonAddNewLocalDrivingLicenseApplication.Name = "ButtonAddNewLocalDrivingLicenseApplication";
            this.ButtonAddNewLocalDrivingLicenseApplication.Size = new System.Drawing.Size(50, 50);
            this.ButtonAddNewLocalDrivingLicenseApplication.TabIndex = 12;
            this.ButtonAddNewLocalDrivingLicenseApplication.UseVisualStyleBackColor = true;
            this.ButtonAddNewLocalDrivingLicenseApplication.Click += new System.EventHandler(this.ButtonAddNewLocalDrivingLicenseApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_System.Properties.Resources.map__1_;
            this.pictureBox1.Location = new System.Drawing.Point(517, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ManageLocalDrivingLicenseApplicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonClose;
            this.ClientSize = new System.Drawing.Size(1143, 540);
            this.Controls.Add(this.ComboBoxStatus);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.LabelRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonAddNewLocalDrivingLicenseApplication);
            this.Controls.Add(this.DataGridViewLocalDrivingLicenseApplications);
            this.Controls.Add(this.TextBoxFilter);
            this.Controls.Add(this.ComboBoxFilterApplications);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(110, 110);
            this.Name = "ManageLocalDrivingLicenseApplicationsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Local Driving License Applications";
            this.Load += new System.EventHandler(this.LocalDrivingLicenseApplicationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLocalDrivingLicenseApplications)).EndInit();
            this.ContextMenuStripManageLocalDrivingLicenseApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TextBoxFilter;
        private System.Windows.Forms.ComboBox ComboBoxFilterApplications;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGridViewLocalDrivingLicenseApplications;
        private System.Windows.Forms.Button ButtonAddNewLocalDrivingLicenseApplication;
        private System.Windows.Forms.Label LabelRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripManageLocalDrivingLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem ShowApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem EditApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CancelApplicationToolStripMenuItem;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem IssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ComboBox ComboBoxStatus;
        private System.Windows.Forms.ToolStripMenuItem ScheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScheduleWrittenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScheduleStreetTestToolStripMenuItem;
    }
}