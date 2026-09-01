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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD1
{
    public partial class frmAddInternationalLicenseAndFilterAndShowInternationalLic : Form
    {
        int _LinID = -1;
        int _InterLicID = -1;
        BLLLinceses Linceses;
        BLLApplications Application;
        BLLDrivers Driver;
        BLLInternationalLicenses internationalLicense;
        public frmAddInternationalLicenseAndFilterAndShowInternationalLic()
        {
            InitializeComponent();
        }

        private void frmAddInternationalLicenseAndFilterAndShowInternationalLic_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            lbShowLicInfo.Enabled = false;
            lbAppDate.Text = DateTime.Now.ToString();
            lbIssueDate.Text = DateTime.Now.ToString();
            lbExDate.Text = DateTime.Now.AddYears(1).ToString();
            lbFees.Text = BLLApplicationTypes.GetFeesApplicationTypeByID(6).ToString();
            lbUserName.Text = clsGlobal.UserName;
           
        }
        private void _AddNewApplication()
        {
            Application = new BLLApplications();
            Linceses = BLLLinceses.Find(_LinID);
            Driver = BLLDrivers.FindByDriverID(Linceses.DriverID);
            Application.ApplicantPersonID = Driver.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = 6;
            Application.ApplicationStatus = 1;
            Application.LastStatusDate = DateTime.Now;
            Application.CreatedByUserID = clsGlobal.UserID;
            Application.PaidFees = BLLApplicationTypes.GetFeesApplicationTypeByID(6);
            Application.AddNewApplication();
            
        }
        private void _AddNewInternationalLice()
        {
            internationalLicense = new BLLInternationalLicenses();
            internationalLicense.ApplicationID = Application.ApplicationID;
            internationalLicense.DriverID = Linceses.DriverID;
            internationalLicense.IssuedUsingLocalLicenseID = Linceses.LincesesID;
            internationalLicense.IssueDate = DateTime.Now;
            internationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            internationalLicense.IsActive = true;
            internationalLicense.CreatedByUserID = clsGlobal.UserID;
            if (internationalLicense.Save())
            {
                MessageBox.Show($"International License Issued Successfully with ID = {internationalLicense.InternationalLicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbLocalLicID.Text = _LinID.ToString();
                lbAppID.Text = Application.ApplicationID.ToString();
                lbInterLicID.Text = internationalLicense.InternationalLicenseID.ToString();
                _InterLicID = internationalLicense.InternationalLicenseID;
                lbShowLicInfo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to Issue International License.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btIssue_Click(object sender, EventArgs e)
        {
            _LinID = ctrlFilterANDLicInfo1.LicenseID;
            if (_LinID == -1 || !ctrlFilterANDLicInfo1.IsFound)
            {
                MessageBox.Show("Please select a valid local license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Linceses = BLLLinceses.Find(_LinID);
            if (Linceses == null)
            {
                MessageBox.Show("License data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (BLLInternationalLicenses.IsDriverHaveInternationalLicenseAndActice(Linceses.DriverID))
            {
                MessageBox.Show("Person alresdy have an active International License", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!BLLLinceses.HaveLicByClassID3(_LinID))
            {
                MessageBox.Show("Person Not have License by class (3)", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!BLLLinceses.IsActiveLicByLicID(_LinID))
            {
                MessageBox.Show("Not Can Complete,Person have License Not Active", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (BLLLinceses.IsEndLic(_LinID))
            {
                MessageBox.Show("Not Can Complete,Person have License Expirated Date", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _AddNewApplication();
            _AddNewInternationalLice();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicense frm = new frmShowInternationalLicense(_InterLicID);
            frm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _LinID = ctrlFilterANDLicInfo1.LicenseID;
            if (_LinID == -1 || !ctrlFilterANDLicInfo1.IsFound)
            {
                MessageBox.Show("Please select a valid local license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Linceses = BLLLinceses.Find(_LinID);
            if (Linceses == null)
            {
                MessageBox.Show("Palese Enter License ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Driver = BLLDrivers.FindByDriverID(Linceses.DriverID);
            frmShowHistoryLic frm = new frmShowHistoryLic(Driver.PersonID, Driver.DriverID);
            frm.ShowDialog();
        }

        private void ctrlFilterANDLicInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
