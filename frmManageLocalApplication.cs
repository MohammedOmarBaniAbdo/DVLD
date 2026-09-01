using BLLPeopleDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD1
{
    public partial class frmManageLocalApplication : Form
    {
        DataTable dt;
        BLLApplications App;
        BLLLocalDirivingLincenseApplication LocalApp;
        BLLLinceses Lic;
        BLLDrivers driver;
        private void _Ref()
        {
            dt = BLLApplications.GetAllApplication();
            dgvApplications.DataSource = dt;
            lbCount.Text = dt.Rows.Count.ToString();

           dgvApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            _DisEnablidContext();
        }
        private void _DisEnablidContext()
        {
            SechduleTests.Enabled = false;
            Vision.Enabled = false;
            Written.Enabled = false;
            Street.Enabled = false;
            ShowLicnese.Enabled = false;
            IssusDrivingLincToolStripMenuItem.Enabled = false;
        }
        public frmManageLocalApplication()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication(-1);
            frm.ShowDialog();
            _Ref();
        }

        private void frmManageLocalApplication_Load(object sender, EventArgs e)
        {
            _Ref();
            txtFilter.Visible = false;
            cmbFilter.SelectedIndex = 0;
            cmbStatus.Visible = false;
            cmbStatus.SelectedIndex = 0;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedIndex == 0)
            {
                txtFilter.Visible = false;
                return;
            }
            if (cmbFilter.SelectedIndex == 4)
            {
                cmbStatus.Visible = true;
                txtFilter.Visible = false;
                cmbStatus.SelectedIndex = 0;
                return;
            }
            else
            {
                txtFilter.Visible = true;
                txtFilter.Clear();
                cmbStatus.Visible = false;
                return;
            }
        }



        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = cmbFilter.Text;
            string filterValue = txtFilter.Text.Trim();

            if (string.IsNullOrEmpty(filterValue))
            {
                dt.DefaultView.RowFilter = "";
                return;
            }
            switch (filterColumn)
            {
                case "Application ID":
                    if (int.TryParse(filterValue, out int ApplicationID))
                        dt.DefaultView.RowFilter = $"LocalDrivingLicenseApplicationID = {ApplicationID}";
                    break;

                case "National No":
                    dt.DefaultView.RowFilter = $"NationalNo LIKE '{filterValue}%'";
                    break;

                case "Full Name":
                    dt.DefaultView.RowFilter = $"[Full Name] LIKE '%{filterValue}%'";
                    break;

                case "Status":

                    if (cmbStatus.SelectedIndex == 0)
                        dt.DefaultView.RowFilter = "";

                    else if (cmbStatus.SelectedIndex == 1)
                        dt.DefaultView.RowFilter = "Status = 'New'";

                    else if (cmbStatus.SelectedIndex == 2)
                        dt.DefaultView.RowFilter = "Status = 'Completed'";

                    else if (cmbStatus.SelectedIndex == 3)
                        dt.DefaultView.RowFilter = "Status = 'Canceled'";
                    break;

                default:
                    dt.DefaultView.RowFilter = "";
                    break;
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedIndex == 0)
            {
                dt.DefaultView.RowFilter = "";
            }
            else if (cmbStatus.SelectedIndex == 1)
            {
                dt.DefaultView.RowFilter = "Status = 'New'";
            }
            else if (cmbStatus.SelectedIndex == 2)
            {
                dt.DefaultView.RowFilter = "Status = 'Completed'";
            }
            else if (cmbStatus.SelectedIndex == 3)
            {
                dt.DefaultView.RowFilter = "Status = 'Canceled'";
            }
        }

        private void showApplicationDetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalApp = BLLLocalDirivingLincenseApplication.FindByLocalDrivingLicenseApplications(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value));
            if (LocalApp == null)
            {
                MessageBox.Show("Not Exist Record ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (MessageBox.Show("Are you sure cancel applecation? ", "",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (BLLApplications.CancelApplecation(LocalApp.ApplicationID))
                {
                    MessageBox.Show("Cancel is Done ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Ref();
                    return;
                }
                else
                {
                    MessageBox.Show("Not Can Cancel ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void dgvApplications_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvApplications.ClearSelection();
                dgvApplications.Rows[e.RowIndex].Selected = true;

                // تعيين الخلية الحالية لضمان تحديث CurrentRow فوراً
                dgvApplications.CurrentCell = dgvApplications.Rows[e.RowIndex].Cells[e.ColumnIndex >= 0 ? e.ColumnIndex : 0];
            }
        }

        private void shToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ApplicationStatus = 1 New
            //ApplicationStatus = 2 Cancel
            //ApplicationStatus = 3 Complete
            LocalApp = BLLLocalDirivingLincenseApplication.FindByLocalDrivingLicenseApplications(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value));
            App = BLLApplications.FindApplication(LocalApp.ApplicationID);
            if (App.ApplicationStatus == 2)
            {
                MessageBox.Show("the Application is Cancel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
    
            frmSechduleVisionTest frm = new frmSechduleVisionTest(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value), (dgvApplications.CurrentRow.Cells[1].Value).ToString());
            frm.ShowDialog();
            _Ref();
        }

        private void sechToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            _DisEnablidContext();

            if (dgvApplications.CurrentRow == null)
                return;

            byte Passed = Convert.ToByte(
                dgvApplications.CurrentRow.Cells[5].Value);

            
            switch (Passed)
            {
                case 0:
                    showApplicationDetToolStripMenuItem.Enabled = true;
                    editApplicationToolStripMenuItem.Enabled = true;
                    deleteApplicationToolStripMenuItem.Enabled = true;
                    cancelApplicationToolStripMenuItem.Enabled = true;
                    SechduleTests.Enabled = true;
                    Vision.Enabled = true;
                    break;

                case 1:
                    showApplicationDetToolStripMenuItem.Enabled = true;
                    editApplicationToolStripMenuItem.Enabled = true;
                    deleteApplicationToolStripMenuItem.Enabled = true;
                    cancelApplicationToolStripMenuItem.Enabled = true;
                    SechduleTests.Enabled = true;
                    Written.Enabled = true;
                    break;

                case 2:
                    showApplicationDetToolStripMenuItem.Enabled = true;
                    editApplicationToolStripMenuItem.Enabled = true;
                    deleteApplicationToolStripMenuItem.Enabled = true;
                    cancelApplicationToolStripMenuItem.Enabled = true;
                    SechduleTests.Enabled = true;
                    Street.Enabled = true;
                    break;

                case 3:
                    IssusDrivingLincToolStripMenuItem.Enabled = true;
                    break;
            }
            byte Statut = 0;
            if (dgvApplications.CurrentRow.Cells[6].Value.ToString() == "Completed")
            {
                Statut = 3;
            }
            if (Statut == 3)
            {
                showApplicationDetToolStripMenuItem.Enabled = true;
                editApplicationToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;
                SechduleTests.Enabled = false;
                IssusDrivingLincToolStripMenuItem.Enabled = false;
                ShowLicnese.Enabled = true;
                showPersonToolStripMenuItem.Enabled = true;
            }
        }

        private void Written_Click(object sender, EventArgs e)
        {
            LocalApp = BLLLocalDirivingLincenseApplication.FindByLocalDrivingLicenseApplications(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value));
            App = BLLApplications.FindApplication(LocalApp.ApplicationID);
            if (App.ApplicationStatus == 2)
            {
                MessageBox.Show("the Application is Cancel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmSechduleWrittrnTest frm = new frmSechduleWrittrnTest(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value), (dgvApplications.CurrentRow.Cells[1].Value).ToString());
            frm.ShowDialog();
            _Ref();
        }
        private void Street_Click(object sender, EventArgs e)
        {
            LocalApp = BLLLocalDirivingLincenseApplication.FindByLocalDrivingLicenseApplications(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value));
            App = BLLApplications.FindApplication(LocalApp.ApplicationID);
            if (App.ApplicationStatus == 2)
            {
                MessageBox.Show("the Application is Cancel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmSechduleStreetTest frm = new frmSechduleStreetTest(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value), (dgvApplications.CurrentRow.Cells[1].Value).ToString());
            frm.ShowDialog();
            _Ref();
        }

        private void dgvApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IssusDrivingLincToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalApp = BLLLocalDirivingLincenseApplication.FindByLocalDrivingLicenseApplications(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value));
            App = BLLApplications.FindApplication(LocalApp.ApplicationID);
            if (App.ApplicationStatus == 2)
            {
                MessageBox.Show("the Application is Cancel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmIssueDrivingLinc frm = new frmIssueDrivingLinc(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value), (dgvApplications.CurrentRow.Cells[1].Value).ToString());
            frm.ShowDialog();
            _Ref();
        }

        private void ShowLicnese_Click(object sender, EventArgs e)
        {
            LocalApp = BLLLocalDirivingLincenseApplication.FindByLocalDrivingLicenseApplications(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value));
            Lic = BLLLinceses.FindByApplicationID(LocalApp.ApplicationID);
            frmShowLic frm = new frmShowLic(Lic.LincesesID);
            frm.ShowDialog();
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalApp = BLLLocalDirivingLincenseApplication.FindByLocalDrivingLicenseApplications(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value));
            App = BLLApplications.FindApplication(LocalApp.ApplicationID);
            driver = BLLDrivers.Find(App.ApplicantPersonID);
            if (driver == null)
            {
                MessageBox.Show("This a Person not have License", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmShowHistoryLic frm = new frmShowHistoryLic(App.ApplicantPersonID, driver.DriverID);
            frm.ShowDialog();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("are you sure delete application?", "",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BLLLocalDirivingLincenseApplication.DeleteLocalApplication(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Delete application is done", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Ref();
                }
            }
        }
    }
}
