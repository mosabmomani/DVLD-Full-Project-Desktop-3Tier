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
    public partial class TestsForm : Form
    {
        int LocalDriverLID;
        int _TestType;
        DataView Test;
        int ReTestTry;
        int User;

        private enum Type {VisionTest=1,WrittenTest=2,StreetTest=3};
        private Type _Type;
        public TestsForm()
        {
            InitializeComponent();
        }
        public TestsForm(int LDLID,int TestType,int UserID)
        {
            InitializeComponent();
            LocalDriverLID = LDLID;
            _Type = (Type)TestType;
            _TestType = TestType;
            User = UserID;
        }
        private void RefreshData()
        {
            Test =clsTestAppointments.GetAppointmentsShort(LocalDriverLID, _TestType).DefaultView;
            dgvTestAppointment.DataSource = Test;
            ReTestTry = dgvTestAppointment.RowCount;
            lbRecords.Text= ReTestTry.ToString();

        }

        private void TestsForm_Load(object sender, EventArgs e)

        {
            buAppointments.Image = Properties.Resources.AddAppointment_32;
            buAppointments.ImageAlign = ContentAlignment.MiddleCenter;
            applicationInfo1.RefreshData(LocalDriverLID);
           
            switch (_Type)
            {
                case Type.VisionTest:
                    lbTest.Text = "Vision Test";
                    pictureBox1.Image = Properties.Resources.medical;
                    break;
                case Type.WrittenTest:
                    lbTest.Text = "Written Test";
                    pictureBox1.Image = Properties.Resources.exam;
                    break;
                case Type.StreetTest:
                    lbTest.Text = "Street Test";
                    pictureBox1.Image = Properties.Resources.exam;
                    break;
            }
            RefreshData();


        }
      
        private void applicationInfo1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clsTestAppointments.HaveAnActiveAppointment(LocalDriverLID, _TestType))
            {
                MessageBox.Show("The person have an active Appointment");
                return;
            }
            if (clsTests.PassedTheTest(LocalDriverLID,_TestType))
            {
                MessageBox.Show("The person have passed the test ");
                return;
            }
            AddNewTestForm add = new AddNewTestForm(LocalDriverLID, _TestType,ReTestTry,User);
            add.ShowDialog();
            RefreshData();
        }

        private void edetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTestForm add = new AddNewTestForm((int)dgvTestAppointment.CurrentRow.Cells[0].Value
                ,LocalDriverLID,ReTestTry, _TestType, User);
                add.ShowDialog();
            RefreshData();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeTestForm Test = new TakeTestForm(LocalDriverLID, _TestType, ReTestTry, User,
                (int)dgvTestAppointment.CurrentRow.Cells[0].Value);
            Test.ShowDialog();
            RefreshData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            cmsEdit.Enabled = true;
            cmsTakeTest.Enabled = true;

            if ((bool)dgvTestAppointment.CurrentRow.Cells[4].Value)
            {
                cmsEdit.Enabled=false;
                cmsTakeTest.Enabled=false;
            }
        }
    }
}
