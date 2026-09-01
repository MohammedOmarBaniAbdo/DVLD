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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD1
{
    public partial class frmShowAllApplicationInternationalLicense : Form
    {
        DataTable dt;
        BLLDrivers Driver;
        private void _Ref()
        {
            dt = BLLInternationalLicenses.GetAllApplcationInternational();
            dgvApplications.DataSource = dt;
            lbCount.Text = (dt.Rows.Count).ToString();
        }
        public frmShowAllApplicationInternationalLicense()
        {
            InitializeComponent();
        }

        private void frmShowAllApplicationInternationalLicense_Load(object sender, EventArgs e)
        {
            _Ref();
            txtFilter.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicenseAndFilterAndShowInternationalLic frm = new frmAddInternationalLicenseAndFilterAndShowInternationalLic();
            frm.ShowDialog();
            _Ref();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Driver = BLLDrivers.FindByDriverID(Convert.ToInt32(dgvApplications.CurrentRow.Cells[2].Value));
            if (Driver == null)
            {
                MessageBox.Show("Not Found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmShowHistoryLic frm = new frmShowHistoryLic(Driver.PersonID, Driver.DriverID);
            frm.ShowDialog();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Driver = BLLDrivers.FindByDriverID(Convert.ToInt32(dgvApplications.CurrentRow.Cells[2].Value));
            if (Driver == null)
            {
                MessageBox.Show("Not Found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmShowPerson frm = new frmShowPerson(Driver.PersonID);
            frm.ShowDialog();
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

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedIndex == 0)
            {
                txtFilter.Visible = false;
                return;
            }
            else
            {
                txtFilter.Visible = true;
                txtFilter.Clear();
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
                case "ApplicationID":
                    if (int.TryParse(filterValue, out int ApplicationID))
                        dt.DefaultView.RowFilter = $"ApplicationID = {ApplicationID}";
                    break;
                case "InternationalLicenseID":
                    if (int.TryParse(filterValue, out int InternationalLicenseID))
                        dt.DefaultView.RowFilter = $"int_LicenseID = {InternationalLicenseID}";
                    break;
                case "DriverID":
                    if (int.TryParse(filterValue, out int DriverID))
                        dt.DefaultView.RowFilter = $"DriverID = {DriverID}";
                    break;
                case "LocalLicenseID":
                    if (int.TryParse(filterValue, out int LocalLicenseID))
                        dt.DefaultView.RowFilter = $"L_LicenseID = {LocalLicenseID}";
                    break;
                default:
                    dt.DefaultView.RowFilter = "";
                    break;
            }
        }
    }
}
