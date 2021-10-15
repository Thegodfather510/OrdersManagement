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
    public partial class ClientNombre : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=msi;Initial Catalog=Commerce;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public ClientNombre()
        {
            InitializeComponent();
        }

        private void ClientNombre_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select count(*) from client where ville like '" + comboBox1.Text + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            lblCount.Text = cmd.ExecuteScalar().ToString();
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.current.Show();

        }
    }
}
