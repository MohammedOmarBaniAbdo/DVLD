using BLLPeopleDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace DVLD1
{
    public partial class frmShowPerson : Form
    {
        private int _PersonID;
       
        public frmShowPerson(int PersonID)
        {
            InitializeComponent();
            this._PersonID = PersonID;
        }

        private void frmShowPerson_Load(object sender, EventArgs e)
        {
            ctrlInfoPerson1.LoadDataPerson(_PersonID);
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
