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
using System.IO;
namespace DVLD1
{
    public partial class Form1 : Form
    {
        private void _RemeberMe()
        {
            if (chRemember.Checked)
            {
                string data = txtUsername.Text + "|" + txtPassword.Text;
                File.WriteAllText("User.txt", txtUsername.Text);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Palese Enter Username...","",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Palese Enter Password...","", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (!BLLUser.IsValidUser(txtUsername.Text,txtPassword.Text))
            {
                MessageBox.Show("Invalid Username or Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!BLLUser.IsActiveUser(txtUsername.Text))
            {
                MessageBox.Show("This User Is Not Acvtive,...", "Conecte with Admin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            clsGlobal.LoadUser(txtUsername.Text);
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();
            if (!chRemember.Checked)
            {
                txtUsername.Focus();
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
