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
using static System.Windows.Forms.LinkLabel;

namespace DVLD1
{
    public partial class ctrlShowLicense : UserControl
    {
        int _LinID = -1;
        int _PersonID = -1;
        // Requre a LinID, PersonID, DriverID
        // LinID => include DriverID
        //BLLDriver.Find(LinID.DruverID) => include PersonID
        BLLLinceses Linceses;
        BLLDrivers Driver;
        BLLPeople Person;
        BLLInternationalLicenses InterLic;
        public ctrlShowLicense()
        {
            InitializeComponent();
            
        }
        public void LoadDataLocalLicense(int linID)
        {
            _LinID = linID;

            Linceses = BLLLinceses.Find(_LinID);

            if (Linceses == null)
                return;

            lbLinID.Text = _LinID.ToString();
            lbIssueDate.Text = Linceses.IssueDate.ToString();
            lbIssueRe.Text = Linceses.IssueReason.ToString();
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
            lbIsActive.Text = Linceses.IsActive == true ? "Yes" : "No";
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
        private void ctrlShowLicense_Load(object sender, EventArgs e)
        {


        }
    }
}
