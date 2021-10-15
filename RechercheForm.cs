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
    public partial class RechercheForm : Form
    {
        public RechercheForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=msi;Initial Catalog=Commerce;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        private void RechercheForm_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = false;
            panel3.Visible = false;
            groupBox1.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCodeCl_TextChanged(object sender, EventArgs e)
        {
            string req = "select * from client where 1=1";
            if (txtCodeCl.Text != "")
                req += " and codeCl = " + txtCodeCl.Text;
            if (txtNom.Text != "")
                req += " and nom like '" + txtNom.Text + "%'";
            if (txtPrenom.Text != "")
                req += " and prenom like '" + txtPrenom.Text + "%'";
            if (txtEmail.Text != "")
                req += " and email like '" + txtEmail.Text + "%'";
            if (txtTel.Text != "")
                req += " and tel like '" + txtTel.Text + "%'";
            if (comboVille.Text != "")
                req += " and ville like '" + comboVille.Text + "%'";

            cmd = new SqlCommand(req, con);
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void radCommande_CheckedChanged(object sender, EventArgs e)
        {
            if (radClient.Checked)
            {
                dt = new DataTable();
                cmd = new SqlCommand("Select * from client", con);
                con.Open();
                SqlDataReader dr2 = cmd.ExecuteReader();
                dt.Clear();
                dt.Load(dr2);
                dataGridView1.Refresh();
                dataGridView1.DataSource = dt;
                con.Close();

                panel1.Visible = panel2.Visible=panel3.Visible=false;
                groupBox1.Visible = true;
            }
            if (radioButton1.Checked)
            {
                dt = new DataTable();
                cmd = new SqlCommand("Select * from article", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Clear();
                dataGridView1.Refresh();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                con.Close();

                groupBox1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel1.Visible = true;
            }
            if (radCommande.Checked)
            {
                dt = new DataTable();
                cmd = new SqlCommand("Select * from commande", con);
                con.Open();
                SqlDataReader dr3 = cmd.ExecuteReader();
                dt.Clear();
                dataGridView1.Refresh();
                dt.Load(dr3);
                dataGridView1.DataSource = dt;
                con.Close();

                groupBox1.Visible = false;
                panel1.Visible = false;
                panel3.Visible = false;
                panel2.Visible = true;
            }
            if (radDetail.Checked)
            {
                dt = new DataTable();
                cmd = new SqlCommand("Select * from detail", con);
                con.Open();
                SqlDataReader dr4 = cmd.ExecuteReader();
                dt.Clear();
                dataGridView1.Refresh();
                dt.Load(dr4);
                dataGridView1.DataSource = dt;
                con.Close();

                groupBox1.Visible = false;
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
            }
            


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodeAr_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            string req = "select * from article where 1=1";
            if (txtCodeAr.Text != "")
                req += " and codeart = " + txtCodeAr.Text;
            if (comboDesg.Text != "")
                req += " and Designation like '" + comboDesg.Text + "%'";
            if (txtPrix.Text != "")
                req += " and PrixUnit = '" + txtPrix.Text + "'";
            if (txtStock.Text != "")
                req += " and QuantityStock like '" + txtStock.Text + "%'";

            cmd = new SqlCommand(req, con);
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void txtCommande_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            string req = "select * from commande where 1=1";
            if (txtCommande.Text != "")
                req += " and NumComm = " + txtCommande.Text;
            if (dateCommande.Value !=DateTime.Now)
                req += " and DateComm = '" + dateCommande.Value.ToShortDateString() + "'";
            if (textBox1.Text != "")
                req += " and QuanityCommand = "+textBox1.Text;     

            cmd = new SqlCommand(req, con);
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr4 = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr4);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.current.Show();
        }

        private void txtCommandD_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            string req = "select * from detail where 1=1";
            if (txtCommandD.Text != "")
                req += " and #NumComm = " + txtCommandD.Text;
            if (txtArticleD.Text != "")
                req += " and #CodeArt = " + txtArticleD.Text;
            if (txtQuantiteD.Text != "")
                req += " and Qte = " + txtQuantiteD.Text;
            if (txtMontantD.Text != "")
                req += " and Montant = " + txtMontantD.Text;

            cmd = new SqlCommand(req, con);
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr5 = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr5);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void txtCommandD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
