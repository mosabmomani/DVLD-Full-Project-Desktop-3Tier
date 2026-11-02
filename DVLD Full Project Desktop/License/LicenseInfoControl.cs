using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Full_Project_Desktop
{
    public partial class LicenseInfoControl : UserControl
    {
       public clsPerson person;
        public clsLicenses licenses;
        public clsLocalDrivingLicenseApplications Local;
        public LicenseInfoControl()
        {
            InitializeComponent();
        }
        
        public void RefreshData(int LDL)
        {
            
            Local = clsLocalDrivingLicenseApplications.Find(LDL);
            clsFullApplicationInfo application;
            if (Local != null)
            {
                application = clsFullApplicationInfo.Find(Local
                    .LocalDrivingLicenseApplicationID);
                person = clsPerson.FindPerson(application.ApplicantPersonID);
                licenses = clsLicenses.FindByAppID(Local.ApplicationID, Local.LicenseClassID);
                if (licenses == null)
                {
                    return;
                }
                lbClass.Text = application.ClassName;
                lbLicenseID.Text=licenses.LicenseID.ToString();
                lbName.Text = application.FullName;
                lbNationalNa.Text = person.NationalNo;
                lbGendor.Text = (person.Gendor == 1) ? "Male" : "Female";
                lbIssueDate.Text = licenses.IssueDate.ToShortDateString();
                lbIssueReason.Text = application.ApplicationTypeTitle;
                lbNotes.Text =(licenses.Notes=="")?"No Notes": licenses.Notes.ToString();
                lbIsActive.Text = (licenses.IsActive) ? "Yes" : "No";
                lbDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
                lbDriverID.Text = licenses.DriverID.ToString();
                lbExpirationDate.Text = licenses.ExpirationDate.ToShortDateString();
                lbIsDetained.Text = (clsSuspendLicenses.IsLicenseSuspended(licenses.LicenseID)) ? "Yes" : "No";
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
                {
                    if (File.Exists(person.ImagePath))
                    {
                        pictureBox1.ImageLocation = person.ImagePath;
                    }
                    else
                    {
                        MessageBox.Show("Can't find that image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
