using BLLPeopleDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD1
{
    public partial class frmIssueDrivingLinc : Form
    {
        BLLLinceses Lin;
        BLLApplications Application;
        BLLDrivers Drivers;
        int LocalDrivingLicenseApplicationID = -1;
        string ClassName = "";
        byte PassRes = 0;
        public frmIssueDrivingLinc(int dLID, string className)
        {
            InitializeComponent();
            LocalDrivingLicenseApplicationID = dLID;
            ClassName = className;
        }

        private void frmIssueDrivingLinc_Load(object sender, EventArgs e)
        {
            ctrlAddAppointments1.LoadDataGroubBox1ANDGB2(LocalDrivingLicenseApplicationID, ClassName, PassRes);
            ctrlAddAppointments1.lbPassedTest = "3/3";
            ctrlAddAppointments1.lnlbShowLin = false;
        }

        private void btIssue_Click(object sender, EventArgs e)
        {
            Lin = new BLLLinceses();
            Lin.ApplicationID = ctrlAddAppointments1.ApplicationID;
            Application = BLLApplications.FindApplication(ctrlAddAppointments1.ApplicationID);
            Drivers = BLLDrivers.Find(Application.ApplicantPersonID);
            if (Drivers == null)
            {
                Drivers = new BLLDrivers();
                Drivers.PersonID = Application.ApplicantPersonID;
                Drivers.CreatedByUserID = clsGlobal.UserID;
                Drivers.CreatedDate = DateTime.Now;
                Drivers.AddNewDriver();
            }
            Lin.DriverID = Drivers.DriverID;
            Lin.LicenseClass = ctrlAddAppointments1.ClassNamID;
            Lin.IssueDate = DateTime.Now;
            Lin.ExpirationDate = Lin.IssueDate.AddYears(
                BLLLicenseClasses.GetDefaultValidityLength(
                    ctrlAddAppointments1.ClassNamID));
            Lin.Notes = txtNots.Text.Trim();
            Lin.PaidFees = 0;
            Lin.IsActive = true;
            Lin.CreatedByUserID = clsGlobal.UserID;
            Lin.IssueReason = 1;
            if (Lin.AddNewLnicess())
            {
                MessageBox.Show("License Issued Sucssfully with License ID = " + Lin.LincesesID, "Succeeded", MessageBoxButtons.OK,MessageBoxIcon.Information);
                BLLApplications.UpdateStatusToComplete(Application.ApplicationID);
                ctrlAddAppointments1.lnlbShowLin = true;
                btIssue.Enabled = false;
            }
        }
    }
}
