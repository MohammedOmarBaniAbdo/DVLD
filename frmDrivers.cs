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
    public partial class frmDrivers : Form
    {
        DataTable dt;
        public frmDrivers()
        {
            InitializeComponent();
        }
        private void _Ref()
        {
            dt = BLLDrivers.GetAllDrivers();
            dgvApplications.DataSource = dt;
            lbCount.Text = dt.Rows.Count.ToString();
        }
        private void frmDrivers_Load(object sender, EventArgs e)
        {
            _Ref();
            txtFilter.Visible = false;
            cmbFilter.SelectedIndex = 0;
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
                case "DriverID":
                    if (int.TryParse(filterValue, out int DriverID))
                        dt.DefaultView.RowFilter = $"DriverID = {DriverID}";
                    break;
                case "PersonID":
                    if (int.TryParse(filterValue, out int PersonID))
                        dt.DefaultView.RowFilter = $"PersonID = {PersonID}";
                    break;

                case "NationalNo":
                    dt.DefaultView.RowFilter = $"[NationalNo] LIKE '{filterValue}%'";
                    break;

                case "FullName":
                    dt.DefaultView.RowFilter = $"[FullName] LIKE '%{filterValue}%'";
                    break;
                default:
                    dt.DefaultView.RowFilter = "";
                    break;
            }
        }
    }
}