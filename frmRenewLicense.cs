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
    public partial class frmRenewLicense : Form
    {
        int OldLicenseID = -1, LicFees = 0, AppFees = 0;
        BLLApplications Application;
        BLLLinceses NewLinceses;
        BLLLinceses OldLic;
        BLLDrivers Driver;
        public frmRenewLicense()
        {
            InitializeComponent();
        }

        private void frmRenewLicense_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            lbShowLicInfo.Enabled = false;
            lbAppDate.Text = DateTime.Now.ToString();
            lbIssueDate.Text = DateTime.Now.ToString();
            lbAppFees.Text = BLLApplicationTypes.GetFeesApplicationTypeByID(2).ToString();
            lbUserName.Text = clsGlobal.UserName;

        }
        private void _AddNewApplication()
        {
            Application = new BLLApplications();
            OldLic = BLLLinceses.Find(OldLicenseID);
            Driver = BLLDrivers.FindByDriverID(OldLic.DriverID);
            Application.ApplicantPersonID = Driver.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = 2;
            Application.ApplicationStatus = 1;
            Application.LastStatusDate = DateTime.Now;
            Application.CreatedByUserID = clsGlobal.UserID;
            Application.PaidFees = BLLApplicationTypes.GetFeesApplicationTypeByID(2);
            AppFees = Convert.ToInt32(Application.PaidFees);
            Application.AddNewApplication();
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
            NewLinceses.Notes = txtNotes.Text;
            NewLinceses.PaidFees = (LicFees + AppFees);
            NewLinceses.IsActive = true;
            NewLinceses.IssueReason = 2;
            NewLinceses.CreatedByUserID = clsGlobal.UserID;
            if (NewLinceses.AddNewLnicess())
            {
                MessageBox.Show($"Renew License Issued Successfully with ID = {NewLinceses.LincesesID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbShowLicInfo.Enabled = true;

                lbAppID.Text = Application.ApplicationID.ToString();
                lbLicFees.Text = BLLLicenseClasses.GetFeesClassByID(OldLic.LicenseClass).ToString();
                LicFees = Convert.ToInt32(BLLLicenseClasses.GetFeesClassByID(OldLic.LicenseClass));
                txtNotes.Text = NewLinceses.Notes;
                lbNewLicID.Text = NewLinceses.LincesesID.ToString();
                lbOldLicID.Text = OldLic.LincesesID.ToString();
                lbExDate.Text = DateTime.Now.AddYears(BLLLicenseClasses.GetDefaultValidityLength(OldLic.LicenseClass)).ToString();
                lbTotalFees.Text = (LicFees + AppFees).ToString();

            }
            else
            {
                MessageBox.Show("Failed to Issue International License.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!BLLLinceses.IsEndLic(OldLicenseID))
            {
                MessageBox.Show("License is not Expirat.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (BLLLinceses.IsActiveLicByLicID(OldLicenseID))
            {
                MessageBox.Show("License is Active.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _AddNewApplication();
            _AddNewLicense();
        }

        private void ctrlFilterANDLicInfo1_Load(object sender, EventArgs e)
        {

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

        private void lbShowLicInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLic frm = new frmShowLic(NewLinceses.LincesesID);
            frm.ShowDialog();
        }

        private void lbTotalFees_Click(object sender, EventArgs e)
        {

        }
    }
}
