using BLLPeopleDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD1
{
   
    public partial class frmUsers : Form
    {
        private DataTable dtUsers;   
        private void _RefreshTable()
        {
            dtUsers = BLLUser.GetAllUsers();
            dgvUsers.DataSource = dtUsers;
            lbCount.Text = dtUsers.Rows.Count.ToString();
            txtFilter.Visible = false;
            cmbFilter.SelectedIndex = 0;
        }
        public frmUsers()
        {
            InitializeComponent();
        }

        private void lbCount_Click(object sender, EventArgs e)
        {

        }

      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            dtUsers = BLLUser.GetAllUsers();
            dgvUsers.DataSource = dtUsers;
            cmbFilter.SelectedIndex = 0;
            cmbActive.SelectedIndex = 0;
            cmbActive.Visible = false;
            _RefreshTable();
        }
        //_____________________________Filter________________________________________________
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.Text == "None")
            {
                txtFilter.Visible = false;
                txtFilter.Text = "";
                dtUsers.DefaultView.RowFilter = "";
            }
            else if (cmbFilter.Text == "IsActive")
            {
                txtFilter.Visible = false;
                cmbActive.Visible = true;

            }
            else
            {
                txtFilter.Visible = true;
                cmbActive.Visible = false;
                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string Text = txtFilter.Text.Trim();
            string filterColumn = cmbFilter.Text;
            if (string.IsNullOrEmpty(Text))
            {
                dtUsers.DefaultView.RowFilter = "";
                return;
            }
            switch (filterColumn) 
            {
                case "UserID":
                    if (int.TryParse(Text, out int userID))

                        dtUsers.DefaultView.RowFilter = $"UserID = {userID}";
                    else
                        dtUsers.DefaultView.RowFilter = "UserID = -1";
                    break;
                case "PersonID":
                    if (int.TryParse(Text, out int personID))
                        dtUsers.DefaultView.RowFilter = $"PersonID = {personID}";
                    else
                        dtUsers.DefaultView.RowFilter = "PersonID = -1";
                    break;
                case "FullName":
                    dtUsers.DefaultView.RowFilter = $"FullName LIKE '%{Text}%'";
                    break;
                case "UserName":
                    dtUsers.DefaultView.RowFilter = $"UserName LIKE '%{Text}%'";
                    break;
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbActive.SelectedIndex)
            {
                case 1:
                    dtUsers.DefaultView.RowFilter = "IsActive = True";
                    break;

                case 2:
                    dtUsers.DefaultView.RowFilter = "IsActive = False";
                    break;

                default:
                    dtUsers.DefaultView.RowFilter = "";
                    break;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmAddUser frmAddUser = new frmAddUser(-1,-1);
            frmAddUser.ShowDialog();
            _RefreshTable();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUser frmShowUser = new frmShowUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells[1].Value));
            frmShowUser.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser frmAddUser = new frmAddUser(-1,-1);
            frmAddUser.ShowDialog();
            _RefreshTable();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);
            int PersonID = Convert.ToInt32(dgvUsers.CurrentRow.Cells[1].Value);
            frmAddUser frmAddUser = new frmAddUser(UserID, PersonID);
            frmAddUser.ShowDialog();
            _RefreshTable();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this user?", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BLLUser.DeleteUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Delete User is done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshTable();
                }
                else
                {
                    MessageBox.Show("Not Can Delete User", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvUsers.ClearSelection();
                dgvUsers.Rows[e.RowIndex].Selected = true;

                // تعيين الخلية الحالية لضمان تحديث CurrentRow فوراً
                dgvUsers.CurrentCell = dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex >= 0 ? e.ColumnIndex : 0];
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);
            int PersonID = Convert.ToInt32(dgvUsers.CurrentRow.Cells[1].Value);
            frmChangeBassword frmChangeBassword = new frmChangeBassword(UserID, PersonID);
            frmChangeBassword.ShowDialog();
        }
        //_____________________________Filter________________________________________________
    }
}
