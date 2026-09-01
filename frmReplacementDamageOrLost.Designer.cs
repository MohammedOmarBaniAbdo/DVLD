namespace DVLD1
{
    partial class frmReplacementDamageOrLost
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdLost = new System.Windows.Forms.RadioButton();
            this.reDamage = new System.Windows.Forms.RadioButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btRenew = new System.Windows.Forms.Button();
            this.lbShowLicInfo = new System.Windows.Forms.LinkLabel();
            this.lbOldLicID = new System.Windows.Forms.Label();
            this.lbReplaceLicID = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAppDate = new System.Windows.Forms.Label();
            this.lbAppFees = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAppID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlFilterANDLicInfo1 = new DVLD1.ctrlFilterANDLicInfo();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdLost);
            this.groupBox1.Controls.Add(this.reDamage);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1012, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacement For: ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdLost
            // 
            this.rdLost.AutoSize = true;
            this.rdLost.Location = new System.Drawing.Point(6, 66);
            this.rdLost.Name = "rdLost";
            this.rdLost.Size = new System.Drawing.Size(140, 28);
            this.rdLost.TabIndex = 1;
            this.rdLost.TabStop = true;
            this.rdLost.Text = "Lost License";
            this.rdLost.UseVisualStyleBackColor = true;
            this.rdLost.CheckedChanged += new System.EventHandler(this.rdLost_CheckedChanged);
            // 
            // reDamage
            // 
            this.reDamage.AutoSize = true;
            this.reDamage.Location = new System.Drawing.Point(6, 31);
            this.reDamage.Name = "reDamage";
            this.reDamage.Size = new System.Drawing.Size(189, 28);
            this.reDamage.TabIndex = 0;
            this.reDamage.TabStop = true;
            this.reDamage.Text = "Damaged License";
            this.reDamage.UseVisualStyleBackColor = true;
            this.reDamage.CheckedChanged += new System.EventHandler(this.reDamage_CheckedChanged);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Brown;
            this.lbTitle.Location = new System.Drawing.Point(388, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(462, 40);
            this.lbTitle.TabIndex = 44;
            this.lbTitle.Text = "Renew License Application";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.btRenew);
            this.groupBox2.Controls.Add(this.lbShowLicInfo);
            this.groupBox2.Controls.Add(this.lbOldLicID);
            this.groupBox2.Controls.Add(this.lbReplaceLicID);
            this.groupBox2.Controls.Add(this.lbUserName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbAppDate);
            this.groupBox2.Controls.Add(this.lbAppFees);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbAppID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 672);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1193, 238);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Info for License Replacement";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD1.Properties.Resources.id;
            this.pictureBox1.Location = new System.Drawing.Point(933, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
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
            // btRenew
            // 
            this.btRenew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRenew.Location = new System.Drawing.Point(972, 188);
            this.btRenew.Name = "btRenew";
            this.btRenew.Size = new System.Drawing.Size(224, 40);
            this.btRenew.TabIndex = 47;
            this.btRenew.Text = "Issue Replacement";
            this.btRenew.UseVisualStyleBackColor = true;
            this.btRenew.Click += new System.EventHandler(this.btRenew_Click);
            // 
            // lbShowLicInfo
            // 
            this.lbShowLicInfo.AutoSize = true;
            this.lbShowLicInfo.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowLicInfo.Location = new System.Drawing.Point(297, 194);
            this.lbShowLicInfo.Name = "lbShowLicInfo";
            this.lbShowLicInfo.Size = new System.Drawing.Size(307, 34);
            this.lbShowLicInfo.TabIndex = 50;
            this.lbShowLicInfo.TabStop = true;
            this.lbShowLicInfo.Text = "Show New License Info";
            this.lbShowLicInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowLicInfo_LinkClicked);
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
            // lbReplaceLicID
            // 
            this.lbReplaceLicID.AutoSize = true;
            this.lbReplaceLicID.Location = new System.Drawing.Point(937, 48);
            this.lbReplaceLicID.Name = "lbReplaceLicID";
            this.lbReplaceLicID.Size = new System.Drawing.Size(45, 28);
            this.lbReplaceLicID.TabIndex = 59;
            this.lbReplaceLicID.Text = "???";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(889, 144);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(45, 28);
            this.lbUserName.TabIndex = 57;
            this.lbUserName.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(674, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 28);
            this.label8.TabIndex = 56;
            this.label8.Text = "Created By:";
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
            this.label2.Size = new System.Drawing.Size(255, 28);
            this.label2.TabIndex = 53;
            this.label2.Text = "Replaced License.ID:";
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
            // lbAppFees
            // 
            this.lbAppFees.AutoSize = true;
            this.lbAppFees.Location = new System.Drawing.Point(235, 144);
            this.lbAppFees.Name = "lbAppFees";
            this.lbAppFees.Size = new System.Drawing.Size(45, 28);
            this.lbAppFees.TabIndex = 50;
            this.lbAppFees.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 28);
            this.label5.TabIndex = 49;
            this.label5.Text = "Application Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 144);
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
            this.label1.Text = "L.R.Application.ID:";
            // 
            // ctrlFilterANDLicInfo1
            // 
            this.ctrlFilterANDLicInfo1.IsFound = false;
            this.ctrlFilterANDLicInfo1.LicenseID = -1;
            this.ctrlFilterANDLicInfo1.Location = new System.Drawing.Point(12, 79);
            this.ctrlFilterANDLicInfo1.Name = "ctrlFilterANDLicInfo1";
            this.ctrlFilterANDLicInfo1.Size = new System.Drawing.Size(1214, 578);
            this.ctrlFilterANDLicInfo1.TabIndex = 0;
            this.ctrlFilterANDLicInfo1.Load += new System.EventHandler(this.ctrlFilterANDLicInfo1_Load);
            // 
            // frmReplacementDamageOrLost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 915);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlFilterANDLicInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReplacementDamageOrLost";
            this.ShowIcon = false;
            this.Text = "Replacement";
            this.Load += new System.EventHandler(this.frmReplacementDamageOrLost_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlFilterANDLicInfo ctrlFilterANDLicInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdLost;
        private System.Windows.Forms.RadioButton reDamage;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btRenew;
        private System.Windows.Forms.LinkLabel lbShowLicInfo;
        private System.Windows.Forms.Label lbOldLicID;
        private System.Windows.Forms.Label lbReplaceLicID;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAppDate;
        private System.Windows.Forms.Label lbAppFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbAppID;
        private System.Windows.Forms.Label label1;
    }
}