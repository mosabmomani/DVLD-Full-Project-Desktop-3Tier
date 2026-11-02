namespace DVLD_Full_Project_Desktop
{
    partial class EditApplicationForm
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
            this.lbID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFees = new System.Windows.Forms.MaskedTextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.buClose = new System.Windows.Forms.Button();
            this.buSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Application Type";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbID.Location = new System.Drawing.Point(116, 71);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(48, 26);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID    : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Title : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fees : ";
            // 
            // tbFees
            // 
            this.tbFees.Location = new System.Drawing.Point(121, 197);
            this.tbFees.Name = "tbFees";
            this.tbFees.PromptChar = ' ';
            this.tbFees.Size = new System.Drawing.Size(355, 22);
            this.tbFees.TabIndex = 2;
            this.tbFees.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbFees_MaskInputRejected);
            this.tbFees.Click += new System.EventHandler(this.tbFees_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(121, 134);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(355, 22);
            this.tbTitle.TabIndex = 1;
            // 
            // buClose
            // 
            this.buClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buClose.ImageIndex = 0;
            this.buClose.Location = new System.Drawing.Point(121, 242);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(158, 49);
            this.buClose.TabIndex = 4;
            this.buClose.Text = "Close";
            this.buClose.UseVisualStyleBackColor = true;
            this.buClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // buSave
            // 
            this.buSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buSave.ImageIndex = 1;
            this.buSave.Location = new System.Drawing.Point(322, 242);
            this.buSave.Name = "buSave";
            this.buSave.Size = new System.Drawing.Size(158, 49);
            this.buSave.TabIndex = 3;
            this.buSave.Text = "Save";
            this.buSave.UseVisualStyleBackColor = true;
            this.buSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 292);
            this.Controls.Add(this.buSave);
            this.Controls.Add(this.buClose);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbFees);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Application";
            this.Load += new System.EventHandler(this.EditApplicationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tbFees;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button buClose;
        private System.Windows.Forms.Button buSave;
    }
}