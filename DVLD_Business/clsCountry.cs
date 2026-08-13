using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsCountry
    {

        public int CountryID { get; private set; }

        public string CountryName { get; set; }

        private clsCountry(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }

        static public DataTable GetAllCountries()
        {

            return clsCountryData.GetAllCountries();

        }

        static public int GetCountryIDByName(string countryName)
        {

            return clsCountryData.GetCountryIDByName(countryName);

        }

        static public clsCountry GetCountryInfoByID(int countryID)
        {

            string countryName = "";

            bool isFound = clsCountryData.GetCountryInfoByID(countryID, ref countryName);

            if (isFound)
            {
               
                return new clsCountry(countryID, countryName);

            }
            return null;


        }
    }
}
