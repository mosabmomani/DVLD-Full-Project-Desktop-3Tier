using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsApplication
    {
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        private enum Mode { AddMode = 1, UpdateMode = 2 }
        private Mode _mode = Mode.UpdateMode;

       public clsApplication()
        {
            ApplicationID = 0;
            ApplicantPersonID = 0;
            ApplicationDate = DateTime.Now;
            CreatedByUserID = 0;
            ApplicationTypeID = 0;
            ApplicationStatus = 0;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID=clsGlobal.CurrentUser.UserID;
            _mode = Mode.AddMode;
        }
       private clsApplication(int ApplicationID,int ApplicantPersonID, DateTime ApplicationDate
          , int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate
            , decimal PaidFees, int CreatedByUserID)
        {
           this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.CreatedByUserID = CreatedByUserID;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            _mode = Mode.UpdateMode;
        }
        public static clsApplication Find(int ApplicationID)
        {
            
            int ApplicantPersonID = 0;
            DateTime ApplicationDate = DateTime.Now;
            int CreatedByUserID = clsGlobal.CurrentUser.UserID;
            int ApplicationTypeID = 0;
            byte ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.Now;
            decimal PaidFees = 0;

            if (clsApplicatoinData.Find(ApplicationID, ref ApplicantPersonID,ref ApplicationDate
                ,ref ApplicationTypeID,ref ApplicationStatus,ref LastStatusDate,ref PaidFees,ref CreatedByUserID))
            {

                return new clsApplication(ApplicationID,ApplicantPersonID,ApplicationDate
                ,ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID);
            }

            return null;


        }

        public static int HasActiveApplication(int PersonID, int ApplicationStutas, int LicenseClassID)
        {
            return clsApplicatoinData.HasActiveApplication(PersonID, ApplicationStutas, LicenseClassID);
        }


        public static DataTable GetAllApplication()
        {
            return clsApplicatoinData.GetAllApplication();
        }

        private bool AddNewApplication()
        {
            return (this.ApplicationID = clsApplicatoinData.AddNewApplication(this.ApplicantPersonID,
                this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus,
                this.LastStatusDate,this.PaidFees,this.CreatedByUserID)) > 0;

        }
        private bool UpdateApplication()
        {
            return clsApplicatoinData.UpdateApplication (this.ApplicationID,this.ApplicantPersonID,
                this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus,
                this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case Mode.AddMode:
                    if (AddNewApplication())
                    {
                        _mode = Mode.UpdateMode;
                        return true;
                    }
                    else { return false; }
                case Mode.UpdateMode:

                    return UpdateApplication();

            }
            return false;
            
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            return clsApplicatoinData.DeleteApplication(ApplicationID);
        }
        public static bool CancelApplication(int ApplicationID,byte ApplicatoinStutas)
        {
            return clsApplicatoinData.CancelApplication(ApplicationID,ApplicatoinStutas);
        }
        public static bool CompletedApplication(int ApplicationID, Byte ApplicationStatus)
        {
            return clsApplicatoinData.CompletedApplication(ApplicationID,ApplicationStatus);
        }
    }
}
