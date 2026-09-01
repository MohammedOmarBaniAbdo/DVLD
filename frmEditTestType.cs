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

    public partial class frmEditTestType : Form
    {
        int _ID = 0;
        string _Title = string.Empty;
        string _Description = string.Empty;
        decimal _Fees = 0;
        public frmEditTestType(int TestID,string Title,string Des,decimal Fees)
        {
            _ID = TestID;
            _Title = Title;
            _Description = Des;
            _Fees = Fees;
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            lbID.Text = _ID.ToString();
            txtTitle.Text = _Title;
            txtDascribtion.Text = _Description;
            txtFees.Text = _Fees.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                errorProvider1.SetError(txtTitle, "Enter Title");
                txtTitle.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDascribtion.Text))
            {
                errorProvider1.SetError(txtDascribtion,"Enter Description");
                txtDascribtion.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtFees.Text))
            {
                errorProvider1.SetError(txtFees, "Enter Fees");
                txtFees.Focus();
                return;
            }
            errorProvider1.Clear();
            if (MessageBox.Show("Sure to this Edit?", "Q", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (decimal.TryParse(txtFees.Text, out decimal fees))
                {
                    if (BLLTestType.UpdateTestType(_ID, txtTitle.Text,txtDascribtion.Text, fees))
                    {
                        MessageBox.Show("Edit is Done", "Done",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Not Can Edit", "Not Done",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    errorProvider1.SetError(txtFees, "Enter a valid number");
                    txtFees.Focus();
                }
            }
        }
    }
}
