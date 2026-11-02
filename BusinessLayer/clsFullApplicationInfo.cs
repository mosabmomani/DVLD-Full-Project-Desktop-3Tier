using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Net.Mime.MediaTypeNames;

namespace BusinessLayer
{
   public class clsFullApplicationInfo
    {
        public int ApplicationID { get; set; }
        public string Status { get; set; }
        public decimal PaidFees { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public string FullName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime LastStatusDate { get; set; }
        public string UserName { get; set; }
        public string ClassName { get; set; }
        public int PassedTestCount { get; set; }
        public int ApplicantPersonID { get; set; }

        clsFullApplicationInfo() {
            ApplicationID=0;
            Status=string.Empty;
            PaidFees=0;
            ApplicationTypeTitle = string.Empty;
            FullName = string.Empty;
            ApplicationDate = DateTime.Now;
            LastStatusDate = DateTime.Now;
            UserName =string.Empty;
            ClassName =string.Empty;
            PassedTestCount = 0;
            ApplicantPersonID = 0;
            
        }
        clsFullApplicationInfo(int ApplicationID, string Status,decimal PaidFees
         ,string ApplicationTypeTitle, string FullName, DateTime ApplicationDate
         ,  DateTime LastStatusDate,string UserName, string ClassName
            , int PassedTestCount,int ApplicantPersonID)
        {
            this.ApplicationID = ApplicationID;
            this.Status = Status;
            this.PaidFees = PaidFees;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.FullName = FullName;
            this.ApplicationDate = ApplicationDate;
            this.LastStatusDate = LastStatusDate;
            this.UserName = UserName;
            this.ClassName = ClassName;
            this.PassedTestCount = PassedTestCount;
            this.ApplicantPersonID= ApplicantPersonID;
        }
        public static clsFullApplicationInfo Find(int ApplicationID)
        {
            string status = string.Empty;
            decimal paidFees = 0;
            string applicationTypeTitle = string.Empty;
            string fullName = string.Empty;
            DateTime applicationDate = DateTime.Now;
            DateTime lastStatusDate = DateTime.Now;
            string userName = string.Empty;
            string className = string.Empty;
            int passedTestCount = 0;
            int applicantPersonID = 0;


            if (FullApplicationInfoData.Find(ApplicationID, ref status, ref paidFees
                , ref applicationTypeTitle, ref fullName, ref applicationDate,
                ref lastStatusDate, ref userName, ref className, ref passedTestCount,ref applicantPersonID))
            {

                return new clsFullApplicationInfo(ApplicationID, status, paidFees
                , applicationTypeTitle, fullName, applicationDate,
               lastStatusDate, userName, className, passedTestCount,applicantPersonID);
            }

            return null;


        }
    }
}
