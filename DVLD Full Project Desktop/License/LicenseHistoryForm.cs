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
    public partial class LicenseHistoryForm : Form
    {
        private int _PersonID;
        private int _driverID;
        public LicenseHistoryForm()
        {
            InitializeComponent();
        }
        public LicenseHistoryForm(int LDLID)
        {
            InitializeComponent();
            clsLocalDrivingLicenseApplications Local = clsLocalDrivingLicenseApplications.Find(LDLID);
            if (Local != null) { 
            clsApplication application=clsApplication.Find(Local.ApplicationID);
                _PersonID = application.ApplicantPersonID;
                _driverID = clsDriver.GetDriverIDByPersonID(_PersonID);
                addOrUpdatePersonWithFilter1.DecableFillter();
            }
        }
        public void LoadDriverLicensesHistory(int DriverID)
        {
            clsDriver driver = clsDriver.Find(DriverID);
            if (driver != null) { 
            _driverID=driver.DriverID;
                _PersonID=driver.PersonID;
                addOrUpdatePersonWithFilter1.DecableFillter();
            }

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            
            if (_driverID != 0) {
                dgvLocalLicenses.DataSource = clsLocalDrivingLicenseApplications
                        .GetAllLocalLicenseForTheDriver(_driverID);
                lbRecords.Text=dgvLocalLicenses.RowCount.ToString();
            }
        }

        private void LicenseHistoryForm_Load(object sender, EventArgs e)
        {
           
            addOrUpdatePersonWithFilter1.FillPersonCard(_PersonID);
            //addOrUpdatePersonWithFilter1.Enabled = false;
            
            tabPage1_Click(sender, e);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
            if (_driverID != 0)
            {
                dgvInternationalLicenses.DataSource = clsInternationalLicenses
                        .GetAllInternationalLicenseForTheDriver(_driverID);
                lbIRecord.Text = dgvInternationalLicenses.RowCount.ToString();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) {
                tabPage1_Click(sender, e);
            }
            else
            {
                tabPage2_Click(sender, e);
            }
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseInfoForm form = new LicenseInfoForm((int)dgvLocalLicenses.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }
    }
}
