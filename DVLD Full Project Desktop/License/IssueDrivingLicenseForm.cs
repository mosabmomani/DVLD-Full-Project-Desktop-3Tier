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
    public partial class IssueDrivingLicenseForm : Form
    {
        private int _LDLID;
        private int _UserID;
        public IssueDrivingLicenseForm()
        {
            InitializeComponent();
        }
        public IssueDrivingLicenseForm(int LDLID,int userID)
        {
            InitializeComponent();
            _LDLID = LDLID;
            _UserID = userID;
        }

        private void buClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetImages()
        {
            buSave.Image = Properties.Resources.Save_32;
            buSave.ImageAlign = ContentAlignment.MiddleLeft;
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
        }
        private void applicationInfo1_Load(object sender, EventArgs e)
        {
            SetImages();
        }

        private void IssueDrivingLicenseForm_Load(object sender, EventArgs e)
        {
            applicationInfo1.RefreshData(_LDLID);
           
        }

        private void buSave_Click(object sender, EventArgs e)
        {
           clsLocalDrivingLicenseApplications Local=clsLocalDrivingLicenseApplications.Find(_LDLID);
            if (Local != null)
            {
                clsApplication application = clsApplication.Find(Local.ApplicationID);
                clsDriver driver= new clsDriver();
                if (application != null) {
                    if (!clsDriver.IsPersonUsed(application.ApplicantPersonID)) {
                      
                        driver.PersonID = application.ApplicantPersonID;
                        driver.CreatedDate = DateTime.Now;
                        driver.CreatedByUserID = _UserID;
                        driver.Save();
                    }
                    else
                    {
                        driver.DriverID = clsDriver.GetDriverIDByPersonID(application.ApplicantPersonID);
                    }
                        clsLicenseClasses LClass = clsLicenseClasses.Find(Local.LicenseClassID);
                    clsLicenses licenses=new clsLicenses();
                    licenses.ApplicationID=Local.ApplicationID;
                    licenses.DriverID=driver.DriverID;
                    licenses.LicenseClass = Local.LicenseClassID;
                    licenses.IssueDate=DateTime.Now;
                    licenses.ExpirationDate=DateTime.Now.AddYears(LClass.DefaultValidityLength);
                    licenses.Notes=textBox1.Text;
                    licenses.PaidFees=LClass.ClassFees;
                    licenses.IsActive=true;
                    licenses.IssueReason=(byte)application.ApplicationTypeID;
                    licenses.CreatedByUserID= _UserID;
                    if (licenses.Save())
                    {
                        MessageBox.Show($"license issued successfully ID {licenses.LicenseID}");
                        clsApplication.CompletedApplication(application.ApplicationID, 3);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("license issued failed");
                    }

                    
                
                }
            }
        }
    }
}
