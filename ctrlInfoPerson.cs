using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLPeopleDVLD;
namespace DVLD1
{
    public partial class ctrlInfoPerson : UserControl
    {
        private int _PersonID = -1;
        BLLPeople FindPerson;
        public ctrlInfoPerson()
        {
            InitializeComponent();
        }
        public void LoadDataPerson(int PersonID)
        {
            _PersonID = PersonID;
            FindPerson = BLLPeople.Find(_PersonID);
            if (FindPerson == null)
            {
                MessageBox.Show("Person not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                lbID.Text = FindPerson.ID.ToString();
                lbName.Text = FindPerson.FirstName + " " + FindPerson.SecName + " " + FindPerson.thirdName + " " + FindPerson.LastName;
                lbNationalNo.Text = FindPerson.nationalNo;
                lbDate.Text = FindPerson.DateOfBirth.ToString("dd/MM/yyyy");
                lbEmail.Text = FindPerson.Email;
                lbPhone.Text = FindPerson.Phone;
                lbAddress.Text = FindPerson.Address;
                lbCountry.Text = BLLCountry.GetCountryNameByID(FindPerson.NationalityCountryID);
                if (FindPerson.Gendor == 0)
                {
                    lbGeneder.Text = "Male";
                }
                else
                {
                    lbGeneder.Text = "Female";
                }
                if (string.IsNullOrEmpty(FindPerson.ImagePath))
                {
                    pictureBox1.Image =
                        FindPerson.Gendor == 0
                        ? Properties.Resources.User_Male
                        : Properties.Resources.User_Female;
                }
                else
                {
                    pictureBox1.ImageLocation = FindPerson.ImagePath;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ctrlInfoPerson_Load(object sender, EventArgs e)
        {

        }

        private void lnEditInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_PersonID == -1)
            {
                MessageBox.Show("No person selected to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbID.Text = "";
                lbName.Text = "";
                lbNationalNo.Text = "";
                lbDate.Text = "";
                lbEmail.Text = "";
                lbPhone.Text = "";
                lbAddress.Text = "";
                lbCountry.Text = "";
                pictureBox1.ImageLocation = Properties.Resources.User_Male.ToString();
                lbGeneder.Text = "";
                return;
            }
            else if (FindPerson == null)
            {
                MessageBox.Show("Person not found to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                frmAddPerson frmAddPerson = new frmAddPerson(_PersonID);
                frmAddPerson.ShowDialog();
                FindPerson = BLLPeople.Find(_PersonID);
                lbID.Text = FindPerson.ID.ToString();
                lbName.Text = FindPerson.FirstName + " " + FindPerson.SecName + " " + FindPerson.thirdName + " " + FindPerson.LastName;
                lbNationalNo.Text = FindPerson.nationalNo;
                lbDate.Text = FindPerson.DateOfBirth.ToString("dd/MM/yyyy");
                lbEmail.Text = FindPerson.Email;
                lbPhone.Text = FindPerson.Phone;
                lbAddress.Text = FindPerson.Address;
                lbCountry.Text = BLLCountry.GetCountryNameByID(FindPerson.NationalityCountryID);
                if (FindPerson.Gendor == 0)
                {
                    lbGeneder.Text = "Male";
                }
                else
                {
                    lbGeneder.Text = "Female";
                }
                if (string.IsNullOrEmpty(FindPerson.ImagePath))
                {
                    pictureBox1.Image =
                        FindPerson.Gendor == 0
                        ? Properties.Resources.User_Male
                        : Properties.Resources.User_Female;
                }
                else
                {
                    pictureBox1.ImageLocation = FindPerson.ImagePath;
                }
            }
        }

    }
}