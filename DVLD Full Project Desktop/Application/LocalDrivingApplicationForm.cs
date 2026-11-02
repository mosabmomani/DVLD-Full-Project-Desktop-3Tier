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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD_Full_Project_Desktop
{
    public partial class LocalDrivingApplicationForm : Form
    {
        DataView dataTable;
        clsUser currentuser;
        public LocalDrivingApplicationForm()
        {
            InitializeComponent();
        }
        public LocalDrivingApplicationForm(clsUser user)
        {
            InitializeComponent();
            currentuser = user;
        }
        public void refreshData()
        {
           dataTable=clsLocalDrivingLicenseApplications.GetLocalDrivingLicenseApplications().DefaultView;
            dgvLocalDrivingApplication.DataSource = dataTable;
            if (dgvLocalDrivingApplication.Columns.Contains("FullName"))
            {
                dgvLocalDrivingApplication.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            lbRecords.Text = dgvLocalDrivingApplication.Rows.Count.ToString();
        }
        private void LocalDrivingApplicationForm_Load(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.New_Driving_License_32;
            button1.ImageAlign = ContentAlignment.MiddleCenter;
            refreshData();
            cbFindby.Items.Clear();
            foreach (DataGridViewColumn col in dgvLocalDrivingApplication.Columns) {
            cbFindby.Items.Add(col.Name);
            }
            cbFindby.SelectedIndex= 0;
           
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            dataTable.RowFilter = "";

            dataTable.RowFilter = string.Format("convert([{0}],'System.String') like '{1}%'", cbFindby.Text, maskedTextBox1.Text);
            dgvLocalDrivingApplication.DataSource = dataTable;
            lbRecords.Text = dgvLocalDrivingApplication.Rows.Count.ToString();
        }

        private void cbFindby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFindby.SelectedIndex == 0 || cbFindby.SelectedIndex == 5)
            {
                maskedTextBox1.Mask = "999999999";
            }
            else
                maskedTextBox1.Mask = "";
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.SelectionStart = 0;
            maskedTextBox1.SelectionLength = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        NewLocalDrivingApplicationForm applicationForm = new NewLocalDrivingApplicationForm(currentuser);
           
            applicationForm.ShowDialog();
            refreshData();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you went to cancel this application",
                "confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
          
            
            if(clsApplication.CancelApplication(
                (int)dgvLocalDrivingApplication
                .CurrentRow.Cells[1].Value, 2))
            {
                MessageBox.Show("The application canceled successfully ");
            }
            else
                MessageBox.Show("The application canceled failed ");

            refreshData();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

             
            if (MessageBox.Show($"Are you sure you went to delete The application"
                , "double check", MessageBoxButtons.YesNo) == DialogResult.Yes) {

                int LDLID = (int)dgvLocalDrivingApplication.CurrentRow.Cells[0].Value;
                clsLocalDrivingLicenseApplications applications
                = clsLocalDrivingLicenseApplications.Find(LDLID);
                if (clsLocalDrivingLicenseApplications.DeleteApplication(LDLID))
                {
                    MessageBox.Show("Application Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Application Deleted Failed");
                }
                refreshData();

            }
        }

        private void sechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sechduleWrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestsForm form = new TestsForm((int)dgvLocalDrivingApplication
               .CurrentRow.Cells[0].Value, 2, currentuser.UserID);

            form.ShowDialog();
            refreshData();
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            TestsForm form = new TestsForm((int)dgvLocalDrivingApplication
                .CurrentRow.Cells[0].Value,1,currentuser.UserID);

            form.ShowDialog();
            refreshData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            string Stutas = (string)dgvLocalDrivingApplication.CurrentRow.Cells[7].Value;
            showLicenseToolStripMenuItem.Enabled = false;
            if ( Stutas !="New")
            {

                CMSSechduleTest.Enabled = false;
                cancelToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                editApplicationToolStripMenuItem.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                
                if (Stutas== "Completed")
                {
                    showLicenseToolStripMenuItem.Enabled=true;
                    deleteApplicationToolStripMenuItem.Enabled = false;
                    return;
                }
                deleteApplicationToolStripMenuItem.Enabled = true;
                return;
            }

            CMSSechduleTest.Enabled = true;
            vToolStripMenuItem.Enabled = false;
            sechduleWrToolStripMenuItem.Enabled = false;
            sechduleStreetTestToolStripMenuItem.Enabled = false;
            cancelToolStripMenuItem.Enabled = true;
            deleteApplicationToolStripMenuItem.Enabled = true;
            editApplicationToolStripMenuItem.Enabled = true; 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
            CMSSechduleTest.Enabled = true;

            int PassedTest = (int)dgvLocalDrivingApplication.CurrentRow.Cells[6].Value;
            switch (PassedTest) { 
            case 0:
                    vToolStripMenuItem.Enabled = true;
                    break;
            case 1:
                    sechduleWrToolStripMenuItem.Enabled = true;
                    break;
            case 2:
                    sechduleStreetTestToolStripMenuItem.Enabled= true;
                   break;
                case 3:
                    CMSSechduleTest.Enabled = false;
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                    break;
             
            }
        }

        private void sechduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestsForm form = new TestsForm((int)dgvLocalDrivingApplication
               .CurrentRow.Cells[0].Value, 3, currentuser.UserID);

            form.ShowDialog();
            refreshData();
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueDrivingLicenseForm issue = new IssueDrivingLicenseForm
                ((int)dgvLocalDrivingApplication.CurrentRow.Cells[0].Value,currentuser.UserID);
            issue.ShowDialog();
            refreshData();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationDetailsForm detailsForm = new ApplicationDetailsForm(
                (int)dgvLocalDrivingApplication.CurrentRow.Cells[0].Value);
            
            detailsForm.ShowDialog();

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseInfoForm form = new LicenseInfoForm(
                (int)dgvLocalDrivingApplication.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void showDriverHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseHistoryForm form = new LicenseHistoryForm(
                (int)dgvLocalDrivingApplication.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
