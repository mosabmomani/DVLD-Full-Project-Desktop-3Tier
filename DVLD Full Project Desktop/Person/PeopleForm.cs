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
    public partial class PeopleForm : Form
    {
        private DataView dataView = clsPerson.GetShortViewPeople().DefaultView;
        
        public PeopleForm()
        {
            
            InitializeComponent();
        }
        private void RefreshData()
        {
            dataGridView1.DataSource = clsPerson.GetShortViewPeople().DefaultView;
            lbRecords.Text = dataView.Count.ToString();
        }
        private void PeopleForm_Load(object sender, EventArgs e)
        {
            RefreshData();
    
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                comboBox1.Items.Add(column.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void personCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonInfo person = new PersonInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
            person.ShowDialog();
            RefreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataView.Sort= (string)comboBox1.SelectedItem;
            if (comboBox1.Text == "PersonID")
            {
                maskedTextBox1.Mask = "999999999";

            }
            else
            {
                maskedTextBox1.Mask = "";

            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            dataView.RowFilter = "";
          
            dataView.RowFilter =string.Format("convert([{0}],'System.String') like '{1}%'",comboBox1.Text,maskedTextBox1.Text);
            dataGridView1.DataSource = dataView;
            lbRecords.Text=dataGridView1.Rows.Count.ToString();
            
        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrUpdatePersonForm form = new AddOrUpdatePersonForm((int)dataGridView1.CurrentRow.Cells[0].Value);  
            form.ShowDialog();
            RefreshData();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrUpdatePersonForm form = new AddOrUpdatePersonForm();
            form.ShowDialog();
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrUpdatePersonForm form = new AddOrUpdatePersonForm();
            form.ShowDialog();
            RefreshData();
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            if (MessageBox.Show($"Are you sure you went to delete the person with ID {personID}","Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            if (clsPerson.DeletePerson(personID))
            {
                MessageBox.Show("Deleted successfully");
                RefreshData();
            }
            else
            {
                MessageBox.Show("Deleted Failed");
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }
        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.SelectionStart = 0;
            maskedTextBox1.SelectionLength = 0;
        }
    }
}
