using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsApplicationType
    {

        public enum enApplicationType
        {
            NewLocalDrivingLicenseService = 1, RenewDrivingLicenseService = 2,
            ReplacementForLostDrivingLicense = 3, ReplacementForADamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicense = 5, NewInternationalLicense = 6,
            RetakeTest = 8
        }
        public int ApplicationTypeID {  get; private set; }

        public string Title { get; set; }

        private decimal? _Fees;

        public decimal? Fees { 
        
        get {  return _Fees; }

            set
            {

                if (value >= 0)
                {

                    _Fees = value;

                }
                else
                {

                    _Fees = null;

                }

            }
        
        }

        public clsApplicationType(int applicationTypeID, string title, decimal ?fees)
        {

            this.ApplicationTypeID = applicationTypeID;
            this.Title = title;
            this.Fees = fees;

        }

        static public DataTable GetAllApplicationTypes()
        {

            return clsApplicationTypeData.GetAllApplicationTypes();

        }

        static public clsApplicationType GetApplicationTypeByID(int applicationTypeID)
        {

            string title = "";  decimal ?fees = null;

            if (clsApplicationTypeData.GetApplicationTypeByID(applicationTypeID, ref title, ref fees))
            {

                return new clsApplicationType(applicationTypeID, title, fees);

            }
            return null;

        }

        public bool UpdateApplicationType()
        {

            return clsApplicationTypeData.UpdateApplicationType(this.ApplicationTypeID, this.Title, this.Fees);

        }


    }
}
