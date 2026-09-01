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
    public partial class frmSechduleWrittrnTest : Form
    {
        int LocalDrivingLicenseApplicationID = -1;
        string ClassName = "";
        byte PassRes = 0;
        BLLTestAppointment App;
        BLLTests test;
        public frmSechduleWrittrnTest(int dLID, string className)
        {
            InitializeComponent();
            LocalDrivingLicenseApplicationID = dLID;
            ClassName = className;
        }
        private void _Ref()
        {
            DataTable dt = BLLTestAppointment.GetAllAppintment(LocalDrivingLicenseApplicationID);
            dgvAppointment.DataSource = dt;
            lbCount.Text = dt.Rows.Count.ToString();
            dgvAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void dgvAppointment_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvAppointment.ClearSelection();
                dgvAppointment.Rows[e.RowIndex].Selected = true;

                // تعيين الخلية الحالية لضمان تحديث CurrentRow فوراً
                dgvAppointment.CurrentCell = dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex >= 0 ? e.ColumnIndex : 0];
            }
        }

        private void dgvAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (BLLTestAppointment.TestAppointmentUnLoached(LocalDrivingLicenseApplicationID))
            {
                MessageBox.Show("Person Already have an active appintment for this test", "Not Can", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (BLLTestAppointment.IsTestPassed(
           LocalDrivingLicenseApplicationID, 2))
            {
                MessageBox.Show(
                    "Person Already Passed this Test",
                    "Not Can",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            frmVisionTest frm = new frmVisionTest(-1, LocalDrivingLicenseApplicationID, 2);
            // 1 => Vision Test
            // 2 => Written Test
            // 3 => Street Test
            frm.ShowDialog();
            _Ref();
        }

        private void TakeTest_Click(object sender, EventArgs e)
        {
            if (dgvAppointment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row.");
                return;
            }

            if (dgvAppointment.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select one row only.");
                return;
            }
            frmTakeTest frm = new frmTakeTest(Convert.ToInt32(dgvAppointment.CurrentRow.Cells[0].Value), LocalDrivingLicenseApplicationID, 2);
            frm.ShowDialog();
            _Ref();
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            if (dgvAppointment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row.");
                return;
            }

            if (dgvAppointment.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select one row only.");
                return;
            }
            frmVisionTest frm = new frmVisionTest(Convert.ToInt32(dgvAppointment.CurrentRow.Cells[0].Value), LocalDrivingLicenseApplicationID, 2);
            frm.GroubBoxEnabled = false;
            frm.ShowDialog();
            _Ref();
        }

        private void ctrlAddAppointments1_Load(object sender, EventArgs e)
        {
            _Ref();
        }

        private void frmSechduleWrittrnTest_Load(object sender, EventArgs e)
        {
            ctrlAddAppointments1.LoadDataGroubBox1ANDGB2(LocalDrivingLicenseApplicationID, ClassName, PassRes);
            ctrlAddAppointments1.lbPassedTest = "1/3";
            this.AutoScroll = true;
            _Ref();
        }
    }
}
