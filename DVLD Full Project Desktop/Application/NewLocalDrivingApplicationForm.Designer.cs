namespace DVLD_Full_Project_Desktop
{
    partial class NewLocalDrivingApplicationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buClos = new System.Windows.Forms.Button();
            this.buNext = new System.Windows.Forms.Button();
            this.addOrUpdatePersonWithFilter1 = new DVLD_Full_Project_Desktop.AddOrUpdatePersonWithFilter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buSave = new System.Windows.Forms.Button();
            this.buClose = new System.Windows.Forms.Button();
            this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(246, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(692, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Local Driving Application ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tabControl1.Location = new System.Drawing.Point(9, 106);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1121, 724);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buClos);
            this.tabPage1.Controls.Add(this.buNext);
            this.tabPage1.Controls.Add(this.addOrUpdatePersonWithFilter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1113, 689);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buClos
            // 
            this.buClos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buClos.ImageIndex = 0;
            this.buClos.Location = new System.Drawing.Point(718, 607);
            this.buClos.Name = "buClos";
            this.buClos.Size = new System.Drawing.Size(126, 42);
            this.buClos.TabIndex = 2;
            this.buClos.Text = "Close";
            this.buClos.UseVisualStyleBackColor = true;
            this.buClos.Click += new System.EventHandler(this.button1_Click);
            // 
            // buNext
            // 
            this.buNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buNext.ImageIndex = 3;
            this.buNext.Location = new System.Drawing.Point(870, 607);
            this.buNext.Name = "buNext";
            this.buNext.Size = new System.Drawing.Size(129, 42);
            this.buNext.TabIndex = 3;
            this.buNext.Text = "Next";
            this.buNext.UseVisualStyleBackColor = true;
            this.buNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // addOrUpdatePersonWithFilter1
            // 
            this.addOrUpdatePersonWithFilter1.Location = new System.Drawing.Point(-4, -3);
            this.addOrUpdatePersonWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addOrUpdatePersonWithFilter1.Name = "addOrUpdatePersonWithFilter1";
            this.addOrUpdatePersonWithFilter1.Size = new System.Drawing.Size(1134, 683);
            this.addOrUpdatePersonWithFilter1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buSave);
            this.tabPage2.Controls.Add(this.buClose);
            this.tabPage2.Controls.Add(this.cbLicenseClasses);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.lbCreatedBy);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.lbApplicationFees);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lbApplicationDate);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lbApplicationID);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1113, 689);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Applicaton Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buSave
            // 
            this.buSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buSave.ImageIndex = 1;
            this.buSave.Location = new System.Drawing.Point(479, 509);
            this.buSave.Name = "buSave";
            this.buSave.Size = new System.Drawing.Size(128, 55);
            this.buSave.TabIndex = 11;
            this.buSave.Text = "Save";
            this.buSave.UseVisualStyleBackColor = true;
            this.buSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // buClose
            // 
            this.buClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buClose.ImageIndex = 0;
            this.buClose.Location = new System.Drawing.Point(242, 509);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(142, 55);
            this.buClose.TabIndex = 10;
            this.buClose.Text = "Close";
            this.buClose.UseVisualStyleBackColor = true;
            this.buClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClasses.FormattingEnabled = true;
            this.cbLicenseClasses.Location = new System.Drawing.Point(285, 243);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(247, 30);
            this.cbLicenseClasses.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label10.Location = new System.Drawing.Point(40, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 26);
            this.label10.TabIndex = 8;
            this.label10.Text = "License Class : ";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbCreatedBy.Location = new System.Drawing.Point(280, 387);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(60, 26);
            this.lbCreatedBy.TabIndex = 7;
            this.lbCreatedBy.Text = "[???]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label9.Location = new System.Drawing.Point(40, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "Created By : ";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbApplicationFees.Location = new System.Drawing.Point(280, 314);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(60, 26);
            this.lbApplicationFees.TabIndex = 5;
            this.lbApplicationFees.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label7.Location = new System.Drawing.Point(40, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "Application Fees : ";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbApplicationDate.Location = new System.Drawing.Point(280, 185);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(60, 26);
            this.lbApplicationDate.TabIndex = 3;
            this.lbApplicationDate.Text = "[???]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label5.Location = new System.Drawing.Point(40, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Application Date : ";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.AutoSize = true;
            this.lbApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbApplicationID.Location = new System.Drawing.Point(280, 109);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(60, 26);
            this.lbApplicationID.TabIndex = 1;
            this.lbApplicationID.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label2.Location = new System.Drawing.Point(40, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "D.L.Application ID : ";
            // 
            // NewLocalDrivingApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 817);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewLocalDrivingApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewLocalDrivingApplicationForm";
            this.Load += new System.EventHandler(this.NewLocalDrivingApplicationForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private AddOrUpdatePersonWithFilter addOrUpdatePersonWithFilter1;
        private System.Windows.Forms.Button buClos;
        private System.Windows.Forms.Button buNext;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
        private System.Windows.Forms.Button buSave;
        private System.Windows.Forms.Button buClose;
    }
}