using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{

    public class clsTest
    {

        public int TestID { get; set; }
        
        public bool TestResult { get; set; }

        public int TestAppointmentID { get; set; }

        public string Notes { get; set; }

        public int CreatedByUserID { get; set; }

        public clsTest()
        {


        }

        public bool AddNewTest()
        {

            return (this.TestID = clsTestData.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes,
                this.CreatedByUserID)) != -1;

        }

        static public bool CheckTestResult(int localDrivingLicenseApplicationID, int testTypeID, bool testResult)
        {

            return clsTestData.CheckTestResult(localDrivingLicenseApplicationID, testTypeID, testResult);

        }

        static public int TotalTrialsPerTest(int localDrivingLicenseApplicationID, int testTypeID)
        {

            return clsTestData.TotalTrialsPerTest(localDrivingLicenseApplicationID, testTypeID);

        }

        static public byte GetPassedTestCount(int localDrivingLicenseApplicationID)
        {

            return clsTestData.GetPassedTestCount(localDrivingLicenseApplicationID);

        }

    }
}
