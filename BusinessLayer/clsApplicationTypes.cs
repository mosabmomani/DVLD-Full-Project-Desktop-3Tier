using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsApplicationTypes
    {
      public int ApplicationID {  get; set; }
       public String ApplicationTypeTitle { get; set; }
       public decimal ApplicationFees { get; set; }

        public clsApplicationTypes() {
            ApplicationID=0; 
            ApplicationTypeTitle = "";
            ApplicationFees = 0;
        }
        private clsApplicationTypes(int ApplicationID, String ApplicationTypeTitle
            , decimal ApplicationFees)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicationTypeTitle =ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }

        public static DataTable GetApplicationTypes()
        {
            return clsApplicationTypesData.GetApplicationTypes();
        }
        public static clsApplicationTypes Find(int ApplicationID)
        {
            String ApplicationTypeTitle = "";
            decimal ApplicationFees = 0;
            if (clsApplicationTypesData.Find(ApplicationID,ref ApplicationTypeTitle,ref ApplicationFees))
            {
                return new clsApplicationTypes(ApplicationID,ApplicationTypeTitle,ApplicationFees);
            }
            return null;
        }
        public bool Update()
        {
           
            return clsApplicationTypesData.Update(this.ApplicationID, this.ApplicationTypeTitle,this.ApplicationFees);
        }
        public static decimal GetFees(int ApplicationTypeID)
        {
            return clsApplicationTypesData.GetFees(ApplicationTypeID);
        }


    }
}
