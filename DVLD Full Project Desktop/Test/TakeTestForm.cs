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
    public partial class TakeTestForm : Form
    {
        private int _TestType;
        private int _LDLID;
        private int _TrialNumber;
        private int _UserID;
        private int _AppID;
        private clsTestTypes types;
        private clsFullApplicationInfo FullInfo;
        private clsTestAppointments appointments;
        private enum Type { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };
        private Type _Type;
        public TakeTestForm()
        {
            InitializeComponent();
        }
        public TakeTestForm(int LDLID, int TestType, int tryN, int userID,int appID)
        {
            InitializeComponent();
            FullInfo = clsFullApplicationInfo.Find(LDLID);
            _AppID = appID;
            _Type = (Type)TestType;
            this._LDLID = LDLID;
            this._TrialNumber = tryN;
            this._TestType = TestType;
            this._UserID = userID;
            types = clsTestTypes.Find(_TestType);
        }

        private void buClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetImages()
        {
            buSave.Image = Properties.Resources.Save_32;
            buSave.ImageAlign = ContentAlignment.MiddleLeft;
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
        }
        private void RefreshData()
        {
            SetImages();

            appointments = new clsTestAppointments();


           if (FullInfo != null)
                {
                    lbDClass.Text = FullInfo.ClassName.ToString();
                    lbFees.Text = types.TestTypeFees.ToString();
                    lbName.Text = FullInfo.FullName.ToString();
                    dateTimePicker1.Text = DateTime.Now.AddDays(1).ToShortDateString();
                    lbDLApplicationID.Text = _LDLID.ToString();
                    lbTrial.Text = _TrialNumber.ToString();
                }

            


          
        }
        public void SetImage()
        {
            buSave.Image = Properties.Resources.Save_32;
            buSave.ImageAlign = ContentAlignment.MiddleCenter;
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleCenter;
        }
        private void TakeTestForm_Load(object sender, EventArgs e)
        {
            SetImage();
            rbPass.Checked = true;
            dateTimePicker1.Value=DateTime.Now;
            switch (_Type)
            {
                case Type.VisionTest:

                    pictureBox1.Image = Properties.Resources.medical;
                    break;
                case Type.WrittenTest:

                    pictureBox1.Image = Properties.Resources.exam;
                    break;
                case Type.StreetTest:

                    pictureBox1.Image = Properties.Resources.exam;
                    break;
            }
            RefreshData();
        }

        private void buSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you went to save that?,You will not be able to change it later","Confirm save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            clsTests tests = new clsTests();
            tests.TestAppointmentID = _AppID;
            tests.TestResult = rbPass.Checked;
            tests.CreatedByUserID = _UserID;
            tests.Notes=textBox1.Text;
            if (tests.AddNewTest())
            {
                MessageBox.Show($"The Test Result Added successfully at {tests.TestID}");
                this.Close();
            }
            else
            {
                MessageBox.Show($"The Test Result Added Failed");
            }
            clsTestAppointments.LocktheAppointment(_AppID);
        }
    }
}
