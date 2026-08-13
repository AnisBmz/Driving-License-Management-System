using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsInternationalLicense
    {

        public int InternationalLicenseID { get; private set; }

        public int ApplicationID { get; set; }

        public clsApplication ApplicationInfo { get; private set; }

        public int DriverID { get; set; }

        public int LocalLicenseID { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool IsActive { get; set; }

        public int CreatedByUserID { get; set; }

        public clsInternationalLicense()
        {


        }

        public clsInternationalLicense(int internationalLicenseID, int applicationID, int driverID,
            int localLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive)
        {

            InternationalLicenseID = internationalLicenseID;
            ApplicationID = applicationID;
            ApplicationInfo = clsApplication.GetApplicationInfoByID(applicationID);
            DriverID = driverID;
            LocalLicenseID = localLicenseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;

        }

        public bool AddNewInternationalLicense()
        {

            return (this.InternationalLicenseID = clsInternationalLicenseData.AddNewInternationalLicense(this.ApplicationID,
                this.DriverID, this.LocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID)) != -1;

        }

        static public int CheckPersonHaveActiveInternationalLicense(int personID)
        {

            return clsInternationalLicenseData.CheckPersonHaveActiveInternationalLicense(personID);

        }

        static public clsInternationalLicense GetInternationalLicenseByID(int internationalLicenseID)
        {

            int applicationID = -1; int driverID = -1; int localLicenseID = -1;
            DateTime issueDate = DateTime.Now; DateTime expirationDate = DateTime.Now; bool isActive = false;


            if (clsInternationalLicenseData.GetInternationalLicenseByID(internationalLicenseID, ref localLicenseID,
            ref issueDate, ref applicationID, ref isActive, ref driverID, ref expirationDate))
            {

                return new clsInternationalLicense(internationalLicenseID, applicationID, driverID,
                   localLicenseID, issueDate, expirationDate, isActive);

            }
            return null;

        }

        static public DataTable GetAllInternationalDrivingLicenses()
        {

            return clsInternationalLicenseData.GetAllInternationalDrivingLicenses();

        }

    }
}
