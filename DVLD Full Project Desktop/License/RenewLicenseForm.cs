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
    public partial class RenewLicenseForm : Form
    {
        private clsLocalDrivingLicenseApplications _LocalDrivingLicense;
        private clsLicenses _licenses;
        private clsApplication _application;
        public RenewLicenseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                MessageBox.Show("you need to add a license");
                return;

            }
            _LocalDrivingLicense = clsLocalDrivingLicenseApplications.Find(Convert.ToInt32(maskedTextBox1.Text));

            if (_LocalDrivingLicense == null)
            {
                MessageBox.Show("The license was not found");
                return;
            }

            cnlicenseInfo.RefreshData(_LocalDrivingLicense
                    .LocalDrivingLicenseApplicationID);

            if (cnlicenseInfo.licenses.ExpirationDate > DateTime.Today)
            {

                MessageBox.Show($@"This license is still active and will expire on
                 {cnlicenseInfo.licenses.ExpirationDate.ToShortDateString()}",
                 "License Active", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                buRenew.Enabled = true;
                llbShowLicensesHistory.Enabled = true;
            }
        }
        private void RefreshBoxData()
        {
            lbRLApplicationID.Text=_application.ApplicationID.ToString();
            lbApplictionDate.Text=_application.ApplicationDate.ToShortDateString();
            lbIssueDate.Text=_licenses.IssueDate.ToShortDateString();
            lbApplicationFees.Text=_application.PaidFees.ToString();
            lbLicenseFees.Text = _licenses.PaidFees.ToString();
            lbRenewedLicenseID.Text=_licenses.LicenseID.ToString();
            lbOldLicenseID.Text = cnlicenseInfo.Local.LocalDrivingLicenseApplicationID.ToString();
            lbExpirationDate.Text = _licenses.ExpirationDate.ToShortDateString();
            lbCreatedByUser.Text=clsGlobal.CurrentUser.UserName;
            lbTotalFees.Text = (_licenses.PaidFees + _application.PaidFees).ToString();
            tbNotes.Enabled = false;
        }

        private void buIssueLicense_Click(object sender, EventArgs e)
        {
            clsApplicationTypes applicationTypes = clsApplicationTypes.Find(2);
            if (applicationTypes != null)
            {
                _application = new clsApplication();
                _application.ApplicantPersonID = cnlicenseInfo.person.PersonID;
                _application.ApplicationDate = DateTime.Now;
                _application.ApplicationTypeID=applicationTypes.ApplicationID;
                _application.ApplicationStatus = 3;
                _application.LastStatusDate= DateTime.Now;
                _application.PaidFees=applicationTypes.ApplicationFees;
                if (_application.Save())
                {
                    clsLicenseClasses Licenseclass=
                        clsLicenseClasses.Find(cnlicenseInfo.licenses.LicenseClass);

                     _licenses=new clsLicenses(); 
                    _licenses.ApplicationID = _application.ApplicationID;
                    _licenses.DriverID = cnlicenseInfo.licenses.DriverID;
                    _licenses.LicenseClass=cnlicenseInfo.licenses.LicenseClass;
                    _licenses.IssueDate = DateTime.Now;
                    _licenses.ExpirationDate = DateTime.Now.AddYears(Licenseclass.DefaultValidityLength);
                    _licenses.Notes =tbNotes.Text;
                    _licenses.PaidFees=Licenseclass.ClassFees;
                    _licenses.IsActive=true;
                    _licenses.IssueReason=(byte)applicationTypes.ApplicationID;
                    _licenses.CreatedByUserID=clsGlobal.CurrentUser.UserID;
                    if (_licenses.Save()) {
                       clsLocalDrivingLicenseApplications Local = new clsLocalDrivingLicenseApplications();
                       Local.ApplicationID=_application.ApplicationID;
                       Local.LicenseClassID=Licenseclass.LicenseClassID;
                        if (Local.Save()) {
                            _LocalDrivingLicense = Local;
                            MessageBox.Show("The license renewed successfully","Renewed",
                                MessageBoxButtons.OK,MessageBoxIcon.Information);
                            RefreshBoxData();
                            clsLicenses.DeactiveLicense(cnlicenseInfo.licenses.LicenseID);
                            llbShowLesense.Enabled=true;
                            buRenew.Enabled=false;
                            
                        }
                    }
                }
            }
            MessageBox.Show("The license Renewed Fouled", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void llbShowLesense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfoForm form = new LicenseInfoForm(
                _LocalDrivingLicense.LocalDrivingLicenseApplicationID);
            form.ShowDialog();
        }

        private void llbShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistoryForm form = new LicenseHistoryForm
               (_LocalDrivingLicense.LocalDrivingLicenseApplicationID);
            form.ShowDialog();
        }

        private void buClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetImage()
        {
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
            buRenew.Image = Properties.Resources.New_Driving_License_32;
            buRenew.ImageAlign = ContentAlignment.MiddleLeft;
            buSearch.Image = Properties.Resources.License_View_32;
            buSearch.ImageAlign = ContentAlignment.MiddleLeft;
        }
        private void RenewLicenseForm_Load(object sender, EventArgs e)
        {
            SetImage();
        }
    }
}
