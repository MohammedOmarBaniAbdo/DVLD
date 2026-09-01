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
    public partial class frmAddUser : Form
    {
        private DataTable dt;
        private int _UserID;
        private int _PersonID;
        BLLUser User;
        enum enMode
        {
            AddNew = 1,
            Update = 2,
        }
        enMode _Mode;
        private void NotEnabled()
        {

            txtFilter.Enabled = false;
            cmbFilter.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            btNext.Enabled = false;

        }
        public frmAddUser(int UserID,int PersonID)
        {
            _UserID = UserID;
            _PersonID = PersonID;
            InitializeComponent();
        }

        private void ctrlInfoPerson1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlInfoPerson1_Load_1(object sender, EventArgs e)
        {

        }

        private void tabPersonInfo_Click(object sender, EventArgs e)
        {

        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            dt = BLLPeople.GetAllPeople();
            txtFilter.Visible = false;
            cmbFilter.SelectedIndex = 0;
            if (_UserID == -1)
            {
                User = new BLLUser();
                _Mode = enMode.AddNew;
            }
            else
            {
                NotEnabled();
                ctrlInfoPerson1.LoadDataPerson(_PersonID);
                _Mode = enMode.Update;
                lbTitle.Text = "      Edit User";
                //______________________________________
                User = BLLUser.FindUserByPersonID(_PersonID);
                lbID.Text = User.UserID.ToString();
                txtUserName.Text = User.UserName.ToString();
                txtPassword.Text = User.Password.ToString();
                txtConfirmPassword.Text = User.Password.ToString();
                if (User.IsActive == true)
                {
                    chIsActive.Checked = true;
                }
                else
                {
                    chIsActive.Checked = false;
                }
            }
            if (_Mode == enMode.Update)
            {
                cmbFilter.SelectedIndex = 1;
                txtFilter.Text = User.PersonID.ToString();

            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.Text == "None")
            {
                txtFilter.Visible = false;
                dt.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                txtFilter.Visible = true;
                txtFilter.Focus();
                txtFilter.Text = string.Empty;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = cmbFilter.Text;
            string filterValue = txtFilter.Text;
            switch (filterColumn) {
                case "Person ID":
                    if (int.TryParse(filterValue, out int personID))
                    {
                        dt.DefaultView.RowFilter = $"PersonID = {personID}";
                        _PersonID = personID;
                    }
                    else
                    {
                        dt.DefaultView.RowFilter = "PersonID = -1";
                        _PersonID = -1;
                    }
                    break;

                case "National No":
                    dt.DefaultView.RowFilter = $"NationalNo LIKE '{filterValue}%'";
                     _PersonID = dt.DefaultView.Count > 0 ? Convert.ToInt32(dt.DefaultView[0]["PersonID"]) : -1;
                    break;

                case "First Name":
                    dt.DefaultView.RowFilter = $"FirstName LIKE '{filterValue}%'";
                    _PersonID = dt.DefaultView.Count > 0 ? Convert.ToInt32(dt.DefaultView[0]["PersonID"]) : -1;
                    break;

                case "Second Name":
                    dt.DefaultView.RowFilter = $"SecondName LIKE '{filterValue}%'";
                    _PersonID = dt.DefaultView.Count > 0 ? Convert.ToInt32(dt.DefaultView[0]["PersonID"]) : -1;
                    break;

                case "Third Name":
                    dt.DefaultView.RowFilter = $"ThirdName LIKE '{filterValue}%'";
                    _PersonID = dt.DefaultView.Count > 0 ? Convert.ToInt32(dt.DefaultView[0]["PersonID"]) : -1;
                    break;

                case "Last Name":
                    dt.DefaultView.RowFilter = $"LastName LIKE '{filterValue}%'";
                    _PersonID = dt.DefaultView.Count > 0 ? Convert.ToInt32(dt.DefaultView[0]["PersonID"]) : -1;
                    break;

                case "Phone":
                    dt.DefaultView.RowFilter = $"Phone LIKE '{filterValue}%'";
                    _PersonID = dt.DefaultView.Count > 0 ? Convert.ToInt32(dt.DefaultView[0]["PersonID"]) : -1;
                    break;

                case "Email":
                    dt.DefaultView.RowFilter = $"Email LIKE '{filterValue}%'";
                    _PersonID = dt.DefaultView.Count > 0 ? Convert.ToInt32(dt.DefaultView[0]["PersonID"]) : -1;
                    break;

                case "Nationality":
                    dt.DefaultView.RowFilter = $"CountryName LIKE '{filterValue}%'";
                    _PersonID = dt.DefaultView.Count > 0 ? Convert.ToInt32(dt.DefaultView[0]["PersonID"]) : -1;
                    break;

                case "Gendor":
                    dt.DefaultView.RowFilter = $"GendorCaption LIKE '{filterValue}%'";
                    _PersonID = dt.DefaultView.Count > 0 ? Convert.ToInt32(dt.DefaultView[0]["PersonID"]) : -1;
                    break;

                default:
                    dt.DefaultView.RowFilter = "";
                    break;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                MessageBox.Show("Please enter a value to search.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFilter.Focus();
                return;
            }
            if (_PersonID == -1)
            {
                MessageBox.Show("Person not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ctrlInfoPerson1.LoadDataPerson(_PersonID);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (_PersonID == -1)
            {
                MessageBox.Show("Please select a person to proceed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            BLLPeople person = BLLPeople.Find(_PersonID);
            if (person == null)
            {
                MessageBox.Show(
                    "The selected person does not exist in the system.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }
            if (BLLUser.IsExistUserByPersonID(_PersonID))
            {
                MessageBox.Show("This person already has a user account.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
   
            tabControl1.SelectedTab = tabLoginInfo;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "User Name is required.");
                txtUserName.Focus();
                return;
            }
            if (BLLUser.isExistUserByUserName(txtUserName.Text,User.UserID))
            {
                errorProvider1.SetError(txtUserName, "User Name is Use by ather user.");
                txtUserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password is required.");
                txtPassword.Focus();
                return;

            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Passwords do not match.");
                txtConfirmPassword.Focus();
                return;
            }
            User.PersonID = _PersonID;
            User.UserName = txtUserName.Text;
            User.Password = txtPassword.Text;
            User.IsActive = chIsActive.Checked;
            errorProvider1.Clear();
            if (User.Save())
            {
                MessageBox.Show("User account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to create user account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAddPerson frm = new frmAddPerson(-1);
            frm.DataBack += frm2_DataBack;
            frm.ShowDialog();
        }
        private void frm2_DataBack(object sender,int PersonID)
        {
            ctrlInfoPerson1.LoadDataPerson(PersonID);
            cmbFilter.SelectedIndex = 1;
            txtFilter.Text = PersonID.ToString();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabLoginInfo && _PersonID == -1)
            {
                MessageBox.Show("Please select a person to proceed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
                return;
            }
            BLLPeople person = BLLPeople.Find(_PersonID);
            if (person == null)
            {
                MessageBox.Show(
                    "The selected person does not exist in the system.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }
            if (e.TabPage == tabLoginInfo && BLLUser.IsExistUserByPersonID(_PersonID))
            {
                MessageBox.Show("This person already has a user account.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
                return;
            }
            tabControl1.SelectedTab = tabLoginInfo;
        }
    }
}

