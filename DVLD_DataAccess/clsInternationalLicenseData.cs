using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsInternationalLicenseData
    {

        static public int AddNewInternationalLicense(int applicationID, int driverID, int localLicenseID, DateTime issueDate,
             DateTime expirationDate, bool isActive, int createdByUserID)
        {

            int internationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "UPDATE InternationalLicenses set IsActive = 0 " +
                " WHERE DriverID = @driverID;" +
                " INSERT INTO InternationalLicenses" +
                " VALUES (@applicationID, @driverID, @localLicenseID, @issueDate, @expirationDate," +
                " @isActive, @createdByUserID);" +
                " SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@applicationID", applicationID != -1 ? (object)applicationID : DBNull.Value);
            cmd.Parameters.AddWithValue("@driverID", driverID != -1 ? (object)driverID: DBNull.Value);
            cmd.Parameters.AddWithValue("@localLicenseID", localLicenseID != -1 ? (object)localLicenseID : DBNull.Value);
            cmd.Parameters.AddWithValue("@issueDate", issueDate);
            cmd.Parameters.AddWithValue("@expirationDate", expirationDate);
            cmd.Parameters.AddWithValue("@isActive", isActive);
            cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);

            try
            {

                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {

                    internationalLicenseID = Convert.ToInt32(result);

                }

            }
            catch { }
            finally { connection.Close(); }
            return internationalLicenseID;
        }

        static public int CheckPersonHaveActiveInternationalLicense(int personID)
        {

            int internationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT InternationalLicenses.InternationalLicenseID " +
                " FROM Applications INNER JOIN InternationalLicenses ON Applications.ApplicationID = InternationalLicenses.ApplicationID " +
                " WHERE ApplicantPersonID = @personID AND IsActive = 1 AND GetDate() BETWEEN InternationalLicenses.IssueDate AND InternationalLicenses.ExpirationDate;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    internationalLicenseID = Convert.ToInt32(result);
                }
            }
            catch { }
            finally { connection.Close(); }
            return internationalLicenseID;

        }

        static public bool GetInternationalLicenseByID(int internationalLicenseID, ref int licenseID,
             ref DateTime issueDate, ref int applicationID, ref bool isActive,
             ref int driverID, ref DateTime expirationDate
            )
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT " +
                " InternationalLicenses.IssuedUsingLocalLicenseID," +
                " InternationalLicenses.IssueDate, " +
                " InternationalLicenses.ApplicationID, InternationalLicenses.IsActive, " +
                " InternationalLicenses.DriverID, InternationalLicenses.ExpirationDate " +
                " FROM InternationalLicenses " +
                " WHERE InternationalLicenses.InternationalLicenseID = @internationalLicenseID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@internationalLicenseID",internationalLicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    licenseID = Convert.ToInt32(reader["IssuedUsingLocalLicenseID"]);
                    issueDate = Convert.ToDateTime(reader["IssueDate"]);
                    applicationID = Convert.ToInt32(reader["ApplicationID"]);
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    driverID = Convert.ToInt32(reader["DriverID"]);
                    expirationDate = Convert.ToDateTime(reader["ExpirationDate"]);

                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return isFound;

        }

        static public DataTable GetAllInternationalDrivingLicenses()
        {

            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT InternationalLicenseID AS [Int.License ID]," +
                " ApplicationID AS [Application ID], DriverID AS [Driver ID], " +
                " IssuedUsingLocalLicenseID AS [L.License ID], IssueDate AS [Issue Date]," +
                " ExpirationDate AS [Expiration Date], IsActive AS [Is Active] " +
                " FROM InternationalLicenses" +
                " ORDER BY InternationalLicenseID DESC;";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            catch { }
            finally { connection.Close(); }
            return dataTable;

        }

        static public DataTable GetAllInternationalDrivingLicensesForPerson(int personID)
        {

            DataTable dataTable = new DataTable();


            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT InternationalLicenses.InternationalLicenseID AS [Int.License ID], InternationalLicenses.IssuedUsingLocalLicenseID AS [L.License ID], InternationalLicenses.ApplicationID AS [Application ID]," +
                " InternationalLicenses.IssueDate AS [Issue Date], InternationalLicenses.ExpirationDate AS [Expiration Date], InternationalLicenses.IsActive AS [Is Active] " +
                " FROM InternationalLicenses " +
                " INNER JOIN Drivers ON InternationalLicenses.DriverID = Drivers.DriverID" +
                " WHERE Drivers.PersonID = @personID" +
                " ORDER BY InternationalLicenseID DESC;";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@personID", personID);

            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);

            }
            catch { }
            finally { connection.Close(); }
            return dataTable;

        }


    }
}

