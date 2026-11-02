using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsDataCountry
    {
  
        public static DataTable GetAllCountries()
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = "Select * from countries";
            SqlCommand command = new SqlCommand(Query, connection);
            DataTable tablecountry = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                tablecountry.Load(reader);
            }
            catch (Exception ex) { clsEventLog.CreateEventLog(ex); }
            finally { connection.Close(); }
            return tablecountry;
        }
        public static string GetCountryName(int countryID) {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Select CountryName from countries
              where CountryID=@CountryID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CountryID", countryID);
            string countryname = "";
            try
            {
                connection.Open();
               object name=command.ExecuteScalar();
                if (name!=null) { 
                countryname = Convert.ToString(name);
                }

            }
            catch (Exception ex) {clsEventLog.CreateEventLog(ex);}
            finally { connection.Close(); }

            return countryname;
        }
    }
}
