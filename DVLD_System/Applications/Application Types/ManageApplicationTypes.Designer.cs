namespace DVLD_System
{
    partial class ManageApplicationTypesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelCount = new System.Windows.Forms.Label();
            this.ButoonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGridViewApplicationTypes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewApplicationTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(255, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Application Types";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "# Records:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditApplicationTypeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 42);
            // 
            // EditApplicationTypeToolStripMenuItem
            // 
            this.EditApplicationTypeToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.edit;
            this.EditApplicationTypeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditApplicationTypeToolStripMenuItem.Name = "EditApplicationTypeToolStripMenuItem";
            this.EditApplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(202, 38);
            this.EditApplicationTypeToolStripMenuItem.Text = "Edit Application Type";
            this.EditApplicationTypeToolStripMenuItem.Click += new System.EventHandler(this.EditApplicationTypeToolStripMenuItem_Click);
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCount.Location = new System.Drawing.Point(87, 532);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(14, 13);
            this.LabelCount.TabIndex = 14;
            this.LabelCount.Text = "7";
            // 
            // ButoonClose
            // 
            this.ButoonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButoonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButoonClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButoonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButoonClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButoonClose.Image = global::DVLD_System.Properties.Resources.Close_32;
            this.ButoonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButoonClose.Location = new System.Drawing.Point(660, 531);
            this.ButoonClose.Name = "ButoonClose";
            this.ButoonClose.Size = new System.Drawing.Size(103, 39);
            this.ButoonClose.TabIndex = 12;
            this.ButoonClose.Text = "      Close";
            this.ButoonClose.UseVisualStyleBackColor = true;
            this.ButoonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_System.Properties.Resources.documents;
            this.pictureBox1.Location = new System.Drawing.Point(320, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DataGridViewApplicationTypes
            // 
            this.DataGridViewApplicationTypes.AllowUserToAddRows = false;
            this.DataGridViewApplicationTypes.AllowUserToDeleteRows = false;
            this.DataGridViewApplicationTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewApplicationTypes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewApplicationTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewApplicationTypes.ColumnHeadersHeight = 40;
            this.DataGridViewApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewApplicationTypes.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewApplicationTypes.Location = new System.Drawing.Point(20, 184);
            this.DataGridViewApplicationTypes.MultiSelect = false;
            this.DataGridViewApplicationTypes.Name = "DataGridViewApplicationTypes";
            this.DataGridViewApplicationTypes.ReadOnly = true;
            this.DataGridViewApplicationTypes.RowHeadersVisible = false;
            this.DataGridViewApplicationTypes.RowHeadersWidth = 54;
            this.DataGridViewApplicationTypes.RowTemplate.Height = 42;
            this.DataGridViewApplicationTypes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewApplicationTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewApplicationTypes.Size = new System.Drawing.Size(743, 336);
            this.DataGridViewApplicationTypes.TabIndex = 5;
            this.DataGridViewApplicationTypes.SelectionChanged += new System.EventHandler(this.DataGridViewApplicationTypes_SelectionChanged);
            // 
            // ManageApplicationTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 578);
            this.Controls.Add(this.LabelCount);
            this.Controls.Add(this.ButoonClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataGridViewApplicationTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(275, 95);
            this.Name = "ManageApplicationTypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manage Application Types";
            this.Load += new System.EventHandler(this.ManageApplicationTypesForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewApplicationTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButoonClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditApplicationTypeToolStripMenuItem;
        private System.Windows.Forms.Label LabelCount;
        private System.Windows.Forms.DataGridView DataGridViewApplicationTypes;
    }
}