using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLicenses
    {
        public int LicenseID {  get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }
        private enum Mode { AddMode = 1, UpdateMode = 2 }
        private Mode _mode = Mode.UpdateMode;

        public clsLicenses()
        {
            this.LicenseID = 0;
            this.ApplicationID = 0;
            this.DriverID = 0;
            this.LicenseClass = 0;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = false;
            this.IssueReason = 0;
            this.CreatedByUserID = 0;
            _mode = Mode.AddMode;
        }
        private clsLicenses(int LicenseID, int TestAppointmentID
          , int DriverID, int LicenseClass,  DateTime IssueDate
          ,     DateTime ExpirationDate, string Notes, decimal PaidFees
           , bool IsActive, byte IssueReason, int CreatedByUserID) {
            this.LicenseID = LicenseID;
            this.ApplicationID = TestAppointmentID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees= PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            _mode = Mode.UpdateMode;
        }
        public static clsLicenses Find(int LicenseID)
        {
            int ApplicationID = 0;
            int DriverID = 0;
            int LicenseClass = 0;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = 0;
            if(clsLicensesData.Find(LicenseID,ref ApplicationID,ref DriverID,ref LicenseClass
                ,ref IssueDate,ref ExpirationDate,ref Notes,ref PaidFees,ref IsActive
                ,ref IssueReason,ref CreatedByUserID))
            {
                return new clsLicenses(LicenseID, ApplicationID, DriverID, LicenseClass
                , IssueDate, ExpirationDate, Notes, PaidFees, IsActive
                , IssueReason, CreatedByUserID);
            }
            return null;
        }
        public static clsLicenses FindByAppID(int ApplicationID,int LicenseClass)
        {
            int licenseID = 0;
            int DriverID = 0;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = 0;
            if (clsLicensesData.FindByAppID(ApplicationID,LicenseClass,ref licenseID, ref DriverID
                , ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive
                , ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicenses(licenseID, ApplicationID, DriverID, LicenseClass
                , IssueDate, ExpirationDate, Notes, PaidFees, IsActive
                , IssueReason, CreatedByUserID);
            }
            return null;
        }
        private bool AddNewAppointment()
        {
            return (this.LicenseID = clsLicensesData.AddNewLicenses (this.ApplicationID
            ,this.DriverID,this.LicenseClass,this.IssueDate,this.ExpirationDate,this.Notes
            ,this.PaidFees,this.IsActive,this.IssueReason,this.CreatedByUserID)) > 0;

        }
        private bool UpdateAppointment()
        {
            return clsLicensesData.UpdateLicenses(this.LicenseID,this.ApplicationID
            ,this.DriverID, this.LicenseClass,this.IssueDate, this.ExpirationDate,this.Notes
            , this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case Mode.AddMode:
                    if (AddNewAppointment())
                    {
                        _mode = Mode.UpdateMode;
                        return true;
                    }
                    else { return false; }
                case Mode.UpdateMode:

                    return UpdateAppointment();

            }
            return false;
        }

        public static bool DeleteLicense(int LicenseID)
        {
            return clsLicensesData.DeleteLicenses(LicenseID);
        }
        public static int HaveAnActiveLicense(int DriverID, int LicenseClass)
        {
            return clsLicensesData.HasAnActiveLicense(DriverID, LicenseClass);
        }
        public static bool DeactiveLicense(int LicenseID)
        {
            return clsLicensesData.DeactivateLicense(LicenseID);
        }


    }
}
