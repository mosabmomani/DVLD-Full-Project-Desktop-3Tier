namespace DVLD_Full_Project_Desktop
{
    partial class PersonCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonCard));
            this.gbPersonInfo = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbGendor = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbNationalNo = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPersonInfo
            // 
            this.gbPersonInfo.Controls.Add(this.linkLabel2);
            this.gbPersonInfo.Controls.Add(this.pictureBox1);
            this.gbPersonInfo.Controls.Add(this.lbCountry);
            this.gbPersonInfo.Controls.Add(this.label6);
            this.gbPersonInfo.Controls.Add(this.lbPhone);
            this.gbPersonInfo.Controls.Add(this.label10);
            this.gbPersonInfo.Controls.Add(this.lbDateOfBirth);
            this.gbPersonInfo.Controls.Add(this.label13);
            this.gbPersonInfo.Controls.Add(this.lbAddress);
            this.gbPersonInfo.Controls.Add(this.label15);
            this.gbPersonInfo.Controls.Add(this.lbEmail);
            this.gbPersonInfo.Controls.Add(this.label17);
            this.gbPersonInfo.Controls.Add(this.lbGendor);
            this.gbPersonInfo.Controls.Add(this.label19);
            this.gbPersonInfo.Controls.Add(this.lbNationalNo);
            this.gbPersonInfo.Controls.Add(this.label21);
            this.gbPersonInfo.Controls.Add(this.lbName);
            this.gbPersonInfo.Controls.Add(this.label23);
            this.gbPersonInfo.Controls.Add(this.lbPersonID);
            this.gbPersonInfo.Controls.Add(this.label25);
            this.gbPersonInfo.Location = new System.Drawing.Point(3, 3);
            this.gbPersonInfo.Name = "gbPersonInfo";
            this.gbPersonInfo.Size = new System.Drawing.Size(865, 353);
            this.gbPersonInfo.TabIndex = 0;
            this.gbPersonInfo.TabStop = false;
            this.gbPersonInfo.Text = "Person Info";
            this.gbPersonInfo.Enter += new System.EventHandler(this.gbPersonInfo_Enter);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Enabled = false;
            this.linkLabel2.Location = new System.Drawing.Point(578, 53);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(248, 31);
            this.linkLabel2.TabIndex = 39;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Update Person Info";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Full_Project_Desktop.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(665, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbCountry.Location = new System.Drawing.Point(518, 254);
            this.lbCountry.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 26);
            this.lbCountry.TabIndex = 37;
            this.lbCountry.Text = "[???]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label6.Location = new System.Drawing.Point(362, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 26);
            this.label6.TabIndex = 36;
            this.label6.Text = "Country:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbPhone.Location = new System.Drawing.Point(518, 196);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(60, 26);
            this.lbPhone.TabIndex = 35;
            this.lbPhone.Text = "[???]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label10.Location = new System.Drawing.Point(362, 196);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 26);
            this.label10.TabIndex = 34;
            this.label10.Text = "Phone:";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbDateOfBirth.Location = new System.Drawing.Point(518, 137);
            this.lbDateOfBirth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(60, 26);
            this.lbDateOfBirth.TabIndex = 33;
            this.lbDateOfBirth.Text = "[???]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label13.Location = new System.Drawing.Point(362, 137);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 26);
            this.label13.TabIndex = 32;
            this.label13.Text = "Date Of Birth:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbAddress.Location = new System.Drawing.Point(188, 323);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(60, 26);
            this.lbAddress.TabIndex = 31;
            this.lbAddress.Text = "[???]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label15.Location = new System.Drawing.Point(19, 323);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 26);
            this.label15.TabIndex = 30;
            this.label15.Text = "Address:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbEmail.Location = new System.Drawing.Point(188, 266);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(60, 26);
            this.lbEmail.TabIndex = 29;
            this.lbEmail.Text = "[???]";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label17.Location = new System.Drawing.Point(19, 266);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 26);
            this.label17.TabIndex = 28;
            this.label17.Text = "Email:";
            // 
            // lbGendor
            // 
            this.lbGendor.AutoSize = true;
            this.lbGendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbGendor.Location = new System.Drawing.Point(188, 209);
            this.lbGendor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbGendor.Name = "lbGendor";
            this.lbGendor.Size = new System.Drawing.Size(60, 26);
            this.lbGendor.TabIndex = 27;
            this.lbGendor.Text = "[???]";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label19.Location = new System.Drawing.Point(19, 209);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 26);
            this.label19.TabIndex = 26;
            this.label19.Text = "Gendor:";
            // 
            // lbNationalNo
            // 
            this.lbNationalNo.AutoSize = true;
            this.lbNationalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbNationalNo.Location = new System.Drawing.Point(188, 156);
            this.lbNationalNo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNationalNo.Name = "lbNationalNo";
            this.lbNationalNo.Size = new System.Drawing.Size(60, 26);
            this.lbNationalNo.TabIndex = 25;
            this.lbNationalNo.Text = "[???]";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label21.Location = new System.Drawing.Point(19, 156);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 26);
            this.label21.TabIndex = 24;
            this.label21.Text = "National No:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbName.ForeColor = System.Drawing.Color.Red;
            this.lbName.Location = new System.Drawing.Point(188, 105);
            this.lbName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(60, 26);
            this.lbName.TabIndex = 23;
            this.lbName.Text = "[???]";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label23.Location = new System.Drawing.Point(19, 105);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 26);
            this.label23.TabIndex = 22;
            this.label23.Text = "Name:";
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbPersonID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPersonID.Location = new System.Drawing.Point(188, 53);
            this.lbPersonID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(60, 26);
            this.lbPersonID.TabIndex = 21;
            this.lbPersonID.Text = "[???]";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label25.ImageList = this.imageList1;
            this.label25.Location = new System.Drawing.Point(19, 53);
            this.label25.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(115, 26);
            this.label25.TabIndex = 20;
            this.label25.Text = "Person ID:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "label.png");
            this.imageList1.Images.SetKeyName(1, "profile (1).png");
            // 
            // PersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPersonInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PersonCard";
            this.Size = new System.Drawing.Size(877, 364);
            this.Load += new System.EventHandler(this.PersonCard_Load);
            this.gbPersonInfo.ResumeLayout(false);
            this.gbPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonInfo;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbGendor;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbNationalNo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ImageList imageList1;
    }
}
