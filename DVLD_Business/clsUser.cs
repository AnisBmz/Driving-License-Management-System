using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsUser
    {

        enum enMode { AddNewUser = 0, UpdateUser = 1 };

        enMode _Mode { get; set; }

        public int UserID { get; private set; }

        public int PersonID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public clsPerson PersonInfo { get; private set; }

        public clsUser(int userID, int personID, string username, string password, bool isActive) {
        
            this.UserID = userID;
            this.PersonID = personID;
            this.Username = username;
            this.Password = password;
            this.IsActive = isActive;
            this.PersonInfo = clsPerson.GetPersonInfoByID(personID);
            this._Mode = enMode.UpdateUser;
            
        }

        public clsUser()
        {


            this._Mode = enMode.AddNewUser;


        }

        static public clsUser FindUserByUsernameAndPassword(string userName, string password)
        {
            int userID = -1; int personID = -1; bool isActive = false;

            if(clsUserData.FindUserByUsernameAndPassword(userName, password, ref userID, ref personID, ref isActive))
            {
                return new clsUser(userID, personID, userName, password, isActive);

            }
            return null;

        }

        static public DataTable GetAllUsers()
        {

            return clsUserData.GetAllUsers();

        }

        private bool _AddNewUser()
        {

            UserID = clsUserData.AddNewUser(this.PersonID, this.Username, this.Password, this.IsActive);

            return UserID != -1;


        }

        private bool _UpdateUserInfo()
        {

            return clsUserData.UpdateUserInfo(this.UserID, this.Username, this.Password, this.IsActive);

        }

        public bool Save()
        {

            switch (_Mode)
            {

                case enMode.AddNewUser:

                    if (_AddNewUser())
                    {
                        this._Mode = enMode.UpdateUser;
                        return true;
                    }
                    break;

                case enMode.UpdateUser:

                    if (_UpdateUserInfo())
                    {
                        return true;

                    }
                    break;

            }


            return false;

        }

        static public bool IsPersonUser(int personID)
        {

            return clsUserData.IsPersonUser(personID);

        }

        static public clsUser GetUserInfoByUserID(int userID)
        {

            int personID = -1; string username = ""; string password = ""; bool isActive = false;

            if (clsUserData.GetUserInfoByUserID(userID, ref personID, ref username, ref password, ref isActive))
            {
                
                return new clsUser(userID, personID, username, password, isActive);

            }else
            {
                 
                return null;

            }


        }

        static public bool DeleteUser(int userID)
        {

            return clsUserData.DeleteUser(userID);

        }

        static public int GetUserIDByUsername(string userName)
        {

            return clsUserData.GetUserIDByUsername(userName);

        }

        static public bool IsUsernameExists(string newUsername, string currentUsername, bool isUpdateMode)
        {

            if (isUpdateMode && currentUsername == newUsername)
            {

                return false;

            }

            return clsUserData.IsUsernameExists(newUsername);

        }

    }


}
