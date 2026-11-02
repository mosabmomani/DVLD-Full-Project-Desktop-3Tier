using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsTestTypesData
    {
        public static DataTable GetTestTypesData()
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = "select * from TestTypes";
            SqlCommand command = new SqlCommand(Query, connection);
            DataTable dataTable=new DataTable();
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

        public static bool Find(int TestTypeID, ref string TestTypeTitle
            , ref string TestTypeDescription,ref decimal TestTypeFees)
        {
            SqlConnection connection=new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from TestTypes 
                           where TestTypeID =@TestTypeID";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    TestTypeFees = (decimal)reader["TestTypeFees"];
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return isFound;
        }

        public static bool Update(int TestTypeID, string TestTypeTitle,
          string TestTypeDescription, decimal TestTypeFees)
        {
            SqlConnection connection =new SqlConnection(DataAccessSetting.connectionString);
            String Query = @"Update TestTypes set 
                    TestTypeTitle=@TestTypeTitle,
                      TestTypeDescription=@TestTypeDescription,
                       TestTypeFees=@TestTypeFees
                         where TestTypeID=@TestTypeID";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

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
    }
}
