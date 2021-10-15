using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CommerceTP
{
    public partial class ListNom : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=msi;Initial Catalog=Commerce;Integrated Security=True");
        SqlCommand cmd;
        public ListNom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select nom from Client", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr.GetValue(0).ToString());
            }
            con.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            this.Close();
            Menu.current.Show();

        }
    }
}
