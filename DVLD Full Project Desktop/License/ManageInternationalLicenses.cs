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
    public partial class ManageInternationalLicenses : Form
    {
        DataView dataTable;
        int _UserID;
        public ManageInternationalLicenses()
        {
            InitializeComponent();
        }
        public ManageInternationalLicenses(int UserID)
        {
            InitializeComponent();
            _UserID=UserID;
        }
      
            public void SetImage()
        {
            buAddNewLicense.Image = Properties.Resources.New_Driving_License_32;
            buAddNewLicense.ImageAlign = ContentAlignment.MiddleCenter;
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
        }
        
        public void refreshData()
        {
            SetImage();
            dataTable =clsInternationalLicenses.GetAllInternationalLicenses().DefaultView;
            dgvInternationalDrivingApplication.DataSource = dataTable;
            if (dgvInternationalDrivingApplication.Columns.Contains("ExpirationDate"))
            {
                dgvInternationalDrivingApplication.Columns["ExpirationDate"].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
            }
            lbRecords.Text = dgvInternationalDrivingApplication.Rows.Count.ToString();
        }
        private void ManageInternationalLicenses_Load(object sender, EventArgs e)
        {
            refreshData();
            cbFindby.Items.Clear();
            foreach (DataGridViewColumn col in dgvInternationalDrivingApplication.Columns)
            {
                cbFindby.Items.Add(col.Name);
            }
            cbFindby.SelectedIndex = 0;
        }

        private void showPersonLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplications LDLID = clsLocalDrivingLicenseApplications.FindByApplicationID
                 ((int)dgvInternationalDrivingApplication.CurrentRow.Cells[1].Value);
            
                LicenseHistoryForm form = new LicenseHistoryForm
                (LDLID.LocalDrivingLicenseApplicationID);
            form.ShowDialog();
        }

        private void buClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            dataTable.RowFilter = "";

            dataTable.RowFilter = string.Format("convert([{0}],'System.String') like '{1}%'", cbFindby.Text, maskedTextBox1.Text);
            dgvInternationalDrivingApplication.DataSource = dataTable;
            lbRecords.Text = dgvInternationalDrivingApplication.Rows.Count.ToString();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDriver driver = clsDriver.Find(
                (int)dgvInternationalDrivingApplication.CurrentRow.Cells[2].Value);
            if (driver != null)
            {
                PersonInfo person = new PersonInfo(driver.PersonID);
                person.ShowDialog();
            }
            
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsInternationalLicenses International = clsInternationalLicenses.Find((int)dgvInternationalDrivingApplication.CurrentRow.Cells[0].Value);
            InternationalLicenseDetialsForm detialsForm = 
                new InternationalLicenseDetialsForm(International);
           
            detialsForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseForm form = new NewInternationalLicenseForm();
            
            form.Show();
        }
    }
}
