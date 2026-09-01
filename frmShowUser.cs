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
    public partial class frmShowUser : Form
    {
        private int _PersonID;
        public frmShowUser(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }
        private void frmShowUser_Load(object sender, EventArgs e)
        {
            ctrlInfoPerson1.LoadDataPerson(_PersonID);
            ctrlLoginInfo1.LoadDataLoginInfo(_PersonID);
        }

        private void ctrlInfoPerson1_Load(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
