using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanGithub
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username tidak boleh kosong");
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password tidak boleh kosong");
                txtUsername.Focus();
                return;
            }
            if (txtUsername.Text == "admin" && txtPassword.Text == "12345")
            {
                MessageBox.Show("Login Berhasil!");
                FormMenu formBaru = new FormMenu();
                formBaru.Owner = this;
                formBaru.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah");
                txtUsername.Text = "";
                txtPassword.Clear();
            }
        }
    }
}
