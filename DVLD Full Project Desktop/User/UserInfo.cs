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
    public partial class UserInfo : UserControl
    {
        private clsUser user;
        public UserInfo()
        {
            InitializeComponent();
        }
        public UserInfo(int UserID)
        {
            InitializeComponent();
            user=clsUser.Find(UserID);
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            lbUserID.Text=user.UserID.ToString();
            lbUsername.Text=user.UserName;
            if (user.IsActive == true)
            {
                lbIsActive.Text = "Yes";
            }
            else { lbIsActive.Text = "No"; }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
