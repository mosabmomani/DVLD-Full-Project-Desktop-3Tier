using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Full_Project_Desktop
{
    public partial class AddOrUpdatePersonForm : Form
    {
        private AddOrUpdatePerson OpenAddOrUpdate;
        int ID = -1;

        //Declare a delegate
        public delegate void DataBackEvent(object sender, int PersonID);

        //Declare an event using the delegate
        public event DataBackEvent DataBack;

        public AddOrUpdatePersonForm()
        {
            InitializeComponent();
            label1.Text = "Add Person";

        }
        public AddOrUpdatePersonForm(int id)
        {
            InitializeComponent();
            ID = id;
            label1.Text = "Update Person";
            lbPersonID.Text=id.ToString();
        }
        private void SetImages()
        {
            buSave.Image = Properties.Resources.Save_32;
            buSave.ImageAlign = ContentAlignment.MiddleLeft;
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
        }
        private void AddOrUpdatePersonForm_Load(object sender, EventArgs e)
        {
            SetImages();

            if (ID == -1) {
                OpenAddOrUpdate = new AddOrUpdatePerson();
                this.Controls.Add(OpenAddOrUpdate);
                OpenAddOrUpdate.Location = new Point(10, 90);
                
            }
            else
            {
                 OpenAddOrUpdate = new AddOrUpdatePerson(ID);
                this.Controls.Add(OpenAddOrUpdate);
                OpenAddOrUpdate.Location = new Point(10, 90);
            }
            OpenAddOrUpdate.TabIndex = 0;
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(lbPersonID.Text);

            DataBack?.Invoke(this, PersonID);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (OpenAddOrUpdate.Save())
                {
                    label1.Text = "Update";
                    lbPersonID.Text = OpenAddOrUpdate.ID.ToString();
                }
                
            }
        }
    }
}
