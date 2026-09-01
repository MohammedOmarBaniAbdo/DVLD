using BLLPeopleDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD1
{
    public partial class frmDetainLicense : Form
    {
        int LicID = -1;
        BLLDetain Detain;
        BLLLinceses Lic;
        BLLDrivers Driver;
        public frmDetainLicense()
        {
            InitializeComponent();
        }
        private void _AddNewDetain()
        {
            Detain = new BLLDetain();
            Detain.LicenseID = LicID;
            Detain.DetainDate = DateTime.Now;
            Detain.FineFees = Convert.ToDecimal(txtFees.Text);
            Detain.CreatedByUserID = clsGlobal.UserID;
            Detain.IsReleased = false;
            if (Detain.Save())
            {
                MessageBox.Show("Done Detailed License.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbDetainID.Text = Detain.DetainID.ToString();
                lbLicID.Text = LicID.ToString();
                lbShowLicInfo.Enabled = true;
            }
        }
        private void lbDetain_Click(object sender, EventArgs e)
        {
            LicID = ctrlFilterANDLicInfo1.LicenseID;
            if (LicID == -1 || !ctrlFilterANDLicInfo1.IsFound)
            {
                MessageBox.Show("Please select a valid local license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (BLLDetain.IsLicenseDetained(LicID))
            {
                MessageBox.Show("this License already detained.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtFees.Text) || txtFees.Text == ".")
            {
                MessageBox.Show("Enter Fine Fees.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFees.Focus();
                return; // إيقاف العملية
            }

            // 3. التحقق من تحويل النص إلى رقم ومن أنه أكبر من صفر
            if (!decimal.TryParse(txtFees.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Enter Fine Fees.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFees.Focus();
                return;
            }
                _AddNewDetain();
        }

        private void ctrlFilterANDLicInfo1_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            lbShowLicInfo.Enabled = false;
            lbDetainDate.Text = DateTime.Now.ToString();
            lbUserName.Text = clsGlobal.UserName;
            txtFees.ValidatingType = typeof(decimal);
        }

        private void txtFees_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicID = ctrlFilterANDLicInfo1.LicenseID;
            if (LicID == -1 || !ctrlFilterANDLicInfo1.IsFound)
            {
                MessageBox.Show("Please select a valid local license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Lic = BLLLinceses.Find(LicID);
            if (Lic == null)
            {
                MessageBox.Show("Palese Enter License ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Driver = BLLDrivers.FindByDriverID(Lic.DriverID);
            frmShowHistoryLic frm = new frmShowHistoryLic(Driver.PersonID, Driver.DriverID);
            frm.ShowDialog();
        }

        private void lbShowLicInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLic frm = new frmShowLic(LicID);
            frm.ShowDialog();
        }
    }
}
