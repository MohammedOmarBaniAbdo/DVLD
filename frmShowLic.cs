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
    public partial class frmShowLic : Form
    {
        int _LicID;
        public frmShowLic(int licID)
        {
            InitializeComponent();
            _LicID = licID;
        }

        private void frmShowLic_Load(object sender, EventArgs e)
        {
            ctrlShowLicense1.LoadDataLocalLicense(_LicID);
        }

        private void ctrlShowLicense1_Load(object sender, EventArgs e)
        {

        }
    }
}
