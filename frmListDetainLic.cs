using BLLPeopleDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD1
{
    public partial class frmListDetainLic : Form
    {
        DataTable dt;
        BLLLinceses Lic;
        BLLDrivers Driver;
        void _Ref()
        {
            dt = new DataTable();
            dt = BLLDetain.GetAllDetains();
            dataGridView1.DataSource = dt;
            lbCount1.Text = dt.Rows.Count.ToString();
            cmbFilter.SelectedIndex = 0;
            cmbRe.SelectedIndex = 0;
        }
        public frmListDetainLic()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
            _Ref();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
            _Ref();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;

                // تعيين الخلية الحالية لضمان تحديث CurrentRow فوراً
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex >= 0 ? e.ColumnIndex : 0];
            }
        }

        private void frmListDetainLic_Load(object sender, EventArgs e)
        {
            _Ref();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.Text == "None")
            {
                cmbRe.Visible = false;
                txtFilter.Visible = false;
                txtFilter.Text = "";
            }
            else if(cmbFilter.Text == "Is Released")
            {
                txtFilter.Visible = false;
                cmbRe.Visible = true;
            }
            else
            {
                txtFilter.Visible = true;
                cmbRe.Visible = false;
                txtFilter.Text = "";
                txtFilter.Focus();
            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            //            None
            //Detain ID
            //Is Released
            //National No.
            //Full Name
            //Release Application ID
            string filterColumn = cmbFilter.Text;
            string filterValue = txtFilter.Text.Trim();

            if (string.IsNullOrEmpty(filterValue))
            {
                dt.DefaultView.RowFilter = "";
                return;
            }

            switch (filterColumn)
            {
                case "Detain ID":

                    if (int.TryParse(filterValue, out int DetainID))
                    {
                        dt.DefaultView.RowFilter =
                            $"DetainID = {DetainID}";
                    }
                    else
                    {
                        dt.DefaultView.RowFilter = "";
                    }

                    break;


                case "License ID":

                    if (int.TryParse(filterValue, out int LicenseID))
                    {
                        dt.DefaultView.RowFilter =
                            $"LicenseID = {LicenseID}";
                    }
                    else
                    {
                        dt.DefaultView.RowFilter = "";
                    }

                    break;


                case "National No.":

                    dt.DefaultView.RowFilter =
                        $"NationalNo LIKE '{filterValue.Replace("'", "''")}%'";

                    break;


                case "Full Name":

                    dt.DefaultView.RowFilter =
                        $"FullName LIKE '{filterValue.Replace("'", "''")}%'";

                    break;


                case "Release Application ID":

                    if (int.TryParse(filterValue, out int ReleaseApplicationID))
                    {
                        dt.DefaultView.RowFilter =
                            $"ReleaseApplicationID = {ReleaseApplicationID}";
                    }
                    else
                    {
                        dt.DefaultView.RowFilter = "";
                    }

                    break;


                default:

                    dt.DefaultView.RowFilter = "";

                    break;
            }
        }

        private void cmbRe_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbRe.Text)
            {
                case "All":
                    dt.DefaultView.RowFilter = "";
                    break;

                case "Yes":
                    dt.DefaultView.RowFilter = "IsReleased = true";
                    break;

                case "No":
                    dt.DefaultView.RowFilter = "IsReleased = false";
                    break;
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLic frm = new frmShowLic(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value));
            frm.ShowDialog();
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lic = BLLLinceses.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value));
            Driver = BLLDrivers.FindByDriverID(Lic.DriverID);
            frmShowPerson frm = new frmShowPerson(Driver.PersonID);
            frm.ShowDialog();
        }
        private void showPersonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Lic = BLLLinceses.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value));
            Driver = BLLDrivers.FindByDriverID(Lic.DriverID);
            frmShowHistoryLic frm = new frmShowHistoryLic(Driver.PersonID,Driver.DriverID);
            frm.ShowDialog();
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value));
            frm.txtLicenseIDEnableInCtrlFilterAndInfo = false;
            frm.txtLicenseIDTextInCtrlFilterAndInfo = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.ShowDialog();
        }
    }
}