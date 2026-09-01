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
    public partial class ctrlScheduleTest : UserControl
    {
        private int ApplicationID = 0;
        private int ClassNameID = 0;
        private int _TestTypeID = 0;
        public ctrlScheduleTest()
        {
            InitializeComponent();
            
        }
        public void LoadData(int DLID, int TestType)
        {
            _TestTypeID = TestType;
            lbDLID.Text = DLID.ToString();
            BLLLocalDirivingLincenseApplication LocalApp = BLLLocalDirivingLincenseApplication.FindByLocalDrivingLicenseApplications(DLID);
            ApplicationID = LocalApp.ApplicationID;
            ClassNameID = LocalApp.classID;
            string CLassName = BLLLicenseClasses.GetNameClassByID(ClassNameID);
            lbClassName.Text = CLassName;
            BLLApplications Application = BLLApplications.FindApplication(ApplicationID);
            BLLPeople Person = BLLPeople.Find(Application.ApplicantPersonID);
            lbName.Text = Person.FirstName + " " + Person.SecName + " " + Person.thirdName + " " + Person.LastName;
            dateTimePicker1.Value = DateTime.Now;
            lbFees.Text = BLLTestType.GetFeesByTestTypeID(_TestTypeID).ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ctrlScheduleTest_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }
        private void lbTitle2_Click(object sender, EventArgs e)
        {
            
        }
        public string LabelText
        {
            get { return lbTitle.Text; }
            set { lbTitle.Text = value; }
        }
        public string LabelText2
        {
            get { return lbTitle.Text; }
            set { lbTitle2.Text = value; }
        }
        public string GroupBoxText
        {
            get { return groupBox1.Text; }
            set { groupBox1.Text = value; }
        }
        public Image Picture
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
        public string labelTrial
        {
           get { return lbTrial.Text; }
           set { lbTrial.Text = value; }
        }
        public DateTime DataTimePicker
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }
        public decimal FeesTest
        {
            get { return BLLTestType.GetFeesByTestTypeID(_TestTypeID); }
        }
    }
}
