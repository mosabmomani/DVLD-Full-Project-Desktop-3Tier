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
    public partial class ReleaseSuspendedLicenseForm : Form
    {
        private clsLocalDrivingLicenseApplications _LocalDrivingLicense;
        private clsSuspendLicenses _Release;
        public ReleaseSuspendedLicenseForm()
        {
            InitializeComponent();
        }

        public ReleaseSuspendedLicenseForm(int LicenseID)
        {
            InitializeComponent();
            clsLicenses licenses = clsLicenses.Find(LicenseID);
            _LocalDrivingLicense =clsLocalDrivingLicenseApplications.FindByApplicationID(licenses.ApplicationID);
            mtbLicenseID.Text = _LocalDrivingLicense.LocalDrivingLicenseApplicationID.ToString();
            buSearch_Click(null, null);
            gbflter.Enabled = false;



        }
        private void SetImage()
        {
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
            buRelease.Image = Properties.Resources.Release_Detained_License_32;
            buRelease.ImageAlign = ContentAlignment.MiddleLeft;
            buSearch.Image = Properties.Resources.License_View_32;
            buSearch.ImageAlign = ContentAlignment.MiddleLeft;
        }
        private void buClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistoryForm form = new LicenseHistoryForm
             (_LocalDrivingLicense.LocalDrivingLicenseApplicationID);
            form.ShowDialog();
        }

        private void llbShowLesense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfoForm form = new LicenseInfoForm(
             _LocalDrivingLicense.LocalDrivingLicenseApplicationID);
            form.ShowDialog();
        }
        private void RefreshSuspendGB()
        {
            lbCreatedBy.Text = _Release.CreatedByUserID.ToString();
            lbDetainDate.Text = _Release.DetainDate.ToString();
            lbDetainID.Text = _Release.DetainID.ToString();
            lbApplicationID.Text=_Release.ReleaseApplicationID.ToString();
        }
        private void buSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbLicenseID.Text))
            {
                MessageBox.Show("you need to add a license", "Add License"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            _LocalDrivingLicense = clsLocalDrivingLicenseApplications.Find(Convert.ToInt32(mtbLicenseID.Text));

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
                if (cnlicenseInfo.licenses == null)
                {
                    MessageBox.Show("The license is Issue yet (you can delete the license Application using Manage Local License)", "Not Issue"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (clsSuspendLicenses.IsLicenseSuspended(cnlicenseInfo.licenses.LicenseID))
                {
                    buRelease.Enabled = true;
                    llbShowLesense.Enabled = true;
                    llbShowLicensesHistory.Enabled = true;
                    _Release = clsSuspendLicenses.FindByLicense(cnlicenseInfo.licenses.LicenseID);

                    lbFineFees.Text = _Release.FineFees.ToString();
                    decimal AFees = clsApplicationTypes.GetFees(5);
                    lbApplicationFees.Text = AFees.ToString();
                    lbTotalFees.Text = (AFees + _Release.FineFees).ToString();
                    lbLicenseID.Text = _Release.LicenseID.ToString();
                }
                else
                {
                    buRelease.Enabled = false;
                    llbShowLesense.Enabled = true;
                    llbShowLicensesHistory.Enabled = true;
                }
            }
        }
        private int CreateApplication()
        {
            clsApplication application= new clsApplication();
            application.ApplicantPersonID=cnlicenseInfo.person.PersonID;
            application.ApplicationDate=DateTime.Now;
            application.ApplicationTypeID = 5;
            application.ApplicationStatus = 3;
            application.LastStatusDate= DateTime.Now;
            application.PaidFees=clsApplicationTypes.GetFees(5);
            application.CreatedByUserID=clsGlobal.CurrentUser.UserID;
            if (application.Save())
            {
                return application.ApplicationID;
            }
            return -1;

        }

        private void buRelease_Click(object sender, EventArgs e)
        {
            int AID = CreateApplication();



            if (!(AID>0))
            {
                MessageBox.Show("The Application created Failed", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _Release.ReleaseApplicationID = AID;
            _Release.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_Release.ReleaseSuspendedLicense(_Release.CreatedByUserID,_Release.ReleaseApplicationID))
            {
                MessageBox.Show("The license is Released Successfully Released ", "Released"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                buRelease.Enabled = false;
                RefreshSuspendGB();
            }
            else
            {
                MessageBox.Show("The license Released Failed", "Released"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ReleaseSuspendedLicenseForm_Load(object sender, EventArgs e)
        {
            SetImage();
        }
    }
}
