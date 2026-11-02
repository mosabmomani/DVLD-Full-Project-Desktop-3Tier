namespace DVLD_Full_Project_Desktop
{
    partial class SuspendLicenseForm
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
            this.buSuspend = new System.Windows.Forms.Button();
            this.buClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buSearch = new System.Windows.Forms.Button();
            this.mtbLicenseID = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.llbShowLesense.Location = new System.Drawing.Point(247, 797);
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
            this.llbShowLicensesHistory.Location = new System.Drawing.Point(7, 797);
            this.llbShowLicensesHistory.Name = "llbShowLicensesHistory";
            this.llbShowLicensesHistory.Size = new System.Drawing.Size(192, 22);
            this.llbShowLicensesHistory.TabIndex = 24;
            this.llbShowLicensesHistory.TabStop = true;
            this.llbShowLicensesHistory.Text = "Show Licenses History";
            this.llbShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowLicensesHistory_LinkClicked);
            // 
            // buSuspend
            // 
            this.buSuspend.Enabled = false;
            this.buSuspend.Location = new System.Drawing.Point(827, 779);
            this.buSuspend.Name = "buSuspend";
            this.buSuspend.Size = new System.Drawing.Size(119, 59);
            this.buSuspend.TabIndex = 23;
            this.buSuspend.Text = "Suspend";
            this.buSuspend.UseVisualStyleBackColor = true;
            this.buSuspend.Click += new System.EventHandler(this.buRenew_Click);
            // 
            // buClose
            // 
            this.buClose.Location = new System.Drawing.Point(667, 779);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(125, 59);
            this.buClose.TabIndex = 22;
            this.buClose.Text = "Close";
            this.buClose.UseVisualStyleBackColor = true;
            this.buClose.Click += new System.EventHandler(this.buClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buSearch);
            this.groupBox1.Controls.Add(this.mtbLicenseID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.groupBox1.Location = new System.Drawing.Point(0, 50);
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
            // mtbLicenseID
            // 
            this.mtbLicenseID.Location = new System.Drawing.Point(166, 28);
            this.mtbLicenseID.Mask = "00000";
            this.mtbLicenseID.Name = "mtbLicenseID";
            this.mtbLicenseID.PromptChar = ' ';
            this.mtbLicenseID.Size = new System.Drawing.Size(204, 32);
            this.mtbLicenseID.TabIndex = 1;
            this.mtbLicenseID.ValidatingType = typeof(int);
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
            this.label1.Location = new System.Drawing.Point(198, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 44);
            this.label1.TabIndex = 19;
            this.label1.Text = "Suspended License Application";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbCreatedBy);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.lbLicenseID);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.lbDetainDate);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lbDetainID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(11, 533);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(894, 240);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(142, 153);
            this.maskedTextBox1.Mask = "99999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(77, 22);
            this.maskedTextBox1.TabIndex = 36;
            this.maskedTextBox1.Text = "0";
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Fine Fees :";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbCreatedBy.Location = new System.Drawing.Point(527, 102);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(50, 22);
            this.lbCreatedBy.TabIndex = 34;
            this.lbCreatedBy.Text = "[???]";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label20.Location = new System.Drawing.Point(362, 102);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 22);
            this.label20.TabIndex = 33;
            this.label20.Text = "Created By :";
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbLicenseID.Location = new System.Drawing.Point(527, 48);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(50, 22);
            this.lbLicenseID.TabIndex = 32;
            this.lbLicenseID.Text = "[???]";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label22.Location = new System.Drawing.Point(362, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 22);
            this.label22.TabIndex = 31;
            this.label22.Text = "License ID :";
            // 
            // lbDetainDate
            // 
            this.lbDetainDate.AutoSize = true;
            this.lbDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbDetainDate.Location = new System.Drawing.Point(141, 102);
            this.lbDetainDate.Name = "lbDetainDate";
            this.lbDetainDate.Size = new System.Drawing.Size(50, 22);
            this.lbDetainDate.TabIndex = 29;
            this.lbDetainDate.Text = "[???]";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label18.Location = new System.Drawing.Point(6, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 22);
            this.label18.TabIndex = 28;
            this.label18.Text = "Detain Date :";
            // 
            // lbDetainID
            // 
            this.lbDetainID.AutoSize = true;
            this.lbDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbDetainID.Location = new System.Drawing.Point(141, 48);
            this.lbDetainID.Name = "lbDetainID";
            this.lbDetainID.Size = new System.Drawing.Size(50, 22);
            this.lbDetainID.TabIndex = 27;
            this.lbDetainID.Text = "[???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Detain ID :";
            // 
            // cnlicenseInfo
            // 
            this.cnlicenseInfo.Location = new System.Drawing.Point(0, 126);
            this.cnlicenseInfo.Name = "cnlicenseInfo";
            this.cnlicenseInfo.Size = new System.Drawing.Size(1014, 510);
            this.cnlicenseInfo.TabIndex = 21;
            this.cnlicenseInfo.Load += new System.EventHandler(this.cnlicenseInfo_Load);
            // 
            // SuspendLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 840);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.llbShowLesense);
            this.Controls.Add(this.llbShowLicensesHistory);
            this.Controls.Add(this.buSuspend);
            this.Controls.Add(this.buClose);
            this.Controls.Add(this.cnlicenseInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SuspendLicenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuspendLicenseForm";
            this.Load += new System.EventHandler(this.SuspendLicenseForm_Load);
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
        private System.Windows.Forms.Button buSuspend;
        private System.Windows.Forms.Button buClose;
        private LicenseInfoControl cnlicenseInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buSearch;
        private System.Windows.Forms.MaskedTextBox mtbLicenseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}