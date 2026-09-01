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
    public partial class frmAddPerson : Form
    {
        enum enMode
        {
            AddNew = 1,
            Update = 2
        }
        enMode Mode;
        int _PersonID;

        BLLPeople Person = new BLLPeople();


        //Delegation-->>>
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;
        //_______________
        private void LoadEditPerson()
        {
            Person = BLLPeople.Find(_PersonID);
            if (Person == null)
            {
                MessageBox.Show("Person not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                lbID.Text = Person.ID.ToString();
                txtNationalNo.Text = Person.nationalNo;
                txtFname.Text = Person.FirstName;
                txtSname.Text = Person.SecName;
                txtTname.Text = Person.thirdName;
                txtLname.Text = Person.LastName;
                dateTimePicker1.Value = Person.DateOfBirth;
                txtEmail.Text = Person.Email;
                txtPhone.Text = Person.Phone;
                txtAddress.Text = Person.Address;
                rdMale.Checked = Person.Gendor == 0;
                rdFemale.Checked = Person.Gendor == 1;
                cmboxCountry.SelectedValue = Person.NationalityCountryID;
                if (string.IsNullOrEmpty(Person.ImagePath))
                {
                    pictureBox1.Image =
                        Person.Gendor == 0
                        ? Properties.Resources.User_Male
                        : Properties.Resources.User_Female;
                }
                else
                {
                    pictureBox1.ImageLocation = Person.ImagePath;
                    btRemove.Visible = true;
                }
            }
        }
        private void SavaAddDataPerson()
        {
            Person.FirstName = txtFname.Text;
            Person.SecName = txtSname.Text;
            if (!string.IsNullOrEmpty(txtTname.Text))
            {
                Person.thirdName = txtTname.Text;
            }
            else
            {
                Person.thirdName = string.Empty;
            }
            Person.LastName = txtLname.Text;
            Person.nationalNo = txtNationalNo.Text;
            Person.DateOfBirth = dateTimePicker1.Value;
            Person.Gendor = rdMale.Checked ? (byte)0 : (byte)1;
            Person.Address = txtAddress.Text;
            Person.Phone = txtPhone.Text;
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                Person.Email = txtEmail.Text;
            }
            else
            {
                Person.Email = string.Empty;
            }
            Person.NationalityCountryID = (int)cmboxCountry.SelectedValue;
            if (pictureBox1.ImageLocation != null)
            {
                Person.ImagePath = pictureBox1.ImageLocation;
            }
            else
            {
                Person.ImagePath = string.Empty;
            }
        }
        public frmAddPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            if (_PersonID == -1)
            {
                Mode = enMode.AddNew;
                lbTitle.Text = "Add New Person";
            }
            else
            {
                Mode = enMode.Update;
                lbTitle.Text = "Edit Person";
            }
        }

        private void frmAddPerson_Load(object sender, EventArgs e)
        {
            cmboxCountry.DataSource =
                BLLPeople.GetAllCountry();

            cmboxCountry.DisplayMember =
                "CountryName";

            cmboxCountry.ValueMember =
                "CountryID";

            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);

            btRemove.Visible = false;

            if (Mode == enMode.AddNew)
            {
                cmboxCountry.SelectedIndex = 89;

                //dateTimePicker1.Value = DateTime.Now.AddYears(-18);

                rdMale.Checked = true;

                pictureBox1.Image = Properties.Resources.User_Male;
            }
            else
            {
                LoadEditPerson();
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFname.Text))
            {
                errorProvider1.SetError(txtFname,"Enter First Name");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFname,"");
            }
            if (string.IsNullOrEmpty(txtSname.Text))
            {

                errorProvider1.SetError(txtSname, "Enter Sucend Name");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSname, "");
            }
            if (string.IsNullOrEmpty(txtLname.Text))
            {

                errorProvider1.SetError(txtLname, "Enter Last Name");
                return;
            }
            else
            {
                errorProvider1.SetError(txtLname, "");
            }
            if (string.IsNullOrEmpty(txtNationalNo.Text))
            {

                errorProvider1.SetError(txtNationalNo, "Enter National No");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, "");
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {

                errorProvider1.SetError(txtPhone, "Enter Phone");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPhone, "");
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {

                errorProvider1.SetError(txtAddress, "Enter Address");
                return;
            }
            else
            {
                errorProvider1.SetError(txtAddress, "");
            }


            if (Mode == enMode.AddNew)
            {
                SavaAddDataPerson();
                if (BLLPeople.IsExistNationalNo(Person.nationalNo))
                {
                    errorProvider1.SetError(txtNationalNo, "National No already exists");
                    //MessageBox.Show("National No already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtNationalNo, string.Empty);
                }
                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                    {
                        errorProvider1.SetError(txtEmail, "Please enter a valid email address");
                        //MessageBox.Show("Please enter a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtEmail, string.Empty);
                    }
                }
                if (Person.Save())
                {
                    MessageBox.Show("Person added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbID.Text = Person.ID.ToString();
                    Mode = enMode.Update;
                    lbTitle.Text = "Edit Person";
                }
                else
                {
                    MessageBox.Show("Error adding person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return;
            }
            else if (Mode == enMode.Update)
            {

                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                    {
                        MessageBox.Show("Please enter a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                SavaAddDataPerson();
                if (Person.Save())
                {
                    MessageBox.Show("Person updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Error updating person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            if(pictureBox1.ImageLocation == null)
            {
                pictureBox1.Image = Properties.Resources.User_Male;
            }
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation == null)
            {
                pictureBox1.Image = Properties.Resources.User_Female;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void llbImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                btRemove.Visible = true;
            }
        }

        private void btRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove the image?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pictureBox1.ImageLocation = null;
                btRemove.Visible = false;
                if (rdMale.Checked)
                    pictureBox1.Image = Properties.Resources.User_Male;
                else
                    pictureBox1.Image = Properties.Resources.User_Female;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (lbID.Text != "N/A")
            {
                int PersonID = int.Parse(lbID.Text);
                DataBack?.Invoke(this, PersonID);
            }
            this.Close();
        }

        private void cmboxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
