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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD_Full_Project_Desktop
{
    public partial class DriversForm : Form
    {
       
        DataTable Table;
        public DriversForm()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            Table = clsDriver.GetAllDrivers();
           dgvDrivers.DataSource=clsDriver.GetAllDrivers().DefaultView;
        }

        private void clsDriversForm_Load(object sender, EventArgs e)
        {
           RefreshData();
            cobSortBy.Items.Clear();
            foreach (DataColumn column in Table.Columns)
            {
                cobSortBy.Items.Add(column.ColumnName);
            }
            cobSortBy.SelectedIndex = 0;

            if (dgvDrivers.Columns.Contains("FullName"))
            {
                dgvDrivers.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            lbRecords.Text=Table.Rows.Count.ToString();
        }

        private void cobSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobSortBy.SelectedIndex == 3 || cobSortBy.SelectedIndex == 2)
                maskedTextBox1.Mask = "";

            else if (cobSortBy.SelectedIndex == 4)
                maskedTextBox1.Mask = "00/00/0000";

            else
                maskedTextBox1.Mask = "999999999";

        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.SelectionStart = 0;
            maskedTextBox1.SelectionLength = 0;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (cobSortBy.Text == "CreatedDate")
            {
                Table.DefaultView.RowFilter = string.Format(@"Convert(CreatedDate,'System.String')
               LIKE '{0}%'", maskedTextBox1.Text.Trim());
            }
            else
            {
                Table.DefaultView.RowFilter = string.Format("convert([{0}],'System.String') like '{1}%'", cobSortBy.Text, maskedTextBox1.Text);
                dgvDrivers.DataSource = Table;
            }
            lbRecords.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

       

        private void deleteDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure you went to delete this Driver","Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            if (clsDriver.DeleteDriver((int)dgvDrivers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Deleted successfully");
                RefreshData();
            }
            else
            {
                MessageBox.Show("Deleted Failed");
            }
        }

        private void showLicensesPersonHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseHistoryForm historyForm = new LicenseHistoryForm();
            historyForm.LoadDriverLicensesHistory((int)dgvDrivers.CurrentRow.Cells[0].Value);
            
            historyForm.ShowDialog();
        }

        private void driverCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonInfo person=new PersonInfo((int)dgvDrivers.CurrentRow.Cells[1].Value);
            person.ShowDialog();
        }
    }
}
