namespace DVLD1
{
    partial class frmDetainLicense
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFees = new System.Windows.Forms.MaskedTextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btDetain = new System.Windows.Forms.Button();
            this.lbShowLicInfo = new System.Windows.Forms.LinkLabel();
            this.lbLicID = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlFilterANDLicInfo1 = new DVLD1.ctrlFilterANDLicInfo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detain License";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFees);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.btDetain);
            this.groupBox2.Controls.Add(this.lbShowLicInfo);
            this.groupBox2.Controls.Add(this.lbLicID);
            this.groupBox2.Controls.Add(this.lbUserName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbDetainDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbDetainID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 679);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1193, 238);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detailed Info ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(197, 144);
            this.txtFees.Mask = "0000";
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(100, 35);
            this.txtFees.TabIndex = 55;
            this.txtFees.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtFees_MaskInputRejected);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(-6, 194);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(279, 34);
            this.linkLabel2.TabIndex = 51;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Show License History";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btDetain
            // 
            this.btDetain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDetain.Location = new System.Drawing.Point(1090, 188);
            this.btDetain.Name = "btDetain";
            this.btDetain.Size = new System.Drawing.Size(97, 40);
            this.btDetain.TabIndex = 47;
            this.btDetain.Text = "Detain";
            this.btDetain.UseVisualStyleBackColor = true;
            this.btDetain.Click += new System.EventHandler(this.lbDetain_Click);
            // 
            // lbShowLicInfo
            // 
            this.lbShowLicInfo.AutoSize = true;
            this.lbShowLicInfo.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowLicInfo.Location = new System.Drawing.Point(297, 194);
            this.lbShowLicInfo.Name = "lbShowLicInfo";
            this.lbShowLicInfo.Size = new System.Drawing.Size(352, 34);
            this.lbShowLicInfo.TabIndex = 50;
            this.lbShowLicInfo.TabStop = true;
            this.lbShowLicInfo.Text = "Show Detailed License Info";
            this.lbShowLicInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowLicInfo_LinkClicked);
            // 
            // lbLicID
            // 
            this.lbLicID.AutoSize = true;
            this.lbLicID.Location = new System.Drawing.Point(848, 48);
            this.lbLicID.Name = "lbLicID";
            this.lbLicID.Size = new System.Drawing.Size(45, 28);
            this.lbLicID.TabIndex = 59;
            this.lbLicID.Text = "???";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(848, 96);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(45, 28);
            this.lbUserName.TabIndex = 57;
            this.lbUserName.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(674, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 28);
            this.label8.TabIndex = 56;
            this.label8.Text = "Created By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(674, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 53;
            this.label2.Text = "License ID:";
            // 
            // lbDetainDate
            // 
            this.lbDetainDate.AutoSize = true;
            this.lbDetainDate.Location = new System.Drawing.Point(192, 96);
            this.lbDetainDate.Name = "lbDetainDate";
            this.lbDetainDate.Size = new System.Drawing.Size(45, 28);
            this.lbDetainDate.TabIndex = 52;
            this.lbDetainDate.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 28);
            this.label5.TabIndex = 49;
            this.label5.Text = "Detain Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 47;
            this.label3.Text = "Fine Fees:";
            // 
            // lbDetainID
            // 
            this.lbDetainID.AutoSize = true;
            this.lbDetainID.Location = new System.Drawing.Point(192, 48);
            this.lbDetainID.Name = "lbDetainID";
            this.lbDetainID.Size = new System.Drawing.Size(45, 28);
            this.lbDetainID.TabIndex = 46;
            this.lbDetainID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "Detain ID:";
            // 
            // ctrlFilterANDLicInfo1
            // 
            this.ctrlFilterANDLicInfo1.IsFound = false;
            this.ctrlFilterANDLicInfo1.LicenseID = -1;
            this.ctrlFilterANDLicInfo1.Location = new System.Drawing.Point(3, 95);
            this.ctrlFilterANDLicInfo1.Name = "ctrlFilterANDLicInfo1";
            this.ctrlFilterANDLicInfo1.Size = new System.Drawing.Size(1214, 578);
            this.ctrlFilterANDLicInfo1.TabIndex = 0;
            this.ctrlFilterANDLicInfo1.Load += new System.EventHandler(this.ctrlFilterANDLicInfo1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD1.Properties.Resources.hand;
            this.pictureBox1.Location = new System.Drawing.Point(1051, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 925);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlFilterANDLicInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetainLicense";
            this.ShowIcon = false;
            this.Text = "Detain License";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlFilterANDLicInfo ctrlFilterANDLicInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btDetain;
        private System.Windows.Forms.LinkLabel lbShowLicInfo;
        private System.Windows.Forms.Label lbLicID;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtFees;
    }
}