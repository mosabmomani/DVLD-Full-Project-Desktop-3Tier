using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTests
    {
       public int TestID  {  get; set; }
       public int TestAppointmentID { get; set; }
       public bool TestResult {  get; set; }
       public string Notes { get; set; }
       public int CreatedByUserID {  get; set; }

        public clsTests()
        {
            this.TestID = 0;
            this.TestAppointmentID = 0;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = 0;
        }
        private clsTests(int TestID,int TestAppointmentID, bool TestResult
           , string Notes, int CreatedByUserID) { 

            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult=TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
        
        }
        public bool AddNewTest()
        {
            return (this.TestID = clsTestsData.AddNewTest(this.TestAppointmentID
                ,this.TestResult ,this.Notes, this.CreatedByUserID)) > 0;
        }
        public static bool PassedTheTest(int LDLID, int TestTypeID)
        {
            return clsTestsData.PassedTheTest(LDLID,TestTypeID);
        }

        public static clsTests Find(int TestID)
        {

            int testAppointmentID = 0;
            bool testResult = false;
            string notes = "";
            int createdByUserID = 0;


            if (clsTestsData.Find(TestID,ref testAppointmentID, ref testResult
            , ref notes, ref createdByUserID))
            {

                return new clsTests(TestID,testAppointmentID, testResult
            ,notes, createdByUserID);
            }

            return null;


        }
    }
    }

