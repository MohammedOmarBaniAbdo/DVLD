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
    public partial class ctrlLoginInfo : UserControl
    {
        public ctrlLoginInfo()
        {
            InitializeComponent();
        }
        public void LoadDataLoginInfo(int PersonID)
        {
            BLLUser User = BLLUser.FindUserByPersonID(PersonID);
            lbUserID.Text = User.UserID.ToString();
            lbUserName.Text = User.UserName;
            if (User.IsActive == true)
            {
                lbIsActive.Text = "Active";
            }
            else
            {
                lbIsActive.Text = "Not Active";
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
