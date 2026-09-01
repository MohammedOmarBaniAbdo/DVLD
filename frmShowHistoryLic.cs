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
    public partial class frmShowHistoryLic : Form
    {
        int _PersonID;
        int _DriverID;
        DataTable dt;
        DataTable dt2;
        public frmShowHistoryLic(int PersonID, int driverID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _DriverID = driverID;
        }
        void _Ref()
        {
            dt = new DataTable();
            dt = BLLLinceses.HistoryLinceses(_DriverID);
            dataGridView1.DataSource = dt;
            lbCount1.Text = dt.Rows.Count.ToString();
            //_________________________________________________________________________
            dt2 = new DataTable();
            dt2 = BLLInternationalLicenses.HistoryLinceses(_DriverID);
            dataGridView2.DataSource = dt2;
            lbCount2.Text = dt2.Rows.Count.ToString();
        }
        private void frmShowHistoryLic_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            ctrlInfoPerson1.LoadDataPerson(_PersonID);
            _Ref();
        }

        private void ctrlFilterAndPersinInfo1_Load(object sender, EventArgs e)
        {

        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLic frm = new frmShowLic(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void ctrlInfoPerson1_Load(object sender, EventArgs e)
        {

        }
    }
}
