using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataAccessLayer
{
    public class clsPersonData
    {
        public static bool IsExists(int PersonID)
        {
            SqlConnection Connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select personID from People 
                          where PersonID=@PersonID";
              SqlCommand command=new SqlCommand(Query,Connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            int ID = -1;
            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int personid)) { 
                ID = personid;
                }


            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { Connection.Close(); }

            return ID > 0;



        }

        public static bool IsExists(String NationalNo)
        {
            SqlConnection Connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select personID from People 
                          where NationalNo=@NationalNo";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            int IsFound = -1;
            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int personID))
                {
                    IsFound = personID;
                }


            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { Connection.Close(); }

            return IsFound > 0;



        }

        public static DataTable GetAllPeople()
        {
            SqlConnection connection=new SqlConnection(DataAccessSetting.connectionString);
            string Query = "Select * From People";
            SqlCommand command= new SqlCommand(Query, connection);
            DataTable PeopleInfo=new DataTable();
            try {
                connection.Open();
                SqlDataReader reader=command.ExecuteReader();
               
                PeopleInfo.Load(reader);
                
                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }

            finally { connection.Close(); }

            return PeopleInfo;
        }

        public static DataTable GetShortViewPeople()
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = "Select * From Peopleview";
            SqlCommand command = new SqlCommand(Query, connection);
            DataTable PeopleInfo = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                PeopleInfo.Load(reader);

                reader.Close();
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }

            finally { connection.Close(); }

            return PeopleInfo;
        }

        public static bool DeletePerson(int PersonID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Delete From People
                            where PersonID=@PersonID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID",PersonID);
            int RowsAffected = -1;
            try
            {
                connection.Open();
                RowsAffected=command.ExecuteNonQuery();
           
            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return RowsAffected > 0;
        }

        public static bool FindPerson(int PersonID,ref string NationalNo,ref string FirstName,ref string SecondName,
           ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gender, ref string Address, ref string Phone
            , ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            SqlConnection connection=new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from People
                            where PersonID=@PersonID ";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            bool IsFound=false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    IsFound = true;
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    NationalNo = reader["NationalNo"] as string ??"";
                    FirstName = reader["FirstName"] as string ?? "";
                    SecondName = reader["SecondName"] as string ?? "";
                    LastName = reader["LastName"] as string ?? "";
                    Gender = (byte)reader["Gendor"];
                    Address = reader["Address"] as string ?? "";
                    Phone = reader["Phone"] as string ?? "";
                    if (reader.IsDBNull(reader.GetOrdinal("Email")))
                    {
                        Email = "";
                    }
                    else
                    {
                        Email = (string)reader["Email"];
                    }

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    if (reader.IsDBNull(reader.GetOrdinal("ImagePath")))
                    {
                        ImagePath = "";
                    }
                    else
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    if (reader.IsDBNull(reader.GetOrdinal("ThirdName")))
                    {
                        ThirdName = "";
                    }
                    else
                    {
                        ThirdName = reader["ThirdName"] as string ?? "";
                    }
                }

                
            }catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }

               
            return IsFound;

        }
        public static bool FindPerson(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName,
   ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gender, ref string Address, ref string Phone
    , ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"select * from People
                            where NationalNo=@NationalNo ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            bool IsFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] == DBNull.Value)
                    {
                        ThirdName = "";
                    }
                    else
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }

                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] == DBNull.Value)
                    {
                        Email = "";
                    }
                    else
                    {
                        Email = (string)reader["Email"];
                    }

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] == null)
                    {
                        ImagePath = "";
                    }
                    else
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }

                }


            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }


            return IsFound;

        }

        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, int Gender, string Address, string Phone
            , string Email, int NationalityCountryID, string ImagePath)
        {
            SqlConnection connection=new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Insert into People 
 (NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth
,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath)
values (@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth
,@Gendor,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath);
select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName == string.Empty)
            {
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (Email == "")
            {
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath == "")
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            int PersonID = 0;
            try
            {
                connection.Open();
                object Result=command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertInto)) { 
                PersonID = InsertInto;
                }


            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return PersonID;

        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, int Gendor, string Address, string Phone
            , string Email, int NationalityCountryID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.connectionString);
            string Query = @"Update People  SET 
NationalNo=@NationalNo,FirstName=@FirstName,SecondName=@SecondName,ThirdName=@ThirdName,
LastName=@LastName,DateOfBirth=@DateOfBirth,Gendor=@Gendor,Address=@Address,Phone=@Phone
,Email=@Email,NationalityCountryID=@NationalityCountryID,ImagePath=@ImagePath
Where PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName == "")
            {
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (Email == "")
            {
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath == "")
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            int RowAfficted = 0;
            try
            {
                connection.Open();
                RowAfficted=command.ExecuteNonQuery();

            }
            catch (Exception exception) { clsEventLog.CreateEventLog(exception); }
            finally { connection.Close(); }
            return RowAfficted>0;
        }
    }
}
