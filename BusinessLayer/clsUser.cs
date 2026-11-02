using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class clsUser
    {
        public int UserID { get; set; }
        public int PersonID { get; set; } 
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        private enum Mode { AddMode=0,UpdateMode}
        private Mode _Mode=Mode.UpdateMode;

       public clsUser() { 
        UserID = 0;
            PersonID = 0;
            UserName= string.Empty;
            Password = string.Empty;
            IsActive = false;
            _Mode = Mode.AddMode;
        }
       private clsUser(int userId, int personID, string userName, string password, bool isActive)
        {
            UserID = userId;
            PersonID = personID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
            _Mode = Mode.UpdateMode;
        }

        public static clsUser Find(string Username, string Password) { 
        int UserId = 0;
            int PersonID = 0;
            bool IsActive = false;
            if (clsUserData.FindUser(Username, Password, ref UserId,ref PersonID,ref IsActive)) {
                
                return new clsUser(  UserId,  PersonID, Username, Password, IsActive);
            }

            return null;
        
        
        }
        public static clsUser Find(int UserID)
        {
            string UserName = string.Empty; 
            string Password = string.Empty;
            int PersonID = 0;
            bool IsActive = false;
            if (clsUserData.FindUser(UserID,ref UserName,ref Password, ref PersonID, ref IsActive))
            {

                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }

            return null;


        }
        public static bool IsExist(int UserID)
        {
            return clsUserData.IsExist(UserID);
        }

        public static bool IsPersonUsed(int PersonID)
        {
            return clsUserData.IsPersonUesd(PersonID);
        }
        public static bool IsUsernameUsed(string Username)
        {
            return clsUserData.IsUsernameUesd(Username);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        private bool AddNewUser()
        {
            return (this.UserID =clsUserData.AddNewUser(this.UserName, this.Password, this.PersonID, this.IsActive))>0; 

        }
        private bool UpdateUser()
        {
            return (clsUserData.UpdateUser(this.UserID, this.UserName, this.Password, this.PersonID, this.IsActive));
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case Mode.AddMode:
                    if (AddNewUser())
                    {
                        _Mode=Mode.UpdateMode;
                        return true;
                    }
                    else { return false; }
                case Mode.UpdateMode:

                    return UpdateUser();

            }
            return false;
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }
    }

}
