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
    public partial class LicenseInfoForm : Form
    {
        private int _LDL;
        public LicenseInfoForm(int LDL)
        {
            InitializeComponent();
            _LDL = LDL;
        }

        private void LicenseInfoForm_Load(object sender, EventArgs e)
        {
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
            licenseInfoControl1.RefreshData(_LDL);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
