using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsPerson
    {
        public int PersonID { get; set; }
        public string NationalNo {  get; set; }
        public string FirstName { get; set; }
        public string SecondName {  get; set;}
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gendor {  get; set; }
        public string Address {  get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID {  get; set; }
        public string ImagePath { get; set; }
        public enum enMode { AddMode=1, UpdateMode=2 }

         enMode _Mode=enMode.AddMode;

      public  clsPerson() {
            PersonID = -1;
            NationalityCountryID = -1; 
            NationalNo=string.Empty;
            FirstName =string.Empty;
            SecondName=string.Empty;
            ThirdName=LastName= string.Empty;
            DateOfBirth = DateTime.Now;
            Gendor = -1;
            Address =string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            ImagePath = string.Empty;
            _Mode = enMode.AddMode;
        }
     private   clsPerson(int PersonID,string NationalNo,string FirstName,string SecondName,
            string ThirdName,string LastName,DateTime DateOfBirth,int Gendor,string Address,string Phone
            ,string Email,int NationalityCountryID, string ImagePath)
        {
           this.PersonID =PersonID ;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName=ThirdName;
            this.LastName = LastName ;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            _Mode= enMode.UpdateMode;
        }

        public string FullName()
        {
            return FirstName +" "+SecondName+  ((ThirdName=="")?"":" "+ThirdName) 
                + " "+LastName;
        }
        public static bool IsExist(int PersonID)
        {
            return clsPersonData.IsExists(PersonID);
        }

        public static bool IsExist(string NationalNo)
        {
            return clsPersonData.IsExists(NationalNo);
        }

        public static DataTable GetPeopleInfo()
        {
            return clsPersonData.GetAllPeople();
        }
        public static DataTable GetShortViewPeople()
        {
            return clsPersonData.GetShortViewPeople();
        }
        public static clsPerson FindPerson(int PersonID)
        {
          int NationalityCountryID = -1;
          string  NationalNo = string.Empty;
           string FirstName = string.Empty;
           string SecondName = string.Empty;
           string ThirdName = string.Empty;  
             string   LastName = string.Empty;
           DateTime DateOfBirth = DateTime.Now;
           int Gender = -1;
           string Address = string.Empty;
           string Phone = string.Empty;
           string Email = string.Empty;
           string ImagePath = string.Empty;

            
            if(clsPersonData.FindPerson(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName
                , ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo,  FirstName, SecondName,  ThirdName
                ,  LastName,DateOfBirth,  Gender,Address, Phone,Email, NationalityCountryID,ImagePath);
            }
        
            return null;
        }
        public static clsPerson FindPerson(string NationalNo)
        {
            int NationalityCountryID = -1;
            int PersonID = -1;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            DateTime DateOfBirth = DateTime.Now;
            int Gender = -1;
            string Address = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            string ImagePath = string.Empty;


            if (clsPersonData.FindPerson(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName
                , ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName
                , LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }

            return null;
        }

        private  bool AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.NationalNo, this.FirstName
                   , this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor
                   , this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);


            return this.PersonID > 0;
        }

       private bool Update()
        {
            return (clsPersonData.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName,
              this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor
              , this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath));
            
        }



        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddMode:
                    if (AddNewPerson())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else { return false; }
                case enMode.UpdateMode:

                    return Update();

            }
            return false;
        }
    }
}
