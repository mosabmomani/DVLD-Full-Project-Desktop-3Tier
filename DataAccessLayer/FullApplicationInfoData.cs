using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FullApplicationInfoData
    {
        public static bool Find(int LocalDrivingLicenseApplicationID, ref string Status, ref decimal PaidFees
         , ref string ApplicationTypeTitle, ref string FullName, ref DateTime ApplicationDate
         ,ref DateTime LastStatusDate,  ref string UserName,ref string ClassName
            ,ref int PassedTestCount,ref int ApplicantPersonID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from BasicApplicationInfo_View 
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
                    Status = (string)reader["Status"];
                    PaidFees = (decimal)reader["PaidFees"];
                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    FullName = (string)reader["FullName"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    UserName = (string)reader["UserName"];
                    ClassName = (string)reader["ClassName"];
                    PassedTestCount = (int)reader["PassedTestCount"];
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return isFound;
        }
    }
}
