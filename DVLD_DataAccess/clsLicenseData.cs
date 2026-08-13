using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccess
{
    public class clsLicenseData
    {

        static public DataTable GetAllLocalDrivingLicensesForPerson(int personID)
        {

            DataTable dataTable = new DataTable();


            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT Licenses.LicenseID AS [License ID], Applications.ApplicationID AS [Application ID], LicenseClasses.ClassName AS [License Class]," +
                " Licenses.IssueDate AS [Issue Date], Licenses.ExpirationDate AS [Expiration Date], Licenses.IsActive AS [Is Active] " +
                " FROM Licenses " +
                " INNER JOIN Applications ON Licenses.ApplicationID = Applications.ApplicationID " +
                " INNER JOIN LicenseClasses ON Licenses.LicenseClassID = LicenseClasses.LicenseClassID" +
                " INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID " +
                " WHERE Drivers.PersonID = @personID" +
                " ORDER BY LicenseID DESC;";

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

        static public bool GetLicenseInfoByID(int licenseID, ref int applicationID, ref int driverID, ref int licenseClassID, ref DateTime issueDate,
                ref DateTime expirationDate, ref string notes, ref decimal paidFees, ref bool isActive, ref byte issueReasonID, ref int createdByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT ApplicationID, DriverID, LicenseClassID, IssueDate," +
                " ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID " +
                " FROM Licenses" +
                " WHERE LicenseID = @licenseID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@licenseID", SqlDbType.Int).Value = licenseID;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    applicationID = Convert.ToInt32(reader["ApplicationID"]);
                    driverID = Convert.ToInt32(reader["DriverID"]);
                    licenseClassID = Convert.ToInt32(reader["LicenseClassID"]);
                    issueDate = Convert.ToDateTime(reader["IssueDate"]);
                    expirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    notes = Convert.ToString(reader["Notes"]);
                    paidFees = Convert.ToDecimal(reader["PaidFees"]);
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    issueReasonID = Convert.ToByte(reader["IssueReason"]);
                    createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return isFound;
        }

        static public bool GetLicenseInfoByApplicationID(int applicationID, ref int licenseID, ref int driverID, ref int licenseClassID, ref DateTime issueDate,
                ref DateTime expirationDate, ref string notes, ref decimal paidFees, ref bool isActive, ref byte issueReasonID, ref int createdByUserID)
        {


            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT LicenseID, DriverID, LicenseClassID, IssueDate," +
                " ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID " +
                " FROM Licenses" +
                " WHERE ApplicationID = @applicationID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@applicationID", applicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    licenseID = Convert.ToInt32(reader["LicenseID"]);
                    driverID = Convert.ToInt32(reader["DriverID"]);
                    licenseClassID = Convert.ToInt32(reader["LicenseClassID"]);
                    issueDate = Convert.ToDateTime(reader["IssueDate"]);
                    expirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    notes = Convert.ToString(reader["Notes"]);
                    paidFees = Convert.ToDecimal(reader["PaidFees"]);
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    issueReasonID = Convert.ToByte(reader["IssueReason"]);
                    createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                }

                reader.Close();

            }
            catch { }
            finally { connection.Close(); }
            return isFound;
        }

        static public int AddNewLicense(int applicationID, int driverID, int licenseClassID, DateTime issueDate,
               DateTime expirationDate, string noter, decimal paidFees, bool isActive, byte IssueReasonID, int createdByUserID)
        {

            int licenseID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "INSERT INTO Licenses" +
                " VALUES (@applicationID, @driverID, @licenseClassID, @issueDate, @expirationDate," +
                " @noter, @paidFees, @isActive, @issueReasonID, @createdByUserID);" +
                " SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@applicationID", applicationID);
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@licenseClassID", licenseClassID);
            cmd.Parameters.AddWithValue("@issueDate", issueDate);
            cmd.Parameters.AddWithValue("@expirationDate", expirationDate);
            if (string.IsNullOrWhiteSpace(noter))
            {
                cmd.Parameters.AddWithValue("@noter", DBNull.Value);

            }
            else
            {
                cmd.Parameters.AddWithValue("@noter", noter);

            }
            cmd.Parameters.AddWithValue("@paidFees", paidFees);
            cmd.Parameters.AddWithValue("@isActive", isActive);
            cmd.Parameters.AddWithValue("@issueReasonID", IssueReasonID);
            cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);

            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    licenseID = Convert.ToInt32(result);
                }
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }
            return licenseID;
        }

        static public int GetLicenseIDByPersonAndClass(int personID, int licenseClassID)
        {

            int licenseID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT Licenses.LicenseID " +
                " FROM Licenses" +
                " INNER JOIN Applications ON Licenses.ApplicationID = Applications.ApplicationID " +
                " INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID" +
                " WHERE Drivers.PersonID = @personID AND Licenses.LicenseClassID = @licenseClassID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@personID", personID);
            cmd.Parameters.AddWithValue("@licenseClassID", licenseClassID);


            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {

                    licenseID = Convert.ToInt32(result);
                }

            }
            catch { }
            finally { connection.Close(); }
            return licenseID;

        }

        static public bool DeactivateLicense(int licenseID)
        {

            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "UPDATE Licenses" +
                " SET IsActive = 0" +
                " WHERE LicenseID = @licenseID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@licenseID", SqlDbType.Int).Value = licenseID;



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
    }
}
