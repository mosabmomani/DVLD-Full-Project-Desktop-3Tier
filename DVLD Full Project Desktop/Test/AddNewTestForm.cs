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
    public partial class AddNewTestForm : Form
    {

        private int _TestType;
        private int _LDLID;
        private int _Trial;
        private int _UserID;
        private int _AppID;
        private clsTestTypes types;
        private clsFullApplicationInfo FullInfo;
        private clsTestAppointments appointments;

        private enum Mode { AddMode=1, UpdateMode=2 }
        private Mode _Mode=Mode.UpdateMode;
        private enum Type { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };
        private Type _Type;
        

        public AddNewTestForm()
        {
            InitializeComponent();
        }
        public AddNewTestForm(int LDLID, int TestType,int tryN,int userID)
        {
            InitializeComponent();
          FullInfo=clsFullApplicationInfo.Find(LDLID);

            _Type = (Type)TestType;
            this._LDLID = LDLID;
            this._Trial = tryN;
            this._TestType = TestType;
            this._UserID = userID;
             types = clsTestTypes.Find(_TestType);
           
            _Mode = Mode.AddMode;
        }
        public AddNewTestForm(int AID, int LDLID, int tryN, int TestType, int userID)
        {
            InitializeComponent();
            FullInfo = clsFullApplicationInfo.Find(LDLID);
            this._AppID = AID;
            _Mode = Mode.UpdateMode;
            this._Trial = tryN;
            this._TestType = TestType;
            this._UserID = userID;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
       private void RefreshData()
        {
         
            buSave.Image = Properties.Resources.Save_32;
            buSave.ImageAlign = ContentAlignment.MiddleLeft;
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleLeft;
       
            if (_Mode == Mode.AddMode)
            {
                appointments = new clsTestAppointments();
            }
            else
            {
                appointments = clsTestAppointments.Find(_AppID);
            }


            if (_Mode == Mode.UpdateMode)
            {
                lbDClass.Text = FullInfo.ClassName.ToString();
                lbFees.Text = appointments.PaidFees.ToString();
                lbName.Text = FullInfo.FullName.ToString();
                dateTimePicker1.Text = appointments.AppointmentDate.ToString();
                lbDLApplicationID.Text = _LDLID.ToString();
                lbTrial.Text = _Trial.ToString();
                lbTestID.Text =appointments.TestTypeID.ToString();


            }
            else
            {
                if (FullInfo != null)
                {

                    if (FullInfo != null)
                    {
                        lbDClass.Text = FullInfo.ClassName.ToString();
                        lbFees.Text = types.TestTypeFees.ToString();
                        lbName.Text = FullInfo.FullName.ToString();
                        dateTimePicker1.Text = DateTime.Now.AddDays(1).ToShortDateString();
                        lbDLApplicationID.Text = _LDLID.ToString();
                        lbTrial.Text = _Trial.ToString();
                    }

                }
            }

            if (_Trial > 0&&_Mode==Mode.AddMode)
            {
                gbRetakeTest.Enabled = true;
                lbRAF.Text = types.TestTypeFees.ToString();
                decimal RetakeFees = clsApplicationTypes.GetFees(8);
                lbRetakeFees.Text = RetakeFees.ToString();
                lbTotalFees.Text = (types.TestTypeFees + RetakeFees).ToString();

            }



        }
        public void SetImage()
        {
            buSave.Image = Properties.Resources.Save_32;
            buSave.ImageAlign = ContentAlignment.MiddleCenter;
            buClose.Image = Properties.Resources.Close_32;
            buClose.ImageAlign = ContentAlignment.MiddleCenter;
        }
        private void AddNewTestForm_Load(object sender, EventArgs e)
        {
            
            dateTimePicker1.MinDate=DateTime.Now;
            SetImage();

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

        private void buClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buSave_Click(object sender, EventArgs e)
        {
            
            
            if (appointments != null)
            {
                if (_Mode == Mode.UpdateMode)
                {
                    appointments.AppointmentDate = dateTimePicker1.Value;
                    if (appointments.Save())
                    {
                        MessageBox.Show("Appointment Updated Successfully");
                        this.Close();
                    }
                }
                else
                {
                    appointments.TestTypeID = _TestType;
                    appointments.LocalDrivingLicenseApplicationID = _LDLID;
                    appointments.AppointmentDate = dateTimePicker1.Value;
                    if (gbRetakeTest.Enabled)
                    {
                        appointments.PaidFees = Convert.ToDecimal(lbTotalFees.Text);
                    }
                    else
                    {
                        appointments.PaidFees = Convert.ToDecimal(lbFees.Text);
                    }
                    appointments.CreatedByUserID = _UserID;
                    appointments.IsLocked = false;
                    if (appointments.Save())
                    {
                        MessageBox.Show("Appointment Add Successfully");
                        this.Close();
                    }
                    
                }
                
            }
        }
    }
}
