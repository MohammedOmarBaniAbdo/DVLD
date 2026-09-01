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
    public partial class frmShowInternationalLicense : Form
    {
        int _LicID;
        public frmShowInternationalLicense(int LicID)
        {
            InitializeComponent();
            _LicID = LicID;
        }

        private void frmShowInternationalLicense_Load(object sender, EventArgs e)
        {
            ctrlShowIntenationalLicense1.LoadDataInterNationalLicense(_LicID);
        }

        private void ctrlShowIntenationalLicense1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlShowIntenationalLicense2_Load(object sender, EventArgs e)
        {

        }
    }
}
