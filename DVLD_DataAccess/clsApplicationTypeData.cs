using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsApplicationTypeData
    {

        static public DataTable GetAllApplicationTypes()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT ApplicationTypeID AS ID, ApplicationTypeTitle AS Title, ApplicationFees AS Fees" +
                " FROM ApplicationTypes" +
                " ORDER BY ApplicationTypeTitle;";

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

        static public bool GetApplicationTypeByID(int applicationTypeID, ref string title, ref decimal? fees)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT ApplicationTypeTitle AS Title, ApplicationFees AS Fees" +
                            " FROM ApplicationTypes" +
                            " WHERE ApplicationTypeID = @applicationTypeID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@applicationTypeID", SqlDbType.Int).Value = applicationTypeID;

            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    title = reader["Title"].ToString();
                    fees = Convert.ToDecimal(reader["Fees"]);

                }

                reader.Close();

            }
            catch { }
            finally { connection.Close(); }
            return isFound;

        }

        static public bool UpdateApplicationType(int applicationTypeID, string title, decimal ?fees)
        {

            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);


            string query = "UPDATE ApplicationTypes" +
                " SET ApplicationTypeTitle = @Title, ApplicationFees = @Fees" +
                " WHERE ApplicationTypeID = @applicationTypeID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@applicationTypeID", SqlDbType.Int).Value = applicationTypeID;

            cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(title) ? (object)DBNull.Value : title;

            cmd.Parameters.Add("@Fees", SqlDbType.SmallMoney).Value = fees == null ? (object)DBNull.Value : fees;

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
