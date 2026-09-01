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
    public partial class frmVisionTest : Form
    {
        enum enMode
        {
            AddNew = 1,
            Update = 2,
        }
        enMode Mode;
        BLLTestAppointment App;
        int _DLID = -1, _TestTypeID = -1, _TestID = -1;
        int RAppFees = 0;
        public frmVisionTest(int TestID,int LDID,int TestTypeID)
        {
            _DLID = LDID;
            _TestTypeID = TestTypeID;
            _TestID = TestID;
            InitializeComponent();
        }
        private void _LoadInformation()
        {
            if (_TestID == -1)
            {
                Mode = enMode.AddNew;
                App = new BLLTestAppointment();
            }
            else
            {
                Mode = enMode.Update;
                App = BLLTestAppointment.Find(_TestID);
            }
        }
        private void _LoadDataInForm()
        {
            ctrlScheduleTest1.GroupBoxText = "Vision Test";
            ctrlScheduleTest1.LabelText2 = "";
            ctrlScheduleTest1.Picture = Properties.Resources.eye;
            ctrlScheduleTest1.labelTrial = BLLTestAppointment.TestAppointmentCount(_DLID,_TestTypeID).ToString();
            ctrlScheduleTest1.LoadData(_DLID, _TestTypeID);
            groupBox1.Enabled = false;
            btSave.Enabled = true;
            if (BLLTestAppointment.TestAppointmentCount(_DLID,_TestTypeID) > 0)
            {
                lbTestAppId.Text = App.TestAppID.ToString();
                lbAppFees.Text = "5";
                RAppFees = 5;
            }
            lbTotalFees.Text = (RAppFees + ctrlScheduleTest1.FeesTest).ToString();
        }
        private void _EnableOrLockDateAndSave()
        {
            if (_TestID == -1)
                return;

            if (BLLTestAppointment.TestAppointmentIsLoachedByTestID(_TestID))
            {
                btSave.Enabled = false;
                ctrlScheduleTest1.LabelText2 =
                    "Person already sat for the test, appointment locked";
                return;
            }
        }
        private void ctrlScheduleTest1_Load(object sender, EventArgs e)
        {
            
        }

        private void lbTotalFees_Click(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            
            //this.TestTypeID, this.LDID, this.AppDate, this.TestFees, this.GlobleUserID, this.IsLocked
             App.TestTypeID = _TestTypeID;
            App.LDID = _DLID;
            App.AppDate = ctrlScheduleTest1.DataTimePicker;
            App.TestFees = ctrlScheduleTest1.FeesTest;
            App.GlobleUserID = clsGlobal.UserID;
            App.IsLocked = 0;
            if (App.Save())
            {
                if (Mode == enMode.AddNew)
                {
                    MessageBox.Show("Add Appointment Is Done", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mode = enMode.Update;
                    btSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Edit Appointment Is Done", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Not Can Complete Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string GroubBoxText
        {
            set { groupBox1.Text = value; }
            get { return groupBox1.Text; }
        }

        private void lbAppFees_Click(object sender, EventArgs e)
        {

        }

        public bool GroubBoxEnabled { set { groupBox1.Enabled = value; } }
        private void frmVisionTest_Load(object sender, EventArgs e)
        {
            _LoadInformation();
            _LoadDataInForm();
            if (Mode == enMode.Update)
            {
                ctrlScheduleTest1.DataTimePicker = App.AppDate;
            }
            _EnableOrLockDateAndSave();

        }

    }
}
