using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static DVLD_Business.clsApplication;

namespace DVLD_Business
{
    public class clsApplication
    {

        public enum enMode { AddNew = 1, Update = 2 }

        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 }

        public enMode Mode = enMode.AddNew;

        public int ApplicationID { get; set; }

        public DateTime ApplicationDate { get; set; }

        public int ApplicationPersonID { get; set; }

        public clsPerson PersonInfo { get; set; }

        public int ApplicationTypeID { get; set; }

        public clsApplicationType ApplicationTypeInfo { get; set; }

        public enApplicationStatus ApplicationStatus { get; set; }

        public string ApplicationStatusName {

            get
            {

                switch (ApplicationStatus)
                {

                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";


                }
           
            }
        
        }

        public DateTime LastStatusDate { get; set; }

        public decimal PaidFees { get; set; }

        public int CreatedByUserID { get; set; }

        public clsApplication()
        {

            ApplicationStatus = enApplicationStatus.New;
            Mode = enMode.AddNew;


        }

        public clsApplication(int applicationID, int applicationPersonID, DateTime applicationDate, int applicationTypeID,
            byte applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {

            this.ApplicationID = applicationID;
            this.ApplicationPersonID = applicationPersonID;
            PersonInfo = clsPerson.GetPersonInfoByID(applicationPersonID);
            this.ApplicationDate = applicationDate;
            this.ApplicationTypeID = applicationTypeID;
            ApplicationTypeInfo = clsApplicationType.GetApplicationTypeByID(applicationTypeID);
            this.ApplicationStatus = (enApplicationStatus)applicationStatus;
            this.LastStatusDate = lastStatusDate;
            this.PaidFees = paidFees;
            this.CreatedByUserID = createdByUserID;
            Mode = enMode.Update;

        }

        private bool _AddNewApplication()
        {


            return (this.ApplicationID = clsApplicationData.AddNewApplication(this.ApplicationPersonID, this.ApplicationDate,
                this.ApplicationTypeID, Convert.ToByte(this.ApplicationStatus), this.LastStatusDate, this.PaidFees, this.CreatedByUserID)) != -1;


        }

        private bool _UpdateApplication()
        {

            if (ApplicationStatus != enApplicationStatus.New)
            {
                return false;
            }
            return clsApplicationData.UpdateApplication(this.ApplicationID, this.ApplicationDate, this.LastStatusDate, this.PaidFees,
                 this.CreatedByUserID);

        }

        virtual public bool Delete()
        {

            return clsApplicationData.DeleteApplication(this.ApplicationID);

        }

        static public int GetActiveApplicationIDByPersonAndClass(int applicantPersonID, int licenseClassID)
        {

            return clsApplicationData.GetActiveApplicationIDByPersonAndClass(applicantPersonID, licenseClassID, Convert.ToByte(enApplicationStatus.Cancelled));

        }

        public bool EditStatusToCancelled()
        {

            return clsApplicationData.EditApplicationStatus(this.ApplicationID, Convert.ToByte(enApplicationStatus.Cancelled));

        }

        static public bool EditStatusToCompleted(int applicationID)
        {

            return clsApplicationData.EditApplicationStatus(applicationID, Convert.ToByte(enApplicationStatus.Completed));

        }

        static public clsApplication GetApplicationInfoByID(int applicationID)
        {

            int applicationPersonID = -1; DateTime applicationDate = DateTime.Now;  int applicationTypeID = -1;
            byte applicationStatus = 0; DateTime lastStatusDate = DateTime.Now; decimal paidFees = 0; int createdByUserID = -1;

            if (clsApplicationData.GetApplicationInfoByID(applicationID, ref applicationPersonID, ref applicationDate, ref applicationTypeID,
                ref applicationStatus, ref lastStatusDate, ref paidFees, ref createdByUserID))
            {

                return new clsApplication(applicationID, applicationPersonID, applicationDate, applicationTypeID,
                 applicationStatus, lastStatusDate, paidFees, createdByUserID);

            }
            else
            {

                return null;
            }

        }

        virtual public bool Save()
        {

            switch (Mode)
            {

            case enMode.AddNew:

                    if (_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    if (this.ApplicationStatus != enApplicationStatus.New)
                    {
                        return false;
                    }
                    return _UpdateApplication();


            }

            return false;

        }

        static public int GetApplicationIDByLicenseID(int licenseID)
        {

            return clsApplicationData.GetApplicationIDByLicenseID(licenseID);

        }

        static public decimal CalculateTotalFees(decimal baseFees, decimal applicationFess)
        {

            return baseFees + applicationFess;

        }
    }
}
