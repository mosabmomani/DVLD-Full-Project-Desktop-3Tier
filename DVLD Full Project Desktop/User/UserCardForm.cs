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
    public partial class UserCardForm : Form
    {
        private int UID = 0;
        private int PID = 0;
        public UserCardForm()
        {
            InitializeComponent();
        }
        public UserCardForm(int UserID,int PersonID)
        {
            InitializeComponent();
            UID = UserID;
            PID = PersonID;

        }

        private void UserCardForm_Load(object sender, EventArgs e)
        {
            PersonCard card = new PersonCard(PID);
            this.Controls.Add(card);
            card.Location = new Point(0, 0);
            UserInfo userInfo = new UserInfo(UID);
            this.Controls.Add(userInfo);
            userInfo.Location = new Point(50, 360);
        }
    }
}
