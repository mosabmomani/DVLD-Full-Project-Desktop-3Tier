using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DataAccessLayer
{
    public class clsApplicatoinData
    {
        public static DataTable GetAllApplication()
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = "select * from Applications";
            SqlCommand command = new SqlCommand(Query, connection);
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader);

            }
            catch (Exception exception){ clsEventLog.CreateEventLog(exception);}
            finally { connection.Close(); }
            return table;
        }
        public static bool DeleteApplication(int ApplicationID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Delete From Applications
                            where ApplicationID=@ApplicationID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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
        public static bool Find(int ApplicationID,ref int ApplicantPersonID,ref DateTime ApplicationDate
          ,ref int ApplicationTypeID,ref byte ApplicationStatus,ref DateTime LastStatusDate
            ,ref decimal PaidFees,ref int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from Applications 
                           where ApplicationID =@ApplicationID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception exception){ clsEventLog.CreateEventLog(exception);}
            finally { connection.Close(); }
            return isFound;
        }

        public static int AddNewApplication( int ApplicantPersonID,DateTime ApplicationDate
          , int ApplicationTypeID,byte ApplicationStatus,DateTime LastStatusDate
            , decimal PaidFees,int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Insert Into Applications
            (ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus
             ,LastStatusDate,PaidFees,CreatedByUserID)
            Values (@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus
             ,@LastStatusDate,@PaidFees,@CreatedByUserID);
            select SCOPE_IDENTITY()";
            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            
            int ApplicationID = 0;
            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertAt))
                {
                    ApplicationID = InsertAt;
                }

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return ApplicationID;
        }

        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID,DateTime ApplicationDate
          ,int ApplicationTypeID,byte ApplicationStatus,DateTime LastStatusDate
           ,decimal PaidFees,int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Update Applications
                         set
               ApplicantPersonID=@ApplicantPersonID,ApplicationDate=@ApplicationDate
           ,ApplicationTypeID=@ApplicationTypeID,ApplicationStatus=@ApplicationStatus
             ,LastStatusDate=@LastStatusDate,PaidFees=@PaidFees,CreatedByUserID=@CreatedByUserID
              where ApplicationID = @ApplicationID";

            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@ApplicantPersonID",ApplicantPersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
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
        public static int HasActiveApplication(int PersonID,int ApplicationStutas,int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"SELECT Applications.ApplicationID
            FROM     Applications INNER JOIN
            LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
            where LocalDrivingLicenseApplications.LicenseClassID =@LicenseClassID And 
            ApplicantPersonID=@ApplicantPersonID and ApplicationStatus =@ApplicationStatus";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStutas);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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
        public static bool CancelApplication(int ApplicationID,Byte ApplicationStatus)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Update Applications
         set ApplicationStatus=@ApplicationStatus, LastStatusDate=GETDATE()
                            where ApplicationID=@ApplicationID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
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
        public static bool CompletedApplication(int ApplicationID, Byte ApplicationStatus)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Update Applications 
          set ApplicationStatus=@ApplicationStatus,LastStatusDate=GETDATE()
                            where ApplicationID=@ApplicationID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
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
