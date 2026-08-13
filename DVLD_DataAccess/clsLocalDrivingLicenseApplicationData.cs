using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccess
{
    public class clsLocalDrivingLicenseApplicationData
    {

        static public DataTable GetAllLocalDrivingLicenseApplications()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT * FROM LocalDrivingLicenseApplications_View" +
                " ORDER BY ApplicationDate DESC;";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

            }
            catch
            {


            }
            finally
            {

                connection.Close();
            }

            return dt;

        }

        static public int AddNewLocalDrivingLicenseApplication(int applicationID, int licenseClassID)
        {


            int localDrivingLicenseApplicationID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "INSERT INTO LocalDrivingLicenseApplications" +
                " VALUES (@ApplicationID, @LicenseClassID);" +
                " SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = applicationID;
            cmd.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = licenseClassID;

            try
            {


                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {

                    localDrivingLicenseApplicationID = Convert.ToInt32(result);

                }
            }
            catch
            {

            }
            finally
            {

                connection.Close();

            }

            return localDrivingLicenseApplicationID;

        }
   
        static public bool GetLocalDrivingLicenseApplicationByID(int localDrivingLicenseApplicationID, ref int applicationID, ref int licenseClassID)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);


            string query = "SELECT ApplicationID, LicenseClassID FROM LocalDrivingLicenseApplications" +
                " WHERE LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@localDrivingLicenseApplicationID", SqlDbType.Int).Value = localDrivingLicenseApplicationID;

            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    applicationID = Convert.ToInt32(reader["ApplicationID"]);
                    licenseClassID = Convert.ToInt32(reader["LicenseClassID"]);

                }
                reader.Close();
            }
            catch { }
            finally {  connection.Close(); }
            return isFound;
        }

        static public bool UpdateLocalDrivingLicenseApplication(int localDrivingLicenseApplicationID, int licenseClassID)
        {

            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "UPDATE LocalDrivingLicenseApplications" +
                " SET LicenseClassID = @licenseClassID" +
                " WHERE LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@localDrivingLicenseApplicationID", SqlDbType.Int).Value = localDrivingLicenseApplicationID;
            cmd.Parameters.Add("@licenseClassID", SqlDbType.Int).Value = licenseClassID;

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

        static public bool DeleteLocalDrivingLicenseApplication(int localDrivingLicenseApplicationID)
        {

            bool isDeleted = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "DELETE FROM LocalDrivingLicenseApplications" +
           " WHERE LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@localDrivingLicenseApplicationID", SqlDbType.Int).Value = localDrivingLicenseApplicationID;

            try
            {

                connection.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {

                    isDeleted = true;

                }

            }
            catch { }
            finally { connection.Close(); }
            return isDeleted;
        }

    }
}
