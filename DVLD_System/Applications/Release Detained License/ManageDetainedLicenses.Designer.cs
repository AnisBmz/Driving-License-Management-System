namespace DVLD_System
{
    partial class ManageDetainedLicensesForm
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
            this.DataGridViewDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.TextBoxFilter = new System.Windows.Forms.TextBox();
            this.ComboBoxFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelRecordsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxIsReleased = new System.Windows.Forms.ComboBox();
            this.contextMenuStripManageDetainedLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonReleaseLicense = new System.Windows.Forms.Button();
            this.ButtonAddDetainLicense = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReleaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDetainedLicenses)).BeginInit();
            this.contextMenuStripManageDetainedLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewDetainedLicenses
            // 
            this.DataGridViewDetainedLicenses.AllowUserToAddRows = false;
            this.DataGridViewDetainedLicenses.AllowUserToDeleteRows = false;
            this.DataGridViewDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewDetainedLicenses.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDetainedLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewDetainedLicenses.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewDetainedLicenses.Location = new System.Drawing.Point(10, 208);
            this.DataGridViewDetainedLicenses.MultiSelect = false;
            this.DataGridViewDetainedLicenses.Name = "DataGridViewDetainedLicenses";
            this.DataGridViewDetainedLicenses.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(20);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDetainedLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewDetainedLicenses.RowHeadersVisible = false;
            this.DataGridViewDetainedLicenses.RowHeadersWidth = 57;
            this.DataGridViewDetainedLicenses.RowTemplate.Height = 45;
            this.DataGridViewDetainedLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDetainedLicenses.Size = new System.Drawing.Size(1123, 256);
            this.DataGridViewDetainedLicenses.TabIndex = 29;
            this.DataGridViewDetainedLicenses.SelectionChanged += new System.EventHandler(this.DataGridViewDetainedLicenses_SelectionChanged);
            // 
            // TextBoxFilter
            // 
            this.TextBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxFilter.Location = new System.Drawing.Point(230, 182);
            this.TextBoxFilter.MaxLength = 300;
            this.TextBoxFilter.Name = "TextBoxFilter";
            this.TextBoxFilter.Size = new System.Drawing.Size(165, 20);
            this.TextBoxFilter.TabIndex = 28;
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
            this.ComboBoxFilter.Location = new System.Drawing.Point(73, 181);
            this.ComboBoxFilter.Name = "ComboBoxFilter";
            this.ComboBoxFilter.Size = new System.Drawing.Size(139, 21);
            this.ComboBoxFilter.TabIndex = 27;
            this.ComboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterApplications_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Filter By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(435, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Manage Detained Licenses";
            // 
            // LabelRecordsCount
            // 
            this.LabelRecordsCount.AutoSize = true;
            this.LabelRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRecordsCount.Location = new System.Drawing.Point(83, 477);
            this.LabelRecordsCount.Name = "LabelRecordsCount";
            this.LabelRecordsCount.Size = new System.Drawing.Size(14, 13);
            this.LabelRecordsCount.TabIndex = 32;
            this.LabelRecordsCount.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "# Records:";
            // 
            // ComboBoxIsReleased
            // 
            this.ComboBoxIsReleased.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ComboBoxIsReleased.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ComboBoxIsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxIsReleased.FormattingEnabled = true;
            this.ComboBoxIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.ComboBoxIsReleased.Location = new System.Drawing.Point(230, 182);
            this.ComboBoxIsReleased.Name = "ComboBoxIsReleased";
            this.ComboBoxIsReleased.Size = new System.Drawing.Size(122, 21);
            this.ComboBoxIsReleased.TabIndex = 35;
            this.ComboBoxIsReleased.SelectedIndexChanged += new System.EventHandler(this.ComboBoxIsReleased_SelectedIndexChanged);
            // 
            // contextMenuStripManageDetainedLicenses
            // 
            this.contextMenuStripManageDetainedLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonDetailsToolStripMenuItem,
            this.ShowLicenseDetailsToolStripMenuItem,
            this.ShowPersonLicenseHistoryToolStripMenuItem,
            this.toolStripSeparator1,
            this.ReleaseDetainedLicenseToolStripMenuItem});
            this.contextMenuStripManageDetainedLicenses.Name = "contextMenuStripManageInternationalLicenseApplications";
            this.contextMenuStripManageDetainedLicenses.Size = new System.Drawing.Size(242, 184);
            this.contextMenuStripManageDetainedLicenses.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripManageDetainedLicenses_Opening);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(238, 6);
            // 
            // ButtonReleaseLicense
            // 
            this.ButtonReleaseLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonReleaseLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReleaseLicense.Image = global::DVLD_System.Properties.Resources.money_10876258;
            this.ButtonReleaseLicense.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonReleaseLicense.Location = new System.Drawing.Point(1016, 152);
            this.ButtonReleaseLicense.Name = "ButtonReleaseLicense";
            this.ButtonReleaseLicense.Size = new System.Drawing.Size(50, 50);
            this.ButtonReleaseLicense.TabIndex = 34;
            this.ButtonReleaseLicense.UseVisualStyleBackColor = true;
            this.ButtonReleaseLicense.Click += new System.EventHandler(this.ButtonReleaseLicense_Click);
            // 
            // ButtonAddDetainLicense
            // 
            this.ButtonAddDetainLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddDetainLicense.Image = global::DVLD_System.Properties.Resources.booking_2262618;
            this.ButtonAddDetainLicense.Location = new System.Drawing.Point(1081, 152);
            this.ButtonAddDetainLicense.Name = "ButtonAddDetainLicense";
            this.ButtonAddDetainLicense.Size = new System.Drawing.Size(50, 50);
            this.ButtonAddDetainLicense.TabIndex = 33;
            this.ButtonAddDetainLicense.UseVisualStyleBackColor = true;
            this.ButtonAddDetainLicense.Click += new System.EventHandler(this.ButtonAddDetainLicense_Click);
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
            this.ButtonClose.TabIndex = 30;
            this.ButtonClose.Text = "      Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_System.Properties.Resources.card_12138031;
            this.pictureBox1.Location = new System.Drawing.Point(501, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
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
            // ReleaseDetainedLicenseToolStripMenuItem
            // 
            this.ReleaseDetainedLicenseToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.credit_card_11505943;
            this.ReleaseDetainedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReleaseDetainedLicenseToolStripMenuItem.Name = "ReleaseDetainedLicenseToolStripMenuItem";
            this.ReleaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.ReleaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.ReleaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.ReleaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // ManageDetainedLicensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1143, 521);
            this.Controls.Add(this.ComboBoxIsReleased);
            this.Controls.Add(this.ButtonReleaseLicense);
            this.Controls.Add(this.ButtonAddDetainLicense);
            this.Controls.Add(this.LabelRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.DataGridViewDetainedLicenses);
            this.Controls.Add(this.TextBoxFilter);
            this.Controls.Add(this.ComboBoxFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(110, 125);
            this.Name = "ManageDetainedLicensesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manage Detained Licenses";
            this.Load += new System.EventHandler(this.ManageDetainedLicensesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDetainedLicenses)).EndInit();
            this.contextMenuStripManageDetainedLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewDetainedLicenses;
        private System.Windows.Forms.TextBox TextBoxFilter;
        private System.Windows.Forms.ComboBox ComboBoxFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonAddDetainLicense;
        private System.Windows.Forms.Button ButtonReleaseLicense;
        private System.Windows.Forms.ComboBox ComboBoxIsReleased;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripManageDetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ReleaseDetainedLicenseToolStripMenuItem;
    }
}