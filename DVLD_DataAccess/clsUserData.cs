using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsUserData
    {

        static public bool FindUserByUsernameAndPassword(string userName, string password, ref int userID, ref int personID, ref bool isActive)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = $"SELECT * FROM Users" +
                            $" WHERE UserName = @userName AND Password = @password;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);


            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    personID = Convert.ToInt32(reader["PersonID"]);
                    userID = Convert.ToInt32(reader["UserID"]);

                }

                reader.Close();

            }
            catch { }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        static public DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT " +
                " Users.UserID AS [User ID]," +
                " Users.PersonID AS [Person ID]," +
                " People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName + ' ', '') " +
                " + People.LastName AS [Full Name]," +
                " Users.UserName, " +
                " Users.IsActive AS [Is Active]" +
                " FROM Users " +
                " INNER JOIN People ON Users.PersonID = People.PersonID;";

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

        public static bool GetUserInfoByUserID(int userID, ref int personID, ref string userName, ref string password, ref bool isActive)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = $"SELECT PersonID, UserName, Password, IsActive" +
                $" FROM Users" + 
                $" WHERE UserID = @userID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@userID", userID);

            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    personID = Convert.ToInt32(reader["PersonID"]);
                    userName = reader["UserName"].ToString();
                    password = reader["Password"].ToString();
                    isActive = Convert.ToBoolean(reader["IsActive"]);

                }

                reader.Close();

            }
            catch { }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        static public int AddNewUser(int personID, string userName, string password, bool isActive)
        {

            int newUserID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "INSERT INTO Users" +
                " VALUES" +
                " (@PersonID, @UserName, @Password, @IsActive);" +
                " SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@PersonID", SqlDbType.Int).Value = personID == -1 ? (object)DBNull.Value : personID;

            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(userName) ? (object)DBNull.Value : userName;

            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(password) ? (object)DBNull.Value : password;

            cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;

            try
            {

                connection.Open();

                object num = cmd.ExecuteScalar();

                if (num != null)
                {

                    newUserID = Convert.ToInt32(num);

                }

            }
            catch { }
            finally { connection.Close(); }
            return newUserID;

        }

        static public bool UpdateUserInfo(int userID,  string userName, string password, bool isActive)
        {

            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "UPDATE Users " +
                " SET UserName = @UserName, Password = @Password, IsActive = @IsActive" +
                " WHERE UserID = @UserID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;

            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(userName) ? (object)DBNull.Value : userName;

            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(password) ? (object)DBNull.Value : password;

            cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;

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

        static public bool IsPersonUser(int personID)
        {

            bool isExists = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = $"SELECT PersonID FROM Users" +
                $" WHERE PersonID = @PersonID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@PersonID", SqlDbType.Int).Value = personID;

            try
            {

                connection.Open();

                object num = cmd.ExecuteScalar();

                if (num != null)
                {

                    isExists = true;

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

        static public bool IsUsernameExists(string username)
        {

            bool isExists = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = $"SELECT UserID FROM Users" +
                $" WHERE UserName = @username;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = username;

            try
            {

                connection.Open();

                object num = cmd.ExecuteScalar();

                if (num != null)
                {

                    isExists = true;

                }

            }
            catch { }
            finally
            {

                connection.Close();

            }

            return isExists;

        }

        static public bool DeleteUser(int userID)
        {

            bool isDeleted = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "DELETE FROM Users " +
                " WHERE UserID = @UserID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", userID);


            try
            {

                connection.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {

                    isDeleted = true;

                }

            }
            catch
            {


            }
            finally
            {

                connection.Close();
            }

            return isDeleted;


        }

        static public int GetUserIDByUsername(string userName)
        {

            int userID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);

            string query = "SELECT UserID FROM Users" +
                " WHERE UserName = @UserName;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue ("@UserName", userName);


            try
            {


                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    
                    userID = (int)result;
                }

            }
            catch
            {


            }
            finally {

                connection.Close();

            }

            return userID;

        }

        
    }
}
