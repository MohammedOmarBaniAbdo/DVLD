namespace DVLD1
{
    partial class frmRenewLicense
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btRenew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbShowLicInfo = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbLicFees = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbOldLicID = new System.Windows.Forms.Label();
            this.lbNewLicID = new System.Windows.Forms.Label();
            this.lbExDate = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAppDate = new System.Windows.Forms.Label();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.lbAppFees = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAppID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlFilterANDLicInfo1 = new DVLD1.ctrlFilterANDLicInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Brown;
            this.lbTitle.Location = new System.Drawing.Point(379, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(462, 40);
            this.lbTitle.TabIndex = 43;
            this.lbTitle.Text = "Renew License Application";
            // 
            // btRenew
            // 
            this.btRenew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRenew.Location = new System.Drawing.Point(1081, 356);
            this.btRenew.Name = "btRenew";
            this.btRenew.Size = new System.Drawing.Size(106, 40);
            this.btRenew.TabIndex = 47;
            this.btRenew.Text = "Renew";
            this.btRenew.UseVisualStyleBackColor = true;
            this.btRenew.Click += new System.EventHandler(this.btRenew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD1.Properties.Resources.id;
            this.pictureBox1.Location = new System.Drawing.Point(1045, 356);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // lbShowLicInfo
            // 
            this.lbShowLicInfo.AutoSize = true;
            this.lbShowLicInfo.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowLicInfo.Location = new System.Drawing.Point(294, 362);
            this.lbShowLicInfo.Name = "lbShowLicInfo";
            this.lbShowLicInfo.Size = new System.Drawing.Size(307, 34);
            this.lbShowLicInfo.TabIndex = 50;
            this.lbShowLicInfo.TabStop = true;
            this.lbShowLicInfo.Text = "Show New License Info";
            this.lbShowLicInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowLicInfo_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(6, 362);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(279, 34);
            this.linkLabel2.TabIndex = 51;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Show License History";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTotalFees);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.btRenew);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbShowLicInfo);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbLicFees);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbOldLicID);
            this.groupBox1.Controls.Add(this.lbNewLicID);
            this.groupBox1.Controls.Add(this.lbExDate);
            this.groupBox1.Controls.Add(this.lbUserName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbAppDate);
            this.groupBox1.Controls.Add(this.lbIssueDate);
            this.groupBox1.Controls.Add(this.lbAppFees);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbAppID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 650);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1193, 404);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Location = new System.Drawing.Point(889, 236);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(45, 28);
            this.lbTotalFees.TabIndex = 66;
            this.lbTotalFees.Text = "???";
            this.lbTotalFees.Click += new System.EventHandler(this.lbTotalFees_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(674, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 28);
            this.label11.TabIndex = 65;
            this.label11.Text = "Total Fees:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(240, 283);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(445, 76);
            this.txtNotes.TabIndex = 64;
            this.txtNotes.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 28);
            this.label10.TabIndex = 63;
            this.label10.Text = "Notes:";
            // 
            // lbLicFees
            // 
            this.lbLicFees.AutoSize = true;
            this.lbLicFees.Location = new System.Drawing.Point(235, 236);
            this.lbLicFees.Name = "lbLicFees";
            this.lbLicFees.Size = new System.Drawing.Size(45, 28);
            this.lbLicFees.TabIndex = 62;
            this.lbLicFees.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 28);
            this.label9.TabIndex = 61;
            this.label9.Text = "License Fees:";
            // 
            // lbOldLicID
            // 
            this.lbOldLicID.AutoSize = true;
            this.lbOldLicID.Location = new System.Drawing.Point(889, 95);
            this.lbOldLicID.Name = "lbOldLicID";
            this.lbOldLicID.Size = new System.Drawing.Size(45, 28);
            this.lbOldLicID.TabIndex = 60;
            this.lbOldLicID.Text = "???";
            // 
            // lbNewLicID
            // 
            this.lbNewLicID.AutoSize = true;
            this.lbNewLicID.Location = new System.Drawing.Point(937, 48);
            this.lbNewLicID.Name = "lbNewLicID";
            this.lbNewLicID.Size = new System.Drawing.Size(45, 28);
            this.lbNewLicID.TabIndex = 59;
            this.lbNewLicID.Text = "???";
            // 
            // lbExDate
            // 
            this.lbExDate.AutoSize = true;
            this.lbExDate.Location = new System.Drawing.Point(889, 142);
            this.lbExDate.Name = "lbExDate";
            this.lbExDate.Size = new System.Drawing.Size(45, 28);
            this.lbExDate.TabIndex = 58;
            this.lbExDate.Text = "???";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(889, 189);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(45, 28);
            this.lbUserName.TabIndex = 57;
            this.lbUserName.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(674, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 28);
            this.label8.TabIndex = 56;
            this.label8.Text = "Created By:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(674, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 28);
            this.label7.TabIndex = 55;
            this.label7.Text = "Espiration Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(674, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 28);
            this.label6.TabIndex = 54;
            this.label6.Text = "Old License ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(674, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 28);
            this.label2.TabIndex = 53;
            this.label2.Text = "Renewed License.ID:";
            // 
            // lbAppDate
            // 
            this.lbAppDate.AutoSize = true;
            this.lbAppDate.Location = new System.Drawing.Point(235, 95);
            this.lbAppDate.Name = "lbAppDate";
            this.lbAppDate.Size = new System.Drawing.Size(45, 28);
            this.lbAppDate.TabIndex = 52;
            this.lbAppDate.Text = "???";
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.AutoSize = true;
            this.lbIssueDate.Location = new System.Drawing.Point(235, 142);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(45, 28);
            this.lbIssueDate.TabIndex = 51;
            this.lbIssueDate.Text = "???";
            // 
            // lbAppFees
            // 
            this.lbAppFees.AutoSize = true;
            this.lbAppFees.Location = new System.Drawing.Point(235, 189);
            this.lbAppFees.Name = "lbAppFees";
            this.lbAppFees.Size = new System.Drawing.Size(45, 28);
            this.lbAppFees.TabIndex = 50;
            this.lbAppFees.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 28);
            this.label5.TabIndex = 49;
            this.label5.Text = "Application Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 28);
            this.label4.TabIndex = 48;
            this.label4.Text = "Issue Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 28);
            this.label3.TabIndex = 47;
            this.label3.Text = "Application Fees:";
            // 
            // lbAppID
            // 
            this.lbAppID.AutoSize = true;
            this.lbAppID.Location = new System.Drawing.Point(235, 48);
            this.lbAppID.Name = "lbAppID";
            this.lbAppID.Size = new System.Drawing.Size(45, 28);
            this.lbAppID.TabIndex = 46;
            this.lbAppID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "R.L.Application.ID:";
            // 
            // ctrlFilterANDLicInfo1
            // 
            this.ctrlFilterANDLicInfo1.IsFound = false;
            this.ctrlFilterANDLicInfo1.LicenseID = -1;
            this.ctrlFilterANDLicInfo1.Location = new System.Drawing.Point(3, 66);
            this.ctrlFilterANDLicInfo1.Name = "ctrlFilterANDLicInfo1";
            this.ctrlFilterANDLicInfo1.Size = new System.Drawing.Size(1193, 585);
            this.ctrlFilterANDLicInfo1.TabIndex = 67;
            // 
            // frmRenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 1055);
            this.Controls.Add(this.ctrlFilterANDLicInfo1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRenewLicense";
            this.ShowIcon = false;
            this.Text = "Renew License Application";
            this.Load += new System.EventHandler(this.frmRenewLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lbShowLicInfo;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btRenew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbOldLicID;
        private System.Windows.Forms.Label lbNewLicID;
        private System.Windows.Forms.Label lbExDate;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAppDate;
        private System.Windows.Forms.Label lbIssueDate;
        private System.Windows.Forms.Label lbAppFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbAppID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbLicFees;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTotalFees;
        private ctrlFilterANDLicInfo ctrlFilterANDLicInfo1;
    }
}