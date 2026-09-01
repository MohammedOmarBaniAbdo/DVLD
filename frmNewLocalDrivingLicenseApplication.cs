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
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {
        enum enMode
        {
            AddNew = 1,
            Update = 2,
        }
        enMode Mode;
        private int _AppID;
        private void _FillCmbClass()
        {
            DataTable dt = BLLLicenseClasses.GetAllNameLicenseClasses();
            cmbClass.DataSource = dt;
            cmbClass.DisplayMember = "ClassName";
            cmbClass.ValueMember = "LicenseClassID";
            cmbClass.SelectedIndex = 0;
        }
        BLLApplications Application;
        BLLLocalDirivingLincenseApplication NewLocalApp;
        public frmNewLocalDrivingLicenseApplication(int ApplicationID)
        {
            InitializeComponent();
            _AppID = ApplicationID;
            if (_AppID == -1)
            {
                Mode = enMode.AddNew;
            }
            else
            {
                Mode = enMode.Update;
                lbTitle1.Text = "Update Local Driving License Application";
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            lbUserName.Text = clsGlobal.UserName;
            _FillCmbClass();
            lbFees.Text = BLLApplicationTypes.GetFeesApplicationTypeByID(1).ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (ctrlFilterAndPersinInfo1.PersonID != -1)
            {
                tabControl1.SelectedTab = tabPage2;
            }
            else
            {
                MessageBox.Show("Please Find Person", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void ctrlFilterAndPersinInfo1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void tabPage2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage2 && ctrlFilterAndPersinInfo1.PersonID == -1)
            {
                MessageBox.Show("Please Find Person", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (BLLApplications.IsExistApplication(Convert.ToInt32(ctrlFilterAndPersinInfo1.PersonID), Convert.ToInt32(cmbClass.SelectedValue)))
            {
                MessageBox.Show("Appliacation Is Exist", "Not Can Complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Mode == enMode.AddNew)
            {
                Application = new BLLApplications();
                Application.ApplicantPersonID = ctrlFilterAndPersinInfo1.PersonID;
                Application.ApplicationDate = dateTimePicker1.Value;
                Application.ApplicationTypeID = 1;
                Application.ApplicationStatus = 1;
                Application.LastStatusDate = dateTimePicker1.Value;
                Application.PaidFees = BLLLicenseClasses.GetFeesClassByID(Convert.ToInt32(cmbClass.SelectedValue));
                Application.CreatedByUserID = clsGlobal.UserID;
      
                if (Application.Save())
                {
                    MessageBox.Show("Appliacation Add is Done", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbTitle2.Text = "Update Local Driving License Application";
                    Mode = enMode.Update;
                    //_____________________________________________________
                    NewLocalApp = new BLLLocalDirivingLincenseApplication();
                    NewLocalApp.classID = Convert.ToInt32(cmbClass.SelectedValue);
                    NewLocalApp.ApplicationID = Application.ApplicationID;
                    NewLocalApp.AddNewAppLocalDriving();
                    lbID.Text = NewLocalApp.ApplicationLocalDrivingID.ToString();
                    return;
                }
                else
                {
                    MessageBox.Show("Appliacation can`t Add", "Erroe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
    }
}