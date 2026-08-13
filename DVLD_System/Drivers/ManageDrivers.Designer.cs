namespace DVLD_System
{
    partial class ManageDriversForm
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
            this.LabelRecordsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxFilter = new System.Windows.Forms.TextBox();
            this.ComboBoxFilterDrivers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewDrivers = new System.Windows.Forms.DataGridView();
            this.ContextMenuStripManageDriver = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPesonLicensesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDrivers)).BeginInit();
            this.ContextMenuStripManageDriver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelRecordsCount
            // 
            this.LabelRecordsCount.AutoSize = true;
            this.LabelRecordsCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRecordsCount.Location = new System.Drawing.Point(93, 462);
            this.LabelRecordsCount.Name = "LabelRecordsCount";
            this.LabelRecordsCount.Size = new System.Drawing.Size(17, 15);
            this.LabelRecordsCount.TabIndex = 19;
            this.LabelRecordsCount.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "# Records:";
            // 
            // TextBoxFilter
            // 
            this.TextBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxFilter.Location = new System.Drawing.Point(235, 174);
            this.TextBoxFilter.MaxLength = 300;
            this.TextBoxFilter.Name = "TextBoxFilter";
            this.TextBoxFilter.Size = new System.Drawing.Size(165, 20);
            this.TextBoxFilter.TabIndex = 17;
            this.TextBoxFilter.Visible = false;
            this.TextBoxFilter.TextChanged += new System.EventHandler(this.TextBoxFilter_TextChanged);
            this.TextBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFilter_KeyPress);
            // 
            // ComboBoxFilterDrivers
            // 
            this.ComboBoxFilterDrivers.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ComboBoxFilterDrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxFilterDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilterDrivers.FormattingEnabled = true;
            this.ComboBoxFilterDrivers.Location = new System.Drawing.Point(78, 173);
            this.ComboBoxFilterDrivers.Name = "ComboBoxFilterDrivers";
            this.ComboBoxFilterDrivers.Size = new System.Drawing.Size(139, 21);
            this.ComboBoxFilterDrivers.TabIndex = 15;
            this.ComboBoxFilterDrivers.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterDrivers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filter By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(491, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Drivers";
            // 
            // DataGridViewDrivers
            // 
            this.DataGridViewDrivers.AllowUserToAddRows = false;
            this.DataGridViewDrivers.AllowUserToDeleteRows = false;
            this.DataGridViewDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewDrivers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewDrivers.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewDrivers.Location = new System.Drawing.Point(13, 200);
            this.DataGridViewDrivers.MultiSelect = false;
            this.DataGridViewDrivers.Name = "DataGridViewDrivers";
            this.DataGridViewDrivers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(20);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDrivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewDrivers.RowHeadersVisible = false;
            this.DataGridViewDrivers.RowHeadersWidth = 57;
            this.DataGridViewDrivers.RowTemplate.Height = 40;
            this.DataGridViewDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDrivers.Size = new System.Drawing.Size(1123, 256);
            this.DataGridViewDrivers.TabIndex = 11;
            this.DataGridViewDrivers.SelectionChanged += new System.EventHandler(this.DataGridViewDrivers_SelectionChanged);
            // 
            // ContextMenuStripManageDriver
            // 
            this.ContextMenuStripManageDriver.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowToolStripMenuItem,
            this.ShowPesonLicensesHistoryToolStripMenuItem});
            this.ContextMenuStripManageDriver.Name = "contextMenuStrip1";
            this.ContextMenuStripManageDriver.Size = new System.Drawing.Size(242, 80);
            // 
            // ShowToolStripMenuItem
            // 
            this.ShowToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.search__1_;
            this.ShowToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            this.ShowToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.ShowToolStripMenuItem.Text = "Show Person Info";
            this.ShowToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // ShowPesonLicensesHistoryToolStripMenuItem
            // 
            this.ShowPesonLicensesHistoryToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.bio;
            this.ShowPesonLicensesHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPesonLicensesHistoryToolStripMenuItem.Name = "ShowPesonLicensesHistoryToolStripMenuItem";
            this.ShowPesonLicensesHistoryToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.ShowPesonLicensesHistoryToolStripMenuItem.Text = "Show Person License History";
            this.ShowPesonLicensesHistoryToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonLicensesHistoryToolStripMenuItem_Click);
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
            this.ButtonClose.Location = new System.Drawing.Point(1033, 462);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(103, 39);
            this.ButtonClose.TabIndex = 16;
            this.ButtonClose.Text = "      Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_System.Properties.Resources.target_audience;
            this.pictureBox1.Location = new System.Drawing.Point(504, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ManageDriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1149, 517);
            this.Controls.Add(this.LabelRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxFilter);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ComboBoxFilterDrivers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewDrivers);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(110, 120);
            this.Name = "ManageDriversForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manage Drivers";
            this.Load += new System.EventHandler(this.ManageDriversForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDrivers)).EndInit();
            this.ContextMenuStripManageDriver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxFilter;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.ComboBox ComboBoxFilterDrivers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridViewDrivers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripManageDriver;
        private System.Windows.Forms.ToolStripMenuItem ShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowPesonLicensesHistoryToolStripMenuItem;
    }
}