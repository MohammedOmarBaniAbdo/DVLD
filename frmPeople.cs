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
    public partial class frmPeople : Form
    {
        private DataTable dt;
        public frmPeople()
        {
            InitializeComponent();
        }

        private void _Refrish()
        {
            dt = BLLPeople.GetAllPeople();
            dgvPeople.DataSource = dt;
            lbCount.Text = "Count: " + dt.Rows.Count.ToString();
            txtFilter.Visible = false;
            cmbFilter.SelectedIndex = 0;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void frmPeople_Load(object sender, EventArgs e)
        {
            _Refrish();
        }
        private void lbCount_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmAddPerson frmAddPerson = new frmAddPerson(-1);
            frmAddPerson.ShowDialog();
            _Refrish();
        }
        private void showDetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPerson frmShowPerson1 = new frmShowPerson(Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value));
            frmShowPerson1.ShowDialog();
        }

        private void dgvPeople_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvPeople.ClearSelection();
                dgvPeople.Rows[e.RowIndex].Selected = true;

                // تعيين الخلية الحالية لضمان تحديث CurrentRow فوراً
                dgvPeople.CurrentCell = dgvPeople.Rows[e.RowIndex].Cells[e.ColumnIndex >= 0 ? e.ColumnIndex : 0];
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this person?", "Delete Person", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (BLLPeople.DeletePerson(Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Person deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dt = new DataTable();
                    dt = BLLPeople.GetAllPeople();
                    dgvPeople.DataSource = dt;
                    lbCount.Text = "Count: " + dt.Rows.Count.ToString();
                }
                else
                {
                    MessageBox.Show("Error deleting person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddPerson frmAddPerson = new frmAddPerson(-1);
            frmAddPerson.ShowDialog();
            _Refrish();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddPerson frmAddPerson = new frmAddPerson(Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value));
            frmAddPerson.ShowDialog();
            _Refrish();
        }

        private void btRef_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BLLPeople.GetAllPeople();
            dgvPeople.DataSource = dt;
            lbCount.Text = "Count: " + dt.Rows.Count.ToString();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.Text == "None")
            {
                txtFilter.Visible = false;
                txtFilter.Text = "";
                dt.DefaultView.RowFilter = "";
            }
            else
            {
                // إظهار خانة الكتابة وتنظيفها وتجهيز التركيز عليها
                txtFilter.Visible = true;
                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = cmbFilter.Text;
            string filterValue = txtFilter.Text.Trim();
            if (string.IsNullOrEmpty(filterValue))
            {
                dt.DefaultView.RowFilter = "";
                return;
            }
            switch (filterColumn)
            {
                case "Person ID":
                    // للأرقام: مطابقة مباشرة مع التأكد من إدخال رقم صحيح
                    if (int.TryParse(filterValue, out int personID))
                        dt.DefaultView.RowFilter = $"PersonID = {personID}";
                    else
                        dt.DefaultView.RowFilter = "PersonID = -1"; // إخفاء الصفوف عند كتابة أحرف بالخطأ
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
        }
    }
}
