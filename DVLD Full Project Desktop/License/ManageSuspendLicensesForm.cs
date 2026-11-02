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
    public partial class ManageSuspendLicensesForm : Form
    {
       private DataView dataTable;
        public ManageSuspendLicensesForm()
        {
            InitializeComponent();
        }
        public void refreshData()
        {

            SetImage();
            dataTable = clsSuspendLicenses.GetAllSuspendLicenses().DefaultView;
            dgvSuspendedLicense.DataSource = dataTable;
            if (dgvSuspendedLicense.Columns.Contains("FullName"))
            {
                dgvSuspendedLicense.Columns["FullName"].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
            }
            lbRecords.Text = dgvSuspendedLicense.Rows.Count.ToString();
          
            cbFindby.Items.Clear();
            foreach (DataGridViewColumn col in dgvSuspendedLicense.Columns)
            {
                cbFindby.Items.Add(col.Name);
            }
            cbFindby.SelectedIndex = 0;
        }
        private void ManageSuspendLicensesForm_Load(object sender, EventArgs e)
        {
            refreshData();


        }
        private void SetImage()
        {
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
            buSespend.Image = Properties.Resources.Detain_32;
            buSespend.ImageAlign = ContentAlignment.MiddleCenter;
            buRelease.Image = Properties.Resources.Release_Detained_License_32;
            buRelease.ImageAlign = ContentAlignment.MiddleCenter;
        }
        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            dataTable.RowFilter = "";

            dataTable.RowFilter = string.Format("convert([{0}],'System.String') like '{1}%'", cbFindby.Text, maskedTextBox1.Text);
            dgvSuspendedLicense.DataSource = dataTable;
            lbRecords.Text = dgvSuspendedLicense.Rows.Count.ToString();
        }

        private void buClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLicenses licenses = clsLicenses.Find((int)dgvSuspendedLicense.CurrentRow.Cells[1].Value);

            clsLocalDrivingLicenseApplications LDLID = clsLocalDrivingLicenseApplications.FindByApplicationID
                 (licenses.ApplicationID);
            if (LDLID != null)
            {
                LicenseInfoForm form = new LicenseInfoForm(
                LDLID.LocalDrivingLicenseApplicationID);
                form.ShowDialog();
            }
            
        }

        private void showLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLicenses licenses = clsLicenses.Find((int)dgvSuspendedLicense.CurrentRow.Cells[1].Value);

            clsLocalDrivingLicenseApplications LDLID = clsLocalDrivingLicenseApplications.FindByApplicationID
                 (licenses.ApplicationID);
            if (LDLID != null)
            {
                LicenseHistoryForm form = new LicenseHistoryForm
                 (LDLID.LocalDrivingLicenseApplicationID);
                form.ShowDialog();
            }
            
        }

        private void showPersonDetalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLicenses licenses = clsLicenses.Find((int)dgvSuspendedLicense.CurrentRow.Cells[1].Value);
            clsDriver driver= clsDriver.Find(licenses.DriverID);
            if (driver != null)
            {
                PersonInfo person = new PersonInfo(driver.PersonID);
                person.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SuspendLicenseForm form = new SuspendLicenseForm();
            form.ShowDialog();
            refreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReleaseSuspendedLicenseForm form = new ReleaseSuspendedLicenseForm();
            form.ShowDialog();
            refreshData();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseSuspendedLicenseForm form = new ReleaseSuspendedLicenseForm((int)dgvSuspendedLicense.CurrentRow.Cells[1].Value);
            form.ShowDialog();
            refreshData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            cmsreleaseLicense.Enabled = true;
            if ((bool)dgvSuspendedLicense.CurrentRow.Cells[8].Value)
            {
                cmsreleaseLicense.Enabled = false;
            }
        }
    }
}
