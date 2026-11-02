namespace DVLD_Full_Project_Desktop
{
    partial class RenewLicenseForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buSearch = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCreatedByUser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbRenewedLicenseID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbLicenseFees = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbApplictionDate = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbRLApplicationID = new System.Windows.Forms.Label();
            this.labal = new System.Windows.Forms.Label();
            this.cnlicenseInfo = new DVLD_Full_Project_Desktop.LicenseInfoControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // llbShowLesense
            // 
            this.llbShowLesense.AutoSize = true;
            this.llbShowLesense.Enabled = false;
            this.llbShowLesense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.llbShowLesense.Location = new System.Drawing.Point(256, 806);
            this.llbShowLesense.Name = "llbShowLesense";
            this.llbShowLesense.Size = new System.Drawing.Size(123, 22);
            this.llbShowLesense.TabIndex = 17;
            this.llbShowLesense.TabStop = true;
            this.llbShowLesense.Text = "ShowLesense";
            this.llbShowLesense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowLesense_LinkClicked);
            // 
            // llbShowLicensesHistory
            // 
            this.llbShowLicensesHistory.AutoSize = true;
            this.llbShowLicensesHistory.Enabled = false;
            this.llbShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.llbShowLicensesHistory.Location = new System.Drawing.Point(16, 806);
            this.llbShowLicensesHistory.Name = "llbShowLicensesHistory";
            this.llbShowLicensesHistory.Size = new System.Drawing.Size(192, 22);
            this.llbShowLicensesHistory.TabIndex = 16;
            this.llbShowLicensesHistory.TabStop = true;
            this.llbShowLicensesHistory.Text = "Show Licenses History";
            this.llbShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowLicensesHistory_LinkClicked);
            // 
            // buRenew
            // 
            this.buRenew.Enabled = false;
            this.buRenew.Location = new System.Drawing.Point(841, 798);
            this.buRenew.Name = "buRenew";
            this.buRenew.Size = new System.Drawing.Size(138, 49);
            this.buRenew.TabIndex = 15;
            this.buRenew.Text = "Renew";
            this.buRenew.UseVisualStyleBackColor = true;
            this.buRenew.Click += new System.EventHandler(this.buIssueLicense_Click);
            // 
            // buClose
            // 
            this.buClose.Location = new System.Drawing.Point(650, 798);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(151, 49);
            this.buClose.TabIndex = 14;
            this.buClose.Text = "Close";
            this.buClose.UseVisualStyleBackColor = true;
            this.buClose.Click += new System.EventHandler(this.buClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buSearch);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.groupBox1.Location = new System.Drawing.Point(9, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 73);
            this.groupBox1.TabIndex = 11;
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
            this.label1.Location = new System.Drawing.Point(252, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Renew License Application";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbNotes);
            this.groupBox2.Controls.Add(this.lbTotalFees);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbCreatedByUser);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbExpirationDate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbOldLicenseID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbRenewedLicenseID);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lbLicenseFees);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.lbApplicationFees);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.lbIssueDate);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.lbApplictionDate);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lbRLApplicationID);
            this.groupBox2.Controls.Add(this.labal);
            this.groupBox2.Location = new System.Drawing.Point(16, 536);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 253);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application New License Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(630, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "Notes :";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(634, 66);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(236, 165);
            this.tbNotes.TabIndex = 44;
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbTotalFees.Location = new System.Drawing.Point(525, 205);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(50, 22);
            this.lbTotalFees.TabIndex = 43;
            this.lbTotalFees.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(341, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 42;
            this.label4.Text = "Total Fees :";
            // 
            // lbCreatedByUser
            // 
            this.lbCreatedByUser.AutoSize = true;
            this.lbCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbCreatedByUser.Location = new System.Drawing.Point(525, 158);
            this.lbCreatedByUser.Name = "lbCreatedByUser";
            this.lbCreatedByUser.Size = new System.Drawing.Size(50, 22);
            this.lbCreatedByUser.TabIndex = 41;
            this.lbCreatedByUser.Text = "[???]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.Location = new System.Drawing.Point(341, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 22);
            this.label6.TabIndex = 40;
            this.label6.Text = "Created By User :";
            // 
            // lbExpirationDate
            // 
            this.lbExpirationDate.AutoSize = true;
            this.lbExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbExpirationDate.Location = new System.Drawing.Point(525, 114);
            this.lbExpirationDate.Name = "lbExpirationDate";
            this.lbExpirationDate.Size = new System.Drawing.Size(50, 22);
            this.lbExpirationDate.TabIndex = 39;
            this.lbExpirationDate.Text = "[???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label8.Location = new System.Drawing.Point(341, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Expiration Date :";
            // 
            // lbOldLicenseID
            // 
            this.lbOldLicenseID.AutoSize = true;
            this.lbOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbOldLicenseID.Location = new System.Drawing.Point(525, 62);
            this.lbOldLicenseID.Name = "lbOldLicenseID";
            this.lbOldLicenseID.Size = new System.Drawing.Size(50, 22);
            this.lbOldLicenseID.TabIndex = 37;
            this.lbOldLicenseID.Text = "[???]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label10.Location = new System.Drawing.Point(341, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 22);
            this.label10.TabIndex = 36;
            this.label10.Text = "Old LicenseID";
            // 
            // lbRenewedLicenseID
            // 
            this.lbRenewedLicenseID.AutoSize = true;
            this.lbRenewedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbRenewedLicenseID.Location = new System.Drawing.Point(525, 18);
            this.lbRenewedLicenseID.Name = "lbRenewedLicenseID";
            this.lbRenewedLicenseID.Size = new System.Drawing.Size(50, 22);
            this.lbRenewedLicenseID.TabIndex = 35;
            this.lbRenewedLicenseID.Text = "[???]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label12.Location = new System.Drawing.Point(341, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 22);
            this.label12.TabIndex = 34;
            this.label12.Text = "Renewed LicenseID :";
            // 
            // lbLicenseFees
            // 
            this.lbLicenseFees.AutoSize = true;
            this.lbLicenseFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbLicenseFees.Location = new System.Drawing.Point(182, 205);
            this.lbLicenseFees.Name = "lbLicenseFees";
            this.lbLicenseFees.Size = new System.Drawing.Size(50, 22);
            this.lbLicenseFees.TabIndex = 33;
            this.lbLicenseFees.Text = "[???]";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label22.Location = new System.Drawing.Point(17, 205);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(127, 22);
            this.label22.TabIndex = 32;
            this.label22.Text = "License Fees :";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbApplicationFees.Location = new System.Drawing.Point(182, 158);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(50, 22);
            this.lbApplicationFees.TabIndex = 31;
            this.lbApplicationFees.Text = "[???]";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label24.Location = new System.Drawing.Point(17, 158);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(153, 22);
            this.label24.TabIndex = 30;
            this.label24.Text = "Application Fees :";
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.AutoSize = true;
            this.lbIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbIssueDate.Location = new System.Drawing.Point(182, 114);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(50, 22);
            this.lbIssueDate.TabIndex = 29;
            this.lbIssueDate.Text = "[???]";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label26.Location = new System.Drawing.Point(17, 114);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(105, 22);
            this.label26.TabIndex = 28;
            this.label26.Text = "Issue Date :";
            // 
            // lbApplictionDate
            // 
            this.lbApplictionDate.AutoSize = true;
            this.lbApplictionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbApplictionDate.Location = new System.Drawing.Point(182, 62);
            this.lbApplictionDate.Name = "lbApplictionDate";
            this.lbApplictionDate.Size = new System.Drawing.Size(50, 22);
            this.lbApplictionDate.TabIndex = 27;
            this.lbApplictionDate.Text = "[???]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label14.Location = new System.Drawing.Point(17, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 22);
            this.label14.TabIndex = 26;
            this.label14.Text = "Appliction Date :";
            // 
            // lbRLApplicationID
            // 
            this.lbRLApplicationID.AutoSize = true;
            this.lbRLApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbRLApplicationID.Location = new System.Drawing.Point(182, 18);
            this.lbRLApplicationID.Name = "lbRLApplicationID";
            this.lbRLApplicationID.Size = new System.Drawing.Size(50, 22);
            this.lbRLApplicationID.TabIndex = 25;
            this.lbRLApplicationID.Text = "[???]";
            // 
            // labal
            // 
            this.labal.AutoSize = true;
            this.labal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labal.Location = new System.Drawing.Point(17, 18);
            this.labal.Name = "labal";
            this.labal.Size = new System.Drawing.Size(158, 22);
            this.labal.TabIndex = 24;
            this.labal.Text = "R.L.ApplicationID :";
            // 
            // cnlicenseInfo
            // 
            this.cnlicenseInfo.Location = new System.Drawing.Point(9, 135);
            this.cnlicenseInfo.Name = "cnlicenseInfo";
            this.cnlicenseInfo.Size = new System.Drawing.Size(1014, 510);
            this.cnlicenseInfo.TabIndex = 12;
            // 
            // RenewLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 1055);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.llbShowLesense);
            this.Controls.Add(this.llbShowLicensesHistory);
            this.Controls.Add(this.buRenew);
            this.Controls.Add(this.buClose);
            this.Controls.Add(this.cnlicenseInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RenewLicenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RenewLicenseForm";
            this.Load += new System.EventHandler(this.RenewLicenseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCreatedByUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbExpirationDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbRenewedLicenseID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbLicenseFees;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbIssueDate;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lbApplictionDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbRLApplicationID;
        private System.Windows.Forms.Label labal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNotes;
    }
}