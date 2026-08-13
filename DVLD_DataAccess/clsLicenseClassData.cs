using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLicenseClassData
    {

        static public List<string> GetAllLicenseClassesName()
        {

            List<string> licenseClassesName = new List<string>();

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT ClassName FROM LicenseClasses";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {


                    licenseClassesName.Add(reader["ClassName"].ToString());


                }


            }
            catch
            {


            }
            finally
            {

                connection.Close();

            }

            return licenseClassesName;

        }


        static public int GetLicenseClassIDByName(string className)
        {

            int licenseClassID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT LicenseClassID FROM LicenseClasses" +
                " WHERE ClassName = @className;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@className", className);

            try
            {

                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {

                    licenseClassID = Convert.ToInt32(result);

                }

            }
            catch
            {


            }
            finally
            {

                connection.Close();
            }

            return licenseClassID;

        }


        static public bool GetLicenseClassInfoByID(int licenseClassID, ref string className, ref string classDescription,
            ref byte minimumAllowedAge, ref byte defaultValidityLength, ref decimal classFees)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT ClassName, ClassDescription, MinimumAllowedAge," +
                " DefaultValidityLength, ClassFees" +
                " FROM LicenseClasses" +
                " WHERE LicenseClassID = @licenseClassID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@licenseClassID", licenseClassID);

            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;

                    className = reader["ClassName"].ToString();
                    classDescription = reader["ClassDescription"].ToString();
                    minimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    defaultValidityLength = (byte)reader["DefaultValidityLength"];
                    classFees = (decimal)reader["ClassFees"];

                }

            }
            catch { }
            finally { connection.Close(); }
            return isFound;

        }

    }
}
