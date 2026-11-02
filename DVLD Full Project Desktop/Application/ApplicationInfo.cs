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
    
    public partial class ApplicationInfo : UserControl
    {
        private clsFullApplicationInfo FullInfo;


        public ApplicationInfo()
        {
            InitializeComponent();
        }
       
        public void RefreshData(int LDL)
        {
            clsLocalDrivingLicenseApplications Local = clsLocalDrivingLicenseApplications.Find(LDL);
            if (Local != null) { 
            lbDLApplicationID.Text=Local.LocalDrivingLicenseApplicationID.ToString();
             FullInfo= clsFullApplicationInfo.Find(LDL);
                if (FullInfo != null) { 
                lbAppliedForLicense.Text=FullInfo.ClassName.ToString();
                lbPassedTests.Text=FullInfo.PassedTestCount.ToString()+" of 3";
                lbID.Text = FullInfo.ApplicantPersonID.ToString();
                lbStatus.Text = FullInfo.Status.ToString();
                lbFees.Text=FullInfo.PaidFees.ToString();    
                lbType.Text=FullInfo.ApplicationTypeTitle.ToString();
                lbName.Text=FullInfo.FullName.ToString();
                lbDate.Text=FullInfo.ApplicationDate.ToShortDateString();
                lbStatusDate.Text=FullInfo.LastStatusDate.ToShortDateString();
                lbCreatedBy.Text=FullInfo.UserName.ToString();
                }
            
            }

            

        }

        private void ApplicationInfo_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FullInfo != null) { 
            PersonInfo person=new PersonInfo(FullInfo.ApplicantPersonID);
               
                person.StartPosition = FormStartPosition.Manual;
                person.Location = new Point(275, 200);
                person.ShowDialog();
            
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
