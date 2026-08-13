namespace DVLD_System
{
    partial class UserControl_Search_Person
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
            this.ButtonAddNewPerson = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ComboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userControl_Person_Details1 = new DVLD_System.UserControl_Person_Details();
            this.ErrorProviderBlank = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderBlank)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxFilter
            // 
            this.GroupBoxFilter.Controls.Add(this.ButtonAddNewPerson);
            this.GroupBoxFilter.Controls.Add(this.ButtonSearch);
            this.GroupBoxFilter.Controls.Add(this.TextBoxSearch);
            this.GroupBoxFilter.Controls.Add(this.ComboBoxSearch);
            this.GroupBoxFilter.Controls.Add(this.label2);
            this.GroupBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxFilter.Location = new System.Drawing.Point(4, 3);
            this.GroupBoxFilter.Name = "GroupBoxFilter";
            this.GroupBoxFilter.Size = new System.Drawing.Size(661, 58);
            this.GroupBoxFilter.TabIndex = 44;
            this.GroupBoxFilter.TabStop = false;
            this.GroupBoxFilter.Text = "Search";
            // 
            // ButtonAddNewPerson
            // 
            this.ButtonAddNewPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddNewPerson.Image = global::DVLD_System.Properties.Resources.add_user__2_;
            this.ButtonAddNewPerson.Location = new System.Drawing.Point(550, 15);
            this.ButtonAddNewPerson.Name = "ButtonAddNewPerson";
            this.ButtonAddNewPerson.Size = new System.Drawing.Size(35, 35);
            this.ButtonAddNewPerson.TabIndex = 15;
            this.ButtonAddNewPerson.UseVisualStyleBackColor = true;
            this.ButtonAddNewPerson.Click += new System.EventHandler(this.ButtonAddNewPerson_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.Image = global::DVLD_System.Properties.Resources.search__2_;
            this.ButtonSearch.Location = new System.Drawing.Point(502, 15);
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
            this.TextBoxSearch.Location = new System.Drawing.Point(287, 22);
            this.TextBoxSearch.MaxLength = 300;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(194, 22);
            this.TextBoxSearch.TabIndex = 13;
            this.TextBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearch_KeyPress);
            this.TextBoxSearch.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxSearch_Validating);
            // 
            // ComboBoxSearch
            // 
            this.ComboBoxSearch.BackColor = System.Drawing.Color.White;
            this.ComboBoxSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ComboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSearch.FormattingEnabled = true;
            this.ComboBoxSearch.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.ComboBoxSearch.Location = new System.Drawing.Point(82, 21);
            this.ComboBoxSearch.Name = "ComboBoxSearch";
            this.ComboBoxSearch.Size = new System.Drawing.Size(194, 24);
            this.ComboBoxSearch.TabIndex = 12;
            this.ComboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSearch_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search By:";
            // 
            // userControl_Person_Details1
            // 
            this.userControl_Person_Details1.BackColor = System.Drawing.Color.White;
            this.userControl_Person_Details1.Location = new System.Drawing.Point(4, 79);
            this.userControl_Person_Details1.Margin = new System.Windows.Forms.Padding(4);
            this.userControl_Person_Details1.Name = "userControl_Person_Details1";
            this.userControl_Person_Details1.Size = new System.Drawing.Size(664, 245);
            this.userControl_Person_Details1.TabIndex = 45;
            // 
            // ErrorProviderBlank
            // 
            this.ErrorProviderBlank.ContainerControl = this;
            // 
            // UserControl_Search_Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.userControl_Person_Details1);
            this.Controls.Add(this.GroupBoxFilter);
            this.Name = "UserControl_Search_Person";
            this.Size = new System.Drawing.Size(668, 324);
            this.Load += new System.EventHandler(this.UserControl_Search_Person_Load);
            this.GroupBoxFilter.ResumeLayout(false);
            this.GroupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderBlank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxFilter;
        private System.Windows.Forms.Button ButtonAddNewPerson;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.ComboBox ComboBoxSearch;
        private System.Windows.Forms.Label label2;
        private UserControl_Person_Details userControl_Person_Details1;
        private System.Windows.Forms.ErrorProvider ErrorProviderBlank;
    }
}
