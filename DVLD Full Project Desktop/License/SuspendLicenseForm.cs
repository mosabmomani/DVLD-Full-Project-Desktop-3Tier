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
    public partial class SuspendLicenseForm : Form
    {
        private clsLocalDrivingLicenseApplications _LocalDrivingLicense;
        private clsSuspendLicenses _Suspend;
        public SuspendLicenseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                if (cnlicenseInfo.licenses==null)
                {
                    MessageBox.Show("The license is Issue yet (you can delete the license Application using Manage Local License)", "Not Issue"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
               else if (clsSuspendLicenses.IsLicenseSuspended(cnlicenseInfo.licenses.LicenseID))
                {
                    buSuspend.Enabled = false;
                    llbShowLesense.Enabled = true;  
                    llbShowLicensesHistory.Enabled = true;
                }
                else
                {
                    buSuspend.Enabled=true;
                    llbShowLesense.Enabled = true;
                    llbShowLicensesHistory.Enabled = true;
                }
               

            }
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

        private void buClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetImage()
        {
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
            buSuspend.Image = Properties.Resources.Detain_32;
            buSuspend.ImageAlign = ContentAlignment.MiddleLeft;
            buSearch.Image = Properties.Resources.License_View_32;
            buSearch.ImageAlign = ContentAlignment.MiddleLeft;
        }
        private void SuspendLicenseForm_Load(object sender, EventArgs e)
        {
            SetImage();
        }
        private void RefreshSuspendGB()
        {
            lbCreatedBy.Text = _Suspend.CreatedByUserID.ToString();
            lbDetainDate.Text=_Suspend.DetainDate.ToString();
            lbDetainID.Text= _Suspend.DetainID.ToString();
            maskedTextBox1.Text = _Suspend.FineFees.ToString();
            maskedTextBox1.Enabled = false;
            lbLicenseID.Text= _Suspend.LicenseID.ToString();
        }
        private void buRenew_Click(object sender, EventArgs e)
        {
            _Suspend = new clsSuspendLicenses();
            _Suspend.CreatedByUserID=clsGlobal.CurrentUser.UserID;
            _Suspend.DetainDate = DateTime.Now;
            _Suspend.LicenseID = cnlicenseInfo.licenses.LicenseID;
            _Suspend.FineFees =Convert.ToDecimal( maskedTextBox1.Text);
            if (_Suspend.Save())
            {
                MessageBox.Show($"The license is Suspended Successfully suspend ID :{_Suspend.DetainID}", "suspended"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                buSuspend.Enabled = false;
                RefreshSuspendGB();
            }
            else
            {
                MessageBox.Show("The license Suspended Failed", "suspended"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void cnlicenseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
