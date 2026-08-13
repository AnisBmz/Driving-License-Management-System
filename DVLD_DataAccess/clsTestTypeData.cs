using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTestTypeData
    {

        static public DataTable GetAllTestTypes()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT TestTypeID AS ID, TestTypeTitle AS Title, TestTypeDescription AS Description, " +
                " TestTypeFees AS Fees " +
                " FROM TestTypes;";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }

        public static bool GetTestTypeInfoByID(int testTypeID, ref string title, ref string description, ref decimal ?fees)
        { 

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT TestTypeTitle AS Title, TestTypeDescription AS Description," +
                " TestTypeFees AS Fees" +
                " FROM TestTypes" +
                " WHERE TestTypeID = @testTypeID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@testTypeID", testTypeID);

            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    title = reader["Title"].ToString();
                    description = reader["Description"].ToString();
                    fees = Convert.ToDecimal(reader["Fees"]);

                }

                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return isFound;

        }

        public static bool UpdateTestType(int testTypeID, string title, string description, decimal? fees)
        {

            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "UPDATE TestTypes" +
                " SET TestTypeTitle = @Title, TestTypeDescription = @Description, TestTypeFees = @Fees" +
                " WHERE TestTypeID = @testTypeID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@testTypeID", testTypeID);

            cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(title) ? (object)DBNull.Value : title;

            cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(description) ? (object)DBNull.Value : description;

            cmd.Parameters.Add("@Fees", SqlDbType.SmallMoney).Value = fees == null ? (object)DBNull.Value : fees;

            try
            {

                connection.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)   
                    isUpdated = true;


            }
            catch { }
            finally { connection.Close(); }
            return isUpdated;
        }

    }
}
