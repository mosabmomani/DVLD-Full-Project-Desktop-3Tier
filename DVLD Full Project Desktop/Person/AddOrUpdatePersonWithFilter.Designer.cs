namespace DVLD_Full_Project_Desktop
{
    partial class AddOrUpdatePersonWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdatePersonWithFilter));
            this.gbFillter = new System.Windows.Forms.GroupBox();
            this.mtbFind = new System.Windows.Forms.MaskedTextBox();
            this.buSch = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.personCard1 = new DVLD_Full_Project_Desktop.PersonCard();
            this.gbFillter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFillter
            // 
            this.gbFillter.Controls.Add(this.mtbFind);
            this.gbFillter.Controls.Add(this.buSch);
            this.gbFillter.Controls.Add(this.button1);
            this.gbFillter.Controls.Add(this.comboBox1);
            this.gbFillter.Controls.Add(this.label1);
            this.gbFillter.Location = new System.Drawing.Point(3, 3);
            this.gbFillter.Name = "gbFillter";
            this.gbFillter.Size = new System.Drawing.Size(1131, 115);
            this.gbFillter.TabIndex = 0;
            this.gbFillter.TabStop = false;
            this.gbFillter.Text = "Filter";
            this.gbFillter.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mtbFind
            // 
            this.mtbFind.Location = new System.Drawing.Point(326, 53);
            this.mtbFind.Name = "mtbFind";
            this.mtbFind.PromptChar = ' ';
            this.mtbFind.Size = new System.Drawing.Size(202, 22);
            this.mtbFind.TabIndex = 5;
            this.mtbFind.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbFind_MaskInputRejected);
            this.mtbFind.Enter += new System.EventHandler(this.mtbFind_Enter);
            // 
            // buSch
            // 
            this.buSch.ImageIndex = 2;
            this.buSch.ImageList = this.imageList1;
            this.buSch.Location = new System.Drawing.Point(543, 44);
            this.buSch.Name = "buSch";
            this.buSch.Size = new System.Drawing.Size(50, 41);
            this.buSch.TabIndex = 4;
            this.buSch.UseVisualStyleBackColor = true;
            this.buSch.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-user.png");
            this.imageList1.Images.SetKeyName(1, "resume.png");
            this.imageList1.Images.SetKeyName(2, "serch.png");
            // 
            // button1
            // 
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(609, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 41);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PersonID",
            "Notonal No"});
            this.comboBox1.Location = new System.Drawing.Point(116, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By:";
            // 
            // personCard1
            // 
            this.personCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.personCard1.Location = new System.Drawing.Point(3, 127);
            this.personCard1.Margin = new System.Windows.Forms.Padding(6);
            this.personCard1.Name = "personCard1";
            this.personCard1.Size = new System.Drawing.Size(1125, 406);
            this.personCard1.TabIndex = 1;
            this.personCard1.Load += new System.EventHandler(this.personCard1_Load);
            // 
            // AddOrUpdatePersonWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.personCard1);
            this.Controls.Add(this.gbFillter);
            this.Name = "AddOrUpdatePersonWithFilter";
            this.Size = new System.Drawing.Size(1134, 567);
            this.Load += new System.EventHandler(this.AddOrUpdatePersonWithFilter_Load);
            this.gbFillter.ResumeLayout(false);
            this.gbFillter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFillter;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buSch;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private PersonCard personCard1;
        private System.Windows.Forms.MaskedTextBox mtbFind;
    }
}
