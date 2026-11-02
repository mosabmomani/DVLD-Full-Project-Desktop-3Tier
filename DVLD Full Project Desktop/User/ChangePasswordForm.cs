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
    public partial class ChangePasswordForm : Form
    {
        private int UID = 0;
        private int PID = 0;
        private clsUser user;
        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        public ChangePasswordForm(int UserID, int PersonID)
        {
            InitializeComponent();
            UID = UserID;
            PID = PersonID;
            user = clsUser.Find(UID);

        }
        private void SetImages()
        {
            buSave.Image = Properties.Resources.Save_32;
            buSave.ImageAlign = ContentAlignment.MiddleLeft;
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            SetImages();
            PersonCard card = new PersonCard(PID);
            this.Controls.Add(card);
            card.Location = new Point(0, 0);
            UserInfo userInfo = new UserInfo(UID);
            this.Controls.Add(userInfo);
            userInfo.Location = new Point(50, 360);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (user != null)
            {
                if (user.Password == txbCurrentPassword.Text) {
                    if (txbConfirmPassword.Text == txbNewPassword.Text &&
                         !string.IsNullOrEmpty(txbNewPassword.Text))
                    {
                        user.Password=txbNewPassword.Text;
                        if (user.Save())
                        {
                            MessageBox.Show("Password updated successfully");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Password updated Failed");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("New Password and Confirm Password do not match or empty");
                        return;
                    }
                   
                }
                else
                {
                    MessageBox.Show("current password is wrong");
                    return;
                }
            }
            else { MessageBox.Show("User Was Not Found"); }

        }

        private void txbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txbNewPassword.Text != txbConfirmPassword.Text)
            {
                errorProvider1.SetError(txbConfirmPassword, "The passwords do not match");
            }
            else
            {
                errorProvider1.SetError(txbConfirmPassword, "");
            }
        }

        private void txbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txbCurrentPassword.Text != user.Password) { 
            errorProvider1.SetError(txbCurrentPassword, "current Password is wrong");
            
            }
            else
            {
                errorProvider1.SetError(txbCurrentPassword, "");
            }
        }
    }
}
