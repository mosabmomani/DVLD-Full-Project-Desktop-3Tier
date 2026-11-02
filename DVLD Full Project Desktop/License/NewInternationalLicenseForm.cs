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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Full_Project_Desktop
{
    public partial class NewInternationalLicenseForm : Form
    {
        private clsLocalDrivingLicenseApplications _LocalDrivingLicense;
        public NewInternationalLicenseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox1.Text)) {
                MessageBox.Show("you need to add a license");
                return;
            
            }
          _LocalDrivingLicense=  clsLocalDrivingLicenseApplications.Find(Convert.ToInt32(maskedTextBox1.Text));
            if (_LocalDrivingLicense == null) {
                MessageBox.Show("The license was not found");
                return;
            }
            else
            {
                cnlicenseInfo.RefreshData(_LocalDrivingLicense
                    .LocalDrivingLicenseApplicationID);
                buIssueLicense.Enabled = true;
                llbShowLicensesHistory.Enabled = true; 
                
            }
        }

        private void buClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistoryForm historyForm = new LicenseHistoryForm(_LocalDrivingLicense.
                LocalDrivingLicenseApplicationID);
            historyForm.ShowDialog();
        }

        private void buIssueLicense_Click(object sender, EventArgs e)
        {
            
            if (clsLicenses.HaveAnActiveLicense(cnlicenseInfo.licenses.DriverID, 3)==0)
            {
                MessageBox.Show("The person does't have an active class 3 License");
                return;
            }
            int ID=0;
            if ((ID =clsInternationalLicenses.HaveanActiveInternationalLicense
                (cnlicenseInfo.licenses.DriverID))>0)
            {
                MessageBox.Show("The person  have an active International License");
                return;
            }
            clsApplication Application = new clsApplication();
            Application.ApplicantPersonID = cnlicenseInfo.person.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationStatus = 1;
            Application.ApplicationTypeID = 6;
            Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationTypes.GetFees(6);
            if (Application.Save())
            {
                clsInternationalLicenses license= new clsInternationalLicenses();
                license.ApplicationID = Application.ApplicationID;
                license.DriverID = cnlicenseInfo.licenses.DriverID;
                license.IssuedUsingLocalLicenseID = cnlicenseInfo.licenses.LicenseID;
                license.IssueDate=DateTime.Now;
                license.ExpirationDate=DateTime.Now.AddYears(1);
                license.IsActive=true;
                license.CreatedByUserID=clsGlobal.CurrentUser.UserID;
                if (license.AddNewInternationalLicense())
                {
                    MessageBox.Show("License Add Successfully");
                    llbShowLesense.Enabled= true;
                    coInternationalLicense.RefreshData(license.InternationalLicenseID);
                    return;
                }
            }
            MessageBox.Show("License Add Failed");
        }

        private void llbShowLesense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfoForm form = new LicenseInfoForm(_LocalDrivingLicense.
                LocalDrivingLicenseApplicationID);
            form.ShowDialog();
        }

        private void cnlicenseInfo_Load(object sender, EventArgs e)
        {

        }
        private void SetImage()
        {
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
            buIssueLicense.Image = Properties.Resources.New_Driving_License_32;
            buIssueLicense.ImageAlign = ContentAlignment.MiddleLeft;
            buSearch.Image = Properties.Resources.License_View_32;
            buSearch.ImageAlign = ContentAlignment.MiddleLeft;
        }
        private void NewInternationalLicenseForm_Load(object sender, EventArgs e)
        {
            SetImage();
        }
    }
}
