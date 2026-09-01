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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Form Background
            this.BackColor = ColorTranslator.FromHtml("#1B1D2F");

            // MenuStrip
            menuStrip1.BackColor = ColorTranslator.FromHtml("#252A40");
            menuStrip1.ForeColor = ColorTranslator.FromHtml("#F1F1F1");
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeople frmPeople = new frmPeople();
            frmPeople.ShowDialog();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrivers frm = new frmDrivers();
            frm.ShowDialog();
        }

        private void accountSittingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLLUser FindUser = BLLUser.FindByUserName(clsGlobal.UserName);
            if (FindUser != null)
            {
                frmShowUser frm = new frmShowUser(FindUser.PersonID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login in User");
            }
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers();
            frmUsers.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLLUser FindUser = BLLUser.FindByUserName(clsGlobal.UserName);
            if (FindUser != null)
            {
                frmChangeBassword frm = new frmChangeBassword(FindUser.UserID,FindUser.PersonID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login in User");
            }
        }

        private void manageApplicationsTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestType frm = new frmManageTestType();
            frm.ShowDialog();
        }

        private void drivingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newDrivingLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication(-1);
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalApplication frm = new frmManageLocalApplication();
            frm.ShowDialog();
        }

        private void internationalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicenseAndFilterAndShowInternationalLic frm = new frmAddInternationalLicenseAndFilterAndShowInternationalLic();
            frm.ShowDialog();
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowAllApplicationInternationalLicense frm = new frmShowAllApplicationInternationalLicense();
            frm.ShowDialog();
        }

        private void rnewDrivingLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLicense frm = new frmRenewLicense();
            frm.ShowDialog();
        }

        private void replacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplacementDamageOrLost frm = new frmReplacementDamageOrLost();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void relaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void manageDetainLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDetainLic frm = new frmListDetainLic();
            frm.ShowDialog();
        }

        private void releaseDetaindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void retToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalApplication frm  = new frmManageLocalApplication();
            frm.ShowDialog();
        }
    }
}
