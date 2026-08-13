namespace DVLD_System
{
    partial class ManageTestAppointmentsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.DataGridViewVisionAppointments = new System.Windows.Forms.DataGridView();
            this.LabelRecordsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ContextMenuStripAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonAddAppointment = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControl_DrivingLicenseApplicationInfo1 = new DVLD_System.UserControl_DrivingLicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVisionAppointments)).BeginInit();
            this.ContextMenuStripAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LabelTitle.Location = new System.Drawing.Point(233, 94);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(265, 30);
            this.LabelTitle.TabIndex = 4;
            this.LabelTitle.Text = "Vision Test Appointments";
            // 
            // DataGridViewVisionAppointments
            // 
            this.DataGridViewVisionAppointments.AllowUserToAddRows = false;
            this.DataGridViewVisionAppointments.AllowUserToDeleteRows = false;
            this.DataGridViewVisionAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewVisionAppointments.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewVisionAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewVisionAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewVisionAppointments.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewVisionAppointments.Location = new System.Drawing.Point(17, 489);
            this.DataGridViewVisionAppointments.MultiSelect = false;
            this.DataGridViewVisionAppointments.Name = "DataGridViewVisionAppointments";
            this.DataGridViewVisionAppointments.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(20);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewVisionAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewVisionAppointments.RowHeadersVisible = false;
            this.DataGridViewVisionAppointments.RowHeadersWidth = 57;
            this.DataGridViewVisionAppointments.RowTemplate.Height = 35;
            this.DataGridViewVisionAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewVisionAppointments.Size = new System.Drawing.Size(697, 120);
            this.DataGridViewVisionAppointments.TabIndex = 12;
            this.DataGridViewVisionAppointments.SelectionChanged += new System.EventHandler(this.DataGridViewVisionAppointments_SelectionChanged);
            // 
            // LabelRecordsCount
            // 
            this.LabelRecordsCount.AutoSize = true;
            this.LabelRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRecordsCount.Location = new System.Drawing.Point(90, 614);
            this.LabelRecordsCount.Name = "LabelRecordsCount";
            this.LabelRecordsCount.Size = new System.Drawing.Size(21, 13);
            this.LabelRecordsCount.TabIndex = 16;
            this.LabelRecordsCount.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "# Records:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Appointments:";
            // 
            // ContextMenuStripAppointments
            // 
            this.ContextMenuStripAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAppointmentToolStripMenuItem,
            this.TakeTestToolStripMenuItem});
            this.ContextMenuStripAppointments.Name = "ContextMenuStripVisionAppointments";
            this.ContextMenuStripAppointments.Size = new System.Drawing.Size(197, 102);
            // 
            // EditAppointmentToolStripMenuItem
            // 
            this.EditAppointmentToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.edit;
            this.EditAppointmentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditAppointmentToolStripMenuItem.Name = "EditAppointmentToolStripMenuItem";
            this.EditAppointmentToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.EditAppointmentToolStripMenuItem.Text = "Edit Appointment";
            this.EditAppointmentToolStripMenuItem.Click += new System.EventHandler(this.EditAppointmentToolStripMenuItem_Click);
            // 
            // TakeTestToolStripMenuItem
            // 
            this.TakeTestToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.test__2_;
            this.TakeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TakeTestToolStripMenuItem.Name = "TakeTestToolStripMenuItem";
            this.TakeTestToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.TakeTestToolStripMenuItem.Text = "Take Test";
            this.TakeTestToolStripMenuItem.Click += new System.EventHandler(this.TakeTestToolStripMenuItem_Click);
            // 
            // ButtonAddAppointment
            // 
            this.ButtonAddAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddAppointment.Image = global::DVLD_System.Properties.Resources.calendar__1_;
            this.ButtonAddAppointment.Location = new System.Drawing.Point(669, 444);
            this.ButtonAddAppointment.Name = "ButtonAddAppointment";
            this.ButtonAddAppointment.Size = new System.Drawing.Size(44, 41);
            this.ButtonAddAppointment.TabIndex = 19;
            this.ButtonAddAppointment.UseVisualStyleBackColor = true;
            this.ButtonAddAppointment.Click += new System.EventHandler(this.ButtonAddAppointment_Click);
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
            this.ButtonClose.Location = new System.Drawing.Point(611, 615);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(103, 39);
            this.ButtonClose.TabIndex = 17;
            this.ButtonClose.Text = "      Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_System.Properties.Resources.eye;
            this.pictureBox1.Location = new System.Drawing.Point(294, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // userControl_DrivingLicenseApplicationInfo1
            // 
            this.userControl_DrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.userControl_DrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(13, 127);
            this.userControl_DrivingLicenseApplicationInfo1.Name = "userControl_DrivingLicenseApplicationInfo1";
            this.userControl_DrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(704, 313);
            this.userControl_DrivingLicenseApplicationInfo1.TabIndex = 6;
            // 
            // ManageTestAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 660);
            this.Controls.Add(this.ButtonAddAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.LabelRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataGridViewVisionAppointments);
            this.Controls.Add(this.userControl_DrivingLicenseApplicationInfo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageTestAppointmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vision Test Appointments";
            this.Load += new System.EventHandler(this.TestAppointmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVisionAppointments)).EndInit();
            this.ContextMenuStripAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControl_DrivingLicenseApplicationInfo userControl_DrivingLicenseApplicationInfo1;
        private System.Windows.Forms.DataGridView DataGridViewVisionAppointments;
        private System.Windows.Forms.Label LabelRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonAddAppointment;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripAppointments;
        private System.Windows.Forms.ToolStripMenuItem EditAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TakeTestToolStripMenuItem;
    }
}