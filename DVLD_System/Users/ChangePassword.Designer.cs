namespace DVLD_System
{
    partial class ChangePasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxNewPassword = new System.Windows.Forms.TextBox();
            this.TextBoxCurrentPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TextBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ErrorProviderConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderCurrentPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderNewPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.userControl_User_Details = new DVLD_System.UserControl_User_Details();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderCurrentPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderNewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(279, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Change Password";
            // 
            // TextBoxNewPassword
            // 
            this.TextBoxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxNewPassword.Location = new System.Drawing.Point(262, 455);
            this.TextBoxNewPassword.Name = "TextBoxNewPassword";
            this.TextBoxNewPassword.PasswordChar = '*';
            this.TextBoxNewPassword.Size = new System.Drawing.Size(172, 20);
            this.TextBoxNewPassword.TabIndex = 49;
            this.TextBoxNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNewPassword_Validating);
            // 
            // TextBoxCurrentPassword
            // 
            this.TextBoxCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxCurrentPassword.Location = new System.Drawing.Point(262, 420);
            this.TextBoxCurrentPassword.Name = "TextBoxCurrentPassword";
            this.TextBoxCurrentPassword.PasswordChar = '*';
            this.TextBoxCurrentPassword.Size = new System.Drawing.Size(172, 20);
            this.TextBoxCurrentPassword.TabIndex = 48;
            this.TextBoxCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxCurrentPassword_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Current Password:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_System.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(217, 456);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_System.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(217, 421);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // TextBoxConfirmPassword
            // 
            this.TextBoxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxConfirmPassword.Location = new System.Drawing.Point(262, 490);
            this.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword";
            this.TextBoxConfirmPassword.PasswordChar = '*';
            this.TextBoxConfirmPassword.Size = new System.Drawing.Size(172, 20);
            this.TextBoxConfirmPassword.TabIndex = 52;
            this.TextBoxConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxConfirmPassword_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Confirm Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_System.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(217, 491);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Image = global::DVLD_System.Properties.Resources.Save_32;
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSave.Location = new System.Drawing.Point(599, 543);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(103, 33);
            this.ButtonSave.TabIndex = 54;
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
            this.ButtonClose.Location = new System.Drawing.Point(490, 543);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(103, 33);
            this.ButtonClose.TabIndex = 53;
            this.ButtonClose.Text = "      Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ErrorProviderConfirmPassword
            // 
            this.ErrorProviderConfirmPassword.ContainerControl = this;
            // 
            // ErrorProviderCurrentPassword
            // 
            this.ErrorProviderCurrentPassword.ContainerControl = this;
            // 
            // ErrorProviderNewPassword
            // 
            this.ErrorProviderNewPassword.ContainerControl = this;
            // 
            // userControl_User_Details
            // 
            this.userControl_User_Details.BackColor = System.Drawing.Color.White;
            this.userControl_User_Details.Location = new System.Drawing.Point(27, 60);
            this.userControl_User_Details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userControl_User_Details.Name = "userControl_User_Details";
            this.userControl_User_Details.Size = new System.Drawing.Size(687, 327);
            this.userControl_User_Details.TabIndex = 0;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 588);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.TextBoxConfirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBoxNewPassword);
            this.Controls.Add(this.TextBoxCurrentPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControl_User_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(300, 90);
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePasswordFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderCurrentPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderNewPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl_User_Details userControl_User_Details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxNewPassword;
        private System.Windows.Forms.TextBox TextBoxCurrentPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TextBoxConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.ErrorProvider ErrorProviderConfirmPassword;
        private System.Windows.Forms.ErrorProvider ErrorProviderCurrentPassword;
        private System.Windows.Forms.ErrorProvider ErrorProviderNewPassword;
    }
}