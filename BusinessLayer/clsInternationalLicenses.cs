using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLayer
{
    public class clsInternationalLicenses
    {
       public int InternationalLicenseID {  get; set; }
       public int ApplicationID {  get; set; }
       public int DriverID {  get; set; }
       public int IssuedUsingLocalLicenseID {  get; set; }
       public DateTime IssueDate {  get; set; }
       public DateTime ExpirationDate {  get; set; }
       public bool IsActive {  get; set; }
       public int CreatedByUserID {  get; set; }

        public clsInternationalLicenses()
        {
            this.InternationalLicenseID=0;
            this.ApplicationID =0;
            this.DriverID =0;
            this.IssuedUsingLocalLicenseID =0;
            this.IssueDate =DateTime.Now;
            this.ExpirationDate =DateTime.Now;
            this.IsActive = false;
            this.CreatedByUserID = 0;
        }
        private clsInternationalLicenses(int InternationalLicenseID, int ApplicationID
            ,int DriverID,int UsingLocalLicenseID,DateTime IssueDate
            , DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = UsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
        }
        public static DataTable GetAllInternationalLicenseForTheDriver(int DriverID)
        {
            return clsInternationalLicensesData.
                GetAllInternationalLicenseForTheDriver(DriverID);
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicensesData.GetAllInternationalLicenses();
        }

        public static clsInternationalLicenses Find(
            int InternationalLicenseID)
        {
            int applicationID = 0;
            int driverID= 0;
            int uissuedUsingLocalLicenseID= 0;
            DateTime issueDate =DateTime.Now;
            DateTime expirationDate= DateTime.Now;
            bool isActive = false;
            int createdByUserID = 0;


            if (clsInternationalLicensesData.Find(InternationalLicenseID
            ,ref applicationID, ref driverID , ref uissuedUsingLocalLicenseID
            , ref issueDate, ref expirationDate, ref isActive, ref createdByUserID))
            {

                return new clsInternationalLicenses(InternationalLicenseID
            , applicationID, driverID,uissuedUsingLocalLicenseID
            , issueDate, expirationDate, isActive, createdByUserID);
            }

            return null;


        }
        public bool AddNewInternationalLicense()
        {
           return (this.InternationalLicenseID = clsInternationalLicensesData
           .AddNewInternationalLicense(this.ApplicationID,this.DriverID,this.IssuedUsingLocalLicenseID,
           this.IssueDate,this.ExpirationDate,this.IsActive,this.CreatedByUserID)) > 0;

        }
        public static int HaveAnActiveInternationalLicense(int DriverID)
        {
            return clsInternationalLicensesData.HaveAnActiveInternationalLicense(DriverID);
        }
    }
}
