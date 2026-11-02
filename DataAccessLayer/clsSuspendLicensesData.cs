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
    public class clsSuspendLicensesData
    {

        public static DataTable GetAllSuspendLicenses()
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from SuspendLicensesView";
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
        public static bool FindByID(int DetainID, ref int LicenseID ,ref DateTime DetainDate
            , ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased,
            ref DateTime ReleaseDate, ref int ReleasedByUserID,ref int ReleaseApplicationID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from DetainedLicenses 
             where DetainID =@DetainID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);
            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    if (reader["ReleaseDate"] == DBNull.Value)
                    {
                        ReleaseDate = DateTime.MaxValue;
                    }
                    else
                    {
                        ReleaseDate = (DateTime)reader["ReleaseDate"];
                    }
                    if (reader["ReleasedByUserID"] == DBNull.Value)
                    {
                        ReleasedByUserID = 0;
                    }
                    else
                    {
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    }
                    if (reader["ReleaseApplicationID"] == DBNull.Value)
                    {
                        ReleaseApplicationID = 0;
                    }
                    else
                    {
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                    }
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return isFound;
        }
        public static bool FindByLicenseID(int LicenseID, ref int DetainID, ref DateTime DetainDate
           , ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased,
           ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select top 1 * from DetainedLicenses 
             where LicenseID =@LicenseID
              order by DetainID desc";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    if (reader["ReleaseDate"] == DBNull.Value)
                    {
                        ReleaseDate = DateTime.MinValue;
                    }
                    else
                    {
                        ReleaseDate = (DateTime)reader["ReleaseDate"];
                    }
                    if (reader["ReleasedByUserID"] == DBNull.Value)
                    {
                        ReleasedByUserID = 0;
                    }
                    else
                    {
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    }
                    if (reader["ReleaseApplicationID"] == DBNull.Value)
                    {
                        ReleaseApplicationID = 0;
                    }
                    else
                    {
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                    }
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return isFound;
        }
        public static int AddNewSuspendLicense( int LicenseID,DateTime DetainDate,
            decimal FineFees,int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Insert Into DetainedLicenses
            (LicenseID, DetainDate, FineFees, CreatedByUserID)
            Values (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID);
            select SCOPE_IDENTITY()";
            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
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
        public static bool UpdateSuspendedLicense(int DetainID, int LicenseID
            , DateTime DetainDate,decimal FineFees, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Update DetainedLicenses
                         set
            LicenseID=@LicenseID,DetainDate=@DetainDate,FineFees=@FineFees,
            CreatedByUserID=@CreatedByUserID, IsReleased=@IsReleased
            ReleaseDate=@ReleaseDate,,ReleasedByUserID=@ReleasedByUserID,
           ReleaseApplicationID=@ReleaseApplicationID
             where DetainID=@DetainID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DetainID", DetainID);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
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

        public static bool ReleaseSuspendedLicense(int DetainID, int ReleasedByUserID, int ReleaseApplicationID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Update DetainedLicenses 
                            set IsReleased=1,ReleaseDate=@ReleaseDate,
                            ReleasedByUserID=@ReleasedByUserID,ReleaseApplicationID=@ReleaseApplicationID
                             where DetainID=@DetainID and IsReleased=0";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
           

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
        public static bool IsLicenseSuspended(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select Found=1 from DetainedLicenses
                         where LicenseID=@LicenseID and IsReleased=0";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
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
    }
}
