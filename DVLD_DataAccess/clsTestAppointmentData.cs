using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccess
{
    public class clsTestAppointmentData
    {

        static public DataTable GetAllAppointmentsTestByLocalDrivingLicenseApplicationID(int localDrivingLicenseApplicationID, int testTypeID)
        {

            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT TestAppointments.TestAppointmentID AS [Appointment ID]," +
                " TestAppointments.AppointmentDate AS [Appointment Date]," +
                " TestAppointments.PaidFees AS [Paid Fees]," +
                " CASE" +
                " WHEN TestResult = 0 THEN 'Failed' " +
                " WHEN TestResult = 1 THEN 'Passed' " +
                " ELSE 'Test Not Done' " +
                " END AS [Test Result], TestAppointments.IsLocked AS [Is Locked]" +
                " FROM TestAppointments " +
                " INNER JOIN LocalDrivingLicenseApplications" +
                " ON TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID" +
                " LEFT JOIN Tests ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID" +
                " WHERE TestAppointments.TestTypeID = @testTypeID AND TestAppointments.LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID" +
                " ORDER BY TestAppointments.TestAppointmentID DESC;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@localDrivingLicenseApplicationID", SqlDbType.Int).Value = localDrivingLicenseApplicationID;
            cmd.Parameters.Add("@testTypeID", SqlDbType.Int).Value = testTypeID;

            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                dataTable.Load(reader);

            }
            catch { }
            finally
            {
                connection.Close();
            }

            return dataTable;

        }

        static public int AddNewTestAppointment(int localDrivingLicenseApplicationID, int testTypeID, DateTime appointmentDate,
            decimal paidFees, bool isLocked, int createdByUserID, int retakeTestApplicationID)
        {

            int testAppointmentID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "INSERT INTO TestAppointments " +
                " (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, " +
                " CreatedByUserID, IsLocked, RetakeTestApplicationID)" +
                " VALUES (@testTypeID, @localDrivingLicenseApplicationID, @appointmentDate, @paidFees, " +
                " @createdByUserID, @isLocked, @retakeTestApplicationID);" +
                " SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@localDrivingLicenseApplicationID", SqlDbType.Int).Value = localDrivingLicenseApplicationID;
            cmd.Parameters.Add("@testTypeID", SqlDbType.Int).Value = testTypeID;
            cmd.Parameters.Add("@appointmentDate", SqlDbType.DateTime).Value = appointmentDate;
            cmd.Parameters.Add("@paidFees", SqlDbType.SmallMoney).Value = paidFees;
            cmd.Parameters.Add("@isLocked", SqlDbType.Bit).Value = isLocked;
            cmd.Parameters.Add("@createdByUserID", SqlDbType.Int).Value = createdByUserID;
            cmd.Parameters.Add("@retakeTestApplicationID", SqlDbType.Int).Value = retakeTestApplicationID == -1 ? (object)DBNull.Value : retakeTestApplicationID;

            try
                {

                    connection.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {

                        testAppointmentID = Convert.ToInt32(result);

                    }

                }
            catch { }
            finally { connection.Close(); }

            return testAppointmentID;

        }


        static public bool UpdateTestAppointment(int testAppointmentID, int localDrivingLicenseApplicationID, int testTypeID, DateTime appointmentDate,
            decimal paidFees, bool isLocked, int createdByUserID)
        {

            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "UPDATE TestAppointments" +
                " SET TestTypeID = @testTypeID, LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID," +
                " AppointmentDate = @appointmentDate, PaidFees = @paidFees, CreatedByUserID = @createdByUserID, IsLocked = @isLocked" +
                " WHERE TestAppointmentID = @testAppointmentID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@testAppointmentID", SqlDbType.Int).Value = testAppointmentID;
            cmd.Parameters.Add("@localDrivingLicenseApplicationID", SqlDbType.Int).Value = localDrivingLicenseApplicationID;
            cmd.Parameters.Add("@testTypeID", SqlDbType.Int).Value = testTypeID;
            cmd.Parameters.Add("@appointmentDate", SqlDbType.DateTime).Value = appointmentDate;
            cmd.Parameters.Add("@paidFees", SqlDbType.SmallMoney).Value = paidFees;
            cmd.Parameters.Add("@isLocked", SqlDbType.Bit).Value = isLocked;
            cmd.Parameters.Add("@createdByUserID", SqlDbType.Int).Value = createdByUserID;

            try
            {

                connection.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {

                    isUpdated = true;

                }

            }
            catch { }
            finally { connection.Close(); }

            return isUpdated;

        }

        static public bool GetTestAppointmentByID(int testAppointmentID, ref int localDrivingLicenseApplicationID, ref int testTypeID, ref DateTime appointmentDate,
            ref decimal paidFees, ref bool isLocked, ref int retakeTestApplicationID)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);


            string query = "SELECT * FROM TestAppointments_View" +
                           " WHERE TestAppointmentID = @testAppointmentID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@testAppointmentID", SqlDbType.Int).Value = testAppointmentID;

            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;

                    localDrivingLicenseApplicationID = Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]);
                    testTypeID = Convert.ToInt32(reader["TestTypeID"]);
                    appointmentDate = Convert.ToDateTime(reader["AppointmentDate"]);
                    paidFees = Convert.ToDecimal(reader["PaidFees"]);
                    isLocked = Convert.ToBoolean(reader["IsLocked"]);

                    if ((reader["RetakeTestApplicationID"] == DBNull.Value))
                    {

                        retakeTestApplicationID = -1;


                    }
                    else
                    {

                        retakeTestApplicationID = Convert.ToInt32(reader["RetakeTestApplicationID"]);

                    }
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }

            return isFound;

        }

        static public bool IsPersonHaveActiveAppointment(int localDrivingLicenseApplicationID, int testTypeID)
        {

            bool isHaveActiveAppointment = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT TestAppointmentID FROM TestAppointments" +
                " WHERE LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID" +
                " AND TestTypeID = @testTypeID" +
                " AND IsLocked = 0";

            SqlCommand cmd = new SqlCommand( query, connection);

            cmd.Parameters.AddWithValue("localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@testTypeID", testTypeID);

            try
            {

                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {

                    isHaveActiveAppointment = true;

                }

            }
            catch
            {


            }
            finally { connection.Close(); }

            return isHaveActiveAppointment;

        }

        static public void LockTestAppointment(int testAppointmentID)
        {

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "UPDATE TestAppointments" +
                " SET IsLocked = 1" +
                " WHERE TestAppointmentID = @testAppointmentID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@testAppointmentID", SqlDbType.Int).Value = testAppointmentID;

            try
            {

                connection.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

            }
            catch { }
            finally { connection.Close(); }

        }


    }
}
