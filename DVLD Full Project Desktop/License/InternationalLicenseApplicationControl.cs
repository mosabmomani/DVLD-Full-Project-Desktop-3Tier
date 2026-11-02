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
    public partial class InternationalLicenseApplicationControl : UserControl
    {
        public InternationalLicenseApplicationControl()
        {
            InitializeComponent();
        }

        public void RefreshData(int ILicenseID)
        {
            clsInternationalLicenses licenses = clsInternationalLicenses.Find(ILicenseID);
            if (licenses == null) {
                return;
            }
            lbApplicationID.Text = licenses.ApplicationID.ToString();
            lbApplicationDate.Text=licenses.IssueDate.ToShortDateString();
            lbIssueDate.Text = licenses.IssueDate.ToShortDateString();
            lbFees.Text = clsApplicationTypes.GetFees(6).ToString();
            lbILicenseID.Text=licenses.InternationalLicenseID.ToString();
            lbLocalLicenseID.Text=licenses.IssuedUsingLocalLicenseID.ToString();
            lbExpirationDate.Text = licenses.ExpirationDate.ToShortDateString();
            lbCreatedBy.Text=clsGlobal.CurrentUser.UserName;
            

        }
        private void InternationalLicenseApplicationControl_Load(object sender, EventArgs e)
        {
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
