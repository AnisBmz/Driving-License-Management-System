using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD_Business.clsApplicationType;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Business
{
    public class clsLicense
    {

        public enum enIssueLicenseReason { FirstTime = 1, ReplacementForLost = 2, ReplacementForDamaged = 3, RenewalLicense = 4 };

        public int LicenseID { get; private set; }

        public int ApplicationID { get; set; }

        public bool IsDetained
        {
            get { return clsDetainedLicense.CheckDrivingLicenseIsDetained(LicenseID); }
        }

        public clsApplication applicationInfo { get; private set; }

        public int DriverID { get; set; }

        public int LicenseClassID { get; set; }

        public clsLicenseClass licenseClassInfo { get; private set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string Notes { get; set; }

        public decimal PaidFees { get; set; }

        public bool IsActive { get; set; }

        public byte IssueReasonID { get; set; }

        public string IssueReason { get {

                switch ((enIssueLicenseReason)IssueReasonID)
                {

                    case enIssueLicenseReason.FirstTime:
                        return "First Time";
                    case enIssueLicenseReason.ReplacementForLost:
                        return "Replacement for Lost";
                    case enIssueLicenseReason.ReplacementForDamaged:
                        return "Replacement for Damage";
                    case enIssueLicenseReason.RenewalLicense:
                        return "Renew";
                    default:
                        return "First Time";

                }

            } }

        public int CreatedByUserID { get; set; }

        public clsDetainedLicense DetainedLicenseInfo { get; private set; }

        public clsLicense(int applicationID, int licenseID,  int driverID,  int licenseClassID,  DateTime issueDate,
            DateTime expirationDate,  string notes,  decimal paidFees,  bool isActive,  byte issueReason,  int createdByUserID)
        {

            LicenseID = licenseID;
            DetainedLicenseInfo = clsDetainedLicense.GetDetainedLicenseByLicenseID(licenseID);
            ApplicationID = applicationID;
            applicationInfo = clsApplication.GetApplicationInfoByID(applicationID);
            DriverID = driverID;
            LicenseClassID = licenseClassID;
            licenseClassInfo = clsLicenseClass.GetLicenseClassInfoByID(licenseClassID);
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReasonID = issueReason;
            CreatedByUserID = createdByUserID;

        }
        public clsLicense()
        {



        }

        public bool AddNewLicense()
        {

            return (this.LicenseID = clsLicenseData.AddNewLicense(this.ApplicationID, this.DriverID,
                this.LicenseClassID, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
                this.IsActive ,this.IssueReasonID, this.CreatedByUserID)) != -1;

        }

        static public bool IsPersonHaveLicense(int personID, int licenseClassID)
        {

            return clsLicenseData.GetLicenseIDByPersonAndClass(personID, licenseClassID) != -1;

        }

        static public int GetLicenseIDByPersonAndClass(int personID, int licenseClassID)
        {

            return clsLicenseData.GetLicenseIDByPersonAndClass(personID, licenseClassID);

        }

        static public clsLicense GetLicenseInfoByApplicationID(int applicationID)
        {

            int licenseID = -1;
            int driverID = -1;
            int licenseClassID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            string noter = "";
            decimal paidFees = 0;
            bool isActive = true;
            byte issueReason = 0;
            int createdByUserID = -1;

            if (clsLicenseData.GetLicenseInfoByApplicationID(applicationID, ref licenseID, ref driverID, ref licenseClassID, ref issueDate,
           ref expirationDate, ref noter, ref paidFees, ref isActive, ref issueReason, ref createdByUserID))
            {

                return new clsLicense(applicationID, licenseID, driverID, licenseClassID, issueDate,
            expirationDate, noter, paidFees, isActive, issueReason, createdByUserID);

            }
            return null;

        }

        static public clsLicense GetLicenseInfoByID(int licenseID)
        {

            int applicationID = -1;
            int driverID = -1;
            int licenseClassID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            string noter = "";
            decimal paidFees = 0;
            bool isActive = true;
            byte issueReason = 0;
            int createdByUserID = -1;

            if (clsLicenseData.GetLicenseInfoByID(licenseID, ref applicationID, ref driverID, ref licenseClassID, ref issueDate,
           ref expirationDate, ref noter, ref paidFees, ref isActive, ref issueReason, ref createdByUserID))
            {

                return new clsLicense(applicationID, licenseID, driverID, licenseClassID, issueDate,
            expirationDate, noter, paidFees, isActive, issueReason, createdByUserID);

            }
            return null;

        }

        public void DeactivateLicense()
        {

            if(clsLicenseData.DeactivateLicense(this.LicenseID))
                this.IsActive = false;


        }

        public bool IsExpiredLicense()
        {

            return DateTime.Now > this.ExpirationDate;

        }

        static public bool IsActiveLicense(bool isActiveLicense)
        {

            bool isActive = false;

            if (isActiveLicense)
            {

                isActive = true;
            }

            return isActive;
        }

        public clsLicense RenewLicense(clsApplicationType applicationType, string notes, int CreatedByUserID)
        {

            if (!this.IsActive || this.IsDetained || !this.IsExpiredLicense())
            {
                return null;
            }

            clsApplication application = new clsApplication();

            application.ApplicationDate = DateTime.Now;
            application.ApplicationPersonID = this.applicationInfo.ApplicationPersonID;
            application.ApplicationTypeID = applicationType.ApplicationTypeID;
            application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = applicationType.Fees.Value;
            application.CreatedByUserID = CreatedByUserID;

            if (!application.Save())
            {
                return null;
            }

            clsLicense newLicense = new clsLicense();
            newLicense.ApplicationID = application.ApplicationID;
            newLicense.DriverID = this.DriverID;
            newLicense.LicenseClassID = this.licenseClassInfo.LicenseClassID;
            newLicense.IssueDate = DateTime.Now;
            newLicense.ExpirationDate = DateTime.Now.AddYears(this.licenseClassInfo.DefaultValidityLength);
            newLicense.Notes = notes;
            newLicense.IssueReasonID = (byte)clsLicense.enIssueLicenseReason.RenewalLicense;
            newLicense.IsActive = true;
            newLicense.PaidFees = this.licenseClassInfo.ClassFees;
            newLicense.CreatedByUserID = CreatedByUserID;

            if (!newLicense.AddNewLicense())
            {
               
                application?.Delete();
                return null;
            }

            DeactivateLicense();

            return newLicense;


        }

        public clsLicense ReplaceLicense(clsApplicationType applicationType, enIssueLicenseReason issueReason, int CreatedByUserID)
        {


            if (!this.IsActive || this.IsDetained)
            {
                return null;
            }

            clsApplication application = new clsApplication();

            application.ApplicationDate = DateTime.Now;
            application.ApplicationPersonID = this.applicationInfo.ApplicationPersonID;
            application.ApplicationTypeID = applicationType.ApplicationTypeID;
            application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = applicationType.Fees.Value;
            application.CreatedByUserID = CreatedByUserID;

            if (!application.Save())
            {
                return null;
            }

            clsLicense newLicense = new clsLicense();
            newLicense.ApplicationID = application.ApplicationID;
            newLicense.DriverID = this.DriverID;
            newLicense.LicenseClassID = this.licenseClassInfo.LicenseClassID;
            newLicense.IssueDate = DateTime.Now;
            newLicense.ExpirationDate = this.ExpirationDate;
            newLicense.Notes = this.Notes;
            newLicense.IssueReasonID = (byte)issueReason;
            newLicense.IsActive = true;
            newLicense.PaidFees = 0;
            newLicense.CreatedByUserID = CreatedByUserID;

            if (!newLicense.AddNewLicense())
            {

                application?.Delete();
                return null;
            }

            DeactivateLicense();

            return newLicense;


        }

        public int ?DetainLicense(decimal fineFees, int createdByUserID)
        {

            clsDetainedLicense detainedLicense = new clsDetainedLicense();
            detainedLicense.LicenseID = this.LicenseID;
            detainedLicense.DetainDate = DateTime.Now;
            detainedLicense.FineFees = fineFees;
            detainedLicense.CreatedByUserID = createdByUserID;
            detainedLicense.IsReleased = false;

            if (!detainedLicense.AddNewDetainedLicense())
            {
                return null;
            }

            return detainedLicense.DetainID;

        }
    }
}
