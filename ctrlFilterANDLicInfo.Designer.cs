namespace DVLD1
{
    partial class ctrlFilterANDLicInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEnterPlaceHolder = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLinID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pcImage = new System.Windows.Forms.PictureBox();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.lbDateBrith = new System.Windows.Forms.Label();
            this.lbDriverID = new System.Windows.Forms.Label();
            this.lbExDate = new System.Windows.Forms.Label();
            this.lbIsDet = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbIssueRe = new System.Windows.Forms.Label();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.lbGendor = new System.Windows.Forms.Label();
            this.lbNationalNo = new System.Windows.Forms.Label();
            this.lbLinID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbNotes = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbEnterPlaceHolder);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtLinID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // lbEnterPlaceHolder
            // 
            this.lbEnterPlaceHolder.AutoSize = true;
            this.lbEnterPlaceHolder.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnterPlaceHolder.ForeColor = System.Drawing.Color.Brown;
            this.lbEnterPlaceHolder.Location = new System.Drawing.Point(121, 73);
            this.lbEnterPlaceHolder.Name = "lbEnterPlaceHolder";
            this.lbEnterPlaceHolder.Size = new System.Drawing.Size(169, 21);
            this.lbEnterPlaceHolder.TabIndex = 3;
            this.lbEnterPlaceHolder.Text = "Press Enter to search";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD1.Properties.Resources.id;
            this.pictureBox1.Location = new System.Drawing.Point(444, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtLinID
            // 
            this.txtLinID.Location = new System.Drawing.Point(125, 35);
            this.txtLinID.Name = "txtLinID";
            this.txtLinID.Size = new System.Drawing.Size(299, 35);
            this.txtLinID.TabIndex = 2;
            this.txtLinID.TextChanged += new System.EventHandler(this.txtLinID_TextChanged);
            this.txtLinID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctrlFilterANDLicInfo_KeyDown);
            this.txtLinID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLinID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "LicenseID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pcImage);
            this.groupBox2.Controls.Add(this.lbIsActive);
            this.groupBox2.Controls.Add(this.lbDateBrith);
            this.groupBox2.Controls.Add(this.lbDriverID);
            this.groupBox2.Controls.Add(this.lbExDate);
            this.groupBox2.Controls.Add(this.lbIsDet);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbIssueRe);
            this.groupBox2.Controls.Add(this.lbIssueDate);
            this.groupBox2.Controls.Add(this.lbGendor);
            this.groupBox2.Controls.Add(this.lbNationalNo);
            this.groupBox2.Controls.Add(this.lbLinID);
            this.groupBox2.Controls.Add(this.lbName);
            this.groupBox2.Controls.Add(this.lbNotes);
            this.groupBox2.Controls.Add(this.lbClass);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1193, 463);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Driver License Info ";
            // 
            // pcImage
            // 
            this.pcImage.Location = new System.Drawing.Point(949, 47);
            this.pcImage.Name = "pcImage";
            this.pcImage.Size = new System.Drawing.Size(220, 238);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcImage.TabIndex = 3;
            this.pcImage.TabStop = false;
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsActive.Location = new System.Drawing.Point(722, 188);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(45, 28);
            this.lbIsActive.TabIndex = 28;
            this.lbIsActive.Text = "???";
            // 
            // lbDateBrith
            // 
            this.lbDateBrith.AutoSize = true;
            this.lbDateBrith.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateBrith.Location = new System.Drawing.Point(722, 235);
            this.lbDateBrith.Name = "lbDateBrith";
            this.lbDateBrith.Size = new System.Drawing.Size(45, 28);
            this.lbDateBrith.TabIndex = 27;
            this.lbDateBrith.Text = "???";
            // 
            // lbDriverID
            // 
            this.lbDriverID.AutoSize = true;
            this.lbDriverID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDriverID.Location = new System.Drawing.Point(722, 329);
            this.lbDriverID.Name = "lbDriverID";
            this.lbDriverID.Size = new System.Drawing.Size(45, 28);
            this.lbDriverID.TabIndex = 26;
            this.lbDriverID.Text = "???";
            // 
            // lbExDate
            // 
            this.lbExDate.AutoSize = true;
            this.lbExDate.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExDate.Location = new System.Drawing.Point(722, 282);
            this.lbExDate.Name = "lbExDate";
            this.lbExDate.Size = new System.Drawing.Size(45, 28);
            this.lbExDate.TabIndex = 25;
            this.lbExDate.Text = "???";
            // 
            // lbIsDet
            // 
            this.lbIsDet.AutoSize = true;
            this.lbIsDet.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsDet.Location = new System.Drawing.Point(722, 376);
            this.lbIsDet.Name = "lbIsDet";
            this.lbIsDet.Size = new System.Drawing.Size(45, 28);
            this.lbIsDet.TabIndex = 24;
            this.lbIsDet.Text = "???";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(501, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 28);
            this.label14.TabIndex = 23;
            this.label14.Text = "Is Active:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(501, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 28);
            this.label13.TabIndex = 22;
            this.label13.Text = "Date of Brith:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(501, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 28);
            this.label12.TabIndex = 21;
            this.label12.Text = "Driver ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(501, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 28);
            this.label11.TabIndex = 20;
            this.label11.Text = "Expiration Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(501, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 28);
            this.label10.TabIndex = 19;
            this.label10.Text = "Is Detained:";
            // 
            // lbIssueRe
            // 
            this.lbIssueRe.AutoSize = true;
            this.lbIssueRe.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssueRe.Location = new System.Drawing.Point(186, 329);
            this.lbIssueRe.Name = "lbIssueRe";
            this.lbIssueRe.Size = new System.Drawing.Size(45, 28);
            this.lbIssueRe.TabIndex = 18;
            this.lbIssueRe.Text = "???";
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.AutoSize = true;
            this.lbIssueDate.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssueDate.Location = new System.Drawing.Point(186, 282);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(45, 28);
            this.lbIssueDate.TabIndex = 17;
            this.lbIssueDate.Text = "???";
            // 
            // lbGendor
            // 
            this.lbGendor.AutoSize = true;
            this.lbGendor.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGendor.Location = new System.Drawing.Point(186, 235);
            this.lbGendor.Name = "lbGendor";
            this.lbGendor.Size = new System.Drawing.Size(45, 28);
            this.lbGendor.TabIndex = 16;
            this.lbGendor.Text = "???";
            // 
            // lbNationalNo
            // 
            this.lbNationalNo.AutoSize = true;
            this.lbNationalNo.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationalNo.Location = new System.Drawing.Point(186, 188);
            this.lbNationalNo.Name = "lbNationalNo";
            this.lbNationalNo.Size = new System.Drawing.Size(45, 28);
            this.lbNationalNo.TabIndex = 15;
            this.lbNationalNo.Text = "???";
            // 
            // lbLinID
            // 
            this.lbLinID.AutoSize = true;
            this.lbLinID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinID.Location = new System.Drawing.Point(186, 141);
            this.lbLinID.Name = "lbLinID";
            this.lbLinID.Size = new System.Drawing.Size(45, 28);
            this.lbLinID.TabIndex = 14;
            this.lbLinID.Text = "???";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(186, 94);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 28);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "???";
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotes.Location = new System.Drawing.Point(186, 376);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(45, 28);
            this.lbNotes.TabIndex = 12;
            this.lbNotes.Text = "???";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.Location = new System.Drawing.Point(186, 47);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(45, 28);
            this.lbClass.TabIndex = 11;
            this.lbClass.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 28);
            this.label9.TabIndex = 10;
            this.label9.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "License ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "National NO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gendor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Issue Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Issue Reason:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class:";
            // 
            // ctrlFilterANDLicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlFilterANDLicInfo";
            this.Size = new System.Drawing.Size(1214, 578);
            this.Load += new System.EventHandler(this.ctrlFilterANDLicInfo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctrlFilterANDLicInfo_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLinID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pcImage;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label lbDateBrith;
        private System.Windows.Forms.Label lbDriverID;
        private System.Windows.Forms.Label lbExDate;
        private System.Windows.Forms.Label lbIsDet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbIssueRe;
        private System.Windows.Forms.Label lbIssueDate;
        private System.Windows.Forms.Label lbGendor;
        private System.Windows.Forms.Label lbNationalNo;
        private System.Windows.Forms.Label lbLinID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbNotes;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbEnterPlaceHolder;
    }
}
