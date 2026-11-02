using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataAccessLayer
{
    public class clsLocalDrivingLicenseApplicationsData
    {

        public static DataTable GetLocalDrivingLicenseApplications()
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = "select * from LocalDrivingLicenseApplications_View";
            SqlCommand command = new SqlCommand(Query, connection);
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);

                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return dataTable;
        }
        public static DataTable GetAllLocalLicenseForTheDriver(int DriverID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from LocalLicesnesView
                             where DriverID=@DriverID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);

                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return dataTable;
        }
        public static bool Find(int LocalDrivingLicenseApplicationID
            , ref int ApplicationID, ref int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from LocalDrivingLicenseApplications 
             where LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID"
                , LocalDrivingLicenseApplicationID);
            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return isFound;
        }
        public static bool FindByApplicationID( int ApplicationID
            ,ref int LocalDrivingLicenseApplicationID , ref int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from LocalDrivingLicenseApplications 
             where ApplicationID =@ApplicationID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID" , ApplicationID);
            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    LocalDrivingLicenseApplicationID =
                        (int)reader["LocalDrivingLicenseApplicationID"];

                    LicenseClassID = (int)reader["LicenseClassID"];

                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return isFound;
        }

        public static bool DeleteApplication(int LocalDrivingLicenseApplicationID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Delete From LocalDrivingLicenseApplications
            where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID"
                , LocalDrivingLicenseApplicationID);
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


        public static int AddNewLocalDrivingLicenseApplication(
            int ApplicationID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Insert Into LocalDrivingLicenseApplications
            (ApplicationID,LicenseClassID)
            Values (@ApplicationID,@LicenseClassID);
            select SCOPE_IDENTITY()";
            SqlCommand Command = new SqlCommand(Query, connection);

          
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
           

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

        public static bool UpdateApplication(int LocalDrivingLicenseApplicationID
            , int ApplicationID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Update LocalDrivingLicenseApplications
                         set
               ApplicationID=@ApplicationID,LicenseClassID=@LicenseClassID
                   where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID ";

            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID"
                , LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
          

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

    }
}
