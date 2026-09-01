namespace DVLD1
{
    partial class frmTakeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTakeTest));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdPass = new System.Windows.Forms.RadioButton();
            this.rdFail = new System.Windows.Forms.RadioButton();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.ctrlScheduleTest1 = new DVLD1.ctrlScheduleTest();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notes:";
            // 
            // rdPass
            // 
            this.rdPass.AutoSize = true;
            this.rdPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPass.Location = new System.Drawing.Point(138, 563);
            this.rdPass.Name = "rdPass";
            this.rdPass.Size = new System.Drawing.Size(71, 28);
            this.rdPass.TabIndex = 3;
            this.rdPass.TabStop = true;
            this.rdPass.Text = "Pass";
            this.rdPass.UseVisualStyleBackColor = true;
            // 
            // rdFail
            // 
            this.rdFail.AutoSize = true;
            this.rdFail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFail.Location = new System.Drawing.Point(281, 563);
            this.rdFail.Name = "rdFail";
            this.rdFail.Size = new System.Drawing.Size(62, 28);
            this.rdFail.TabIndex = 4;
            this.rdFail.TabStop = true;
            this.rdFail.Text = "Fail";
            this.rdFail.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(138, 607);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(410, 64);
            this.txtNote.TabIndex = 5;
            this.txtNote.Text = "";
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btSave.Location = new System.Drawing.Point(427, 697);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(121, 35);
            this.btSave.TabIndex = 74;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ctrlScheduleTest1
            // 
            this.ctrlScheduleTest1.DataTimePicker = new System.DateTime(2026, 8, 22, 16, 47, 42, 393);
            this.ctrlScheduleTest1.GroupBoxText = "groupBox1";
            this.ctrlScheduleTest1.LabelText = "Schedule Test";
            this.ctrlScheduleTest1.LabelText2 = "Schedule Test";
            this.ctrlScheduleTest1.labelTrial = "???";
            this.ctrlScheduleTest1.Location = new System.Drawing.Point(11, -2);
            this.ctrlScheduleTest1.Name = "ctrlScheduleTest1";
            this.ctrlScheduleTest1.Picture = ((System.Drawing.Image)(resources.GetObject("ctrlScheduleTest1.Picture")));
            this.ctrlScheduleTest1.Size = new System.Drawing.Size(536, 559);
            this.ctrlScheduleTest1.TabIndex = 0;
            this.ctrlScheduleTest1.Load += new System.EventHandler(this.ctrlScheduleTest1_Load);
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 744);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.rdFail);
            this.Controls.Add(this.rdPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlScheduleTest1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTakeTest";
            this.ShowIcon = false;
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlScheduleTest ctrlScheduleTest1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdPass;
        private System.Windows.Forms.RadioButton rdFail;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Button btSave;
    }
}