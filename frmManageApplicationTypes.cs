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
    public partial class frmManageApplicationTypes : Form
    {
        private void _Ref()
        {
            DataTable dataTable = new DataTable();
            dataTable = BLLApplicationTypes.GetApplicationTypes();
            dgvApplications.DataSource = dataTable;
        }
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void ManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _Ref();
            lbCount.Text = dgvApplications.RowCount.ToString();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplicationType frm = new frmEditApplicationType(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value), dgvApplications.CurrentRow.Cells[1].Value.ToString(), Convert.ToDecimal(dgvApplications.CurrentRow.Cells[2].Value));
            frm.ShowDialog();
            _Ref();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
