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
    public class clsTestAppointment
    {

        enum enMode { AddNew = 0, Update = 1 }

        enMode _Mode = enMode.AddNew;

        public int AppointmentID {  get; private set; }

        public int LocalDrivingLicenseApplicationID { get; set; }

        public clsLocalDrivingLicenseApplication LocalDrivingLicenseApplicationInfo { get; private set; }

        public int TestTypeID { get; set; }

        public DateTime AppointmentDate { get; set; }

        public decimal PaidFees { get; set; }

        public bool IsLocked { get; set; }

        public int CreatedByUserID { get; set; }

        public int RetakeTestApplicationID { get; set; }

        public clsTestAppointment(int testAppointmentID, int localDrivingLicenseApplicationID, int testTypeID, DateTime appointmentDate,
                                 decimal paidFees, bool isLocked, int retakeTest)
        {


            this.AppointmentID = testAppointmentID;
            this.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.LocalDrivingLicenseApplicationInfo = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(localDrivingLicenseApplicationID);
            this.TestTypeID = testTypeID;
            this.AppointmentDate = appointmentDate;
            this.PaidFees = paidFees;
            this.IsLocked = isLocked;
            this.RetakeTestApplicationID = retakeTest;

            _Mode = enMode.Update;


        }

        public clsTestAppointment()
        {

            _Mode = enMode.AddNew;

        }

        static public DataTable GetAllAppointmentsTestByLocalDrivingLicenseApplicationID(int localDrivingLicenseID, int testTypeID)
        {

            return clsTestAppointmentData.GetAllAppointmentsTestByLocalDrivingLicenseApplicationID(localDrivingLicenseID, testTypeID);

        }

        static public clsTestAppointment GetTestAppointmentByID(int testAppointmentID)
        {

            int localDrivingLicenseApplicationID = -1; int testTypeID = -1; DateTime appointmentDate = DateTime.Now;
            decimal paidFees = 0; bool isLocked = false; int retakeTestApplicationID = -1;

            if (clsTestAppointmentData.GetTestAppointmentByID(testAppointmentID, ref localDrivingLicenseApplicationID, ref testTypeID, ref appointmentDate,
                ref paidFees, ref isLocked, ref retakeTestApplicationID))
            {

                return new clsTestAppointment(testAppointmentID, localDrivingLicenseApplicationID, testTypeID, appointmentDate, paidFees, isLocked, retakeTestApplicationID);

            }
            return null;

        }

        private bool _AddNewTestAppointment()
        {

            return (this.AppointmentID = clsTestAppointmentData.AddNewTestAppointment(this.LocalDrivingLicenseApplicationID, this.TestTypeID,
                this.AppointmentDate, this.PaidFees, this.IsLocked, this.CreatedByUserID, this.RetakeTestApplicationID)) != -1;

        }

        private bool _UpdateTestAppointment()
        {

            return clsTestAppointmentData.UpdateTestAppointment(this.AppointmentID, this.LocalDrivingLicenseApplicationID, this.TestTypeID, this.AppointmentDate,
                 this.PaidFees, this.IsLocked, this.CreatedByUserID);

        }

        static public bool IsPersonHaveActiveAppointment(int localDrivingLicenseApplicationID, int testTypeID)
        {

            return clsTestAppointmentData.IsPersonHaveActiveAppointment(localDrivingLicenseApplicationID, testTypeID);

        }

        public bool Save()
        {

            switch (_Mode)
            {

                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else {  return false; }
                   

                case enMode.Update:
                    return _UpdateTestAppointment();


            }

            return false;

        }

        static public void LockTestAppointment(int testAppointmentID)
        {

            clsTestAppointmentData.LockTestAppointment(testAppointmentID);

        }

        public static decimal CalculateTotalFeesForRetakeTest(decimal testFees, decimal retakeTestApplicationFees)
        {
            return testFees + retakeTestApplicationFees;
        }

    }
}
