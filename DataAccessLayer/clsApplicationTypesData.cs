using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataAccessLayer
{
    public class clsApplicationTypesData
    {
        public static DataTable GetApplicationTypes()
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = "select * from ApplicationTypes";
            SqlCommand command = new SqlCommand(Query, connection);
            DataTable dataTable=new DataTable();
            try
            {
                connection.Open();
               SqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
              
                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception);}
            finally { connection.Close(); }
            return dataTable;
        }

        public static bool Find(int ApplicationID,ref string ApplicationTitle,ref decimal fee)
        {
            SqlConnection connection=new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from ApplicationTypes 
                           where ApplicationTypeID=@ApplicationTypeID";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationID);
            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    ApplicationTitle = (string)reader["ApplicationTypeTitle"];
                    fee = (decimal)reader["ApplicationFees"];
                    isFound= true;
                }
                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception);}
            finally { connection.Close(); }
            return isFound;
        }

        public static bool Update(int ApplicationID ,string ApplicationTypeTitle,
           decimal ApplicationFees)
        {
            SqlConnection connection =new SqlConnection(DataAccessSetting.connectionString);
            String Query = @"Update ApplicationTypes set 
                    ApplicationTypeTitle=@ApplicationTypeTitle,
                       ApplicationFees=@ApplicationFees
                         where ApplicationTypeID=@ApplicationTypeID";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

            int RowsAffected = 0;
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception exception)
            {
                clsEventLog.CreateEventLog(exception);
            }
            finally { connection.Close(); }
            return RowsAffected > 0;
        }
        public static decimal GetFees(int ApplicationTypeID)
        {
            SqlConnection Connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select ApplicationFees from ApplicationTypes 
                          where ApplicationTypeID=@ApplicationTypeID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            decimal Fees = -1;
            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && decimal.TryParse(Result.ToString(), out decimal AFees))
                {
                    Fees = AFees;
                }


            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { Connection.Close(); }

            return Fees ;



        }
    }
}
