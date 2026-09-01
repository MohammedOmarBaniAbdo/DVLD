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
    public partial class ctrlFilterANDLicInfo : UserControl
    {
        int _LinID = -1;
        int _PersonID = -1;
        bool _IsFound = false;
        BLLLinceses Linceses;
        BLLDrivers Driver;
        BLLPeople Person;
        public event Action FoundLic;
        public ctrlFilterANDLicInfo()
        {
            InitializeComponent();

        }
        public int LicenseID
        {
            get { return _LinID; }
            set { _LinID = value; }
        }
        public bool IsFound
        {
            get { return _IsFound; }
            set { _IsFound = value; }
        }
        public void LoadData(int linID)
        {
            _LinID = linID;

            Linceses = BLLLinceses.Find(_LinID);

            if (Linceses == null)
                return;

            lbLinID.Text = _LinID.ToString();
            lbIssueDate.Text = Linceses.IssueDate.ToString();
            //____________IssueReason_________________________
            lbIssueRe.Text = Linceses.IssueReason.ToString();
            switch (Linceses.IssueReason)
            {
                case 1:
                    lbIssueRe.Text = "First Time";
                    break;
                case 2:
                    lbIssueRe.Text = "Renew";
                    break;
                case 3:
                    lbIssueRe.Text = "Replacement for Lost";
                    break;
                case 4:
                    lbIssueRe.Text = "Replacement for Damage";
                    break;
              
            }
            //________________________________________________
            lbNotes.Text = Linceses.Notes;

            lbDriverID.Text = Linceses.DriverID.ToString();
            lbExDate.Text = Linceses.ExpirationDate.ToString();

            if (BLLDetain.IsLicenseDetained(_LinID))
            {
                lbIsDet.Text = "yes";
            }
            else
            {
                lbIsDet.Text = "No";
            }

            Driver = BLLDrivers.FindByDriverID(Linceses.DriverID);

            if (Driver == null)
                return;

            _PersonID = Driver.PersonID;

            Person = BLLPeople.Find(_PersonID);

            if (Person == null)
                return;

            lbName.Text = Person.FirstName + " " +
                          Person.SecName + " " +
                          Person.thirdName + " " +
                          Person.LastName;

            lbNationalNo.Text = Person.nationalNo.ToString();

            lbGendor.Text = Person.Gendor == 0 ? "Male" : "Female";
            lbIsActive.Text = Linceses.IsActive == true ? "Actice" : "Not Active";
            if (string.IsNullOrEmpty(Person.ImagePath))
            {
                pcImage.Image = null;
            }
            else
            {
                pcImage.ImageLocation = Person.ImagePath;
            }

            lbClass.Text = BLLLicenseClasses.GetNameClassByID(Linceses.LicenseClass).ToString();
            lbDateBrith.Text = Person.DateOfBirth.ToString();
        }
        private void ctrlFilterANDLicInfo_Load(object sender, EventArgs e)
        {
            lbEnterPlaceHolder.Visible = true;
            if (txtLinID.Enabled == false)
            {
                lbEnterPlaceHolder.Visible = false;
                if (txtLinID.Text == null)
                {
                    MessageBox.Show("Enter License ID", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _IsFound = false;
                    return;
                }
                if (!BLLLinceses.IsFoundLic(Convert.ToInt32(txtLinID.Text)))
                {
                    MessageBox.Show("Not Found License ID", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _IsFound = false;
                    return;
                }
                _IsFound = true;
                _LinID = Convert.ToInt32(txtLinID.Text.Trim());
                LoadData(_LinID);
                FoundLic?.Invoke();
            }
        }

        private void txtLinID_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void ctrlFilterANDLicInfo_KeyDown(object sender, KeyEventArgs e)
        {
            // التحقق مما إذا كان الزر المضغوط هو Enter
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                lbEnterPlaceHolder.Visible = false;
                if (txtLinID.Text == null)
                {
                    MessageBox.Show("Enter License ID", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _IsFound = false;
                    return;
                }
                if (!BLLLinceses.IsFoundLic(Convert.ToInt32(txtLinID.Text)))
                {
                    MessageBox.Show("Not Found License ID", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _IsFound = false;
                    return;
                }
                _IsFound = true;
                _LinID = Convert.ToInt32(txtLinID.Text.Trim());
                LoadData(_LinID);
                FoundLic?.Invoke();
                //__________________________________________________________
            }
        }
        public string txtLicIDText
        {
            get { return txtLinID.Text; }
            set { txtLinID.Text = value; }
        }
        public bool txtLicIDEnable
        {
            get { return txtLinID.Enabled; }
            set { txtLinID.Enabled = value; }
        }

        private void txtLinID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام فقط وزر Backspace لمسح المدخلات
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // إلغاء إدخال الحرف
            }
        }
    }
}