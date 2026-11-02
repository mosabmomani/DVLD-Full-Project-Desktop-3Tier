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
    public partial class TestTypesForm : Form
    {
        DataTable dt = new DataTable();
         private void RefreshData()
        {
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
            dt =clsTestTypes.GetTestTypes();
            dgvTestType.DataSource = dt.DefaultView;
            if (dgvTestType.Columns.Contains("TestTypeDescription"))
            {
                dgvTestType.Columns["TestTypeDescription"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            lbRecords.Text = dgvTestType.Rows.Count.ToString();
        }
        public TestTypesForm()
        {
            InitializeComponent();
        }

        private void TestTypesForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTestTypeForm form = new EditTestTypeForm((int)dgvTestType
                .CurrentRow.Cells[0].Value);
            form.ShowDialog();
            RefreshData();
        }
    }
}
