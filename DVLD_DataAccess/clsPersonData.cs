using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsPersonData
    {

        static public DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = $"SELECT p.PersonID AS [Person ID], p.NationalNo AS [National No]," +
                $" p.FirstName AS [First Name], " +
                $" p.SecondName AS [Second Name], p.ThirdName  AS [Third Name], p.LastName  AS [Last Name]," +
                $" p.DateOfBirth AS [Date Of Birth], " +
                $" CASE " +
                $" WHEN p.Gender = '0' THEN 'Male'" +
                $" WHEN p.Gender = '1' THEN 'Female'" +
                $" END AS Gender, " +
                $" p.Address, c.CountryName AS Nationality, p.Phone, p.Email" +
                $" FROM People AS p " +
                $" INNER JOIN Countries AS c ON p.NationalityCountryID = c.CountryID" +
                $" ORDER BY PersonID DESC;";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

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

        static public bool GetPersonInfoByID(int personID, ref string nationalNo, ref string firstName, ref string secondName,
               ref string thirdName, ref string lastName, ref DateTime dateOfBirth, ref string gender, ref int nationalityCountryID,
               ref string address, ref string phone, ref string email, ref string imagePath)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = $"SELECT p.NationalNo, p.FirstName," +
                $" p.SecondName, p.ThirdName, p.LastName," +
                $" p.DateOfBirth," +
                $" CASE" +
                $" WHEN Gender = 0 THEN 'Male'" +
                $" WHEN Gender = 1 THEN 'Female'" +
                $" END AS Gender," +
                $" p.Address, NationalityCountryID, p.Phone, p.Email, p.ImagePath" +
                $" FROM People AS p " +
                $" WHERE p.PersonID = @personID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@personID", personID);

            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    nationalNo = reader["NationalNo"].ToString();
                    firstName = reader["FirstName"].ToString();
                    secondName = reader["SecondName"].ToString();
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        thirdName = reader["ThirdName"].ToString();
                    }
                    else 
                    {
                        thirdName = "";
                    }
                    lastName = reader["LastName"].ToString();
                    dateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    gender = reader["Gender"].ToString();
                    nationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);
                    address = reader["Address"].ToString();
                    phone = reader["Phone"].ToString();

                    if (reader["Email"] == DBNull.Value)
                    {

                        email = "";

                    }
                    else
                    {
                        email = reader["Email"].ToString();

                    }

                    if (reader["ImagePath"] == DBNull.Value)
                    {

                        imagePath = "";

                    }
                    else
                    {
                        imagePath = reader["ImagePath"].ToString();
                    }

                }

                reader.Close();

            }
            catch { isFound = false; }
            finally { connection.Close(); }
                
            return isFound;

        }


        static public int AddNewPerson(string nationalNo, string firstName,string secondName,
                string thirdName, string lastName, DateTime dateOfBirth, byte gender, int nationalCountryID,
                string address, string phone, string email, string imagePath)
        {

            int newPersonID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "INSERT INTO People" +
                " VALUES" +
                " (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender," +
                " @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);" +
                " SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = dateOfBirth;

            cmd.Parameters.Add("@Gender", SqlDbType.TinyInt).Value = gender;

            cmd.Parameters.Add("@NationalityCountryID", SqlDbType.Int).Value = nationalCountryID;

            cmd.Parameters.Add("@NationalNo", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(nationalNo) ? (object)DBNull.Value : nationalNo;

            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(firstName) ? (object)DBNull.Value : firstName;

            cmd.Parameters.Add("@SecondName", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(secondName) ? (object)DBNull.Value : secondName;

            cmd.Parameters.Add("@ThirdName", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(thirdName) ? (object)DBNull.Value : thirdName;

            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(lastName) ? (object)DBNull.Value : lastName;

            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(address) ? (object)DBNull.Value : address;

            cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(phone) ? (object)DBNull.Value : phone;

            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(email) ? (object)DBNull.Value : email;

            cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(imagePath) ? (object)DBNull.Value : imagePath;

            try
            {

                connection.Open();

                object num = cmd.ExecuteScalar();

                if (num != null)
                {
                    newPersonID = Convert.ToInt32(num);
                }

            }
            catch { newPersonID = -1; }
            finally { connection.Close(); }

            return newPersonID;

        }


        static public bool UpdatePersonInfo(int personID, string nationalNo, string firstName, string secondName,
                string thirdName, string lastName, DateTime dateOfBirth, byte gender, int nationalCountryID,
                string address, string phone, string email, string imagePath)
        {

            bool isUpdate = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "UPDATE People" +
                " SET NationalNo = @NationalNo, FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName," +
                " LastName = @LastName, DateOfBirth = @DateOfBirth, Gender = @Gender, Address = @Address," +
                " Phone = @Phone, Email = @Email, NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath" +
                " WHERE PersonID = @PersonID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@PersonID", SqlDbType.Int).Value = personID;

            cmd.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = dateOfBirth;

            cmd.Parameters.Add("@Gender", SqlDbType.TinyInt).Value = gender;

            cmd.Parameters.Add("@NationalityCountryID", SqlDbType.Int).Value = nationalCountryID;

            cmd.Parameters.Add("@NationalNo", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(nationalNo) ? (object)DBNull.Value : nationalNo;

            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(firstName) ? (object)DBNull.Value : firstName;

            cmd.Parameters.Add("@SecondName", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(secondName) ? (object)DBNull.Value : secondName;

            cmd.Parameters.Add("@ThirdName", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(thirdName) ? (object)DBNull.Value : thirdName;

            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(lastName) ? (object)DBNull.Value : lastName;

            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(address) ? (object)DBNull.Value : address;

            cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(phone) ? (object)DBNull.Value : phone;

            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(email) ? (object)DBNull.Value : email;

            cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(imagePath) ? (object)DBNull.Value : imagePath;


            try
            {

                connection.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    isUpdate = true;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
            finally
            {

                connection.Close();
            }

            return isUpdate;

        }

        static public bool DeletePerson(int personID)
        {

            bool isDelete = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "DELETE FROM People" +
                   " WHERE PersonID = @personID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@personID", personID);

            try
            {

                connection.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    isDelete = true;
                }

            }
            catch
            {


            }
            finally
            {

                connection.Close();

            }

            return isDelete;

        }

        static public bool IsPersonExists(string nationalNo)
        {

            bool isExists = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = $"SELECT PersonID FROM People" +
                $" WHERE NationalNo = @NationalNo;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@NationalNo", nationalNo);

            try
            {

                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {

                    isExists = true;

                }
                else
                {

                    isExists = false;

                }


            }
            catch
            {



            }
            finally
            {

                connection.Close();

            }

            return isExists;

        }

        static public bool IsPersonExists(int personID)
        {

            bool isExists = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = $"SELECT PersonID FROM People" +
                $" WHERE PersonID = @PersonID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", personID);

            try
            {

                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    isExists = true;
                }

            }
            catch { isExists = false; }
            finally { connection.Close(); }
            return isExists;

        }

        static public int GetPersonIDByNationalNo(string nationalNo)
        {

            int personID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = $"SELECT PersonID FROM People" +
                $" WHERE NationalNo = @NationalNo;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@NationalNo", nationalNo);

            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    personID = Convert.ToInt32(reader["PersonID"]);

                }


            }
            catch
            {



            }
            finally
            {

                connection.Close();

            }

            return personID;

        }

    }
}
