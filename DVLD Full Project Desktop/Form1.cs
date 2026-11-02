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
    public partial class MainForm : Form
    {
        clsUser currentUser;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(clsUser user)
        {
            InitializeComponent();
            currentUser = user;

        }

        private void accountSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeopleForm peopleForm = new PeopleForm();
            peopleForm.MdiParent = this;
            peopleForm.Show();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentUser = null;
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            
            usersForm.MdiParent = this;
            usersForm.StartPosition = FormStartPosition.Manual;

            usersForm.Location = new Point(275, 100);
            usersForm.Show();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserCardForm form = new UserCardForm(currentUser.UserID,
              currentUser.PersonID);
            form.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePassword = new ChangePasswordForm(currentUser.UserID,
              currentUser.PersonID);
            changePassword.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriversForm driversForm = new DriversForm();
            driversForm.MdiParent = this;
            driversForm.StartPosition = FormStartPosition.Manual;
            driversForm.Location = new Point(275, 100);
            driversForm.Show();
        }

        private void manageAppToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageAppllcationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageApplicationTypesForm manage=new ManageApplicationTypesForm();
            manage.MdiParent = this;
            manage.StartPosition = FormStartPosition.Manual;
            manage.Location = new Point(375, 100);
            manage.Show();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestTypesForm testForm = new TestTypesForm();
            testForm.MdiParent = this;
            testForm.StartPosition = FormStartPosition.Manual;
            testForm.Location = new Point(400, 125);
            testForm.Show();
        }

        private void localDrivingApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDrivingApplicationForm local = new LocalDrivingApplicationForm(currentUser);
            local.MdiParent = this;
            local.StartPosition = FormStartPosition.Manual;
            local.Location = new Point(275, 100);
            local.Show();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocalDrivingApplicationForm form = new NewLocalDrivingApplicationForm(currentUser);
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(275, 30);
            form.Show();
        }

        private void internationalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInternationalLicenses International = new ManageInternationalLicenses(currentUser.UserID);
            International.MdiParent = this;
            International.StartPosition = FormStartPosition.Manual;
            International.Location = new Point(275, 100);
            International.Show();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseForm form = new NewInternationalLicenseForm();
            form.MdiParent = this;
            form.Show();
        }

        private void renewLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewLicenseForm renew= new RenewLicenseForm();
            renew.MdiParent = this;
            renew.Show();

        }

        private void replacementForLostOrDamagedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplacementLicenseForm replacement= new ReplacementLicenseForm();
            replacement.MdiParent = this;
            replacement.Show();
        }

        private void drivingLicToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageSuspendLiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageSuspendLicensesForm manageSuspend= new ManageSuspendLicensesForm();
            manageSuspend.MdiParent = this;
            manageSuspend.Show();
        }

        private void suspendLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuspendLicenseForm suspendLicense= new SuspendLicenseForm();
            suspendLicense.MdiParent = this;
            suspendLicense.Show();
        }

        private void releaseSuspendedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseSuspendedLicenseForm release= new ReleaseSuspendedLicenseForm();
            release.MdiParent = this;
            release.Show();
        }

        private void suspendLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SuspendLicenseForm suspendLicense = new SuspendLicenseForm();
            suspendLicense.MdiParent = this;
            suspendLicense.Show();
        }

        private void releaseSuspendedLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReleaseSuspendedLicenseForm release = new ReleaseSuspendedLicenseForm();
            release.MdiParent = this;
            release.Show();
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
