using BusinessLayer;
using BusinessLayerLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Full_Project_Desktop
{
    public partial class PersonCard : UserControl
    {
        int ID = -1;
        string NoNumber = "";
        public PersonCard()
        {
            InitializeComponent();
           
        }
        public PersonCard(int PersonID)
        {
            InitializeComponent();
            ID = PersonID;
            
        }
        public PersonCard(string N)
        {
            InitializeComponent();
            NoNumber = N;

        }

        private void PersonCard_Load(object sender, EventArgs e)
        {

            if (ID == -1)
            {
                UpdateCard(NoNumber);
            }
            else
            {
                UpdateCard(ID);

            }

        }
      public void UpdateCard(int ID)
        {
            clsPerson person = clsPerson.FindPerson(ID);
            
            if (person != null)
            {
                linkLabel2.Enabled = true;
                lbPersonID.Text = person.PersonID.ToString();
                lbName.Text = person.FullName();
                lbNationalNo.Text = person.NationalNo.ToString();
                lbEmail.Text = person.Email;
                lbPhone.Text = person.Phone;
                lbAddress.Text = person.Address;
                lbDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
                lbCountry.Text = clsCountry.GetCountryName(person.NationalityCountryID);


                if (person.Gendor == 1)
                {
                    lbGendor.Text = "Male";
                }
                else
                {
                    lbGendor.Text = "Female";
                }
                if (person.ImagePath == "")
                {
                    if (person.Gendor == 1)
                    {
                        pictureBox1.Image = Properties.Resources.profile;
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources.woman;
                    }
                }
                else
                    pictureBox1.ImageLocation = person.ImagePath;


            }
        }
        public void UpdateCard(string N)
        {
            clsPerson person = clsPerson.FindPerson(N);

            if (person != null)
            {
                linkLabel2.Enabled = true;
                lbPersonID.Text = person.PersonID.ToString();
                lbName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
                lbNationalNo.Text = person.NationalNo.ToString();
                lbEmail.Text = person.Email;
                lbPhone.Text = person.Phone;
                lbAddress.Text = person.Address;
                lbDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
                lbCountry.Text = clsCountry.GetCountryName(person.NationalityCountryID-1);
                

                if (person.Gendor == 1)
                {
                    lbGendor.Text = "Male";
                }
                else
                {
                    lbGendor.Text = "Female";
                }
                if (person.ImagePath == "")
                {
                    if (person.Gendor == 1)
                    {
                        pictureBox1.Image = Properties.Resources.profile;
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources.woman;
                    }
                }
                else
                    pictureBox1.ImageLocation = person.ImagePath;


            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
                AddOrUpdatePersonForm updatePerson = new AddOrUpdatePersonForm(Convert.ToInt32(lbPersonID.Text));
                updatePerson.ShowDialog();
            UpdateCard(Convert.ToInt32(lbPersonID.Text));
        }

        private void gbPersonInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
