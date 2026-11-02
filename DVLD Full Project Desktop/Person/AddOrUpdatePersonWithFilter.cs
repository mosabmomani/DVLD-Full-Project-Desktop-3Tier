using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Full_Project_Desktop
{
    public partial class AddOrUpdatePersonWithFilter : UserControl
    {

        
        private clsPerson person;
        public int PID = 0;
        public int UID = 0;
       
        public AddOrUpdatePersonWithFilter()
        {
            
            InitializeComponent();
           
           
        }

        public AddOrUpdatePersonWithFilter(int PersonID)
        {

            InitializeComponent();
            PID = PersonID;
            comboBox1.SelectedIndex = 0;
            mtbFind.Text = PID.ToString();
            FillPersonCard(PersonID);
        }
        private void AddOrUpdatePersonWithFilter_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
        public void DecableFillter()
        {
            gbFillter.Enabled=false;
        }

       public void fillPersoncard()
        {
           
            
            if (comboBox1.Text == "PersonID")
            {
                

                if (int.TryParse(mtbFind.Text, out int id))
                {
                    
                    person = clsPerson.FindPerson(id);
                        if (person == null)
                        {
                            MessageBox.Show($"Person with ID {mtbFind.Text} Not Fond");
                            return;
                        }
                        PID = person.PersonID;
                        personCard1.UpdateCard(id);
                      
                    
                }

            }
            else
            {
               
                 person = clsPerson.FindPerson(mtbFind.Text);
                
                    if (person == null)
                    {
                        MessageBox.Show($"Person with Notional No {mtbFind.Text} Not Fond");
                        return;
                    }
                
                    personCard1.UpdateCard(mtbFind.Text);
                    PID = person.PersonID;
                
            }
            
        }
        public void FillPersonCard(int PersonID)
        {
            comboBox1.SelectedIndex = 0;


            if (comboBox1.Text == "PersonID" )
            {
                mtbFind.Text = PersonID.ToString();
                 person = clsPerson.FindPerson(PersonID);
                    if (person == null)
                    {
                        MessageBox.Show($"Person with ID {mtbFind.Text} Not Fond");
                        return;
                    }
                    PID = person.PersonID;
                    personCard1.UpdateCard(PersonID);


                

            }
          

        }
        private void button2_Click(object sender, EventArgs e)
        {
          
            fillPersoncard();
            
        }

        private void personCard1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrUpdatePersonForm person = new AddOrUpdatePersonForm();
            person.DataBack += person_DataBack;

            person.StartPosition = FormStartPosition.CenterScreen;

            
            person.ShowDialog();
            
            buSch.PerformClick();
        }
        
        private void person_DataBack(object sender, int PersonID)
        {
            mtbFind.Text=PersonID.ToString();

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbFind.Text = string.Empty;
            if (comboBox1.SelectedIndex == 0) {
                mtbFind.Mask = "9999999";
            }
            else
            {
                mtbFind.Mask = null;
            }
        }

        private void mtbFind_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbFind_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
