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
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace DVLD1
{
    public partial class ctrlShowIntenationalLicense : UserControl
    {
        int _LinID = -1;
        BLLInternationalLicenses InterLic;
        BLLDrivers Driver;
        BLLPeople Person;
        public ctrlShowIntenationalLicense()
        {
            InitializeComponent();
        }
        public void LoadDataInterNationalLicense(int ILinID)
        {
            _LinID = ILinID;

            InterLic = BLLInternationalLicenses.Find(_LinID);
            if (InterLic == null)
                return;
            lbIntLicID.Text = _LinID.ToString();


            Driver = BLLDrivers.FindByDriverID(InterLic.DriverID);
            if (Driver == null)
                return;
            lbDriverID.Text = Driver.DriverID.ToString(); ;

            Person = BLLPeople.Find(Driver.PersonID);

            if (Person == null)
                return;

            lbName.Text = Person.FirstName + " " +
                          Person.SecName + " " +
                          Person.thirdName + " " +
                          Person.LastName;
            lbIssueDate.Text = InterLic.IssueDate.ToString();
            lbLinID.Text = InterLic.IssuedUsingLocalLicenseID.ToString();
            lbNationalNo.Text = Person.nationalNo.ToString();
            lbIsActive.Text = InterLic.IsActive == true ? "Active" : "Not Active";
            lbGendor.Text = Person.Gendor == 0 ? "Male" : "Female";
            lbApplication.Text = InterLic.ApplicationID.ToString();
            lbExDate.Text = InterLic.ExpirationDate.ToString();
            if (string.IsNullOrEmpty(Person.ImagePath))
            {
                pcImage.Image = null;
            }
            else
            {
                pcImage.ImageLocation = Person.ImagePath;
            }
            lbDateBrith.Text = Person.DateOfBirth.ToString();
        }
        private void ctrlShowIntenationalLicense_Load(object sender, EventArgs e)
        {

        }
    }
}
