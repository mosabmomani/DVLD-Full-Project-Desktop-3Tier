using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsSuspendLicenses
    {
        public enum enmode { AddNew=0, Update=1}
        public enmode Mode = enmode.AddNew;

        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public clsUser ReleasedByUserInfo { get; set; }
        public int ReleaseApplicationID { get; set; }

       public clsSuspendLicenses() {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate =System.DateTime.Now;
            this.FineFees=0;
            this.CreatedByUserID=-1;
            this.IsReleased = false;
            this.ReleaseDate=DateTime.MaxValue;
            this.ReleasedByUserID=-1;
            this.ReleaseApplicationID=-1;
            Mode = enmode.AddNew;
        }
      private  clsSuspendLicenses (int DetainID, int LicenseID, DateTime DetainDate,
            decimal FineFees, int CreatedByUserID, bool IsReleased,
            DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo=clsUser.Find(CreatedByUserID);
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleasedByUserInfo = clsUser.Find(ReleasedByUserID);
            this.ReleaseApplicationID = ReleaseApplicationID;
            Mode = enmode.Update;
        }
        public static clsSuspendLicenses Find(int DetainID)
        {
            int licenseID = 0;
            DateTime detainDate = DateTime.Now;
            decimal fineFees = 0;
            int createdByUserID = 0;
            bool isReleased = false;
            DateTime releaseDate = DateTime.MaxValue;
            int releasedByUserID = 0;
            int releaseApplicationID = 0;
            if (clsSuspendLicensesData.FindByID(DetainID, ref licenseID, ref detainDate, ref fineFees
                , ref createdByUserID, ref isReleased, ref releaseDate, ref releasedByUserID, ref releaseApplicationID))
            {
                return new clsSuspendLicenses(DetainID, licenseID, detainDate, fineFees
                , createdByUserID, isReleased, releaseDate, releasedByUserID, releaseApplicationID);
            }
            return null;


        }
        public static clsSuspendLicenses FindByLicense(int LicenseID)
        {
            int detainID = 0;
            DateTime detainDate = DateTime.Now;
            decimal fineFees = 0;
            int createdByUserID = 0;
            bool isReleased = false;
            DateTime releaseDate = DateTime.MaxValue;
            int releasedByUserID = 0;
            int releaseApplicationID = 0;
            if (clsSuspendLicensesData.FindByLicenseID(LicenseID,ref detainID, ref detainDate, ref fineFees
                , ref createdByUserID, ref isReleased, ref releaseDate, ref releasedByUserID, ref releaseApplicationID))
            {
                return new clsSuspendLicenses( detainID, LicenseID, detainDate, fineFees
                , createdByUserID, isReleased, releaseDate, releasedByUserID, releaseApplicationID);
            }
            return null;


        }
        public static DataTable GetAllSuspendLicenses()
        {
            return clsSuspendLicensesData.GetAllSuspendLicenses();
        }
        private bool AddNewSuspendLicense()
        {
            this.DetainID = clsSuspendLicensesData.AddNewSuspendLicense(this.LicenseID
                , this.DetainDate, this.FineFees, this.CreatedByUserID);
            return this.DetainID > 0;

        }
        private bool UpdateSuspendLicense() { 
        return clsSuspendLicensesData.UpdateSuspendedLicense(this.DetainID,this.LicenseID
            ,this.DetainDate,this.FineFees,this.CreatedByUserID);
        
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enmode.AddNew:
                    if (AddNewSuspendLicense())
                    {
                        Mode = enmode.Update;
                        return true;
                    }
                    else { return false; }
                case enmode.Update:

                    return UpdateSuspendLicense();

            }
            return false;
        }
        public static bool IsLicenseSuspended(int LicenseID)
        {
            return clsSuspendLicensesData.IsLicenseSuspended(LicenseID);
        }
        public bool ReleaseSuspendedLicense(int ReleaseByUserID, int ReleaseApplicationID)
        {
            return  clsSuspendLicensesData.ReleaseSuspendedLicense(this.DetainID, ReleaseByUserID , ReleaseApplicationID);
        }
        
    }
}
