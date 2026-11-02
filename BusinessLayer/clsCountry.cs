using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLogic
{
    public class clsCountry
    {
        
            public static DataTable GetAllCountries()
            {
                return clsDataCountry.GetAllCountries();
            }
            public static string GetCountryName(int CountryID)
            {
                return clsDataCountry.GetCountryName(CountryID);
            }
        
    }
}
