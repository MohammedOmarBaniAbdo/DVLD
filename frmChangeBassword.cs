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
    public partial class frmChangeBassword : Form
    {
        int _UserID, _PersonID;
        public frmChangeBassword(int UserID,int PersonID)
        {
            _UserID = UserID;
            _PersonID = PersonID;
            InitializeComponent();
        }

        private void frmChangeBassword_Load(object sender, EventArgs e)
        {
            ctrlInfoPerson1.LoadDataPerson(_PersonID);
            ctrlLoginInfo1.LoadDataLoginInfo(_PersonID);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!BLLUser.isCorrectCurrentPassword(_UserID, txtCurrent.Text))
            {
                errorProvider1.SetError(txtCurrent, "This password is incorrect.");
                txtCurrent.Focus();
                return;
            }

            if (txtNew.Text != txtConfirm.Text)
            {
                errorProvider1.SetError(txtConfirm, "Does not match the new password.");
                txtConfirm.Focus();
                return;
            }

            if (BLLUser.UpdatePassword(_UserID, txtConfirm.Text))
            {
                MessageBox.Show(
                    "Password updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Failed to update password.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ctrlLoginInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
