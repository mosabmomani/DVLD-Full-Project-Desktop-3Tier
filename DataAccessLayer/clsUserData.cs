using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsUserData
    {
        public static bool FindUser(string Username, string Password, ref int Userid, ref int
            PersonID, ref bool IsActive)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from Users
          where UserName= @Username and Password= @Password";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            bool isFound=false;
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Userid = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["isActive"];
                    isFound=true;
                }
                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return isFound;

        }

        public static bool FindUser(int UserID,ref string Username,ref string Password, ref int
          PersonID, ref bool IsActive)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from Users
          where UserID= @UserID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            
            bool isFound = false;
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                   Username=(string)reader["UserName"];
                    Password=(string)reader["Password"];    
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["isActive"];
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return isFound;

        }

        public static bool IsExist(int UserID)
        {
            SqlConnection connection=new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select UserID from Users
            where  UserID=@UserID";

            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            int IsFound=0;

            try
            {
                connection.Open();
                object Result= command.ExecuteScalar();
                if (Result != null&&int.TryParse(Result.ToString(),out int ID)) { 
                IsFound=ID;
                }

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }

            return IsFound>0;

        }
        public static DataTable GetAllUsers()
        {
            DataTable table = new DataTable();
            SqlConnection connection=new SqlConnection(DataAccessSetting.connectionString);
            string Query = "select * from UsersView";
            SqlCommand command= new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
               
                    table.Load(reader);
               
                reader.Close();

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); } 



            return table;
        }

        public static bool IsPersonUesd(int PersonID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select PersonID from Users
                         where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            int IsFound=0;
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null&&int.TryParse(Result.ToString(),out int ID )) {
                    IsFound = ID;
                }

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }


            return IsFound>0;

        }
        public static bool IsUsernameUesd(string Username)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select Found=1 from Users
                         where Username=@Username";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            int IsFound = 0;
            try
            {
                connection.Open();
                object Resoult = command.ExecuteScalar();
                if (Resoult != null && int.TryParse(Resoult.ToString(), out int ID))
                {
                    IsFound = ID;
                }

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }


            return IsFound > 0;

        }
        public static int AddNewUser(string Username,string Password,int PersonID,bool IsActive)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Insert Into Users
(PersonID,Username,Password,IsActive)
Values (@PersonID,@Username,@Password,@IsActive);
select SCOPE_IDENTITY()";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue ("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@username", Username);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            int UserID = 0;
            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertAt)) { 
                UserID = InsertAt;
                }

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return UserID;
        }

        public static bool UpdateUser(int UserID, string Username, string Password, int PersonID, bool IsActive)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Update Users
                         set
               PersonID=@PersonID,Username=@Username,Password=@Password,IsActive=@IsActive
               where UserID=@UserID;";

            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@username", Username);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);

            int RowsAffected = 0;

            try
            {
                connection.Open();
                RowsAffected=Command.ExecuteNonQuery();

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }
        public static bool DeleteUser(int UserID) { 
        SqlConnection connection=new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"delete from Users
                      where UserID=@UserID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("UserID", UserID);

            int RowsAffected = 0;

            try
            {
                connection.Open();
                RowsAffected=command.ExecuteNonQuery();

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }

         return RowsAffected > 0; 
        }


    }
}