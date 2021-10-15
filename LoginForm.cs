using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CommerceTP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=msi;Initial Catalog=Commerce;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("select * from users WHERE username = '" + txtUsername.Text.Trim() + "' AND userPassword = '" + txtPassword.Text.Trim() + "' ", con);
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("username or password is incorrect");
                txtPassword.Text = "Password";
                txtUsername.Text = "Username";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}
