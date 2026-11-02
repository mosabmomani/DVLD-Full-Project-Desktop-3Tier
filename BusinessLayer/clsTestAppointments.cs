using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTestAppointments
    {
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked {  get; set; }

        private enum Mode { AddMode = 1, UpdateMode = 2 }
        private Mode _mode = Mode.UpdateMode;

        public clsTestAppointments()
        {
            TestAppointmentID = 0;
            TestTypeID = 0;
            LocalDrivingLicenseApplicationID= 0;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = 0;
            IsLocked = false;
            _mode = Mode.AddMode;
        }
        private clsTestAppointments(int TestAppointmentID, int TestTypeID
            , int LocalDrivingLicenseApplicationID, DateTime AppointmentDate
            , decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.CreatedByUserID = CreatedByUserID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            _mode = Mode.UpdateMode;
        }
        public static DataTable GetAppointmentsShort(int LDLA,int TestType)
        {
            return clstestAppointmentsData.GetShortTestAppointments(LDLA,TestType);
        }
        public static clsTestAppointments Find(int TestAppointmentID)
        {

          int TestTypeID = 0;
          int LocalDrivingLicenseApplicationID = 0;
          DateTime  AppointmentDate = DateTime.Now;
          decimal  PaidFees = 0;
          int  CreatedByUserID = 0;
          bool  IsLocked = false;
          

            if (clstestAppointmentsData.Find(TestAppointmentID,ref TestTypeID
            ,ref LocalDrivingLicenseApplicationID,ref AppointmentDate
            ,ref PaidFees,ref CreatedByUserID,ref IsLocked))
            {

                return new clsTestAppointments(TestAppointmentID, TestTypeID
            ,LocalDrivingLicenseApplicationID, AppointmentDate,PaidFees,
            CreatedByUserID,IsLocked);
            }

            return null;


        }

        private bool AddNewAppointment()
        {
            return (this.TestAppointmentID = clstestAppointmentsData
                .AddNewAppointment(this.TestTypeID
            ,this.LocalDrivingLicenseApplicationID,this.AppointmentDate
            ,this.PaidFees,this.CreatedByUserID,this.IsLocked)) > 0;

        }
        private bool UpdateAppointment()
        {
            return clstestAppointmentsData.UpdateAppointment(
            this.TestAppointmentID, this.TestTypeID
            , this.LocalDrivingLicenseApplicationID, this.AppointmentDate
            , this.PaidFees, this.CreatedByUserID, this.IsLocked);
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

        public static bool DeleteAppointment(int TestAppointmentID)
        {
            return clstestAppointmentsData.DeleteAppointment(TestAppointmentID);
        }
        public static bool HaveAnActiveAppointment(int LDLID, int TestType)
        {
            return clstestAppointmentsData.HaveAnActiveAppointment(LDLID, TestType);
        }
        public static bool SetAppointmentLocked(int TestAppointmentID)
        {
            return clstestAppointmentsData.SetAppointmentLocked(TestAppointmentID);
        }
    }
}
