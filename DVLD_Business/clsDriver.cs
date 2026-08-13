using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsDriver
    {

        public int DriverID { get; private set; }

        public int PersonID { get; set; }

        public clsPerson personInfo;

        public int CreatedByUserID { get; set; }

        public DateTime CreatedDate { get; set; }

        public clsDriver()
        {



        }

        public clsDriver(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {

            DriverID = driverID;
            PersonID = personID;
            personInfo = clsPerson.GetPersonInfoByID(personID);
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;

        }

        public bool AddNewDriver()
        {

            return (this.DriverID = clsDriverData.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate)) != -1;

        }

        static public int CheckDriverIsExists(int personID)
        {

            return clsDriverData.CheckDriverIsExists(personID);

        }

        static public DataTable GetAllDrivers()
        {

            return clsDriverData.GetAllDrivers();

        }

        public static clsDriver GetDriverInfoByID(int driverID)
        {

            int personID = -1;
            int createdByUserID = -1;
            DateTime createdDate = DateTime.Now;

            if (clsDriverData.GetDriverInfoByID(driverID, ref personID, ref createdByUserID, ref createdDate))
            {

                return new clsDriver(driverID, personID, createdByUserID, createdDate);

            }

            return null;


        }

        static public DataTable GetAllLocalDrivingLicensesForPerson(int personID)
        {

            return clsLicenseData.GetAllLocalDrivingLicensesForPerson(personID);

        }

        static public DataTable GetAllInternationalDrivingLicensesForPerson(int personID)
        {

            return clsInternationalLicenseData.GetAllInternationalDrivingLicensesForPerson(personID);

        }
    }
}
