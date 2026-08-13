using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTestData
    {

        static public int AddNewTest(int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {

            int testID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "INSERT INTO Tests" +
                " VALUES (@testAppointmentID, @testResult, @notes, @createdByUserID);" +
                " SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@testAppointmentID", testAppointmentID);
            cmd.Parameters.AddWithValue("@testResult", testResult);
            cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);

            if (notes == "")
            {
                cmd.Parameters.AddWithValue("@notes", DBNull.Value);

            }
            else
            {
                cmd.Parameters.AddWithValue("@notes", notes);

            }

            try
                {

                    connection.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {

                        testID = Convert.ToInt32(result);

                    }

                }
                catch
                {


                }
                finally { connection.Close(); }

            return testID;

        }

        static public bool CheckTestResult(int localDrivingLicenseApplicationID, int testTypeID, bool testResult)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = @"SELECT TOP 1 TestID FROM Tests" +
                " INNER JOIN TestAppointments ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID " +
                " WHERE TestAppointments.TestTypeID = @testTypeID" +
                " AND LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID" +
                " AND TestResult = @testResult" +
                " ORDER BY TestAppointments.TestAppointmentID DESC";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@localDrivingLicenseApplicationID", System.Data.SqlDbType.Int).Value = localDrivingLicenseApplicationID;
            cmd.Parameters.Add("@testTypeID", System.Data.SqlDbType.Int).Value = testTypeID;
            cmd.Parameters.Add("@testResult", System.Data.SqlDbType.Bit).Value = testResult ? 1 : 0;

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                IsFound = result != null;

            }
            catch { }
            finally { connection.Close(); }
            return IsFound;
        }

        static public int TotalTrialsPerTest(int localDrivingLicenseApplicationID, int testTypeID)
        {

            int failedCount = 0;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT COUNT(testID) FROM Tests " +
                " INNER JOIN TestAppointments ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID " +
                " WHERE TestTypeID = @testTypeID AND TestResult = 0 AND TestAppointments.LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);



            cmd.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@testTypeID", testTypeID);


            try
            {

                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {

                    failedCount = Convert.ToInt32(result);

                }

            }
            catch
            {


            }
            finally { connection.Close(); }
            return failedCount;

        }

        static public byte GetPassedTestCount(int localDrivingLicenseApplicationID)
        {

            byte PassedTestCount = 0;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);


            string query = "SELECT " +
                " (SELECT COUNT(TestAppointments.TestTypeID) AS PassedTestCount " +
                " FROM Tests " +
                " INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID" +
                " WHERE (TestAppointments.LocalDrivingLicenseApplicationID = LD.LocalDrivingLicenseApplicationID) AND (Tests.TestResult = 1)) AS PassedTestCount " +
                " FROM LocalDrivingLicenseApplications AS LD " +
                " WHERE LD.LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);

            try
            {

                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {

                    PassedTestCount = Convert.ToByte(result);

                }
            }
            catch { }
            finally { connection.Close(); }
            return PassedTestCount;

        }

    }
}
