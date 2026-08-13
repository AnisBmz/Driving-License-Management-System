namespace DVLD_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.aplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrivingLicenseServcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InternationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ReleaseDetainedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RetakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ManageApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalDrivingLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageInternationalLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DetainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReleaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.MenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // aplicationsToolStripMenuItem
            // 
            this.aplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrivingLicenseServcesToolStripMenuItem,
            this.toolStripSeparator1,
            this.ManageApplicationToolStripMenuItem,
            this.toolStripSeparator2,
            this.DetainLicensesToolStripMenuItem,
            this.ApplicationTypeToolStripMenuItem,
            this.ManageTestTypesToolStripMenuItem});
            resources.ApplyResources(this.aplicationsToolStripMenuItem, "aplicationsToolStripMenuItem");
            this.aplicationsToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.Application_32;
            this.aplicationsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.aplicationsToolStripMenuItem.Name = "aplicationsToolStripMenuItem";
            // 
            // DrivingLicenseServcesToolStripMenuItem
            // 
            this.DrivingLicenseServcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewDrivingLicenseToolStripMenuItem,
            this.RenewDrivingLicenseToolStripMenuItem,
            this.toolStripSeparator3,
            this.ReplaceToolStripMenuItem,
            this.toolStripSeparator4,
            this.ReleaseDetainedToolStripMenuItem,
            this.RetakeTestToolStripMenuItem});
            this.DrivingLicenseServcesToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.id_card;
            resources.ApplyResources(this.DrivingLicenseServcesToolStripMenuItem, "DrivingLicenseServcesToolStripMenuItem");
            this.DrivingLicenseServcesToolStripMenuItem.Name = "DrivingLicenseServcesToolStripMenuItem";
            // 
            // NewDrivingLicenseToolStripMenuItem
            // 
            this.NewDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocalLicenseToolStripMenuItem,
            this.InternationalLicenseToolStripMenuItem});
            this.NewDrivingLicenseToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.card;
            resources.ApplyResources(this.NewDrivingLicenseToolStripMenuItem, "NewDrivingLicenseToolStripMenuItem");
            this.NewDrivingLicenseToolStripMenuItem.Name = "NewDrivingLicenseToolStripMenuItem";
            // 
            // LocalLicenseToolStripMenuItem
            // 
            this.LocalLicenseToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.location_1801362;
            resources.ApplyResources(this.LocalLicenseToolStripMenuItem, "LocalLicenseToolStripMenuItem");
            this.LocalLicenseToolStripMenuItem.Name = "LocalLicenseToolStripMenuItem";
            this.LocalLicenseToolStripMenuItem.Click += new System.EventHandler(this.LocalLicenseToolStripMenuItem_Click);
            // 
            // InternationalLicenseToolStripMenuItem
            // 
            this.InternationalLicenseToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.global_3210030;
            resources.ApplyResources(this.InternationalLicenseToolStripMenuItem, "InternationalLicenseToolStripMenuItem");
            this.InternationalLicenseToolStripMenuItem.Name = "InternationalLicenseToolStripMenuItem";
            this.InternationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.InternationalLicenseToolStripMenuItem_Click);
            // 
            // RenewDrivingLicenseToolStripMenuItem
            // 
            this.RenewDrivingLicenseToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.shopping_16294162;
            resources.ApplyResources(this.RenewDrivingLicenseToolStripMenuItem, "RenewDrivingLicenseToolStripMenuItem");
            this.RenewDrivingLicenseToolStripMenuItem.Name = "RenewDrivingLicenseToolStripMenuItem";
            this.RenewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.RenewDrivingLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // ReplaceToolStripMenuItem
            // 
            this.ReplaceToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.discard_8583873;
            resources.ApplyResources(this.ReplaceToolStripMenuItem, "ReplaceToolStripMenuItem");
            this.ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem";
            this.ReplaceToolStripMenuItem.Click += new System.EventHandler(this.ReplaceToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // ReleaseDetainedToolStripMenuItem
            // 
            this.ReleaseDetainedToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.yellow_card_7441725;
            resources.ApplyResources(this.ReleaseDetainedToolStripMenuItem, "ReleaseDetainedToolStripMenuItem");
            this.ReleaseDetainedToolStripMenuItem.Name = "ReleaseDetainedToolStripMenuItem";
            this.ReleaseDetainedToolStripMenuItem.Click += new System.EventHandler(this.ReleaseDetainedToolStripMenuItem_Click);
            // 
            // RetakeTestToolStripMenuItem
            // 
            this.RetakeTestToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.contract_327883;
            resources.ApplyResources(this.RetakeTestToolStripMenuItem, "RetakeTestToolStripMenuItem");
            this.RetakeTestToolStripMenuItem.Name = "RetakeTestToolStripMenuItem";
            this.RetakeTestToolStripMenuItem.Click += new System.EventHandler(this.RetakeTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // ManageApplicationToolStripMenuItem
            // 
            this.ManageApplicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocalDrivingLToolStripMenuItem,
            this.ManageInternationalLicenseApplicationsToolStripMenuItem});
            this.ManageApplicationToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.document;
            resources.ApplyResources(this.ManageApplicationToolStripMenuItem, "ManageApplicationToolStripMenuItem");
            this.ManageApplicationToolStripMenuItem.Name = "ManageApplicationToolStripMenuItem";
            // 
            // LocalDrivingLToolStripMenuItem
            // 
            this.LocalDrivingLToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.map;
            resources.ApplyResources(this.LocalDrivingLToolStripMenuItem, "LocalDrivingLToolStripMenuItem");
            this.LocalDrivingLToolStripMenuItem.Name = "LocalDrivingLToolStripMenuItem";
            this.LocalDrivingLToolStripMenuItem.Click += new System.EventHandler(this.LocalDrivingLToolStripMenuItem_Click);
            // 
            // ManageInternationalLicenseApplicationsToolStripMenuItem
            // 
            this.ManageInternationalLicenseApplicationsToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.globe;
            resources.ApplyResources(this.ManageInternationalLicenseApplicationsToolStripMenuItem, "ManageInternationalLicenseApplicationsToolStripMenuItem");
            this.ManageInternationalLicenseApplicationsToolStripMenuItem.Name = "ManageInternationalLicenseApplicationsToolStripMenuItem";
            this.ManageInternationalLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.ManageInternationalLicenseApplicationsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // DetainLicensesToolStripMenuItem
            // 
            this.DetainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageDetainedLicensesToolStripMenuItem,
            this.DetainedLicenseToolStripMenuItem,
            this.ReleaseToolStripMenuItem});
            this.DetainLicensesToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.credit_card_6164618;
            resources.ApplyResources(this.DetainLicensesToolStripMenuItem, "DetainLicensesToolStripMenuItem");
            this.DetainLicensesToolStripMenuItem.Name = "DetainLicensesToolStripMenuItem";
            // 
            // ManageDetainedLicensesToolStripMenuItem
            // 
            this.ManageDetainedLicensesToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.disapproval_66065191;
            resources.ApplyResources(this.ManageDetainedLicensesToolStripMenuItem, "ManageDetainedLicensesToolStripMenuItem");
            this.ManageDetainedLicensesToolStripMenuItem.Name = "ManageDetainedLicensesToolStripMenuItem";
            this.ManageDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.ManageDetainedLicensesToolStripMenuItem_Click);
            // 
            // DetainedLicenseToolStripMenuItem
            // 
            this.DetainedLicenseToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.rejected_7440786;
            resources.ApplyResources(this.DetainedLicenseToolStripMenuItem, "DetainedLicenseToolStripMenuItem");
            this.DetainedLicenseToolStripMenuItem.Name = "DetainedLicenseToolStripMenuItem";
            this.DetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.DetainedLicenseToolStripMenuItem_Click);
            // 
            // ReleaseToolStripMenuItem
            // 
            this.ReleaseToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.yellow_card_7441725;
            resources.ApplyResources(this.ReleaseToolStripMenuItem, "ReleaseToolStripMenuItem");
            this.ReleaseToolStripMenuItem.Name = "ReleaseToolStripMenuItem";
            this.ReleaseToolStripMenuItem.Click += new System.EventHandler(this.ReleaseToolStripMenuItem_Click);
            // 
            // ApplicationTypeToolStripMenuItem
            // 
            this.ApplicationTypeToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.paste;
            resources.ApplyResources(this.ApplicationTypeToolStripMenuItem, "ApplicationTypeToolStripMenuItem");
            this.ApplicationTypeToolStripMenuItem.Name = "ApplicationTypeToolStripMenuItem";
            this.ApplicationTypeToolStripMenuItem.Click += new System.EventHandler(this.ApplicationTypeToolStripMenuItem_Click);
            // 
            // ManageTestTypesToolStripMenuItem
            // 
            this.ManageTestTypesToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.exam;
            resources.ApplyResources(this.ManageTestTypesToolStripMenuItem, "ManageTestTypesToolStripMenuItem");
            this.ManageTestTypesToolStripMenuItem.Name = "ManageTestTypesToolStripMenuItem";
            this.ManageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.ManageTestTypesToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            resources.ApplyResources(this.peopleToolStripMenuItem, "peopleToolStripMenuItem");
            this.peopleToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.group__1_1;
            this.peopleToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.PeopleToolStripMenuItem_Click);
            // 
            // DriversToolStripMenuItem
            // 
            resources.ApplyResources(this.DriversToolStripMenuItem, "DriversToolStripMenuItem");
            this.DriversToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.Drivers_32;
            this.DriversToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DriversToolStripMenuItem.Name = "DriversToolStripMenuItem";
            this.DriversToolStripMenuItem.Click += new System.EventHandler(this.DriversToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            resources.ApplyResources(this.usersToolStripMenuItem, "usersToolStripMenuItem");
            this.usersToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.Users_32;
            this.usersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.UsersToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentUserInfoToolStripMenuItem,
            this.ChangePasswordToolStripMenuItem,
            this.signOutToolStripMenuItem});
            resources.ApplyResources(this.accountSettingsToolStripMenuItem, "accountSettingsToolStripMenuItem");
            this.accountSettingsToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.Account_32;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            // 
            // CurrentUserInfoToolStripMenuItem
            // 
            this.CurrentUserInfoToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.user;
            resources.ApplyResources(this.CurrentUserInfoToolStripMenuItem, "CurrentUserInfoToolStripMenuItem");
            this.CurrentUserInfoToolStripMenuItem.Name = "CurrentUserInfoToolStripMenuItem";
            this.CurrentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.CurrentUserInfoToolStripMenuItem_Click);
            // 
            // ChangePasswordToolStripMenuItem
            // 
            this.ChangePasswordToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.locked;
            resources.ApplyResources(this.ChangePasswordToolStripMenuItem, "ChangePasswordToolStripMenuItem");
            this.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem";
            this.ChangePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.log_out;
            resources.ApplyResources(this.signOutToolStripMenuItem, "signOutToolStripMenuItem");
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.SignOutToolStripMenuItem_Click);
            // 
            // MenuStripMain
            // 
            resources.ApplyResources(this.MenuStripMain, "MenuStripMain");
            this.MenuStripMain.BackColor = System.Drawing.Color.White;
            this.MenuStripMain.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicationsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.DriversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem});
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.Stretch = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD_System.Properties.Resources.Blank_2000_x_20001;
            this.Controls.Add(this.MenuStripMain);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.MenuStripMain;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem aplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DrivingLicenseServcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LocalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InternationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ReleaseDetainedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RetakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ManageApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LocalDrivingLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageInternationalLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem DetainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReleaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ApplicationTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CurrentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuStripMain;
    }
}

