using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLicenseClasses
    {
        public int LicenseClassID {  get; set; }
        public string LicenseName {  get; set; }
        public string LicenseDescription {  get; set; }
        public byte MinimumAllowedAge {  get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        clsLicenseClasses()
        {
            LicenseClassID = 0;
            LicenseName = string.Empty;
            LicenseDescription = string.Empty;
            MinimumAllowedAge = 0;
            DefaultValidityLength = 0;
            ClassFees = 0;
        }
        clsLicenseClasses(int LCID,string LCN,string LD,byte MAA,byte DVL,decimal CF)
        {
            LicenseClassID = LCID;
            LicenseName = LCN;
            LicenseDescription = LD;
            MinimumAllowedAge=MAA;
            ClassFees=CF;
            DefaultValidityLength = DVL;
        }
        public static DataTable GetLicenseClass()
        {
            return clsLicenseClassData.GetLicenseClassData();
        }
        public static clsLicenseClasses Find(int LCID)
        {

          string  licenseName = string.Empty;
          string  licenseDescription = string.Empty;
          byte  minimumAllowedAge = 0;
          byte defaultValidityLength = 0;
          decimal  classFees = 0;

            if (clsLicenseClassData.Find(LCID, ref licenseName, ref licenseDescription
                , ref minimumAllowedAge, ref defaultValidityLength, ref classFees))
            {

                return new clsLicenseClasses(LCID,  licenseName, licenseDescription
                , minimumAllowedAge, defaultValidityLength, classFees);
            }

            return null;


        }

    }
}
