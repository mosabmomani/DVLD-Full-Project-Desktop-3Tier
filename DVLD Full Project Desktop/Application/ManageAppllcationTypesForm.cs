using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace DVLD_Full_Project_Desktop
{
    public partial class ManageApplicationTypesForm : Form
    {
        private DataTable ApplicationData;
        public ManageApplicationTypesForm()
        {
            InitializeComponent();
            
           
        }
        private void RefreshData()
        {
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
        
        ApplicationData =clsApplicationTypes.GetAppllcationTypes();


            dgvApplicationData.DataSource =ApplicationData.DefaultView;
            if (dgvApplicationData.Columns.Contains("ApplicationTypeTitle"))
            {
                dgvApplicationData.Columns["ApplicationTypeTitle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            lbRecords.Text = ApplicationData.Rows.Count.ToString();
        }
        private void ManageAppllcationTypesForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditApplicationForm form = new EditApplicationForm((int)dgvApplicationData
                .CurrentRow.Cells[0].Value);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(500, 300);

            form.ShowDialog();
            RefreshData();
        }
    }
}
