using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestsData
    {
        public static int AddNewTest(int TestAppointmentID, bool TestResult
           , string Notes, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Insert Into Tests
            (TestAppointmentID,TestResult, Notes, CreatedByUserID)
            Values (@TestAppointmentID,@TestResult, @Notes,@CreatedByUserID);
            select SCOPE_IDENTITY()";
            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestResult" , TestResult);
            if (Notes == "")
            {
                Command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            }
            else
            {
                Command.Parameters.AddWithValue("@Notes", Notes);
            }
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
        public static bool PassedTheTest(int LDLID,int TestTypeID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Select 1 from TestResult_View
           where LocalDrivingLicenseApplicationID=@LDLID and TestResult= 1 
           and TestTypeID=@TestTypeID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LDLID", LDLID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            bool Found = false;

            try
            {
                connection.Open();
                Object Result = command.ExecuteScalar();
                if (Result != null)
                {
                    Found = true;
                }


            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return Found;

        }
        public static bool Find(int TestID,ref int TestAppointmentID,ref bool TestResult
           ,ref string Notes,ref int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from Tests
                           where TestID= @TestID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestID", TestID);

            bool Isfound = false;
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    if (reader["Notes"] == DBNull.Value)
                    {
                        Notes = "";
                    }
                    else
                    {
                        Notes = (string)reader["Notes"];
                    }
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    
                    Isfound = true;
                }
                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return Isfound;

        }
    }
}
