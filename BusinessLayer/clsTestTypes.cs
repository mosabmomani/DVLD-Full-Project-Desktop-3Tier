using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTestTypes
    {
        public int TestTypeID { get; set; }
        public String TestTypeTitle { get; set; }
        public String TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }

        public clsTestTypes()
        {
            TestTypeID = 0;
            TestTypeTitle = "";
            TestTypeDescription = "";
            TestTypeFees = 0;
        }
        private clsTestTypes(int TestTypeID, String TestTypeTitle
            , String TestTypeDescription, decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
        }

        public static DataTable GetTestTypes()
        {
            return clsTestTypesData.GetTestTypesData();
        }
        public static clsTestTypes Find(int TestTypeID)
        {
            String TestTypeTitle = "";
            string TestTypeDescription = "";
            decimal TestTypeFees = 0;
            if (clsTestTypesData.Find(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
            {
                return new clsTestTypes(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            }
            return null;
        }
        public bool Update()
        {

            return clsTestTypesData.Update(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }
    }
    }
