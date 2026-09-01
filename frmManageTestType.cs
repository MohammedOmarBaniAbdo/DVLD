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
    public partial class frmManageTestType : Form
    {
        DataTable dt;
        private void _Refresh()
        {
            dt = BLLTestType.GetTestType();
            dgvTest.DataSource = dt;
            lbCount.Text = dt.Rows.Count.ToString();
        }
        public frmManageTestType()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestType frm = new frmEditTestType(Convert.ToInt32(dgvTest.CurrentRow.Cells[0].Value), dgvTest.CurrentRow.Cells[1].Value.ToString(), 
                dgvTest.CurrentRow.Cells[2].Value.ToString(), Convert.ToDecimal(dgvTest.CurrentRow.Cells[3].Value));
            frm.ShowDialog();
            _Refresh();
        }

        private void dgvTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmManageTestType_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void dgvTest_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvTest.ClearSelection();
                dgvTest.Rows[e.RowIndex].Selected = true;

                // تعيين الخلية الحالية لضمان تحديث CurrentRow فوراً
                dgvTest.CurrentCell = dgvTest.Rows[e.RowIndex].Cells[e.ColumnIndex >= 0 ? e.ColumnIndex : 0];
            }
        }
    }
}
