using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsTestType
    {

        public enum enTestType { VisionTest = 1, WrittenTest  = 2, StreetTest = 3}

        public int TestTypeID {  get; private set; }

        public string Title { get; set; }

        public string Description { get; set; }


        private decimal? _fees;

        public decimal? Fees
        {
            get { return _fees; }

            set
            {
                if (value >= 0)
                {
                    _fees = value;
                }
                else
                {
                    _fees = null;
                }
            }
        }

        public clsTestType(int testTypeID, string title, string description, decimal ?fees)
        {

            this.TestTypeID = testTypeID;
            this.Title = title;
            this.Description = description;
            this.Fees = fees;

        }

        static public DataTable GetAllTestTypes()
        {

            return clsTestTypeData.GetAllTestTypes();

        }

        static public clsTestType GetTestTypeInfoByID(int testTypeID)
        {

            string title = ""; string description = ""; decimal ?fees = null;

            if(clsTestTypeData.GetTestTypeInfoByID (testTypeID, ref title, ref description, ref fees)){

                return new clsTestType(testTypeID, title, description, fees);

            }
            return null;

        }

        public bool UpdateTestType()
        {

            return clsTestTypeData.UpdateTestType(this.TestTypeID, this.Title, this.Description, this.Fees);

        } 

    }

}
