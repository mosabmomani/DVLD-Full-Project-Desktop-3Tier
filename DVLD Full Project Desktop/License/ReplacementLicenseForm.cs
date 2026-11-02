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
    public partial class ReplacementLicenseForm : Form
    {
        private clsLocalDrivingLicenseApplications _LocalDrivingLicense;
        private clsLicenses _licenses;
        private clsApplication _application;
        private enum Type {LostLicense=3,DamagedLicense=4 }
        private Type _type;
        public ReplacementLicenseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                MessageBox.Show("you need to add a license", "Add License"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            _LocalDrivingLicense = clsLocalDrivingLicenseApplications.Find(Convert.ToInt32(maskedTextBox1.Text));

            if (_LocalDrivingLicense == null)
            {
                MessageBox.Show("The license was not found", "Not Found"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                cnlicenseInfo.RefreshData(_LocalDrivingLicense
                    .LocalDrivingLicenseApplicationID);

                if (cnlicenseInfo.licenses.IsActive) {
                    buRenew.Enabled = true;
                    llbShowLicensesHistory.Enabled = true;
                }
                else
                {
                    MessageBox.Show("The license is not active","Not Active"
                        ,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                

            }
        }
        private void RefreshData()
        {
            lbReplacementLicenseID.Text=_LocalDrivingLicense
                .LocalDrivingLicenseApplicationID.ToString();
            lbApplicationDate.Text=_application.ApplicationDate.ToShortDateString();
            lbApplicationFees.Text=_application.PaidFees.ToString();
            lbApplicationID.Text=_application.ApplicationID.ToString();
            lbOldLicenseID.Text = cnlicenseInfo.Local.LocalDrivingLicenseApplicationID.ToString();
            lbCreatedBy.Text=clsGlobal.CurrentUser.UserName;
        }

        private void buRenew_Click(object sender, EventArgs e)
        {
            clsApplicationTypes applicationTypes;
            if (_type == Type.LostLicense)
            {
                applicationTypes = clsApplicationTypes.Find(((int)Type.LostLicense));
            }
            else
            {
                 applicationTypes = clsApplicationTypes.Find(((int)Type.DamagedLicense));
            }
            if (applicationTypes != null)
            {
                _application = new clsApplication();
                _application.ApplicantPersonID = cnlicenseInfo.person.PersonID;
                _application.ApplicationDate = DateTime.Now;
                _application.ApplicationTypeID = applicationTypes.ApplicationID;
                _application.ApplicationStatus = 3;
                _application.LastStatusDate = DateTime.Now;
                _application.PaidFees = applicationTypes.ApplicationFees;
                if (_application.Save())
                {
                    clsLicenseClasses Licenseclass =
                        clsLicenseClasses.Find(cnlicenseInfo.licenses.LicenseClass);

                    _licenses = new clsLicenses();
                    _licenses.ApplicationID = _application.ApplicationID;
                    _licenses.DriverID = cnlicenseInfo.licenses.DriverID;
                    _licenses.LicenseClass = cnlicenseInfo.licenses.LicenseClass;
                    _licenses.IssueDate = DateTime.Now;
                    _licenses.ExpirationDate = DateTime.Now.AddYears(Licenseclass.DefaultValidityLength);
                    _licenses.PaidFees = Licenseclass.ClassFees;
                    _licenses.IsActive = true;
                    _licenses.IssueReason = (byte)applicationTypes.ApplicationID;
                    _licenses.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                    if (_licenses.Save())
                    {
                        clsLocalDrivingLicenseApplications Local = new clsLocalDrivingLicenseApplications();
                        Local.ApplicationID = _application.ApplicationID;
                        Local.LicenseClassID = Licenseclass.LicenseClassID;
                        if (Local.Save())
                        {
                            _LocalDrivingLicense = Local;
                            MessageBox.Show("The license Replacement successfully", "Replacement",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clsLicenses.DeactiveLicense(cnlicenseInfo.licenses.LicenseID);
                            RefreshData();
                            llbShowLesense.Enabled = true;
                            buRenew.Enabled = false;
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("The license Replacement Fouled", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _type=Type.LostLicense;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _type = Type.DamagedLicense;
        }

        private void buClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void SetImage()
        {
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
            buRenew.Image = Properties.Resources.New_Driving_License_32;
            buRenew.ImageAlign = ContentAlignment.MiddleLeft;
            buSearch.Image = Properties.Resources.License_View_32;
            buSearch.ImageAlign = ContentAlignment.MiddleLeft;
        }
        private void ReplacementLicenseForm_Load(object sender, EventArgs e)
        {
            SetImage();
        }
    }
}
