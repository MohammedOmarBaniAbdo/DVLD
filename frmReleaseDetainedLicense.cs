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
    public partial class frmReleaseDetainedLicense : Form
    {
        int LicID;
        int LicIDbyParameter;
        BLLDetain Detain;
        BLLLinceses Lic;
        BLLDrivers Driver;
        BLLApplications Application;
        public frmReleaseDetainedLicense(int licID = -1)
        {
            InitializeComponent();
            LicIDbyParameter = licID;
        }
        public string txtLicenseIDTextInCtrlFilterAndInfo { 
            get { return ctrlFilterANDLicInfo1.txtLicIDText; }
            set { ctrlFilterANDLicInfo1.txtLicIDText = value; }
        }
        public bool txtLicenseIDEnableInCtrlFilterAndInfo
        {
            get { return ctrlFilterANDLicInfo1.txtLicIDEnable; }
            set { ctrlFilterANDLicInfo1.txtLicIDEnable = value; }
        }
        private void lbShowLicInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLic frm = new frmShowLic(LicID);
            frm.ShowDialog();
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
        private void _AddNewApplication()
        {
            if (Detain == null)
            {
                MessageBox.Show("No active detain record found for this license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application = new BLLApplications();
            Application.ApplicantPersonID = Driver.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = 5;
            Application.ApplicationStatus = 3;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = (BLLApplicationTypes.GetFeesApplicationTypeByID(5) + Detain.FineFees);
            Application.CreatedByUserID = clsGlobal.UserID;
            bool IsDone = Application.Save();
            if (!IsDone)
            {
                MessageBox.Show("Not Can Save Application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void _UpdateDetain()
        {
            //Detain = BLLDetain.FindByLicenseID(LicID);
            Detain.Mode = BLLDetain.enMode.Update;
            Detain.IsReleased = true;
            Detain.ReleaseDate = DateTime.Now;
            Detain.ReleasedByUserID = clsGlobal.UserID;
            Detain.ReleaseApplicationID = Application.ApplicationID;
            if (Detain.Save())
            {
                lbAppID.Text = Application.ApplicationID.ToString();
                MessageBox.Show("Done Detailed License.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btRelase_Click(object sender, EventArgs e)
        {
            LicID = ctrlFilterANDLicInfo1.LicenseID;
            if (LicID == -1 || !ctrlFilterANDLicInfo1.IsFound)
            {
                MessageBox.Show("Please select a valid local license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!BLLDetain.IsLicenseDetained(LicID))
            {
                MessageBox.Show("this License Not detained.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _AddNewApplication();
            _UpdateDetain();
            lbShowLicInfo.Enabled = true;
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            lbShowLicInfo.Enabled = false;
            lbDetainDate.Text = DateTime.Now.ToString();
            lbUserName.Text = clsGlobal.UserName;
            if (txtLicenseIDEnableInCtrlFilterAndInfo == false)
            {
                LicIDbyParameter = ctrlFilterANDLicInfo1.LicenseID;
                if (LicIDbyParameter == -1)
                    return;
                Lic = BLLLinceses.Find(LicIDbyParameter);
                if (Lic == null)
                    return;
                Detain = BLLDetain.FindByLicenseID(LicIDbyParameter);

                if (Detain == null)
                {
                    MessageBox.Show("This license is not detained.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Driver = BLLDrivers.FindByDriverID(Lic.DriverID);
                lbDetainID.Text = Detain.DetainID.ToString();
                lbLicID.Text = LicIDbyParameter.ToString();
                lbAppFees.Text = BLLApplicationTypes.GetFeesApplicationTypeByID(5).ToString();
                lbTotalFees.Text = (BLLApplicationTypes.GetFeesApplicationTypeByID(5) + Detain.FineFees).ToString();
                lbFees.Text = Detain.FineFees.ToString();
                return;
            }
            ctrlFilterANDLicInfo1.FoundLic += ctrlFilterANDLicInfo1_FoundLic;
        }
        private void ctrlFilterANDLicInfo1_FoundLic()
        {
            LicID = ctrlFilterANDLicInfo1.LicenseID;
            if (LicID == -1)
                return;
            Lic = BLLLinceses.Find(LicID);
            if (Lic == null)
                return;
            Detain = BLLDetain.FindByLicenseID(LicID);

            if (Detain == null)
            {
                MessageBox.Show("This license is not detained.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Driver = BLLDrivers.FindByDriverID(Lic.DriverID);
            lbDetainID.Text = Detain.DetainID.ToString();
            lbLicID.Text = LicID.ToString();
            lbAppFees.Text = BLLApplicationTypes.GetFeesApplicationTypeByID(5).ToString();
            lbTotalFees.Text = (BLLApplicationTypes.GetFeesApplicationTypeByID(5) + Detain.FineFees).ToString();
            lbFees.Text = Detain.FineFees.ToString();
            

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
