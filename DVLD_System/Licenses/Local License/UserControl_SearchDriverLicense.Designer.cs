namespace DVLD_System.Licenses.Local_License
{
    partial class UserControl_SearchDriverLicense
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
            this.GroupBoxFilter = new System.Windows.Forms.GroupBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userControl_DriverLicenseInfo1 = new DVLD_System.UserControl_DriverLicenseInfo();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxFilter
            // 
            this.GroupBoxFilter.Controls.Add(this.ButtonSearch);
            this.GroupBoxFilter.Controls.Add(this.TextBoxSearch);
            this.GroupBoxFilter.Controls.Add(this.label2);
            this.GroupBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxFilter.Location = new System.Drawing.Point(2, 2);
            this.GroupBoxFilter.Name = "GroupBoxFilter";
            this.GroupBoxFilter.Size = new System.Drawing.Size(366, 58);
            this.GroupBoxFilter.TabIndex = 53;
            this.GroupBoxFilter.TabStop = false;
            this.GroupBoxFilter.Text = "Search";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.Image = global::DVLD_System.Properties.Resources.search__2_;
            this.ButtonSearch.Location = new System.Drawing.Point(300, 15);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(35, 35);
            this.ButtonSearch.TabIndex = 14;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.Location = new System.Drawing.Point(90, 21);
            this.TextBoxSearch.MaxLength = 300;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(194, 22);
            this.TextBoxSearch.TabIndex = 13;
            this.TextBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearch_KeyPress);
            this.TextBoxSearch.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxSearch_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Licanse ID:";
            // 
            // userControl_DriverLicenseInfo1
            // 
            this.userControl_DriverLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.userControl_DriverLicenseInfo1.Location = new System.Drawing.Point(0, 66);
            this.userControl_DriverLicenseInfo1.Name = "userControl_DriverLicenseInfo1";
            this.userControl_DriverLicenseInfo1.Size = new System.Drawing.Size(722, 314);
            this.userControl_DriverLicenseInfo1.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UserControl_SearchDriverLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GroupBoxFilter);
            this.Controls.Add(this.userControl_DriverLicenseInfo1);
            this.Name = "UserControl_SearchDriverLicense";
            this.Size = new System.Drawing.Size(721, 382);
            this.GroupBoxFilter.ResumeLayout(false);
            this.GroupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_DriverLicenseInfo userControl_DriverLicenseInfo1;
        private System.Windows.Forms.GroupBox GroupBoxFilter;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
