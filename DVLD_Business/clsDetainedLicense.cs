using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsDetainedLicense
    {

        public int DetainID { get; private set; }

        public int LicenseID { get; set; }

        public DateTime DetainDate { get; set; }

        public decimal FineFees { get; set; }

        public int CreatedByUserID { get; set; }


        public clsUser CreatedByUserInfo;

        public bool IsReleased { get; set; }

        public DateTime ReleasedDate { get; set; }

        public int ReleasedByUserID { get; set; }

        public int ReleasedApplicationID { get; set; }

        public clsDetainedLicense()
        {


        }

        public clsDetainedLicense(int licenseID, int detainID, DateTime detainDate, decimal fineFees, int createdByUserID)
        {

            this.LicenseID = licenseID;
            this.DetainID = detainID;
            this.DetainDate = detainDate;
            this.FineFees = fineFees;
            this.CreatedByUserID = createdByUserID;
            CreatedByUserInfo = clsUser.GetUserInfoByUserID(createdByUserID);

        }

        public bool AddNewDetainedLicense()
        {

            return (this.DetainID = clsDetainedLicenseData.AddNewDetainedLicense(this.LicenseID, 
                this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased)) != -1;

        }

        static public bool CheckDrivingLicenseIsDetained(int licenseID)
        {

            return clsDetainedLicenseData.CheckDrivingLicenseIsDetained(licenseID);

        }

        static public DataTable GetAllDetainedLicenses()
        {

            return clsDetainedLicenseData.GetAllDetainedLicenses();

        }

        static public clsDetainedLicense GetDetainedLicenseByLicenseID(int licenseID)
        {

            int detainID = -1; DateTime detainDate = DateTime.Now; decimal fineFees = 0; int createdByUserID = -1;

            if (clsDetainedLicenseData.GetDetainedLicenseByLicenseID(licenseID, ref detainID, ref detainDate, ref fineFees, ref createdByUserID))
            {

                return new clsDetainedLicense(licenseID, detainID, detainDate, fineFees, createdByUserID);

            }
            
            return null;

        }

        public bool ReleaseDetainedLicense()
        {

            return clsDetainedLicenseData.ReleaseDetainedLicense(this.DetainID, this.IsReleased, this.ReleasedDate,
                this.ReleasedByUserID, this.ReleasedApplicationID);

        }

    }
}
