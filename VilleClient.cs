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
    public partial class VilleClient : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=msi;Initial Catalog=Commerce;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public VilleClient()
        {
            InitializeComponent();
        }

        private void VilleClient_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from client where Ville like '"+comboBox1.Text+"'" , con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.current.Show();
        }
    }
}
