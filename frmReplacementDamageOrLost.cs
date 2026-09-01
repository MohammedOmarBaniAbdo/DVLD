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
    public partial class frmReplacementDamageOrLost : Form
    {
        int OldLicenseID = -1;
        BLLApplications Application;
        BLLLinceses OldLic;
        BLLDrivers Driver;
        BLLLinceses NewLinceses;
        public frmReplacementDamageOrLost()
        {
            InitializeComponent();
        }

        private void reDamage_CheckedChanged(object sender, EventArgs e)
        {
            if (reDamage.Checked == true)
            {
                lbTitle.Text = "Replacement For Damaged License";
                lbAppFees.Text = BLLApplicationTypes.GetFeesApplicationTypeByID(4).ToString();
            }
            else
            {
                lbTitle.Text = "Replacement For Lost License";
                lbAppFees.Text = BLLApplicationTypes.GetFeesApplicationTypeByID(3).ToString();
            }
        }

        private void frmReplacementDamageOrLost_Load(object sender, EventArgs e)
        {
            reDamage.Checked = true;
            this.AutoScroll = true;
            lbShowLicInfo.Enabled = false;
            lbAppDate.Text = DateTime.Now.ToString();
            lbUserName.Text = clsGlobal.UserName;
            lbAppFees.Text = BLLApplicationTypes.GetFeesApplicationTypeByID(4).ToString();
        }

        private void ctrlFilterANDLicInfo1_Load(object sender, EventArgs e)
        {

        }
        private void _AddNewApplication()
        {
            Application = new BLLApplications();
            OldLic = BLLLinceses.Find(OldLicenseID);
            Driver = BLLDrivers.FindByDriverID(OldLic.DriverID);
            Application.ApplicantPersonID = Driver.PersonID;
            Application.ApplicationDate = DateTime.Now;

            if (reDamage.Checked == true)
            {
                Application.ApplicationTypeID = 4;
                Application.PaidFees = BLLApplicationTypes.GetFeesApplicationTypeByID(4);
            }
            else
            {
                Application.ApplicationTypeID = 3;
                Application.PaidFees = BLLApplicationTypes.GetFeesApplicationTypeByID(3);
            }


            Application.ApplicationStatus = 3;
            Application.LastStatusDate = DateTime.Now;
            Application.CreatedByUserID = clsGlobal.UserID;
            Application.AddNewApplication();
        }
        private void _ConvertToNotActive()
        {
            bool IsDone = BLLLinceses.ConvertToNotActiveLicense(OldLicenseID);
            if (!IsDone)
            {
                MessageBox.Show("Can Not Convert Old License to Not Active.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void _AddNewLicense()
        {
            NewLinceses = new BLLLinceses();
            OldLic = BLLLinceses.Find(OldLicenseID);
            //Application = BLLApplications.FindApplication(OldLic.ApplicationID);
            NewLinceses.ApplicationID = Application.ApplicationID;
            NewLinceses.DriverID = OldLic.DriverID;
            NewLinceses.LicenseClass = OldLic.LicenseClass;
            NewLinceses.IssueDate = DateTime.Now;
            NewLinceses.ExpirationDate = DateTime.Now.AddYears(BLLLicenseClasses.GetDefaultValidityLength(OldLic.LicenseClass));
            NewLinceses.Notes = "";
            NewLinceses.PaidFees =  BLLApplicationTypes.GetFeesApplicationTypeByID(Application.ApplicationTypeID);
            NewLinceses.IsActive = true;
            if (reDamage.Checked == true)
            {
                NewLinceses.IssueReason = 4;
            }
            if (rdLost.Checked == true)
            {
                NewLinceses.IssueReason = 3;
            }
            NewLinceses.CreatedByUserID = clsGlobal.UserID;
            if (NewLinceses.AddNewLnicess())
            {
                MessageBox.Show($"Replacement License Issued Successfully with ID = {NewLinceses.LincesesID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbShowLicInfo.Enabled = true;
                lbAppID.Text = Application.ApplicationID.ToString();
                lbReplaceLicID.Text = NewLinceses.LincesesID.ToString();
                lbOldLicID.Text = OldLic.LincesesID.ToString();
            }
            else
            {
                MessageBox.Show("Failed to Replacment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btRenew_Click(object sender, EventArgs e)
        {
            OldLicenseID = ctrlFilterANDLicInfo1.LicenseID;
            if (OldLicenseID == -1 || !ctrlFilterANDLicInfo1.IsFound)
            {
                MessageBox.Show("Please select a valid local license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!BLLLinceses.IsActiveLicByLicID(OldLicenseID))
            {
                MessageBox.Show("Can Not Replacement License is Not Active.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _AddNewApplication();
            _ConvertToNotActive();
            _AddNewLicense();
        }

        private void rdLost_CheckedChanged(object sender, EventArgs e)
        {
            //lbAppFees.Text = BLLApplicationTypes.GetFeesApplicationTypeByID(3).ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbShowLicInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLic frm = new frmShowLic(NewLinceses.LincesesID);
            frm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OldLicenseID = ctrlFilterANDLicInfo1.LicenseID;
            if (OldLicenseID == -1 || !ctrlFilterANDLicInfo1.IsFound)
            {
                MessageBox.Show("Please select a valid local license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OldLic = BLLLinceses.Find(OldLicenseID);
            if (OldLic == null)
            {
                MessageBox.Show("Palese Enter License ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Driver = BLLDrivers.FindByDriverID(OldLic.DriverID);
            frmShowHistoryLic frm = new frmShowHistoryLic(Driver.PersonID, Driver.DriverID);
            frm.ShowDialog();
        }
    }
}
