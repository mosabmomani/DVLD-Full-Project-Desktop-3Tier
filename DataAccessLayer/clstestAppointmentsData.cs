using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clstestAppointmentsData
    {
        public static DataTable GetShortTestAppointments(int LDLA,int TestType)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select TestAppointmentID,TestTypes.TestTypeTitle,AppointmentDate,PaidFees,	IsLocked 
from TestAppointments inner join TestTypes on TestTypes.TestTypeID=TestAppointments.TestTypeID
where TestAppointments.TestTypeID=@TestType and LocalDrivingLicenseApplicationID=@LDLA";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LDLA", LDLA);
            command.Parameters.AddWithValue("@TestType", TestType);
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader);

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return table;
        }
        public static bool Find(int TestAppointmentID,ref int TestTypeID
            , ref int LocalDrivingLicenseApplicationID, ref DateTime
           AppointmentDate, ref decimal PaidFees,ref int CreatedByUserID,ref bool IsLocked)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from TestAppointments
                           where TestAppointmentID= @TestAppointmentID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            
            bool Isfound = false;
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
                    Isfound = true;
                }
                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return Isfound;

        }

        public static bool DeleteAppointment(int TestAppointmentID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Delete From TestAppointments
            where TestAppointmentID=@TestAppointmentID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
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


        public static int AddNewAppointment(int TestTypeID
            , int LocalDrivingLicenseApplicationID,DateTime AppointmentDate
            ,decimal PaidFees, int CreatedByUserID,bool IsLocked)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Insert Into TestAppointments
            (TestTypeID,LocalDrivingLicenseApplicationID,
            AppointmentDate, PaidFees,CreatedByUserID, IsLocked)
            Values (@TestTypeID,@LocalDrivingLicenseApplicationID,
            @AppointmentDate,@PaidFees,@CreatedByUserID, @IsLocked);
            select SCOPE_IDENTITY()";
            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID"
                , LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);

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

        public static bool UpdateAppointment(int TestAppointmentID
            , int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime
           AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Update TestAppointments
                         set
            TestTypeID=@TestTypeID,LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID,
            AppointmentDate=@AppointmentDate,PaidFees=@PaidFees
            ,CreatedByUserID=@CreatedByUserID, IsLocked=@IsLocked
             where TestAppointmentID=@TestAppointmentID";

            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID"
                , LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);


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
       public static bool HaveAnActiveAppointment(int LDLID,int TestTypeID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Select 1 from TestAppointments
           where LocalDrivingLicenseApplicationID=@LDLID and TestTypeID=@TestTypeID
           and IsLocked=0;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LDLID", LDLID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            bool Found = false;

            try
            {
                connection.Open();
                Object Result =command.ExecuteScalar();
                if (Result != null) { 
                Found= true;
                }
                

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return Found;

        }

        public static bool SetAppointmentLocked(int TestAppointmentID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Update TestAppointments
                         set  IsLocked=1
             where TestAppointmentID=@TestAppointmentID";

            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
           


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
