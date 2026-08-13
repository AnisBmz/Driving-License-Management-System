namespace DVLD_System
{
    partial class UserControl_User_Details
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
            this.userControl_Person_Details = new DVLD_System.UserControl_Person_Details();
            this.GroupBoxLoginInformation = new System.Windows.Forms.GroupBox();
            this.LabelIsActive = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.LabelUserID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBoxLoginInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // userControl_Person_Details
            // 
            this.userControl_Person_Details.BackColor = System.Drawing.Color.White;
            this.userControl_Person_Details.Location = new System.Drawing.Point(13, 3);
            this.userControl_Person_Details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userControl_Person_Details.Name = "userControl_Person_Details";
            this.userControl_Person_Details.Size = new System.Drawing.Size(661, 241);
            this.userControl_Person_Details.TabIndex = 0;
            // 
            // GroupBoxLoginInformation
            // 
            this.GroupBoxLoginInformation.Controls.Add(this.LabelIsActive);
            this.GroupBoxLoginInformation.Controls.Add(this.LabelUserName);
            this.GroupBoxLoginInformation.Controls.Add(this.LabelUserID);
            this.GroupBoxLoginInformation.Controls.Add(this.label3);
            this.GroupBoxLoginInformation.Controls.Add(this.label2);
            this.GroupBoxLoginInformation.Controls.Add(this.label1);
            this.GroupBoxLoginInformation.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.GroupBoxLoginInformation.Location = new System.Drawing.Point(13, 250);
            this.GroupBoxLoginInformation.Name = "GroupBoxLoginInformation";
            this.GroupBoxLoginInformation.Size = new System.Drawing.Size(661, 73);
            this.GroupBoxLoginInformation.TabIndex = 44;
            this.GroupBoxLoginInformation.TabStop = false;
            this.GroupBoxLoginInformation.Text = "Login Information";
            // 
            // LabelIsActive
            // 
            this.LabelIsActive.AutoSize = true;
            this.LabelIsActive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelIsActive.Location = new System.Drawing.Point(510, 34);
            this.LabelIsActive.Name = "LabelIsActive";
            this.LabelIsActive.Size = new System.Drawing.Size(35, 15);
            this.LabelIsActive.TabIndex = 30;
            this.LabelIsActive.Text = "[????]";
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelUserName.Location = new System.Drawing.Point(327, 34);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(35, 15);
            this.LabelUserName.TabIndex = 29;
            this.LabelUserName.Text = "[????]";
            // 
            // LabelUserID
            // 
            this.LabelUserID.AutoSize = true;
            this.LabelUserID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelUserID.Location = new System.Drawing.Point(135, 34);
            this.LabelUserID.Name = "LabelUserID";
            this.LabelUserID.Size = new System.Drawing.Size(35, 15);
            this.LabelUserID.TabIndex = 28;
            this.LabelUserID.Text = "[????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Is Active:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID:";
            // 
            // UserControl_User_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GroupBoxLoginInformation);
            this.Controls.Add(this.userControl_Person_Details);
            this.Name = "UserControl_User_Details";
            this.Size = new System.Drawing.Size(687, 327);
            this.GroupBoxLoginInformation.ResumeLayout(false);
            this.GroupBoxLoginInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_Person_Details userControl_Person_Details;
        private System.Windows.Forms.GroupBox GroupBoxLoginInformation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelIsActive;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.Label LabelUserID;
        private System.Windows.Forms.Label label1;
    }
}
