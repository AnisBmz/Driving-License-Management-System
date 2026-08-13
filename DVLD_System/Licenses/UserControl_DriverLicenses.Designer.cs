namespace DVLD_System.Licenses
{
    partial class UserControlDriverLicenses
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

        #region Component Designer generated code

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageLocal = new System.Windows.Forms.TabPage();
            this.LabelNoLocal = new System.Windows.Forms.Label();
            this.LabelRecordsCountLocal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridViewLocalLicense = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TabPageInternational = new System.Windows.Forms.TabPage();
            this.LabelNo = new System.Windows.Forms.Label();
            this.LabelRecordsCountInternational = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DataGridViewInternationalLicense = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.ContextMenuStripInternationalLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowInternationalLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuLocalLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowLocalLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.TabPageLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLocalLicense)).BeginInit();
            this.TabPageInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInternationalLicense)).BeginInit();
            this.ContextMenuStripInternationalLicense.SuspendLayout();
            this.ContextMenuLocalLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageLocal);
            this.tabControl1.Controls.Add(this.TabPageInternational);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 276);
            this.tabControl1.TabIndex = 9;
            // 
            // TabPageLocal
            // 
            this.TabPageLocal.BackColor = System.Drawing.Color.White;
            this.TabPageLocal.Controls.Add(this.LabelNoLocal);
            this.TabPageLocal.Controls.Add(this.LabelRecordsCountLocal);
            this.TabPageLocal.Controls.Add(this.label3);
            this.TabPageLocal.Controls.Add(this.DataGridViewLocalLicense);
            this.TabPageLocal.Controls.Add(this.label2);
            this.TabPageLocal.Location = new System.Drawing.Point(4, 22);
            this.TabPageLocal.Name = "TabPageLocal";
            this.TabPageLocal.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageLocal.Size = new System.Drawing.Size(904, 250);
            this.TabPageLocal.TabIndex = 0;
            this.TabPageLocal.Text = "Local";
            // 
            // LabelNoLocal
            // 
            this.LabelNoLocal.AutoSize = true;
            this.LabelNoLocal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNoLocal.Location = new System.Drawing.Point(350, 115);
            this.LabelNoLocal.Name = "LabelNoLocal";
            this.LabelNoLocal.Size = new System.Drawing.Size(205, 21);
            this.LabelNoLocal.TabIndex = 32;
            this.LabelNoLocal.Text = "No Local Driving Licenses";
            // 
            // LabelRecordsCountLocal
            // 
            this.LabelRecordsCountLocal.AutoSize = true;
            this.LabelRecordsCountLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRecordsCountLocal.Location = new System.Drawing.Point(87, 231);
            this.LabelRecordsCountLocal.Name = "LabelRecordsCountLocal";
            this.LabelRecordsCountLocal.Size = new System.Drawing.Size(21, 13);
            this.LabelRecordsCountLocal.TabIndex = 26;
            this.LabelRecordsCountLocal.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "# Records:";
            // 
            // DataGridViewLocalLicense
            // 
            this.DataGridViewLocalLicense.AllowUserToAddRows = false;
            this.DataGridViewLocalLicense.AllowUserToDeleteRows = false;
            this.DataGridViewLocalLicense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewLocalLicense.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewLocalLicense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewLocalLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewLocalLicense.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewLocalLicense.Location = new System.Drawing.Point(9, 33);
            this.DataGridViewLocalLicense.MultiSelect = false;
            this.DataGridViewLocalLicense.Name = "DataGridViewLocalLicense";
            this.DataGridViewLocalLicense.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(20);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewLocalLicense.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewLocalLicense.RowHeadersVisible = false;
            this.DataGridViewLocalLicense.RowHeadersWidth = 57;
            this.DataGridViewLocalLicense.RowTemplate.Height = 35;
            this.DataGridViewLocalLicense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLocalLicense.Size = new System.Drawing.Size(886, 195);
            this.DataGridViewLocalLicense.TabIndex = 24;
            this.DataGridViewLocalLicense.SelectionChanged += new System.EventHandler(this.DataGridViewLocalLicense_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Local Licenses History:";
            // 
            // TabPageInternational
            // 
            this.TabPageInternational.BackColor = System.Drawing.Color.White;
            this.TabPageInternational.Controls.Add(this.LabelNo);
            this.TabPageInternational.Controls.Add(this.LabelRecordsCountInternational);
            this.TabPageInternational.Controls.Add(this.label5);
            this.TabPageInternational.Controls.Add(this.DataGridViewInternationalLicense);
            this.TabPageInternational.Controls.Add(this.label6);
            this.TabPageInternational.Location = new System.Drawing.Point(4, 22);
            this.TabPageInternational.Name = "TabPageInternational";
            this.TabPageInternational.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageInternational.Size = new System.Drawing.Size(904, 250);
            this.TabPageInternational.TabIndex = 1;
            this.TabPageInternational.Text = "International";
            // 
            // LabelNo
            // 
            this.LabelNo.AutoSize = true;
            this.LabelNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNo.Location = new System.Drawing.Point(320, 115);
            this.LabelNo.Name = "LabelNo";
            this.LabelNo.Size = new System.Drawing.Size(265, 21);
            this.LabelNo.TabIndex = 31;
            this.LabelNo.Text = "No International Driving Licenses";
            // 
            // LabelRecordsCountInternational
            // 
            this.LabelRecordsCountInternational.AutoSize = true;
            this.LabelRecordsCountInternational.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRecordsCountInternational.Location = new System.Drawing.Point(87, 231);
            this.LabelRecordsCountInternational.Name = "LabelRecordsCountInternational";
            this.LabelRecordsCountInternational.Size = new System.Drawing.Size(21, 13);
            this.LabelRecordsCountInternational.TabIndex = 30;
            this.LabelRecordsCountInternational.Text = "??";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "# Records:";
            // 
            // DataGridViewInternationalLicense
            // 
            this.DataGridViewInternationalLicense.AllowUserToAddRows = false;
            this.DataGridViewInternationalLicense.AllowUserToDeleteRows = false;
            this.DataGridViewInternationalLicense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewInternationalLicense.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewInternationalLicense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewInternationalLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewInternationalLicense.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewInternationalLicense.Location = new System.Drawing.Point(9, 33);
            this.DataGridViewInternationalLicense.MultiSelect = false;
            this.DataGridViewInternationalLicense.Name = "DataGridViewInternationalLicense";
            this.DataGridViewInternationalLicense.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(20);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewInternationalLicense.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewInternationalLicense.RowHeadersVisible = false;
            this.DataGridViewInternationalLicense.RowHeadersWidth = 57;
            this.DataGridViewInternationalLicense.RowTemplate.Height = 35;
            this.DataGridViewInternationalLicense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewInternationalLicense.Size = new System.Drawing.Size(886, 195);
            this.DataGridViewInternationalLicense.TabIndex = 28;
            this.DataGridViewInternationalLicense.SelectionChanged += new System.EventHandler(this.DataGridViewInternationalLicense_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "International Licenses History:";
            // 
            // ContextMenuStripInternationalLicense
            // 
            this.ContextMenuStripInternationalLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowInternationalLicenseInfoToolStripMenuItem});
            this.ContextMenuStripInternationalLicense.Name = "ContextMenuLocalLicense";
            this.ContextMenuStripInternationalLicense.Size = new System.Drawing.Size(186, 42);
            // 
            // ShowInternationalLicenseInfoToolStripMenuItem
            // 
            this.ShowInternationalLicenseInfoToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.driving_license__1_;
            this.ShowInternationalLicenseInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowInternationalLicenseInfoToolStripMenuItem.Name = "ShowInternationalLicenseInfoToolStripMenuItem";
            this.ShowInternationalLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.ShowInternationalLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.ShowInternationalLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.ShowInternationalLicenseInfoToolStripMenuItem_Click);
            // 
            // ContextMenuLocalLicense
            // 
            this.ContextMenuLocalLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowLocalLicenseInfoToolStripMenuItem});
            this.ContextMenuLocalLicense.Name = "ContextMenuLocalLicense";
            this.ContextMenuLocalLicense.Size = new System.Drawing.Size(186, 42);
            // 
            // ShowLocalLicenseInfoToolStripMenuItem
            // 
            this.ShowLocalLicenseInfoToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.driving_license__1_;
            this.ShowLocalLicenseInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLocalLicenseInfoToolStripMenuItem.Name = "ShowLocalLicenseInfoToolStripMenuItem";
            this.ShowLocalLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.ShowLocalLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.ShowLocalLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.ShowLicenseInfoToolStripMenuItem_Click);
            // 
            // UserControlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControlDriverLicenses";
            this.Size = new System.Drawing.Size(919, 281);
            this.tabControl1.ResumeLayout(false);
            this.TabPageLocal.ResumeLayout(false);
            this.TabPageLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLocalLicense)).EndInit();
            this.TabPageInternational.ResumeLayout(false);
            this.TabPageInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInternationalLicense)).EndInit();
            this.ContextMenuStripInternationalLicense.ResumeLayout(false);
            this.ContextMenuLocalLicense.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPageLocal;
        private System.Windows.Forms.Label LabelNoLocal;
        private System.Windows.Forms.Label LabelRecordsCountLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridViewLocalLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage TabPageInternational;
        private System.Windows.Forms.Label LabelNo;
        private System.Windows.Forms.Label LabelRecordsCountInternational;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DataGridViewInternationalLicense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem ShowInternationalLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenuLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem ShowLocalLicenseInfoToolStripMenuItem;
    }
}
