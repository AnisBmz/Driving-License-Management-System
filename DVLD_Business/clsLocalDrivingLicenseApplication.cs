using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD_Business.clsApplication;
using static DVLD_Business.clsPerson;

namespace DVLD_Business
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {

        new public enum enMode { AddNew = 1, Update = 2 }

        new public enMode Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID {  get; private set; }

        public int LicenseClassID { get; set; }

        public clsLicenseClass LicenseClassInfo { get; private set; }

        public clsLocalDrivingLicenseApplication()
        {

            Mode = enMode.AddNew;

        }

        public clsLocalDrivingLicenseApplication(int localDrivingLicenseApplicationID, int applicationID,
            int applicationPersonID, DateTime applicationDate, int applicationTypeID,
            byte applicationStatus, DateTime lastStatusDate, decimal paidFees,
            int createdByUserID, int licenseClassID)
        {

            this.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.ApplicationID = applicationID;
            this.ApplicationPersonID = applicationPersonID;
            this.PersonInfo = clsPerson.GetPersonInfoByID(applicationPersonID);
            this.ApplicationDate = applicationDate;
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationTypeInfo = clsApplicationType.GetApplicationTypeByID(applicationTypeID);
            this.ApplicationStatus = (enApplicationStatus)applicationStatus;
            this.LastStatusDate = lastStatusDate;
            this.PaidFees = paidFees;
            this.CreatedByUserID = createdByUserID;
            this.LicenseClassID = licenseClassID;
            this.LicenseClassInfo = clsLicenseClass.GetLicenseClassInfoByID(licenseClassID);

            Mode = enMode.Update;


        }

        static public DataTable GetAllLocalDrivingLicenseApplications()
        {

            return clsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplications();

        }

        static public clsLocalDrivingLicenseApplication GetLocalDrivingLicenseApplicationByID(int localDrivingLicenseApplicationID)
        {

            int applicationID = -1; int licenseClassID = -1;

            bool isFound = clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationByID(localDrivingLicenseApplicationID, ref applicationID, ref licenseClassID);

            if (isFound)
            {
                clsApplication application = clsApplication.GetApplicationInfoByID(applicationID);
                return new clsLocalDrivingLicenseApplication(localDrivingLicenseApplicationID, applicationID, application.ApplicationPersonID, application.ApplicationDate, application.ApplicationTypeID,
                (byte)application.ApplicationStatus, application.LastStatusDate, application.PaidFees, application.CreatedByUserID, licenseClassID);

            }
            else { return null; }


        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {

            return (this.LocalDrivingLicenseApplicationID = 
                clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication
                (this.ApplicationID, this.LicenseClassID)) != -1;

        }

        private bool _UpdateLocalDrivingLicenseApplication()
        {

            return clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID, this.LicenseClassID);

        }

        override public bool Save()
        {

            base.Mode = (clsApplication.enMode) Mode;

            if (!base.Save())
            {
                return false;
            }

            switch (Mode)
            {
                case enMode.AddNew:

                    Mode = enMode.Update;
                    return _AddNewLocalDrivingLicenseApplication();

                case enMode.Update:
                    return _UpdateLocalDrivingLicenseApplication();

            }

            return false;

        }

        override public bool Delete()
        {

            if (!clsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID))
            {
                return false;
            }
            return base.Delete();

        }

        static public bool IsAgeOfPersonNotAllowed(int personID, int licenseClassID)
        {

            return clsPerson.GetPersonInfoByID(personID).Age < clsLicenseClass.GetLicenseClassInfoByID(licenseClassID).MinimumAllowedAge;

        }

        public byte GetPassedTestCount()
        {

            return clsTest.GetPassedTestCount(this.LocalDrivingLicenseApplicationID);

        }

        public bool DoesPassTestType(int testType)
        {

            return clsTest.CheckTestResult(this.LocalDrivingLicenseApplicationID, testType, true);

        }

        public int GetLicenseID()
        {

            return clsLicense.GetLicenseIDByPersonAndClass(this.ApplicationPersonID, this.LicenseClassID);

        }

        public bool IsLicenseIssued()
        {

            return GetLicenseID() != -1;

        }
    }
}
