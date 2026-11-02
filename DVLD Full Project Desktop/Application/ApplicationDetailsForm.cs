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
    public partial class ApplicationDetailsForm : Form
    {
        int _LDLID;
        public ApplicationDetailsForm()
        {
            InitializeComponent();
        }
        public ApplicationDetailsForm(int LDLID)
        {
            InitializeComponent();
            _LDLID = LDLID;
        }
        private void ApplicationDetailsForm_Load(object sender, EventArgs e)
        {
            applicationInfo1.RefreshData(_LDLID);
        }

        private void applicationInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
