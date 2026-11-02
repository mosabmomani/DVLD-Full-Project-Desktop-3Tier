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
    public partial class EditApplicationForm : Form
    {
        private clsApplicationTypes ApplicationTypes;
       
        public EditApplicationForm(int ID)
        {
            InitializeComponent();
            ApplicationTypes = clsApplicationTypes.Find(ID);

        }
        private void SetImages()
        {
            buSave.Image = Properties.Resources.Save_32;
            buSave.ImageAlign = ContentAlignment.MiddleLeft;
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
        }
        private void EditApplicationForm_Load(object sender, EventArgs e)
        {
            SetImages();
            if (ApplicationTypes != null) {

                lbID.Text = ApplicationTypes.ApplicationID.ToString();
                tbTitle.Text = ApplicationTypes.ApplicationTypeTitle;
                tbFees.Text = ApplicationTypes.ApplicationFees.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFees_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbFees_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbFees.Text == "" || tbTitle.Text == "")
            {
                MessageBox.Show("You need to fill up the boxes");
                return;
            }
            else if(!decimal.TryParse(tbFees.Text.ToString(),out decimal Fees))
            {
                MessageBox.Show("You can't use letters or special chars in fees box");
                    return;
            }
            else
            {
                ApplicationTypes.ApplicationTypeTitle = tbTitle.Text;
                ApplicationTypes.ApplicationFees = Fees;
                if (ApplicationTypes.Update())
                {
                    MessageBox.Show("The Application Updated Successfully");
                }
                else
                {
                    MessageBox.Show("The Application Updated failed");
                }
            }
        }
    }
}
