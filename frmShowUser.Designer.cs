namespace DVLD1
{
    partial class frmShowUser
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
            this.btClose = new System.Windows.Forms.Button();
            this.ctrlLoginInfo1 = new DVLD1.ctrlLoginInfo();
            this.ctrlInfoPerson1 = new DVLD1.ctrlInfoPerson();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btClose.Location = new System.Drawing.Point(834, 542);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(121, 35);
            this.btClose.TabIndex = 73;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // ctrlLoginInfo1
            // 
            this.ctrlLoginInfo1.Location = new System.Drawing.Point(12, 409);
            this.ctrlLoginInfo1.Name = "ctrlLoginInfo1";
            this.ctrlLoginInfo1.Size = new System.Drawing.Size(953, 127);
            this.ctrlLoginInfo1.TabIndex = 74;
            // 
            // ctrlInfoPerson1
            // 
            this.ctrlInfoPerson1.Location = new System.Drawing.Point(12, 26);
            this.ctrlInfoPerson1.Name = "ctrlInfoPerson1";
            this.ctrlInfoPerson1.Size = new System.Drawing.Size(943, 373);
            this.ctrlInfoPerson1.TabIndex = 0;
            this.ctrlInfoPerson1.Load += new System.EventHandler(this.ctrlInfoPerson1_Load);
            // 
            // frmShowUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 584);
            this.Controls.Add(this.ctrlLoginInfo1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.ctrlInfoPerson1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowUser";
            this.ShowIcon = false;
            this.Text = "ShowUser";
            this.Load += new System.EventHandler(this.frmShowUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlInfoPerson ctrlInfoPerson1;
        private System.Windows.Forms.Button btClose;
        private ctrlLoginInfo ctrlLoginInfo1;
    }
}