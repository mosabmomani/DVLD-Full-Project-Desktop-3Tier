namespace DVLD_Full_Project_Desktop
{
    partial class AddOrUpdatUserForm
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
            this.components = new System.ComponentModel.Container();
            this.lbMode = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbCPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buClose = new System.Windows.Forms.Button();
            this.buNext = new System.Windows.Forms.Button();
            this.buClose2 = new System.Windows.Forms.Button();
            this.buSave2 = new System.Windows.Forms.Button();
            this.buBack = new System.Windows.Forms.Button();
            this.addOrUpdatePersonWithFilter1 = new DVLD_Full_Project_Desktop.AddOrUpdatePersonWithFilter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.lbMode.ForeColor = System.Drawing.Color.Red;
            this.lbMode.Location = new System.Drawing.Point(468, 28);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(130, 51);
            this.lbMode.TabIndex = 0;
            this.lbMode.Text = "Mode";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1126, 670);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buClose);
            this.tabPage1.Controls.Add(this.buNext);
            this.tabPage1.Controls.Add(this.addOrUpdatePersonWithFilter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1118, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buClose2);
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.buSave2);
            this.tabPage2.Controls.Add(this.buBack);
            this.tabPage2.Controls.Add(this.tbPassword);
            this.tabPage2.Controls.Add(this.tbCPassword);
            this.tabPage2.Controls.Add(this.tbUsername);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lbUserID);
            this.tabPage2.Controls.Add(this.lb);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1118, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.checkBox3.Location = new System.Drawing.Point(383, 311);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(140, 35);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Is Active";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(590, 244);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 20);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(590, 192);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(125, 20);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Show Password";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(383, 190);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(175, 22);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // tbCPassword
            // 
            this.tbCPassword.Location = new System.Drawing.Point(383, 244);
            this.tbCPassword.Name = "tbCPassword";
            this.tbCPassword.PasswordChar = '*';
            this.tbCPassword.Size = new System.Drawing.Size(175, 22);
            this.tbCPassword.TabIndex = 2;
            this.tbCPassword.TextChanged += new System.EventHandler(this.tbCPassword_TextChanged);
            this.tbCPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbCPassword_Validating);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(383, 124);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(175, 22);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label5.Location = new System.Drawing.Point(16, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Password : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label4.Location = new System.Drawing.Point(16, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label3.Location = new System.Drawing.Point(16, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName :";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lbUserID.Location = new System.Drawing.Point(219, 46);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(44, 31);
            this.lbUserID.TabIndex = 1;
            this.lbUserID.Text = "??";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lb.Location = new System.Drawing.Point(16, 46);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(115, 31);
            this.lb.TabIndex = 0;
            this.lb.Text = "UserID :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buClose
            // 
            this.buClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buClose.ImageIndex = 4;
            this.buClose.Location = new System.Drawing.Point(581, 506);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(118, 44);
            this.buClose.TabIndex = 2;
            this.buClose.Text = "close";
            this.buClose.UseVisualStyleBackColor = true;
            this.buClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // buNext
            // 
            this.buNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buNext.ImageIndex = 3;
            this.buNext.Location = new System.Drawing.Point(760, 506);
            this.buNext.Name = "buNext";
            this.buNext.Size = new System.Drawing.Size(119, 44);
            this.buNext.TabIndex = 1;
            this.buNext.Text = "Next";
            this.buNext.UseVisualStyleBackColor = true;
            this.buNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // buClose2
            // 
            this.buClose2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buClose2.ImageIndex = 4;
            this.buClose2.Location = new System.Drawing.Point(432, 465);
            this.buClose2.Name = "buClose2";
            this.buClose2.Size = new System.Drawing.Size(126, 43);
            this.buClose2.TabIndex = 12;
            this.buClose2.Text = "close";
            this.buClose2.UseVisualStyleBackColor = true;
            this.buClose2.Click += new System.EventHandler(this.button5_Click);
            // 
            // buSave2
            // 
            this.buSave2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buSave2.ImageIndex = 0;
            this.buSave2.Location = new System.Drawing.Point(530, 385);
            this.buSave2.Name = "buSave2";
            this.buSave2.Size = new System.Drawing.Size(117, 41);
            this.buSave2.TabIndex = 4;
            this.buSave2.Text = "Save";
            this.buSave2.UseVisualStyleBackColor = true;
            this.buSave2.Click += new System.EventHandler(this.button3_Click);
            // 
            // buBack
            // 
            this.buBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buBack.ImageIndex = 2;
            this.buBack.Location = new System.Drawing.Point(356, 385);
            this.buBack.Name = "buBack";
            this.buBack.Size = new System.Drawing.Size(114, 41);
            this.buBack.TabIndex = 5;
            this.buBack.Text = "Back";
            this.buBack.UseVisualStyleBackColor = true;
            this.buBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // addOrUpdatePersonWithFilter1
            // 
            this.addOrUpdatePersonWithFilter1.Location = new System.Drawing.Point(14, 19);
            this.addOrUpdatePersonWithFilter1.Name = "addOrUpdatePersonWithFilter1";
            this.addOrUpdatePersonWithFilter1.Size = new System.Drawing.Size(1134, 544);
            this.addOrUpdatePersonWithFilter1.TabIndex = 0;
            this.addOrUpdatePersonWithFilter1.Load += new System.EventHandler(this.addOrUpdatePersonWithFilter1_Load);
            // 
            // AddOrUpdatUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 682);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddOrUpdatUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrUpdatUserForm";
            this.Load += new System.EventHandler(this.AddOrUpdatUserForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private AddOrUpdatePersonWithFilter addOrUpdatePersonWithFilter1;
        private System.Windows.Forms.Button buNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button buSave2;
        private System.Windows.Forms.Button buBack;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbCPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buClose;
        private System.Windows.Forms.Button buClose2;
    }
}