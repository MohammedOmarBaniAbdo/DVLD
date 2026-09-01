namespace DVLD1
{
    partial class frmShowLic
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
            this.ctrlShowLicense1 = new DVLD1.ctrlShowLicense();
            this.SuspendLayout();
            // 
            // ctrlShowLicense1
            // 
            this.ctrlShowLicense1.Location = new System.Drawing.Point(1, 3);
            this.ctrlShowLicense1.Name = "ctrlShowLicense1";
            this.ctrlShowLicense1.Size = new System.Drawing.Size(1159, 646);
            this.ctrlShowLicense1.TabIndex = 0;
            this.ctrlShowLicense1.Load += new System.EventHandler(this.ctrlShowLicense1_Load);
            // 
            // frmShowLic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 648);
            this.Controls.Add(this.ctrlShowLicense1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowLic";
            this.ShowIcon = false;
            this.Text = "Show License";
            this.Load += new System.EventHandler(this.frmShowLic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowLicense ctrlShowLicense1;
    }
}