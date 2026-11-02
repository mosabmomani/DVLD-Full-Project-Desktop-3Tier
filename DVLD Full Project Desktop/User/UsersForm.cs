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
    public partial class UsersForm : Form
    {
        public static DataView UserData=clsUser.GetAllUsers().DefaultView;
        public void RefreshData()
        {
            dgvUsers.DataSource = clsUser.GetAllUsers().DefaultView;
            lbRecords.Text=dgvUsers.RowCount.ToString();

        }
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            RefreshData();
            comboBox1.Items.Clear();
            foreach (DataGridViewColumn column in dgvUsers.Columns)
            {
                comboBox1.Items.Add(column.Name);
            }
            if (dgvUsers.Columns.Contains("FullName"))
            {
                dgvUsers.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            {
                maskedTextBox1.Mask = "999999999";
            }
            else
                maskedTextBox1.Mask = "";
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

            UserData.RowFilter = string.Format("convert([{0}],'System.String') like '{1}%'", comboBox1.Text, maskedTextBox1.Text);
            dgvUsers.DataSource = UserData;
            lbRecords.Text = dgvUsers.Rows.Count.ToString();

        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.SelectionStart = 0;
            maskedTextBox1.SelectionLength = 0;
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUser user =clsGlobal.CurrentUser;
            if (user.UserID == (int)dgvUsers.CurrentRow.Cells[0].Value) {
                MessageBox.Show("You can't delete your self");
                return;
            }
            if (MessageBox.Show("Are you sure you went to delete this user", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                if (clsUser.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    
                    MessageBox.Show("User Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("User Deleted Failed because it has related data");
                }
                RefreshData();
            }
        }

        private void userCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserCardForm form = new UserCardForm((int)dgvUsers.CurrentRow.Cells[0].Value,
                (int)dgvUsers.CurrentRow.Cells[1].Value);
            form.ShowDialog();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePassword = new ChangePasswordForm((int)dgvUsers.CurrentRow.Cells[0].Value,
                (int)dgvUsers.CurrentRow.Cells[1].Value);
            changePassword.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrUpdatUserForm add = new AddOrUpdatUserForm();
            add.ShowDialog();
            RefreshData();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrUpdatUserForm add = new AddOrUpdatUserForm();
            add.ShowDialog();
            RefreshData();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrUpdatUserForm add = new AddOrUpdatUserForm((int)dgvUsers.CurrentRow.Cells[0].Value, (int)dgvUsers.CurrentRow.Cells[1].Value);
            add.ShowDialog();
            RefreshData();
        }
    }
}
