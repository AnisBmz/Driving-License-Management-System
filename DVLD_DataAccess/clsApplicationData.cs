using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsApplicationData
    {

        static public bool GetApplicationInfoByID(int applicationID, ref int applicationPersonID, ref DateTime applicationDate, ref int applicationTypeID,
            ref byte applicationStatus, ref DateTime lastStatusDate, ref decimal paidFees, ref int createdByUserID)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT ApplicantPersonID, ApplicationDate, ApplicationTypeID, PaidFees, LastStatusDate, ApplicationStatus, CreatedByUserID" +
                " FROM Applications" +
                " WHERE ApplicationID = @applicationID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@applicationID", applicationID);

            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    applicationPersonID = Convert.ToInt32(reader["ApplicantPersonID"]);
                    applicationDate = Convert.ToDateTime(reader["ApplicationDate"]);
                    applicationTypeID = Convert.ToInt32(reader["ApplicationTypeID"]);
                    paidFees = Convert.ToDecimal(reader["PaidFees"]);
                    lastStatusDate = Convert.ToDateTime(reader["LastStatusDate"]);
                    createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    applicationStatus = Convert.ToByte(reader["ApplicationStatus"]);

                }
            }
            catch { }
            finally { connection.Close(); }
            return isFound;
        }

        static public int AddNewApplication(int applicationPersonID, DateTime applicationDate, int applicationTypeID,
            byte applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {

            int applicationID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "INSERT INTO Applications" +
                " VALUES (@ApplicationPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus," +
                " @LastStatusDate, @PaidFees, @CreatedByUserID);" +
                " SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@ApplicationPersonID", SqlDbType.Int).Value = applicationPersonID;
            cmd.Parameters.Add("@ApplicationDate", SqlDbType.DateTime).Value = applicationDate;
            cmd.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = applicationTypeID;
            cmd.Parameters.Add("@ApplicationStatus", SqlDbType.TinyInt).Value = applicationStatus;
            cmd.Parameters.Add("@LastStatusDate", SqlDbType.DateTime).Value = lastStatusDate;
            cmd.Parameters.Add("@PaidFees", SqlDbType.SmallMoney).Value = paidFees;
            cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = createdByUserID;

            try
            {

                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {

                    applicationID = Convert.ToInt32(result);

                }

            }
            catch { }
            finally { connection.Close(); }
            return applicationID;
        }

        static public bool UpdateApplication(int applicationID, DateTime applicationDate, DateTime lastStatusDate,
            decimal paidFees, int createdByUserID)
        {

            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "UPDATE Applications" +
                " SET ApplicationDate = @applicationDate, LastStatusDate = @lastStatusDate, PaidFees = @paidFees, CreatedByUserID = @createdByUserID" +
                " WHERE ApplicationID = @applicationID;";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@applicationID", SqlDbType.Int).Value = applicationID;
            cmd.Parameters.Add("@applicationDate", SqlDbType.DateTime).Value = applicationDate;
            cmd.Parameters.Add("@lastStatusDate", SqlDbType.DateTime).Value = lastStatusDate;
            cmd.Parameters.Add("@paidFees", SqlDbType.SmallMoney).Value = paidFees;
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

        static public bool DeleteApplication(int applicationID)
        {

            bool isDeleted = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "DELETE FROM Applications" +
            " WHERE ApplicationID = @applicationID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@applicationID", SqlDbType.Int).Value = applicationID;


            try
            {

                connection.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {

                    isDeleted = true;

                }

            }
            catch
            {


            }
            finally
            {

                connection.Close();

            }
            return isDeleted;

        }

        static public int GetActiveApplicationIDByPersonAndClass(int applicationPersonID, int licenseClassID, byte excludedStatus)
        {

            int applicationID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT Applications.ApplicationID " +
                " FROM Applications " +
                " INNER JOIN LocalDrivingLicenseApplications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID " +
                " WHERE Applications.ApplicantPersonID = @applicantPersonID AND LocalDrivingLicenseApplications.LicenseClassID = @licenseClassID AND Applications.ApplicationStatus <> @excludedStatus;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@applicantPersonID", SqlDbType.Int).Value = applicationPersonID;
            cmd.Parameters.Add("@licenseClassID", SqlDbType.Int).Value = licenseClassID;
            cmd.Parameters.Add("@excludedStatus", SqlDbType.TinyInt).Value = excludedStatus;

            try
            {

                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {

                    applicationID = Convert.ToInt32(result);

                }

            }
            catch { }
            finally { connection.Close(); }
            return applicationID;

        }

        static public bool EditApplicationStatus(int applicationID, byte applicationStatus)
        {


            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "UPDATE Applications" +
                " SET ApplicationStatus = @applicationStatus, LastStatusDate = @lastStatusDate" +
                " WHERE ApplicationID = @applicationID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@applicationID", SqlDbType.Int).Value = applicationID;
            cmd.Parameters.Add("@applicationStatus", SqlDbType.TinyInt).Value = applicationStatus;
            cmd.Parameters.Add("@lastStatusDate", SqlDbType.DateTime).Value = DateTime.Now;

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

        static public int GetApplicationIDByLicenseID(int licenseID)
        {

            int applicationID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT ApplicationID FROM Licenses" +
                " WHERE LicenseID = @licenseID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@licenseID", licenseID);

            try
            {

                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {

                    applicationID = Convert.ToInt32(result);

                }

            }
            catch { }
            finally { connection.Close(); }
            return applicationID;
        }

    }
}
