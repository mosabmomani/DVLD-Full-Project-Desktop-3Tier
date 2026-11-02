using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class clsDriverData
    {
        static public bool FindDriver(int driverID,ref int PersonID,ref int CreatedByUserID,ref DateTime CreatedDate)
        {
            SqlConnection connection=new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from Drivers
                           where DriverID=@DriverID";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DriverID", driverID);
            bool IsFound=false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return IsFound;

        }
        static public int GetDriverIDByPersonID(int PersonID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select driverID from Drivers
                           where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            int FoundAt = 0;
            try
            {
                connection.Open();
                object Result =command.ExecuteScalar();
                if(Result != null&&int.TryParse(Result.ToString(),out int ID))
                {
                    FoundAt= ID;
                }
                
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return FoundAt;

        }

        public static bool IsExist(int DriverID)
        {
            SqlConnection connection=new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select DriverID from Drivers
                           where DriverID=@DriverID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            int IsFound = 0;

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result!=null&&int.TryParse(Result.ToString(),out int ID))
                {
                    IsFound = ID;
                }

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return IsFound > 0;
        }

        static public DataTable GetAllDriver()
        {
            DataTable data=new DataTable();
            SqlConnection connection =new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from Drivers_View";
            SqlCommand command= new SqlCommand(Query, connection);
            try
            {
                connection.Open();
               SqlDataReader reader = command.ExecuteReader();
                
                data.Load(reader);

              reader.Close(); 

            }catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }

            return data;

        }

        public static bool IsPersonUsed(int PersonID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select PersonID from Drivers
                         where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            int IsFound = 0;
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    IsFound = ID;
                    
                }

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }


            return IsFound > 0;

        }

        public static bool DeleteDriver(int DriverID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"delete from Drivers
                      where DriverID=@DriverID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("DriverID", DriverID);

            int RowsAffected = 0;

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            SqlConnection connection = new SqlConnection( DataAccessSetting.connectionString);
          
            string Query = @"Insert Into Drivers
            (PersonID, CreatedByUserID,CreatedDate)
            Values (@PersonID, @CreatedByUserID,@CreatedDate);
             select SCOPE_IDENTITY()";

            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            int DriverID = 0;

            try
            {
                connection.Open();
                object Result= command.ExecuteScalar();
                if (Result != null&&int.TryParse(Result.ToString(),out int InsertAt)) {
                    DriverID = InsertAt;
                }

            }catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return DriverID;
        }

        public static bool UpdateDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            SqlConnection connection =new SqlConnection( DataAccessSetting.connectionString);
           
            string Query = @"Update Drivers set 
                (PersonID=@PersonID, CreatedByUserID=@CreatedByUserID,CreatedDate=@CreatedDate)  
                 where DriverID=@DriverID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            int RowsAffected = 0;

            try
            {
                connection.Open();
                RowsAffected=command.ExecuteNonQuery();
            }
            catch (Exception exception) {clsEventLog.CreateEventLog(exception);}
            finally { connection.Close(); }
            return RowsAffected > 0;
        }
    }
}
