using BusinessLayer;
using BusinessLayerLogic;
using DVLD_Full_Project_Desktop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace DVLD_Full_Project_Desktop
{
    public partial class AddOrUpdatePerson : UserControl
    {
        public clsPerson Person;
        public int ID =-1;
        private enum Mode { AddMode=1,UpdateMode=2}
        private Mode _Mode=Mode.UpdateMode;

        public AddOrUpdatePerson()
        {
            InitializeComponent();
            _Mode = Mode.AddMode;
            
        }
        public AddOrUpdatePerson(int PersonID)
        {
            InitializeComponent();
           ID = PersonID;
            _Mode = Mode.UpdateMode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void _FillContryInCombobox()
        {
            DataTable view = clsCountry.GetAllCountries();
            this.DateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            this.DateOfBirth.MinDate = DateTime.Now.AddYears(-148);
            this.DateOfBirth.Value = this.DateOfBirth.MaxDate;
            foreach (DataRow row in view.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
            cbCountry.SelectedIndex = cbCountry.FindString("jORDAN");
        }
        private void AddOrUpdatePerson_Load(object sender, EventArgs e)
        {
            
            _FillContryInCombobox();
            txbFirstName.Focus();
            switch (_Mode)
            {
                case Mode.AddMode:
                    {
                        Person=new clsPerson();
                      
                      
                        break;
                    }
                case Mode.UpdateMode:
                    {
                        Person = clsPerson.FindPerson(ID);

                        if (Person == null)
                        {
                            MessageBox.Show($"The person with {ID} was not found");
                        }
                        else
                        {
                            txbFirstName.Text = Person.FirstName;
                            txbSecondName.Text = Person.SecondName;
                            txbThirdName.Text = Person.ThirdName;
                            txbLastName.Text = Person.LastName;
                            txbEmail.Text = Person.Email;
                            txbAddress.Text = Person.Address;
                            txbNotionalNo.Text = Person.NationalNo;
                            txbPhone.Text = Person.Phone;
                            if (Person.Gendor == 1)
                            {
                                rbMale.Select();
                            }
                            else
                            {
                                rdFemale.Select();
                            }
                            DateOfBirth.Text = Person.DateOfBirth.ToString();
                            if (Person.ImagePath != "")
                            {
                                pictureBox1.ImageLocation = Person.ImagePath;
                                llbRemove.Enabled = true;
                            }
                            else
                            {
                                pictureBox1.ImageLocation = Person.ImagePath;
                                llbRemove.Enabled = false;
                            }

                            cbCountry.SelectedIndex = Person.NationalityCountryID;
                           

                           
                        }
                        break;
                    }


            }
        }

        public bool Save()
        {
           
            Person.FirstName = txbFirstName.Text;
            Person.SecondName = txbSecondName.Text;
            Person.ThirdName = txbThirdName.Text;
            Person.LastName = txbLastName.Text;
            Person.Email = txbEmail.Text;
            Person.Address = txbAddress.Text;
            Person.NationalNo = txbNotionalNo.Text;
            Person.Phone = txbPhone.Text;
            Person.DateOfBirth = Convert.ToDateTime((DateOfBirth.Value));
            Person.NationalityCountryID = cbCountry.SelectedIndex+1;
            if (Person.ImagePath != "")
            {
                Person.ImagePath = pictureBox1.ImageLocation;
                
            }
            if (rdFemale.Checked)
            {
                Person.Gendor = 2;
            }
            else
            {
                Person.Gendor = 1;
            }
           
            if (Person.Save())
            {

                MessageBox.Show("The Person Saved Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ID = Person.PersonID;
                _Mode = Mode.UpdateMode;
                return true;

            }
            else
            {
                MessageBox.Show("The Person Saved failed", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
           
        }
       

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(Person.ImagePath=="")
            pictureBox1.Image = Properties.Resources.profile;
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (Person.ImagePath == "")
                pictureBox1.Image = Properties.Resources.woman;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string DistinsFile = @"C:\PeopleImage\";

            if (!Directory.Exists(DistinsFile))
            {
                Directory.CreateDirectory(DistinsFile);
            }

            openFileDialog1.Filter = "Image Filter | *.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourcefilename = openFileDialog1.FileName;
                string extension = Path.GetExtension(sourcefilename);
                string NewFileName = Guid.NewGuid().ToString() + extension;
                string finalpath = Path.Combine(DistinsFile, NewFileName);

                try
                {
                    File.Copy(sourcefilename, finalpath, true);

                    
                    using (var tempImage = Image.FromFile(finalpath))
                    {
                        pictureBox1.Image = new Bitmap(tempImage);
                    }

                    Person.ImagePath = finalpath;
                    pictureBox1.ImageLocation = Person.ImagePath;
                    llbRemove.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void llbRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            pictureBox1.ImageLocation = null;

            if (rbMale.Checked)
                pictureBox1.Image = Properties.Resources.profile;
            else
                pictureBox1.Image = Properties.Resources.woman;

            if (!string.IsNullOrEmpty(Person.ImagePath) && File.Exists(Person.ImagePath))
            {
                try
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Delete(Person.ImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            Person.ImagePath = "";
            llbRemove.Enabled = false;

        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }
        private void txbFirstName_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }

        private void txbSecondName_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }

       

        private void txbLastName_Validating(object sender, CancelEventArgs e)
        {

            ValidateEmptyTextBox(sender, e);
        }

        private void txbNotionalNo_Validating(object sender, CancelEventArgs e)
        {
            if (_Mode != Mode.UpdateMode)
            {
                if (string.IsNullOrEmpty(txbNotionalNo.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txbNotionalNo, "Notional No Is required!");
                }
                else if (clsPerson.IsExist(txbNotionalNo.Text))
                {
                   
                    errorProvider1.SetError(txbNotionalNo, "Notional No Is Exist");
                }
                else
                {
                    
                    errorProvider1.SetError(txbNotionalNo, "");
                }
            }
        }

        private void txbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!txbEmail.Text.EndsWith("@gmail.com")&&!string.IsNullOrEmpty(txbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbEmail, "Email have to end whit @gmail.com");
            }
            else
            {
               
                errorProvider1.SetError(txbEmail, "");
            }
        }

        private void txbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbPhone.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(txbPhone, "Phone Is required!");
            }
            else
            {
                
                errorProvider1.SetError(txbPhone, "");
            }
        }

        private void txbAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }

        private void txbFirstName_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbFirstName.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(txbFirstName, "FirstName Is required!");
            }
            else
            {
                
                errorProvider1.SetError(txbFirstName, "");
            }
        }

        private void txbPhone_Validating_1(object sender, CancelEventArgs e)
        {
            if (!txbPhone.MaskCompleted)
            {
                e.Cancel = true;

                errorProvider1.SetError(txbPhone, "Phone Is required!");
            }
            else
            {
               
                errorProvider1.SetError(txbPhone, "");
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
