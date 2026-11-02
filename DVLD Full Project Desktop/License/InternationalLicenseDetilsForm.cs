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
    public partial class InternationalLicenseDetialsForm : Form
    {
        clsInternationalLicenses _InternationalLicense;
        public InternationalLicenseDetialsForm()
        {
            InitializeComponent();
        }
        public InternationalLicenseDetialsForm(clsInternationalLicenses International)
        {
            InitializeComponent();
            _InternationalLicense = International;
        }
        private void buClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InternationalLicenseDetialsForm_Load(object sender, EventArgs e)
        {
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
            internationalLicenseInfoControl1.RefreshData(_InternationalLicense);
        }
    }
}
