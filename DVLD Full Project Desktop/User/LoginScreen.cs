using BusinessLayer;
using DVLD_Full_Project_Desktop.Properties;
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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           clsUser user = clsUser.Find(txbUsername.Text,txbPassword.Text);
            if (user != null) {
                if (user.IsActive)
                {
                    clsGlobal.CurrentUser = user;
                    if (clsGlobal.CurrentUser != null)
                    {
                        if (cbRememberMe.Checked)
                        {
                            clsGlobal.RememberUserNameAndPasswordInRegistry(user.UserName, user.Password);
                        }
                        else
                        {
                            clsGlobal.DeleteSortedCredentialFromRegistry();
                        }
                    }
                    MainForm form = new MainForm(user);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("the User is not Active ,Please contact your manager");
                }
            
            }
            else
            {
                MessageBox.Show("Username/Password Is not Correct");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            buLogin.Image = Properties.Resources.sign_in_32;
            buLogin.ImageAlign = ContentAlignment.MiddleLeft;
            string Username="";
            string Password="";
            clsGlobal.GetSortedCredentialFromRegistry(ref  Username, ref Password); 
            clsGlobal.CurrentUser=clsUser.Find(Username, Password);
            if (clsGlobal.CurrentUser != null) { 
             txbUsername.Text = Username;
             txbPassword.Text = Password;
                cbRememberMe.Checked = true;
            }
        }
    }
}
