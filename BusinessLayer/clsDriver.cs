using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsDriver
    {
        public int DriverID {  get; set; }
        public int PersonID {  get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        private enum Mode { AddMode=1, UpdateMode=2}
        private Mode _mode=Mode.UpdateMode;

       public clsDriver() { 
        DriverID = 0;
        PersonID = 0;
        CreatedByUserID = 0;
        CreatedDate = DateTime.Now;
        _mode = Mode.AddMode;    
        }
       private clsDriver(int driverID,int personID,int CreatedBy,DateTime date) { 
        this.DriverID = driverID;
            this.PersonID=personID;
            this.CreatedByUserID = CreatedBy;
            this.CreatedDate = date;
            _mode=Mode.UpdateMode;
        }
        public static DataTable GetAllDrivers()
        {
            return clsDriverData.GetAllDriver();
        }
        public static bool IsPersonUsed(int PersonID)
        {
            return clsDriverData.IsPersonUsed(PersonID);
        }
        public static clsDriver Find(int DriverID)
        {
            int personID = 0; int createdByUserID = 0 ;DateTime createdDate=DateTime.Now;
            if (clsDriverData.FindDriver(DriverID,ref personID,ref createdByUserID,ref createdDate))
            {
                return new clsDriver(DriverID,personID,createdByUserID,createdDate);
            }
            return null;

        }
        static public int GetDriverIDByPersonID(int PersonID)
        {
            return clsDriverData.GetDriverIDByPersonID(PersonID);
        }

        public static bool IsExist(int DrID) {
            return clsDriverData.IsExist(DrID);
        }
        public static bool DeleteDriver(int DriverID) { 
        return clsDriverData.DeleteDriver(DriverID);
        }
        private bool AddNewDriver()
        {
          return(  this.DriverID = clsDriverData.AddNewDriver(this.PersonID,
              this.CreatedByUserID,this.CreatedDate))>0;
        }
        private bool Update()
        {
            return clsDriverData.UpdateDriver(this.DriverID,this.PersonID
                ,this.CreatedByUserID,this.CreatedDate);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case Mode.AddMode:
                    if (AddNewDriver())
                    {
                        _mode=Mode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                    
                case Mode.UpdateMode:
                    return Update();
            }
            return false;
            
            }
    }
}
