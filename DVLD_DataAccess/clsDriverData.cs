using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsDriverData
    {

        static public int AddNewDriver(int personID, int createdByUserID, DateTime createdDate)
        {

            int driverID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "INSERT INTO Drivers" +
                " VALUES (@personID, @createdByUserID, @createdDate);" +
                " SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@personID", personID);
            cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);
            cmd.Parameters.AddWithValue("@createdDate", createdDate);

            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {   
                    driverID = Convert.ToInt32(result);
                }
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }
            return driverID;
        }

        static public int CheckDriverIsExists(int personID)
        {

            int driverID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT DriverID FROM Drivers" +
                " WHERE PersonID = @personID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null) {

                    driverID = Convert.ToInt32(result);

                }
            }
            catch { }
            finally { connection.Close(); }
            return driverID;
        }

        static public DataTable GetAllDrivers()
        {

            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT * FROM Drivers_View;";

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

        public static bool GetDriverInfoByID(int driverID, ref int personID, ref int createdByUserID, ref DateTime createdDate)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT PersonID, CreatedByUserID, CreatedDate" +
                " From Drivers" +
                " WHERE DriverID = @driverID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@driverID", driverID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    personID = Convert.ToInt32(reader["PersonID"]);
                    createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    createdDate = Convert.ToDateTime(reader["CreatedDate"]);

                }
                reader.Close();

            }
            catch { }
            finally { connection.Close(); }
            return isFound;

        }


    }
}
