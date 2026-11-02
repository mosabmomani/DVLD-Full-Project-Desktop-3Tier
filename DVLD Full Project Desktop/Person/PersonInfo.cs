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
    public partial class PersonInfo : Form
    {
        int ID = 0;
        public PersonInfo()
        {
            InitializeComponent();
        }
        public PersonInfo(int PersonID)
        {
            InitializeComponent();
            ID = PersonID;
            PersonCard card = new PersonCard(ID);
            this.Controls.Add(card);
            card.Location = new Point(0, 60);
        }

        private void PersonInfo_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
