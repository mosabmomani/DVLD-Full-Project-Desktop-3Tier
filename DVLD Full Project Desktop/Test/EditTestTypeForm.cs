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
    public partial class EditTestTypeForm : Form
    {
        clsTestTypes type;
      
        public EditTestTypeForm(int TestID)
        {
            InitializeComponent();
            type=clsTestTypes.Find(TestID);
        }
        private void SetImages()
        {
            buSave.Image = Properties.Resources.Save_32;
            buSave.ImageAlign = ContentAlignment.MiddleLeft;
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
        }
        private void EditTestTypeForm_Load(object sender, EventArgs e)
        {
            SetImages();
            lbID.Text=type.TestTypeID.ToString();
            tbTitle.Text=type.TestTypeTitle;
            tbDescription.Text=type.TestTypeDescription;
            tbFees.Text = type.TestTypeFees.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbFees.Text == "" || tbTitle.Text == ""|| tbDescription.Text=="")
            {
                MessageBox.Show("You need to fill up the boxes");
                return;
            }
            else if (!decimal.TryParse(tbFees.Text.ToString(), out decimal Fees))
            {
                MessageBox.Show("You can't use letters or special chars in fees box");
                return;
            }
            else
            {
                type.TestTypeTitle = tbTitle.Text;
                type.TestTypeDescription = tbDescription.Text;
                type.TestTypeFees = Fees;
                if (type.Update())
                {
                    MessageBox.Show("The Test Type Updated Successfully");
                }
                else
                {
                    MessageBox.Show("The Test Type Updated failed");
                }
            }
        }
    }
}
