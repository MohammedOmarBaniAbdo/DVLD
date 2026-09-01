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
    public partial class frmTakeTest : Form
    {
        BLLTestAppointment App;
        BLLTests test;
        BLLApplications applications;
        BLLLocalDirivingLincenseApplication LocalApp;
        int _TestAppID = -1, _DLID = -1, _TestTypeID = -1;

        private void btSave_Click(object sender, EventArgs e)
        {
            App = BLLTestAppointment.Find(_TestAppID);
            App.LDID = _DLID;
            App.AppDate = ctrlScheduleTest1.DataTimePicker;
            App.TestFees = ctrlScheduleTest1.FeesTest;
            App.GlobleUserID = clsGlobal.UserID;
            App.IsLocked = 1;
            //________________________________________________________________
            test = new BLLTests();
            test.TestAppointmentID = _TestAppID;
            test.Notes = txtNote.Text;
            test.CreatedByUserID = clsGlobal.UserID;
            if (rdPass.Checked == true)
            {
                test.TestResult = true;
            }
            else {
                test.TestResult = false;
            }
            if (MessageBox.Show("Are you sure to Save Result? ", "Q", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (App.Save() && test.AddNewTest())
                {
                    MessageBox.Show(" Done; Save Result", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Not Can Complete Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ctrlScheduleTest1_Load(object sender, EventArgs e)
        {

        }

        public frmTakeTest(int TestAppID, int DLID,int TestTypeID)
        {
            _TestAppID = TestAppID;
            _DLID = DLID;
            _TestTypeID = TestTypeID;
            InitializeComponent();
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            App = BLLTestAppointment.Find(_TestAppID);
            ctrlScheduleTest1.LoadData(_DLID, _TestTypeID);
            ctrlScheduleTest1.labelTrial = BLLTestAppointment.TestAppointmentCount(_DLID, _TestTypeID).ToString();
            ctrlScheduleTest1.LabelText2 = "";
            ctrlScheduleTest1.DataTimePicker = App.AppDate;
            rdPass.Checked = true;
            btSave.Enabled = true;
            if (BLLTestAppointment.TestAppointmentIsLoachedByTestID(_TestAppID))
            {
                rdPass.Enabled = false;
                rdFail.Enabled = false;
                txtNote.Enabled = false;
                btSave.Enabled = false;
            }
        }
    }
}
