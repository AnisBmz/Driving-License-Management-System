namespace DVLD_System
{
    partial class AddEditUserForm
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TabControlAddNewUser = new System.Windows.Forms.TabControl();
            this.TabPagePersenalInfo = new System.Windows.Forms.TabPage();
            this.userControl_Search_Person1 = new DVLD_System.UserControl_Search_Person();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.TabPageLoginInfo = new System.Windows.Forms.TabPage();
            this.CheckBoxIsActive = new System.Windows.Forms.CheckBox();
            this.TextBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LabelUserID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ErrorProviderConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBlank = new System.Windows.Forms.ErrorProvider(this.components);
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.TabControlAddNewUser.SuspendLayout();
            this.TabPagePersenalInfo.SuspendLayout();
            this.TabPageLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBlank)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LabelTitle.Location = new System.Drawing.Point(303, 28);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(154, 30);
            this.LabelTitle.TabIndex = 3;
            this.LabelTitle.Text = "Add New User";
            // 
            // TabControlAddNewUser
            // 
            this.TabControlAddNewUser.Controls.Add(this.TabPagePersenalInfo);
            this.TabControlAddNewUser.Controls.Add(this.TabPageLoginInfo);
            this.TabControlAddNewUser.Location = new System.Drawing.Point(12, 69);
            this.TabControlAddNewUser.Name = "TabControlAddNewUser";
            this.TabControlAddNewUser.SelectedIndex = 0;
            this.TabControlAddNewUser.Size = new System.Drawing.Size(737, 443);
            this.TabControlAddNewUser.TabIndex = 44;
            // 
            // TabPagePersenalInfo
            // 
            this.TabPagePersenalInfo.BackColor = System.Drawing.Color.White;
            this.TabPagePersenalInfo.Controls.Add(this.userControl_Search_Person1);
            this.TabPagePersenalInfo.Controls.Add(this.ButtonNext);
            this.TabPagePersenalInfo.Location = new System.Drawing.Point(4, 22);
            this.TabPagePersenalInfo.Name = "TabPagePersenalInfo";
            this.TabPagePersenalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagePersenalInfo.Size = new System.Drawing.Size(729, 417);
            this.TabPagePersenalInfo.TabIndex = 0;
            this.TabPagePersenalInfo.Text = "Persenal Info";
            // 
            // userControl_Search_Person1
            // 
            this.userControl_Search_Person1.BackColor = System.Drawing.Color.White;
            this.userControl_Search_Person1.Location = new System.Drawing.Point(30, 26);
            this.userControl_Search_Person1.Name = "userControl_Search_Person1";
            this.userControl_Search_Person1.Size = new System.Drawing.Size(668, 324);
            this.userControl_Search_Person1.TabIndex = 44;
            // 
            // ButtonNext
            // 
            this.ButtonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.Image = global::DVLD_System.Properties.Resources.Next_32;
            this.ButtonNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonNext.Location = new System.Drawing.Point(587, 369);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(103, 33);
            this.ButtonNext.TabIndex = 43;
            this.ButtonNext.Text = "      Next";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // TabPageLoginInfo
            // 
            this.TabPageLoginInfo.BackColor = System.Drawing.Color.White;
            this.TabPageLoginInfo.Controls.Add(this.CheckBoxIsActive);
            this.TabPageLoginInfo.Controls.Add(this.TextBoxConfirmPassword);
            this.TabPageLoginInfo.Controls.Add(this.TextBoxPassword);
            this.TabPageLoginInfo.Controls.Add(this.TextBoxUserName);
            this.TabPageLoginInfo.Controls.Add(this.label8);
            this.TabPageLoginInfo.Controls.Add(this.LabelUserID);
            this.TabPageLoginInfo.Controls.Add(this.label3);
            this.TabPageLoginInfo.Controls.Add(this.label4);
            this.TabPageLoginInfo.Controls.Add(this.label5);
            this.TabPageLoginInfo.Controls.Add(this.pictureBox4);
            this.TabPageLoginInfo.Controls.Add(this.pictureBox3);
            this.TabPageLoginInfo.Controls.Add(this.pictureBox2);
            this.TabPageLoginInfo.Controls.Add(this.pictureBox1);
            this.TabPageLoginInfo.Location = new System.Drawing.Point(4, 22);
            this.TabPageLoginInfo.Name = "TabPageLoginInfo";
            this.TabPageLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageLoginInfo.Size = new System.Drawing.Size(729, 417);
            this.TabPageLoginInfo.TabIndex = 1;
            this.TabPageLoginInfo.Text = "Login Info";
            // 
            // CheckBoxIsActive
            // 
            this.CheckBoxIsActive.AutoSize = true;
            this.CheckBoxIsActive.Location = new System.Drawing.Point(292, 225);
            this.CheckBoxIsActive.Name = "CheckBoxIsActive";
            this.CheckBoxIsActive.Size = new System.Drawing.Size(67, 17);
            this.CheckBoxIsActive.TabIndex = 44;
            this.CheckBoxIsActive.Text = "Is Active";
            this.CheckBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // TextBoxConfirmPassword
            // 
            this.TextBoxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxConfirmPassword.Location = new System.Drawing.Point(292, 180);
            this.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword";
            this.TextBoxConfirmPassword.PasswordChar = '*';
            this.TextBoxConfirmPassword.Size = new System.Drawing.Size(172, 20);
            this.TextBoxConfirmPassword.TabIndex = 43;
            this.TextBoxConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxConfirmPassword_Validating);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPassword.Location = new System.Drawing.Point(292, 145);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(172, 20);
            this.TextBoxPassword.TabIndex = 42;
            this.TextBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.Blank_Validating);
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxUserName.Location = new System.Drawing.Point(292, 110);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(172, 20);
            this.TextBoxUserName.TabIndex = 41;
            this.TextBoxUserName.Validating += new System.ComponentModel.CancelEventHandler(this.Blank_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Confirm Password:";
            // 
            // LabelUserID
            // 
            this.LabelUserID.AutoSize = true;
            this.LabelUserID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserID.Location = new System.Drawing.Point(289, 78);
            this.LabelUserID.Name = "LabelUserID";
            this.LabelUserID.Size = new System.Drawing.Size(32, 17);
            this.LabelUserID.TabIndex = 36;
            this.LabelUserID.Text = "????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "UserName:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "User ID:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_System.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(247, 181);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_System.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(247, 78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_System.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(247, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_System.Properties.Resources.Person_32;
            this.pictureBox1.Location = new System.Drawing.Point(247, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // ErrorProviderConfirmPassword
            // 
            this.ErrorProviderConfirmPassword.ContainerControl = this;
            // 
            // errorProviderBlank
            // 
            this.errorProviderBlank.ContainerControl = this;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.Enabled = false;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Image = global::DVLD_System.Properties.Resources.Save_32;
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSave.Location = new System.Drawing.Point(642, 527);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(103, 33);
            this.ButtonSave.TabIndex = 42;
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
            this.ButtonClose.Location = new System.Drawing.Point(531, 527);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(103, 33);
            this.ButtonClose.TabIndex = 41;
            this.ButtonClose.Text = "      Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // AddEditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 572);
            this.Controls.Add(this.TabControlAddNewUser);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.LabelTitle);
            this.Name = "AddEditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.AddNewUserForm_Load);
            this.TabControlAddNewUser.ResumeLayout(false);
            this.TabPagePersenalInfo.ResumeLayout(false);
            this.TabPageLoginInfo.ResumeLayout(false);
            this.TabPageLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBlank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.TabControl TabControlAddNewUser;
        private System.Windows.Forms.TabPage TabPagePersenalInfo;
        private System.Windows.Forms.TabPage TabPageLoginInfo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LabelUserID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckBoxIsActive;
        private System.Windows.Forms.TextBox TextBoxConfirmPassword;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider ErrorProviderConfirmPassword;
        private System.Windows.Forms.ErrorProvider errorProviderBlank;
        private UserControl_Search_Person userControl_Search_Person1;
    }
}