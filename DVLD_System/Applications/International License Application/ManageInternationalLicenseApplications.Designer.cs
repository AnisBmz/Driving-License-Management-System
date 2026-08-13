namespace DVLD_System
{
    partial class ManageInternationalLicenseApplicationsForm
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
            this.TextBoxFilter = new System.Windows.Forms.TextBox();
            this.ComboBoxFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelRecordsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonAddNewInternationalLicenseApplication = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStripManageInternationalLicenseApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridViewInternationalLicenseApplications = new System.Windows.Forms.DataGridView();
            this.ComboBoxIsActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStripManageInternationalLicenseApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInternationalLicenseApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxFilter
            // 
            this.TextBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxFilter.Location = new System.Drawing.Point(230, 178);
            this.TextBoxFilter.MaxLength = 300;
            this.TextBoxFilter.Name = "TextBoxFilter";
            this.TextBoxFilter.Size = new System.Drawing.Size(165, 20);
            this.TextBoxFilter.TabIndex = 22;
            this.TextBoxFilter.Visible = false;
            this.TextBoxFilter.TextChanged += new System.EventHandler(this.TextBoxFilter_TextChanged);
            this.TextBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFilter_KeyPress);
            // 
            // ComboBoxFilter
            // 
            this.ComboBoxFilter.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ComboBoxFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilter.FormattingEnabled = true;
            this.ComboBoxFilter.Location = new System.Drawing.Point(73, 177);
            this.ComboBoxFilter.Name = "ComboBoxFilter";
            this.ComboBoxFilter.Size = new System.Drawing.Size(139, 21);
            this.ComboBoxFilter.TabIndex = 21;
            this.ComboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterApplications_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Filter By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(357, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Manage International License Applications";
            // 
            // LabelRecordsCount
            // 
            this.LabelRecordsCount.AutoSize = true;
            this.LabelRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRecordsCount.Location = new System.Drawing.Point(85, 473);
            this.LabelRecordsCount.Name = "LabelRecordsCount";
            this.LabelRecordsCount.Size = new System.Drawing.Size(14, 13);
            this.LabelRecordsCount.TabIndex = 26;
            this.LabelRecordsCount.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "# Records:";
            // 
            // ButtonAddNewInternationalLicenseApplication
            // 
            this.ButtonAddNewInternationalLicenseApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddNewInternationalLicenseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddNewInternationalLicenseApplication.Image = global::DVLD_System.Properties.Resources.add_file__1_;
            this.ButtonAddNewInternationalLicenseApplication.Location = new System.Drawing.Point(1081, 148);
            this.ButtonAddNewInternationalLicenseApplication.Name = "ButtonAddNewInternationalLicenseApplication";
            this.ButtonAddNewInternationalLicenseApplication.Size = new System.Drawing.Size(50, 50);
            this.ButtonAddNewInternationalLicenseApplication.TabIndex = 28;
            this.ButtonAddNewInternationalLicenseApplication.UseVisualStyleBackColor = true;
            this.ButtonAddNewInternationalLicenseApplication.Click += new System.EventHandler(this.ButtonAddNewInternationalLicenseApplication_Click);
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
            this.ButtonClose.Location = new System.Drawing.Point(1030, 473);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(103, 39);
            this.ButtonClose.TabIndex = 27;
            this.ButtonClose.Text = "      Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_System.Properties.Resources.driver_license__4_;
            this.pictureBox1.Location = new System.Drawing.Point(501, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStripManageInternationalLicenseApplications
            // 
            this.contextMenuStripManageInternationalLicenseApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonDetailsToolStripMenuItem,
            this.ShowLicenseDetailsToolStripMenuItem,
            this.ShowPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStripManageInternationalLicenseApplications.Name = "contextMenuStripManageInternationalLicenseApplications";
            this.contextMenuStripManageInternationalLicenseApplications.Size = new System.Drawing.Size(242, 118);
            // 
            // ShowPersonDetailsToolStripMenuItem
            // 
            this.ShowPersonDetailsToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.search__1_;
            this.ShowPersonDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPersonDetailsToolStripMenuItem.Name = "ShowPersonDetailsToolStripMenuItem";
            this.ShowPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.ShowPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.ShowPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonDetailsToolStripMenuItem_Click);
            // 
            // ShowLicenseDetailsToolStripMenuItem
            // 
            this.ShowLicenseDetailsToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.driving_license__1_;
            this.ShowLicenseDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLicenseDetailsToolStripMenuItem.Name = "ShowLicenseDetailsToolStripMenuItem";
            this.ShowLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.ShowLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.ShowLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowLicenseDetailsToolStripMenuItem_Click);
            // 
            // ShowPersonLicenseHistoryToolStripMenuItem
            // 
            this.ShowPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.bio;
            this.ShowPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPersonLicenseHistoryToolStripMenuItem.Name = "ShowPersonLicenseHistoryToolStripMenuItem";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.ShowPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // DataGridViewInternationalLicenseApplications
            // 
            this.DataGridViewInternationalLicenseApplications.AllowUserToAddRows = false;
            this.DataGridViewInternationalLicenseApplications.AllowUserToDeleteRows = false;
            this.DataGridViewInternationalLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewInternationalLicenseApplications.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewInternationalLicenseApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewInternationalLicenseApplications.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewInternationalLicenseApplications.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewInternationalLicenseApplications.Location = new System.Drawing.Point(10, 204);
            this.DataGridViewInternationalLicenseApplications.MultiSelect = false;
            this.DataGridViewInternationalLicenseApplications.Name = "DataGridViewInternationalLicenseApplications";
            this.DataGridViewInternationalLicenseApplications.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(20);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewInternationalLicenseApplications.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewInternationalLicenseApplications.RowHeadersVisible = false;
            this.DataGridViewInternationalLicenseApplications.RowHeadersWidth = 57;
            this.DataGridViewInternationalLicenseApplications.RowTemplate.Height = 45;
            this.DataGridViewInternationalLicenseApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewInternationalLicenseApplications.Size = new System.Drawing.Size(1123, 256);
            this.DataGridViewInternationalLicenseApplications.TabIndex = 23;
            this.DataGridViewInternationalLicenseApplications.SelectionChanged += new System.EventHandler(this.DataGridViewInternationalLicenseApplications_SelectionChanged);
            // 
            // ComboBoxIsActive
            // 
            this.ComboBoxIsActive.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ComboBoxIsActive.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ComboBoxIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxIsActive.FormattingEnabled = true;
            this.ComboBoxIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.ComboBoxIsActive.Location = new System.Drawing.Point(230, 178);
            this.ComboBoxIsActive.Name = "ComboBoxIsActive";
            this.ComboBoxIsActive.Size = new System.Drawing.Size(122, 21);
            this.ComboBoxIsActive.TabIndex = 29;
            this.ComboBoxIsActive.SelectedIndexChanged += new System.EventHandler(this.ComboBoxIsActive_SelectedIndexChanged);
            // 
            // ManageInternationalLicenseApplicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1143, 521);
            this.Controls.Add(this.ComboBoxIsActive);
            this.Controls.Add(this.ButtonAddNewInternationalLicenseApplication);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.LabelRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataGridViewInternationalLicenseApplications);
            this.Controls.Add(this.TextBoxFilter);
            this.Controls.Add(this.ComboBoxFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(110, 125);
            this.Name = "ManageInternationalLicenseApplicationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ManageInternationalLicenseApplications";
            this.Load += new System.EventHandler(this.ManageInternationalLicenseApplicationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStripManageInternationalLicenseApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInternationalLicenseApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxFilter;
        private System.Windows.Forms.ComboBox ComboBoxFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonAddNewInternationalLicenseApplication;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripManageInternationalLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.DataGridView DataGridViewInternationalLicenseApplications;
        private System.Windows.Forms.ComboBox ComboBoxIsActive;
    }
}