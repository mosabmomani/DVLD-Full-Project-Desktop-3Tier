namespace DVLD_Full_Project_Desktop
{
    partial class InternationalLicenseDetialsForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buClose = new System.Windows.Forms.Button();
            this.internationalLicenseInfoControl1 = new DVLD_Full_Project_Desktop.InternationalLicenseInfoControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(222, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "InternationalLicenseDetails";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Full_Project_Desktop.Properties.Resources.driving_license;
            this.pictureBox1.Location = new System.Drawing.Point(319, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buClose
            // 
            this.buClose.Location = new System.Drawing.Point(728, 518);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(102, 49);
            this.buClose.TabIndex = 3;
            this.buClose.Text = "Close";
            this.buClose.UseVisualStyleBackColor = true;
            this.buClose.Click += new System.EventHandler(this.buClose_Click);
            // 
            // internationalLicenseInfoControl1
            // 
            this.internationalLicenseInfoControl1.Location = new System.Drawing.Point(36, 154);
            this.internationalLicenseInfoControl1.Name = "internationalLicenseInfoControl1";
            this.internationalLicenseInfoControl1.Size = new System.Drawing.Size(827, 372);
            this.internationalLicenseInfoControl1.TabIndex = 1;
            // 
            // InternationalLicenseDetialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 569);
            this.Controls.Add(this.buClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.internationalLicenseInfoControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InternationalLicenseDetialsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InternationalLicenseDetailsForm";
            this.Load += new System.EventHandler(this.InternationalLicenseDetialsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private InternationalLicenseInfoControl internationalLicenseInfoControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buClose;
    }
}