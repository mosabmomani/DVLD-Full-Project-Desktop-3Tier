namespace DVLD_Full_Project_Desktop
{
    partial class TestsForm
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
            this.lbTest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTestAppointment = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.buAppointments = new System.Windows.Forms.Button();
            this.applicationInfo1 = new DVLD_Full_Project_Desktop.ApplicationInfo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointment)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lbTest.Location = new System.Drawing.Point(306, 111);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(75, 31);
            this.lbTest.TabIndex = 2;
            this.lbTest.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label1.Location = new System.Drawing.Point(-4, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Appointments :";
            // 
            // dgvTestAppointment
            // 
            this.dgvTestAppointment.AllowUserToAddRows = false;
            this.dgvTestAppointment.AllowUserToDeleteRows = false;
            this.dgvTestAppointment.AllowUserToOrderColumns = true;
            this.dgvTestAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestAppointment.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTestAppointment.Location = new System.Drawing.Point(1, 642);
            this.dgvTestAppointment.Name = "dgvTestAppointment";
            this.dgvTestAppointment.ReadOnly = true;
            this.dgvTestAppointment.RowHeadersWidth = 51;
            this.dgvTestAppointment.RowTemplate.Height = 24;
            this.dgvTestAppointment.Size = new System.Drawing.Size(835, 152);
            this.dgvTestAppointment.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsTakeTest,
            this.cmsEdit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // cmsTakeTest
            // 
            this.cmsTakeTest.Name = "cmsTakeTest";
            this.cmsTakeTest.Size = new System.Drawing.Size(137, 24);
            this.cmsTakeTest.Text = "Take Test";
            this.cmsTakeTest.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // cmsEdit
            // 
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(137, 24);
            this.cmsEdit.Text = "Edit Test";
            this.cmsEdit.Click += new System.EventHandler(this.edetTestToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label2.Location = new System.Drawing.Point(-3, 797);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Records : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lbRecords.Location = new System.Drawing.Point(90, 797);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(46, 20);
            this.lbRecords.TabIndex = 6;
            this.lbRecords.Text = "[???]";
            // 
            // buAppointments
            // 
            this.buAppointments.Location = new System.Drawing.Point(753, 595);
            this.buAppointments.Name = "buAppointments";
            this.buAppointments.Size = new System.Drawing.Size(59, 48);
            this.buAppointments.TabIndex = 7;
            this.buAppointments.UseVisualStyleBackColor = true;
            this.buAppointments.Click += new System.EventHandler(this.button1_Click);
            // 
            // applicationInfo1
            // 
            this.applicationInfo1.Location = new System.Drawing.Point(-15, 111);
            this.applicationInfo1.Name = "applicationInfo1";
            this.applicationInfo1.Size = new System.Drawing.Size(878, 572);
            this.applicationInfo1.TabIndex = 0;
            this.applicationInfo1.Load += new System.EventHandler(this.applicationInfo1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Full_Project_Desktop.Properties.Resources.cone__1_;
            this.pictureBox1.Location = new System.Drawing.Point(312, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 825);
            this.Controls.Add(this.buAppointments);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTestAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.applicationInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestsForm";
            this.Load += new System.EventHandler(this.TestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointment)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ApplicationInfo applicationInfo1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTestAppointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Button buAppointments;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsTakeTest;
        private System.Windows.Forms.ToolStripMenuItem cmsEdit;
    }
}