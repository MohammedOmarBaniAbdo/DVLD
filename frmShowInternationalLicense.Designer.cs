namespace DVLD1
{
    partial class frmShowInternationalLicense
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
            this.ctrlShowIntenationalLicense1 = new DVLD1.ctrlShowIntenationalLicense();
            this.SuspendLayout();
            // 
            // ctrlShowIntenationalLicense1
            // 
            this.ctrlShowIntenationalLicense1.Location = new System.Drawing.Point(12, 12);
            this.ctrlShowIntenationalLicense1.Name = "ctrlShowIntenationalLicense1";
            this.ctrlShowIntenationalLicense1.Size = new System.Drawing.Size(1198, 516);
            this.ctrlShowIntenationalLicense1.TabIndex = 0;
            // 
            // frmShowInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 540);
            this.Controls.Add(this.ctrlShowIntenationalLicense1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowInternationalLicense";
            this.ShowIcon = false;
            this.Text = "Show International License";
            this.Load += new System.EventHandler(this.frmShowInternationalLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowIntenationalLicense ctrlShowIntenationalLicense1;
    }
}