namespace DVLD1
{
    partial class frmShowPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPerson));
            this.lbTitle = new System.Windows.Forms.Label();
            this.ctrlInfoPerson1 = new DVLD1.ctrlInfoPerson();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Brown;
            this.lbTitle.Location = new System.Drawing.Point(350, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(257, 40);
            this.lbTitle.TabIndex = 42;
            this.lbTitle.Text = "Person Details";
            // 
            // ctrlInfoPerson1
            // 
            this.ctrlInfoPerson1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrlInfoPerson1.Location = new System.Drawing.Point(2, 93);
            this.ctrlInfoPerson1.Name = "ctrlInfoPerson1";
            this.ctrlInfoPerson1.Size = new System.Drawing.Size(953, 362);
            this.ctrlInfoPerson1.TabIndex = 43;
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btClose.Location = new System.Drawing.Point(834, 469);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(121, 35);
            this.btClose.TabIndex = 72;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frmShowPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 516);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.ctrlInfoPerson1);
            this.Controls.Add(this.lbTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowPerson";
            this.Text = "Person Details";
            this.Load += new System.EventHandler(this.frmShowPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private ctrlInfoPerson ctrlInfoPerson1;
        private System.Windows.Forms.Button btClose;
    }
}