namespace DVLD_Full_Project_Desktop
{
    partial class ReplacementLicenseForm
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
            this.llbShowLesense = new System.Windows.Forms.LinkLabel();
            this.llbShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.buRenew = new System.Windows.Forms.Button();
            this.buClose = new System.Windows.Forms.Button();
            this.cnlicenseInfo = new DVLD_Full_Project_Desktop.LicenseInfoControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buSearch = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.jnj = new System.Windows.Forms.Label();
            this.lbReplacementLicenseID = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // llbShowLesense
            // 
            this.llbShowLesense.AutoSize = true;
            this.llbShowLesense.Enabled = false;
            this.llbShowLesense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.llbShowLesense.Location = new System.Drawing.Point(256, 747);
            this.llbShowLesense.Name = "llbShowLesense";
            this.llbShowLesense.Size = new System.Drawing.Size(123, 22);
            this.llbShowLesense.TabIndex = 25;
            this.llbShowLesense.TabStop = true;
            this.llbShowLesense.Text = "ShowLesense";
            this.llbShowLesense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowLesense_LinkClicked);
            // 
            // llbShowLicensesHistory
            // 
            this.llbShowLicensesHistory.AutoSize = true;
            this.llbShowLicensesHistory.Enabled = false;
            this.llbShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.llbShowLicensesHistory.Location = new System.Drawing.Point(32, 747);
            this.llbShowLicensesHistory.Name = "llbShowLicensesHistory";
            this.llbShowLicensesHistory.Size = new System.Drawing.Size(192, 22);
            this.llbShowLicensesHistory.TabIndex = 24;
            this.llbShowLicensesHistory.TabStop = true;
            this.llbShowLicensesHistory.Text = "Show Licenses History";
            this.llbShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowLicensesHistory_LinkClicked);
            // 
            // buRenew
            // 
            this.buRenew.Enabled = false;
            this.buRenew.Location = new System.Drawing.Point(798, 741);
            this.buRenew.Name = "buRenew";
            this.buRenew.Size = new System.Drawing.Size(214, 49);
            this.buRenew.TabIndex = 23;
            this.buRenew.Text = "Issue Replacement";
            this.buRenew.UseVisualStyleBackColor = true;
            this.buRenew.Click += new System.EventHandler(this.buRenew_Click);
            // 
            // buClose
            // 
            this.buClose.Location = new System.Drawing.Point(632, 741);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(141, 49);
            this.buClose.TabIndex = 22;
            this.buClose.Text = "Close";
            this.buClose.UseVisualStyleBackColor = true;
            this.buClose.Click += new System.EventHandler(this.buClose_Click);
            // 
            // cnlicenseInfo
            // 
            this.cnlicenseInfo.Location = new System.Drawing.Point(9, 132);
            this.cnlicenseInfo.Name = "cnlicenseInfo";
            this.cnlicenseInfo.Size = new System.Drawing.Size(1014, 510);
            this.cnlicenseInfo.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buSearch);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.groupBox1.Location = new System.Drawing.Point(9, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 73);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // buSearch
            // 
            this.buSearch.Location = new System.Drawing.Point(433, 17);
            this.buSearch.Name = "buSearch";
            this.buSearch.Size = new System.Drawing.Size(69, 53);
            this.buSearch.TabIndex = 2;
            this.buSearch.UseVisualStyleBackColor = true;
            this.buSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(166, 28);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(204, 32);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "License ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 44);
            this.label1.TabIndex = 19;
            this.label1.Text = "Replacement License Application";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(671, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 71);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Replacement For";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Lost License";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(139, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Damaged License";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCreatedBy);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.lbApplicationFees);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lbApplicationDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbOldLicenseID);
            this.groupBox2.Controls.Add(this.jnj);
            this.groupBox2.Controls.Add(this.lbReplacementLicenseID);
            this.groupBox2.Controls.Add(this.lbApplicationID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 529);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(882, 192);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Applicatoin Info for License Replacement";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbCreatedBy.Location = new System.Drawing.Point(616, 141);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(50, 22);
            this.lbCreatedBy.TabIndex = 25;
            this.lbCreatedBy.Text = "[???]";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label.Location = new System.Drawing.Point(381, 141);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(110, 22);
            this.label.TabIndex = 24;
            this.label.Text = "Created By :";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbApplicationFees.Location = new System.Drawing.Point(187, 141);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(50, 22);
            this.lbApplicationFees.TabIndex = 23;
            this.lbApplicationFees.Text = "[???]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label14.Location = new System.Drawing.Point(6, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 22);
            this.label14.TabIndex = 22;
            this.label14.Text = "Application Fees :";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbApplicationDate.Location = new System.Drawing.Point(187, 89);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(50, 22);
            this.lbApplicationDate.TabIndex = 21;
            this.lbApplicationDate.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(6, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Application Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(381, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Old License ID :";
            // 
            // lbOldLicenseID
            // 
            this.lbOldLicenseID.AutoSize = true;
            this.lbOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbOldLicenseID.Location = new System.Drawing.Point(616, 89);
            this.lbOldLicenseID.Name = "lbOldLicenseID";
            this.lbOldLicenseID.Size = new System.Drawing.Size(50, 22);
            this.lbOldLicenseID.TabIndex = 18;
            this.lbOldLicenseID.Text = "[???]";
            // 
            // jnj
            // 
            this.jnj.AutoSize = true;
            this.jnj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.jnj.Location = new System.Drawing.Point(381, 47);
            this.jnj.Name = "jnj";
            this.jnj.Size = new System.Drawing.Size(214, 22);
            this.jnj.TabIndex = 17;
            this.jnj.Text = "Replacement License ID :";
            // 
            // lbReplacementLicenseID
            // 
            this.lbReplacementLicenseID.AutoSize = true;
            this.lbReplacementLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbReplacementLicenseID.Location = new System.Drawing.Point(616, 47);
            this.lbReplacementLicenseID.Name = "lbReplacementLicenseID";
            this.lbReplacementLicenseID.Size = new System.Drawing.Size(50, 22);
            this.lbReplacementLicenseID.TabIndex = 16;
            this.lbReplacementLicenseID.Text = "[???]";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.AutoSize = true;
            this.lbApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbApplicationID.Location = new System.Drawing.Point(187, 42);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(50, 22);
            this.lbApplicationID.TabIndex = 15;
            this.lbApplicationID.Text = "[???]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "L.R.Application ID :";
            // 
            // ReplacementLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 840);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.llbShowLesense);
            this.Controls.Add(this.llbShowLicensesHistory);
            this.Controls.Add(this.buRenew);
            this.Controls.Add(this.buClose);
            this.Controls.Add(this.cnlicenseInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReplacementLicenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReplacementLicenseForm";
            this.Load += new System.EventHandler(this.ReplacementLicenseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel llbShowLesense;
        private System.Windows.Forms.LinkLabel llbShowLicensesHistory;
        private System.Windows.Forms.Button buRenew;
        private System.Windows.Forms.Button buClose;
        private LicenseInfoControl cnlicenseInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buSearch;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.Label jnj;
        private System.Windows.Forms.Label lbReplacementLicenseID;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label label9;
    }
}