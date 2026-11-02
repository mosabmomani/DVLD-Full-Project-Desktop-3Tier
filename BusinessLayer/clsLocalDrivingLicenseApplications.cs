using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLocalDrivingLicenseApplications
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        private enum Mode { AddMode = 1, UpdateMode = 2 }
        private Mode _mode = Mode.UpdateMode;

        public clsLocalDrivingLicenseApplications()
        {
            LocalDrivingLicenseApplicationID = 0;
            ApplicationID = 0;
            LicenseClassID = 0;
           
            _mode = Mode.AddMode;
        }
        private clsLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID,
            int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID= LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
           this.LicenseClassID = LicenseClassID;
            _mode = Mode.UpdateMode;
        }
        public static DataTable GetLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationsData.GetLocalDrivingLicenseApplications();
        }
        public static DataTable GetAllLocalLicenseForTheDriver(int DriverID)
        {
         return clsLocalDrivingLicenseApplicationsData.GetAllLocalLicenseForTheDriver(DriverID);
        }
        public static clsLocalDrivingLicenseApplications Find(
            int localDrivingLicenseApplicationID)
        {
            int applicationID = 0;
            int licenseClassID = 0;


            if (clsLocalDrivingLicenseApplicationsData.Find(
                localDrivingLicenseApplicationID, ref applicationID, ref licenseClassID))
            {

                return new clsLocalDrivingLicenseApplications
                    (localDrivingLicenseApplicationID, applicationID, licenseClassID);
            }

            return null;


        }
        public static clsLocalDrivingLicenseApplications FindByApplicationID(
            int ApplicationID)
        {
            int localDrivingLicenseApplicationID = 0;
            int licenseClassID = 0;


            if (clsLocalDrivingLicenseApplicationsData.FindByApplicationID(
                ApplicationID, ref  localDrivingLicenseApplicationID, ref licenseClassID))
            {

                return new clsLocalDrivingLicenseApplications
                    (localDrivingLicenseApplicationID, ApplicationID, licenseClassID);
            }

            return null;


        }
        private bool AddNewApplication()
        {
            return (this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationsData
                .AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID)) > 0;

        }
        private bool UpdateApplication()
        {
            return clsLocalDrivingLicenseApplicationsData.UpdateApplication(
            this.LocalDrivingLicenseApplicationID,this.ApplicationID, this.LicenseClassID);
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

        public static bool DeleteApplication(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsData.DeleteApplication
                (LocalDrivingLicenseApplicationID);
        }



    }
}
