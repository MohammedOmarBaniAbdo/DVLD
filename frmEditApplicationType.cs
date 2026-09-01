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
    public partial class frmEditApplicationType : Form
    {
        private int _ID;
        private string _Title;
        private decimal _Fees;
       
        public frmEditApplicationType(int ID,string Title,decimal Fees)
        {
            _ID = ID;
            _Title = Title;
            _Fees = Fees;
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                errorProvider1.SetError(txtTitle, "Enter Title");
                txtTitle.Focus();
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
                    if (BLLApplicationTypes.UpdateApplicationTypes(_ID, txtTitle.Text, fees))
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
        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            lbID.Text = _ID.ToString();
            txtFees.Text = _Fees.ToString();
            txtTitle.Text = _Title;
            txtTitle.Focus();

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtFees_TextChanged(object sender, EventArgs e)
        {
           
       
        }
    }
}
