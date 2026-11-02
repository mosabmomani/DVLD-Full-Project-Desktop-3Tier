using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsLicensesData
    {
        public static bool Find(int LicenseID,ref int ApplicationID
          , ref int DriverID, ref int LicenseClass, ref DateTime IssueDate
          ,ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees
           ,ref bool IsActive,ref byte IssueReason,ref int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from Licenses
                           where LicenseID= @LicenseID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            bool IsFound = false;
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    if (reader["Notes"] == DBNull.Value)
                    {
                        Notes = "";
                    }
                    else
                    {
                        Notes = (string)reader["Notes"];
                    }
                    PaidFees = (decimal)reader["PaidFees"];
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    
                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return IsFound;

        }
        public static bool FindByAppID( int ApplicationID, int LicenseClass,
            ref int LicenseID, ref int DriverID,  ref DateTime IssueDate
         , ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees
          , ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from Licenses
             where ApplicationID= @ApplicationID and LicenseClass=@LicenseClass";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            bool isfound = false;
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    LicenseID = (int)reader["LicenseID"];
                    DriverID = (int)reader["DriverID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    if (reader["Notes"] == DBNull.Value)
                    {
                        Notes = "";
                    }
                    else
                    {
                        Notes = (string)reader["Notes"];
                    }
                    PaidFees = (decimal)reader["PaidFees"];
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    isfound = true;
                }
                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return isfound;

        }
        public static bool DeleteLicenses(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Delete From Licenses
                           where LicenseID= @LicenseID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            int RowsAffected = -1;
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return RowsAffected > 0;
        }
        public static int AddNewLicenses(int ApplicationID,int DriverID
            ,int LicenseClass,DateTime IssueDate, DateTime ExpirationDate, string Notes
            , decimal PaidFees, bool IsActive, byte IssueReason,int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Insert Into Licenses
           (ApplicationID,DriverID,LicenseClass,IssueDate,ExpirationDate,Notes
            ,PaidFees,IsActive,IssueReason,CreatedByUserID)
            Values (@ApplicationID,@DriverID,@LicenseClass,@IssueDate,@ExpirationDate,@Notes
            ,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID);
            select SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            if (string.IsNullOrEmpty(Notes))
            {
                Command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            }
            else {
                Command.Parameters.AddWithValue("@Notes",Notes);
            }

            Command.Parameters.AddWithValue("@PaidFees", PaidFees);  
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            int AID = 0;
            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertAt))
                {
                    AID = InsertAt;
                }

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return AID;
        }
        public static bool UpdateLicenses(int LicenseID, int ApplicationID, int DriverID
            , int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes
            , decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Update Licenses
           set ApplicationID= @ApplicationID,DriverID=@DriverID,LicenseClass=@LicenseClass
          ,IssueDate=@IssueDate,ExpirationDate=@ExpirationDate,Notes=@Notes,PaidFees=@PaidFees
           ,IsActive=@IsActive,IssueReason=@IssueReason,CreatedByUserID=@CreatedByUserID
             where LicenseID=@LicenseID";

            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            if (Notes == "")
            {
                Command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            }
            else
            {
                Command.Parameters.AddWithValue("@Notes", Notes);
            }

            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            int RowsAffected = 0;

            try
            {
                connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }
        public static int HasAnActiveLicense(int DriverID, int LicenseClass)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"SELECT LicenseID FROM Licenses
            where DriverID =@DriverID And LicenseClass=@LicenseClass and IsActive =1";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            
            int FoundAt = 0;

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    FoundAt = ID;
                }

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return FoundAt;

        }
        public static bool DeactivateLicense(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Update Licenses 
                           set IsActive=0
                           where LicenseID= @LicenseID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            
            int RowsAffected = -1;
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return RowsAffected > 0;
        }

    }
}
