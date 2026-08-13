using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsCountryData
    {

        static public DataTable GetAllCountries()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT CountryName FROM Countries;";

            try
            {

                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

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

        static public int GetCountryIDByName(string countryName)
        {


            int countryID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT CountryID FROM Countries" +
                " WHERE CountryName = @CountryName;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@CountryName", countryName);

            try
            {

                connection.Open();

                object countryId = cmd.ExecuteScalar();

                if (countryId != null)
                {

                    countryID = Convert.ToInt32(countryId);

                }


            }
            catch
            {



            }
            finally
            {

                connection.Close();
            }

            return countryID;

        }

        static public bool GetCountryInfoByID(int countryID, ref string countryName)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT CountryName FROM Countries" +
                " WHERE CountryID = @countryID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@countryID", countryID);

            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    countryName = Convert.ToString(reader["CountryName"]);

                }
            }
            catch { }
            finally { connection.Close(); }
            return isFound;
        }

    }
}
