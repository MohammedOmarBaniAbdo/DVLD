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
    public partial class ctrlFilterAndPersinInfo : UserControl
    {
        public int PersonID = -1;
        DataTable dt;
        public ctrlFilterAndPersinInfo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string filterColumn = cmbFilter.Text;
            string filterValue = txtFilter.Text.Trim();

            if (string.IsNullOrEmpty(filterValue))
            {
                dt.DefaultView.RowFilter = "";
                PersonID = -1;
                return;
            }

            switch (filterColumn)
            {
                case "Person ID":
                    if (int.TryParse(filterValue, out int personID))
                        dt.DefaultView.RowFilter = $"PersonID = {personID}";
                    else
                        dt.DefaultView.RowFilter = "PersonID = -1";
                    break;

                case "National No":
                    dt.DefaultView.RowFilter = $"NationalNo LIKE '{filterValue}%'";
                    break;

                case "First Name":
                    dt.DefaultView.RowFilter = $"FirstName LIKE '{filterValue}%'";
                    break;

                case "Second Name":
                    dt.DefaultView.RowFilter = $"SecondName LIKE '{filterValue}%'";
                    break;

                case "Third Name":
                    dt.DefaultView.RowFilter = $"ThirdName LIKE '{filterValue}%'";
                    break;

                case "Last Name":
                    dt.DefaultView.RowFilter = $"LastName LIKE '{filterValue}%'";
                    break;

                case "Phone":
                    dt.DefaultView.RowFilter = $"Phone LIKE '{filterValue}%'";
                    break;

                case "Email":
                    dt.DefaultView.RowFilter = $"Email LIKE '{filterValue}%'";
                    break;

                case "Nationality":
                    dt.DefaultView.RowFilter = $"CountryName LIKE '{filterValue}%'";
                    break;

                case "Gendor":
                    dt.DefaultView.RowFilter = $"GendorCaption LIKE '{filterValue}%'";
                    break;

                default:
                    dt.DefaultView.RowFilter = "";
                    break;
            }

            // بعد تنفيذ البحث، خذ PersonID من أول نتيجة
            PersonID = dt.DefaultView.Count > 0
                ? Convert.ToInt32(dt.DefaultView[0]["PersonID"])
                : -1;
            ctrlInfoPerson1.LoadDataPerson(PersonID);
        }

        private void ctrlFilterAndPersinInfo_Load(object sender, EventArgs e)
        {
            txtFilter.Visible = false;
            cmbFilter.SelectedIndex = 0;
            dt = BLLPeople.GetAllPeople();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void ctrlInfoPerson1_Load(object sender, EventArgs e)
        {

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedIndex == 0)
            {
                txtFilter.Visible = false;
            }
            else
            {
                txtFilter.Visible = true;
            }

        }
        public int cmbFilter1
        {
            get { return cmbFilter.SelectedIndex; }
            set { cmbFilter.SelectedIndex = value; }
        }
        public bool cmbFilterEnable
        {
            get { return cmbFilter.Enabled; }
            set { cmbFilter.Enabled = value; }
        }
        public bool txtFilterEnable
        {
            get { return txtFilter.Enabled; }
            set { txtFilter.Enabled = value; }
        }
    }
}
