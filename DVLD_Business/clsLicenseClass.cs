using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsLicenseClass
    {
        public int LicenseClassID { get; }
        public string ClassName { get; }
        public string ClassDescription { get; }
        public byte MinimumAllowedAge { get; }
        public byte DefaultValidityLength { get; }
        public decimal ClassFees { get; }

        public clsLicenseClass(int licenseClassID, string className, string classDescription,
            byte minimumAllowedAge, byte defaultValidityLength, decimal classFees)
        {

            LicenseClassID = licenseClassID;
            ClassName = className;
            ClassDescription = classDescription;
            MinimumAllowedAge = minimumAllowedAge;
            DefaultValidityLength = defaultValidityLength;
            ClassFees = classFees;

        }

        static public List<string> GetAllLicenseClassesName()
        {


            return clsLicenseClassData.GetAllLicenseClassesName();

        }

        static public int GetLicenseClassIDByName(string className)
        {

            return clsLicenseClassData.GetLicenseClassIDByName(className);

        }

        static public clsLicenseClass GetLicenseClassInfoByID(int licenseClassID)
        {

            string className = "";
            string classDescription = "";
            byte minimumAllowedAge = 0; 
            byte defaultValidityLength = 0;
            decimal classFees = 0;

            if (clsLicenseClassData.GetLicenseClassInfoByID(licenseClassID, ref className, ref classDescription, ref minimumAllowedAge, ref defaultValidityLength, ref classFees))
            {
               
                return new clsLicenseClass(licenseClassID, className, classDescription, minimumAllowedAge, defaultValidityLength, classFees);


            }
            return null;


        }
    }
}
