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
    public partial class ctrlAddAppointments : UserControl
    {
        private int _DLID = -1;
        private string _ClassName = "";
        private byte _PassRes = 0;
        private int _PersonID = -1;
        int ID = -1;
        int ClassNameID = -1;
        BLLLocalDirivingLincenseApplication LocalApp;
        BLLLinceses Lic;
        public ctrlAddAppointments()
        {
            InitializeComponent();
   
        }
        private void _LoadStatus(int NumSta)
        {

            if (NumSta == 1)
            {
                lbStatus.Text = "New";
                return;
            }
            if (NumSta == 2)
            {
                lbStatus.Text = "Cnnceled";
                return;
            }
            if (NumSta == 3)
            {
                lbStatus.Text = "Completed";
                return;
            }
            else
            {
                lbStatus.Text = "NULL";
            }
        }
        public void LoadDataGroubBox1ANDGB2(int DLID, string ClassName, byte PassedResult)
        {
            _DLID = DLID;
            _ClassName = ClassName;
            _PassRes = PassedResult;
            lbAppID.Text = _DLID.ToString();
            lbClassLic.Text = _ClassName;
            lbPassedTests.Text = _PassRes.ToString();
            _LoadDataGroubBox2();
        }
        private void _LoadDataGroubBox2()
        {
            BLLLocalDirivingLincenseApplication LocalApp = BLLLocalDirivingLincenseApplication.FindByLocalDrivingLicenseApplications(_DLID);
            if (LocalApp == null)
            {
                MessageBox.Show("Not Found Application", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            ID = LocalApp.ApplicationID;
            ClassNameID = LocalApp.classID;
            BLLApplications Application = BLLApplications.FindApplication(ID);
            if (Application == null)
            {
                MessageBox.Show("Not Found Application", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            lbID.Text = ID.ToString();
            _LoadStatus(Application.ApplicationStatus);
            lbFees.Text = Application.PaidFees.ToString();
            string NameServce =  BLLApplicationTypes.GetNameApplicationTypeByID(Application.ApplicationTypeID);
            lbType.Text = NameServce;
            lbDate.Text = Application.ApplicationDate.ToString();
            lbStDate.Text = Application.LastStatusDate.ToString();
            _PersonID = Application.ApplicantPersonID;
            string UserName = BLLUser.GetUserName(Application.CreatedByUserID);
            lbUser.Text = UserName;
            BLLPeople Person = BLLPeople.Find(_PersonID);
            lbApplicant.Text = Person.FirstName + " " + Person.SecName + " " + Person.thirdName + " " + Person.LastName;
        }
        private void ctrlAddAppointments_Load(object sender, EventArgs e)
        {
            lnlbLicneseInfo.Enabled = false;
        }
        public string lbPassedTest { set { lbPassedTests.Text = value; } get { return lbPassedTests.Text; } }
        public bool lnlbShowLin { set { lnlbLicneseInfo.Enabled = value; } get { return lnlbLicneseInfo.Enabled; } }
        public int ApplicationID { set { this.ID = value;  } get { return this.ID;  } }
        public int ClassNamID { set { this.ClassNameID = value; } get { return this.ClassNameID; } }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPerson frm = new frmShowPerson(_PersonID);
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lnlbLicneseInfo_Click(object sender, EventArgs e)
        {
            LocalApp = BLLLocalDirivingLincenseApplication.FindByLocalDrivingLicenseApplications(_DLID);
            Lic = BLLLinceses.FindByApplicationID(LocalApp.ApplicationID);
            frmShowLic frm = new frmShowLic(Lic.LincesesID);
            frm.ShowDialog();
        }
    }
}
