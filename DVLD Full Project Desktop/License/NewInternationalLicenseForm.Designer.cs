namespace DVLD_Full_Project_Desktop
{
    partial class NewInternationalLicenseForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buSearch = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cnlicenseInfo = new DVLD_Full_Project_Desktop.LicenseInfoControl();
            this.coInternationalLicense = new DVLD_Full_Project_Desktop.InternationalLicenseApplicationControl();
            this.buClose = new System.Windows.Forms.Button();
            this.buIssueLicense = new System.Windows.Forms.Button();
            this.llbShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.llbShowLesense = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(194, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "New International License Application";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buSearch);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.groupBox1.Location = new System.Drawing.Point(27, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 73);
            this.groupBox1.TabIndex = 1;
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
            // cnlicenseInfo
            // 
            this.cnlicenseInfo.Location = new System.Drawing.Point(27, 149);
            this.cnlicenseInfo.Name = "cnlicenseInfo";
            this.cnlicenseInfo.Size = new System.Drawing.Size(1014, 510);
            this.cnlicenseInfo.TabIndex = 4;
            this.cnlicenseInfo.Load += new System.EventHandler(this.cnlicenseInfo_Load);
            // 
            // coInternationalLicense
            // 
            this.coInternationalLicense.Location = new System.Drawing.Point(27, 540);
            this.coInternationalLicense.Name = "coInternationalLicense";
            this.coInternationalLicense.Size = new System.Drawing.Size(746, 277);
            this.coInternationalLicense.TabIndex = 5;
            // 
            // buClose
            // 
            this.buClose.Location = new System.Drawing.Point(696, 812);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(123, 59);
            this.buClose.TabIndex = 6;
            this.buClose.Text = "Close";
            this.buClose.UseVisualStyleBackColor = true;
            this.buClose.Click += new System.EventHandler(this.buClose_Click);
            // 
            // buIssueLicense
            // 
            this.buIssueLicense.Enabled = false;
            this.buIssueLicense.Location = new System.Drawing.Point(851, 812);
            this.buIssueLicense.Name = "buIssueLicense";
            this.buIssueLicense.Size = new System.Drawing.Size(122, 59);
            this.buIssueLicense.TabIndex = 7;
            this.buIssueLicense.Text = "Issue License";
            this.buIssueLicense.UseVisualStyleBackColor = true;
            this.buIssueLicense.Click += new System.EventHandler(this.buIssueLicense_Click);
            // 
            // llbShowLicensesHistory
            // 
            this.llbShowLicensesHistory.AutoSize = true;
            this.llbShowLicensesHistory.Enabled = false;
            this.llbShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.llbShowLicensesHistory.Location = new System.Drawing.Point(34, 820);
            this.llbShowLicensesHistory.Name = "llbShowLicensesHistory";
            this.llbShowLicensesHistory.Size = new System.Drawing.Size(192, 22);
            this.llbShowLicensesHistory.TabIndex = 8;
            this.llbShowLicensesHistory.TabStop = true;
            this.llbShowLicensesHistory.Text = "Show Licenses History";
            this.llbShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowLicensesHistory_LinkClicked);
            // 
            // llbShowLesense
            // 
            this.llbShowLesense.AutoSize = true;
            this.llbShowLesense.Enabled = false;
            this.llbShowLesense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.llbShowLesense.Location = new System.Drawing.Point(274, 820);
            this.llbShowLesense.Name = "llbShowLesense";
            this.llbShowLesense.Size = new System.Drawing.Size(123, 22);
            this.llbShowLesense.TabIndex = 9;
            this.llbShowLesense.TabStop = true;
            this.llbShowLesense.Text = "ShowLesense";
            this.llbShowLesense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowLesense_LinkClicked);
            // 
            // NewInternationalLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 1055);
            this.Controls.Add(this.llbShowLesense);
            this.Controls.Add(this.llbShowLicensesHistory);
            this.Controls.Add(this.buIssueLicense);
            this.Controls.Add(this.buClose);
            this.Controls.Add(this.coInternationalLicense);
            this.Controls.Add(this.cnlicenseInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewInternationalLicenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New International License Form";
            this.Load += new System.EventHandler(this.NewInternationalLicenseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buSearch;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private LicenseInfoControl cnlicenseInfo;
        private InternationalLicenseApplicationControl coInternationalLicense;
        private System.Windows.Forms.Button buClose;
        private System.Windows.Forms.Button buIssueLicense;
        private System.Windows.Forms.LinkLabel llbShowLicensesHistory;
        private System.Windows.Forms.LinkLabel llbShowLesense;
    }
}