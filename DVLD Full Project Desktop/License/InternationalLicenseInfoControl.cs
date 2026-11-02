using BusinessLayer;
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
    public partial class InternationalLicenseInfoControl : UserControl
    {
       private clsInternationalLicenses _International;
        public InternationalLicenseInfoControl()
        {
            InitializeComponent();
        }
        
        public void RefreshData(clsInternationalLicenses International)
        {
            _International = International;
            if (_International == null)
            {
                return;
            }
            clsDriver driver = clsDriver.Find(_International.DriverID);
            if (driver != null)
            {
                clsPerson person = clsPerson.FindPerson(driver.PersonID);
                lbName.Text = person.FullName();
                lbIntLicenseID.Text = _International.InternationalLicenseID.ToString();
                lbLicenseID.Text = _International.IssuedUsingLocalLicenseID.ToString();
                lbNationalNa.Text = person.NationalNo.ToString();
                lbGendor.Text = (person.Gendor == 1) ? "Male" : "Female";
                lbIssueDate.Text = _International.IssueDate.ToShortDateString();
                lbApplicationID.Text = _International.ApplicationID.ToString();
                lbIsActive.Text = (_International.IsActive) ? "Yes" : "No";
                lbDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
                lbDriverID.Text = _International.DriverID.ToString();
                lbExpirationDate.Text = _International.ExpirationDate.ToShortDateString();
                pictureBox1.ImageLocation = person.ImagePath;

            }

        }

        private void InternationalLicenseInfoControl_Load(object sender, EventArgs e)
        {
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
