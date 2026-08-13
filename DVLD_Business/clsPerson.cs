using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsPerson
    {

        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode  = enMode.AddNew;

        public int PersonID { get; private set; }

        public string NationalNo { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string ThirdName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {

            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

        }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public byte GenderN { get; set; }

        public int NationalityCountryID { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string ImagePath { get; set; }

        public clsCountry countryInfo;

        public int Age
        {
            get { return DateTime.Now.Year - DateOfBirth.Year; }
        }

        public clsPerson(int personID, string nationalNo, string firstName, string secondName, string thirdName, string lastName,
               DateTime dateOfBirth, string gender, int nationalityCountryID, string address, string phone, string email, string imagePath)
        {

            this.PersonID = personID;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.ImagePath = imagePath;
            this.countryInfo = clsCountry.GetCountryInfoByID(nationalityCountryID);

            this.Mode = enMode.Update;

        }

        public clsPerson()
        {

            this.Mode = enMode.AddNew;

        }

        static public DataTable GetAllPeople()
        {

            return clsPersonData.GetAllPeople();

        }

        static public clsPerson GetPersonInfoByID(int PersonID)
        {

            string nationalNo = ""; string firstName = ""; string secondName = ""; string thirdName = ""; string lastName = "";
            DateTime dateOfBirth = DateTime.Now; string gender = ""; int nationalityCountryID = -1; string address = ""; string phone = ""; string imagePath = "";
            string email = "";

            bool isFound = clsPersonData.GetPersonInfoByID(PersonID, ref nationalNo, ref firstName, ref secondName, ref thirdName, ref lastName,
                ref dateOfBirth, ref gender, ref nationalityCountryID, ref address, ref phone, ref email, ref imagePath);

            if (isFound)
            {

                return new clsPerson(PersonID ,nationalNo, firstName, secondName, thirdName, lastName, dateOfBirth, gender,
                       nationalityCountryID, address, phone, email, imagePath);

            }
            else
                return null;

        }

        static public int GetPersonIDByNationalNo(string nationalNo)
        {

            return clsPersonData.GetPersonIDByNationalNo(nationalNo);

        }

        private bool _AddNewPerson()
        {

            this.PersonID = clsPersonData.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.DateOfBirth, this.GenderN, this.NationalityCountryID, this.Address, this.Phone, this.Email, this.ImagePath);

            return this.PersonID != -1;

        }

        private bool _UpdatePersonInfo()
        {

            return clsPersonData.UpdatePersonInfo(this.PersonID, this.NationalNo, this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.DateOfBirth, this.GenderN, this.NationalityCountryID, this.Address,
                this.Phone, this.Email, this.ImagePath);

        }

        public bool Save()
        {

            switch (this.Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewPerson())
                        {
                            this.Mode = enMode.Update;
                            return true;
                        }
                        else { return false; }

                    }

                case enMode.Update:
                    return _UpdatePersonInfo();

            }

            return false;

        }

        static public bool DeletePerson(int PersonID)
        {

            return clsPersonData.DeletePerson(PersonID);

        }

        static public bool IsPersonExists(string nationalNo)
        {

            return clsPersonData.IsPersonExists(nationalNo);

        }

        static public bool IsPersonExists(int personID)
        {

            return clsPersonData.IsPersonExists(personID);

        }

    }
}
