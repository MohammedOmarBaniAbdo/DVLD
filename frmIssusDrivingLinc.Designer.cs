namespace DVLD1
{
    partial class frmIssueDrivingLinc
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
            this.txtNots = new System.Windows.Forms.RichTextBox();
            this.btIssue = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlAddAppointments1 = new DVLD1.ctrlAddAppointments();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notes:";
            // 
            // txtNots
            // 
            this.txtNots.Location = new System.Drawing.Point(137, 567);
            this.txtNots.Name = "txtNots";
            this.txtNots.Size = new System.Drawing.Size(786, 120);
            this.txtNots.TabIndex = 2;
            this.txtNots.Text = "";
            // 
            // btIssue
            // 
            this.btIssue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIssue.Location = new System.Drawing.Point(817, 693);
            this.btIssue.Name = "btIssue";
            this.btIssue.Size = new System.Drawing.Size(106, 40);
            this.btIssue.TabIndex = 3;
            this.btIssue.Text = "Issue";
            this.btIssue.UseVisualStyleBackColor = true;
            this.btIssue.Click += new System.EventHandler(this.btIssue_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD1.Properties.Resources.id;
            this.pictureBox1.Location = new System.Drawing.Point(776, 693);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlAddAppointments1
            // 
            this.ctrlAddAppointments1.ApplicationID = -1;
            this.ctrlAddAppointments1.ClassNamID = -1;
            this.ctrlAddAppointments1.lbPassedTest = "???";
            this.ctrlAddAppointments1.lnlbShowLin = false;
            this.ctrlAddAppointments1.Location = new System.Drawing.Point(12, 12);
            this.ctrlAddAppointments1.Name = "ctrlAddAppointments1";
            this.ctrlAddAppointments1.Size = new System.Drawing.Size(911, 552);
            this.ctrlAddAppointments1.TabIndex = 0;
            // 
            // frmIssueDrivingLinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 762);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btIssue);
            this.Controls.Add(this.txtNots);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlAddAppointments1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIssueDrivingLinc";
            this.ShowIcon = false;
            this.Text = "Issus Driving Lincese For First Time";
            this.Load += new System.EventHandler(this.frmIssueDrivingLinc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlAddAppointments ctrlAddAppointments1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtNots;
        private System.Windows.Forms.Button btIssue;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}