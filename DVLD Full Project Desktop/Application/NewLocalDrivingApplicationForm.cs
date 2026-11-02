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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace DVLD_Full_Project_Desktop
{
    public partial class NewLocalDrivingApplicationForm : Form
    {
        clsUser user;
        decimal Fees = clsApplicationTypes.GetFees(1);
        public NewLocalDrivingApplicationForm()
        {
            InitializeComponent();
        }
        public NewLocalDrivingApplicationForm(clsUser CurrentUser)
        {
            InitializeComponent();
            user = CurrentUser;
            tabPage2.Enabled = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setImage()
        {
            buNext.Image = Properties.Resources.Next_32;
            buNext.ImageAlign = ContentAlignment.MiddleLeft;
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
            buSave.Image = Properties.Resources.Save_32;
            buSave.ImageAlign = ContentAlignment.MiddleLeft;
            buClos.Image = Properties.Resources.Close_32;
            buClos.ImageAlign = ContentAlignment.MiddleLeft;
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            if (addOrUpdatePersonWithFilter1.PID != 0)
            {
                tabPage2.Enabled=true;
             tabControl1.SelectTab(1);
                
                
            }
            else
            {
                MessageBox.Show("please choice a person");
            }
        }

        private void NewLocalDrivingApplicationForm_Load(object sender, EventArgs e)

        {
            setImage();
            lbApplicationDate.Text = DateTime.Now.ToShortDateString();
            lbCreatedBy.Text = user.UserName.ToString();
            lbApplicationFees.Text = Fees.ToString();

            DataTable dtLicenseClass = clsLicenseClasses.GetLicenseClass();
            cbLicenseClasses.DisplayMember = "ClassName";
            cbLicenseClasses.ValueMember = "LicenseClassID";
            cbLicenseClasses.DataSource = dtLicenseClass;

            cbLicenseClasses.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {  
            clsPerson person = clsPerson.FindPerson(addOrUpdatePersonWithFilter1.PID);
            if (person == null)
            {
                MessageBox.Show("please choice a person");
            }
            else
            {
               int DriverID= clsDriver.GetDriverIDByPersonID(person.PersonID);
                int selectedClassID = (int)cbLicenseClasses.SelectedValue;
                int AID = clsApplication.haveanactiveApplication(person.PersonID,
                    1, selectedClassID);
                
                
                int LID=0;
                if (( LID=clsLicenses.HaveAnActiveLicense(DriverID, selectedClassID)) > 0)
                {
                    MessageBox.Show($@"The person Have an active License with the 
                    same Class choice Different Class License,License ID {LID}");
                    return;
                }
                if (AID!=0)
                {
                    MessageBox.Show($@"The person with NationalNo {person.NationalNo} 
                    Have an active application with ID {AID}" );
                    return;
                }
                else
                {
                    clsApplication application=new clsApplication();
                    application.ApplicantPersonID = person.PersonID;
                    application.ApplicationDate=DateTime.Now;
                    application.ApplicationStatus = 1;
                    application.ApplicationTypeID = 1;
                    application.CreatedByUserID=user.UserID;
                    application.LastStatusDate=DateTime.Now;
                    application.PaidFees=Fees;
                    if (application.Save())
                    {
                    clsLocalDrivingLicenseApplications Local=new clsLocalDrivingLicenseApplications();
                     Local.ApplicationID=application.ApplicationID;
                        Local.LicenseClassID = selectedClassID;
                        if (Local.Save())
                        {
                          lbApplicationID.Text=Local.LocalDrivingLicenseApplicationID.ToString();
                          MessageBox.Show("Application Added Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Application Added Failed");
                        }
                    }
                }
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if(addOrUpdatePersonWithFilter1.PID== 0)
            {
                MessageBox.Show("choice a person");
                tabControl1.SelectedTab=tabPage1;
            }
        }
    }
}
