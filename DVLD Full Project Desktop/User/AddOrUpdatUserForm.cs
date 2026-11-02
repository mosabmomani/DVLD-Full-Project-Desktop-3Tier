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
    public partial class AddOrUpdatUserForm : Form
    {
        private int UID = 0;
        private int PID = 0;
        
        clsUser user;
        enum Mode { AddMode=1,UpdateMode=2}
        private Mode _mode;
        public AddOrUpdatUserForm()
        {
            InitializeComponent();
            tabPage2.Enabled = false;
            _mode = Mode.AddMode;
            lbMode.Text = "Add User";
        }
        public AddOrUpdatUserForm(int UserID,int PersonID)
        {
            InitializeComponent();
            
            UID = UserID;
           PID = PersonID;

            addOrUpdatePersonWithFilter1.PID = this.PID;
            addOrUpdatePersonWithFilter1.FillPersonCard(PersonID);
            addOrUpdatePersonWithFilter1.Enabled = false;

            _mode = Mode.UpdateMode;
            lbMode.Text = "Update User";
            lbUserID.Text=UserID.ToString();

            user = clsUser.Find(UserID);
            tbUsername.Text = user.UserName;
            tbPassword.Text = user.Password;
            tbCPassword.Text = user.Password;
            checkBox3.Checked = user.IsActive;
            tabPage2.Enabled = true;

        }
        private void SetImages()
        {
            buNext.Image = Properties.Resources.Next_32;
            buNext.ImageAlign = ContentAlignment.MiddleLeft;
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
            buSave2.Image = Properties.Resources.Save_32;
            buSave2.ImageAlign = ContentAlignment.MiddleLeft;
            buClose2.Image = Properties.Resources.Close_32;
            buClose2.ImageAlign = ContentAlignment.MiddleLeft;
            buBack.Image = Properties.Resources.Prev_32;
            buBack.ImageAlign = ContentAlignment.MiddleLeft;
        }
        private void AddOrUpdatUserForm_Load(object sender, EventArgs e)
        {
            SetImages();


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (addOrUpdatePersonWithFilter1.PID != 0  )
            {
                if (!clsUser.IsPersonUesd(addOrUpdatePersonWithFilter1.PID) || !addOrUpdatePersonWithFilter1.Enabled) {
                    tabPage2.Enabled = true;
                    tabControl1.SelectTab(1);

                }
                else
                {
                    MessageBox.Show("the person you choice is Used");
                }
            }
            else {
                MessageBox.Show("please choice a person");
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void addOrUpdatePersonWithFilter1_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbCPassword.PasswordChar = '\0';
            }
            else
            {
                tbCPassword.PasswordChar = '*';
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "" )
            {

                if (tbPassword.Text == tbCPassword.Text&&tbPassword.Text!="") {
                    if (_mode == Mode.AddMode)
                    {
                        if (clsUser.IsUsernameUesd(tbUsername.Text))
                        {
                            MessageBox.Show("The username is used change it", "Used Username", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        user = new clsUser();
                    }
                    else
                    {
                        user = clsUser.Find(UID);
                        

                    }
                    user.UserName = tbUsername.Text;
                    user.Password = tbPassword.Text;
                    user.PersonID=addOrUpdatePersonWithFilter1.PID;
                   user.IsActive= checkBox3.Checked;
                    if (user.Save())
                    {
                        MessageBox.Show("user saved successfully");
                        lbUserID.Text = user.UserID.ToString();
                        lbMode.Text = "Update";
                        UID = user.UserID;
                        _mode= Mode.UpdateMode;
                        addOrUpdatePersonWithFilter1.Enabled=false;
                        
                    }
                    else
                    {
                        MessageBox.Show("user saved failed");
                    }
                    
                }
                else
                {
                    MessageBox.Show("The passwords does not match");
                }
            }
            else
            {
                MessageBox.Show("you need to fill the user name");
            }
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text))
            {

                errorProvider1.SetError(tbUsername, "UserName Is Required");
            }
            else
            {

                errorProvider1.SetError(tbUsername, "");
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text))
            {

                errorProvider1.SetError(tbPassword, "Password Is Required");
            }
            else
            {

                errorProvider1.SetError(tbPassword, "");
            }
        }

        private void tbCPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbCPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbPassword.Text != tbCPassword.Text)
            {

                errorProvider1.SetError(tbCPassword, "Password does not match");
            }

            else
            {

                errorProvider1.SetError(tbCPassword, "");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_Click_1(object sender, EventArgs e)
        {
            if (addOrUpdatePersonWithFilter1.PID == 0)
            {
                MessageBox.Show("choice a person");
                tabControl1.SelectedTab = tabPage1;
                
            }
        }
    }
}
