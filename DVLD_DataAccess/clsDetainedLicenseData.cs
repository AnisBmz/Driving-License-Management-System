using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsDetainedLicenseData
    {

        static public DataTable GetAllDetainedLicenses()
        {

            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT DetainedLicenses.DetainID AS [Detain ID], People.NationalNo AS [National No]," +
                " People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName + ' ', '') + ' ' + " +
                " People.LastName AS [Full Name], DetainedLicenses.LicenseID AS [License ID], DetainedLicenses.DetainDate AS [Detain Date]," +
                " DetainedLicenses.FineFees AS [Fine Fees], DetainedLicenses.releaseDate AS [Release Date]," +
                " DetainedLicenses.releaseApplicationID AS [Release A.ID],  DetainedLicenses.IsReleased AS [Is Released]" +
                " FROM DetainedLicenses" +
                " INNER JOIN Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID" +
                " INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID " +
                " INNER JOIN People ON Drivers.PersonID = People.PersonID" +
                " ORDER BY DetainID DESC ";

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


        static public bool GetDetainedLicenseByLicenseID(int licenseID, ref int detainID, ref DateTime detainDate,
                                ref decimal fineFees, ref int createdByUserID)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT DetainID, DetainDate, FineFees, CreatedByUserID " +
                " FROM DetainedLicenses" +
                " WHERE LicenseID = @licenseID AND IsReleased = 0;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@licenseID", SqlDbType.Int).Value = licenseID;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    detainID = Convert.ToInt32(reader["DetainID"]);
                    detainDate = Convert.ToDateTime(reader["DetainDate"]);
                    fineFees = Convert.ToDecimal(reader["FineFees"]);
                    createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                }
                reader.Close();

            }
            catch { }
            finally { connection.Close(); }
            return isFound;
        }


        static public int AddNewDetainedLicense(int licenseID, DateTime detainDate, decimal fineFees, 
            int createdByUserID, bool isReleased)
        {

            int detainID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "INSERT INTO DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased)" +
                " VALUES (@licenseID, @detainDate, @fineFees, @createdByUserID, @isReleased);" +
                " SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@licenseID", SqlDbType.Int).Value = licenseID;
            cmd.Parameters.Add("@detainDate", SqlDbType.SmallDateTime).Value = detainDate;
            cmd.Parameters.Add("@fineFees", SqlDbType.SmallMoney).Value = fineFees;
            cmd.Parameters.Add("@createdByUserID", SqlDbType.Int).Value = createdByUserID;
            cmd.Parameters.Add("@isReleased", SqlDbType.Bit).Value = isReleased;

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null) {
                    detainID = Convert.ToInt32(result);
                }

            }
            catch { }
            finally { connection.Close(); }
            return detainID;

        }


        static public bool CheckDrivingLicenseIsDetained(int licenseID)
        {

            bool isDetained = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT DetainID" +
                " FROM DetainedLicenses" +
                " WHERE LicenseID = @licenseID AND DetainedLicenses.IsReleased = 0;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@licenseID", SqlDbType.Int).Value = licenseID;

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    isDetained = true;
                }
            }
            catch { }
            finally { connection.Close(); }
            return isDetained;
        }


        static public bool ReleaseDetainedLicense(int detainID, bool isReleased, DateTime releaseDate, int releasedByUserID,
                            int releaseApplicationID)
        {

            bool isRelease = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "UPDATE DetainedLicenses" +
                " SET IsReleased = @isReleased, ReleaseDate = @releaseDate, ReleasedByUserID = @releasedByUserID," +
                " ReleaseApplicationID = @releaseApplicationID" +
                " WHERE DetainID = @detainID AND IsReleased = 0;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@detainID", SqlDbType.Int).Value = detainID;
            cmd.Parameters.Add("@isReleased", SqlDbType.Bit).Value = isReleased ? 1 : 0;
            cmd.Parameters.Add("@releaseDate", SqlDbType.SmallDateTime).Value = releaseDate;
            cmd.Parameters.Add("@releasedByUserID", SqlDbType.Int).Value = releasedByUserID;
            cmd.Parameters.Add("@releaseApplicationID", SqlDbType.Int).Value = releaseApplicationID;

            try
            {
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isRelease = true;
                }
            }
            catch {}
            finally { connection.Close(); }
            return isRelease;

        }
    }
}
