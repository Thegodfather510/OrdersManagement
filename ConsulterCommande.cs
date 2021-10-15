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
    public partial class ConsulterCommande : Form
    {
        public ConsulterCommande()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=msi;Initial Catalog=Commerce;Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmd2;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();

        //SqlDataAdapter adapter;
        //SqlDataAdapter adapterCommande;
        //DataSet ds = new DataSet();
        BindingSource src = new BindingSource();
        double TVA=0;
        double TTC = 0;
        double total = 0;
        private void ConsulterCommande_Load(object sender, EventArgs e)
        {
            //adapter = new SqlDataAdapter("select * from client", con);
            //adapter.Fill(ds, "clt");
            //src.DataSource = ds.Tables["clt"];

            cmd = new SqlCommand("select * from client", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            src.DataSource = dt;

            txtNom.DataBindings.Add("Text", src, "Nom", true, DataSourceUpdateMode.Never);
            txtVille.DataBindings.Add("Text", src, "Ville", true, DataSourceUpdateMode.Never);

            comboClient.DataSource = src;
            comboClient.ValueMember = "CodeCl";

            con.Close();

        }

        void afficherCommande()
        {
            if (con.State == ConnectionState.Open)
                con.Close();

                cmd2 = new SqlCommand("select * from commande where #codeclt = " + comboClient.SelectedValue + "", con);
                con.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                dt2.Clear();
                dt2.Load(dr2);
                dataGridView1.DataSource = dt2;
                dataGridView1.Refresh();
        }

        void afficherDetail()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            
                cmd2 = new SqlCommand("select #NumComm,#CodeArt,Qte,Montant from Detail d,Commande co WHERE d.#NumComm=co.NumComm AND co.#CodeClt=" + comboClient.SelectedValue,con);
                SqlDataReader dr3 = cmd2.ExecuteReader();
                dt3.Clear();
                dt3.Load(dr3);
                dataGridView2.DataSource = dt3;
                dataGridView2.Refresh();

        }


        private void comboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //adapterCommande = new SqlDataAdapter("Select * from commande", con);
            //adapterCommande.Fill(ds, "commande");
            //ds.Relations.Add("reel", ds.Tables["clt"].Columns["codecl"], ds.Tables["commande"].Columns["#codeClt"]);
            //dataGridView2.DataSource = "reel";
            
                if (con.State == ConnectionState.Open)
                    con.Close();
                else
                {
                    cmd2 = new SqlCommand("select * from commande where #codeclt = " + comboClient.SelectedValue + "", con);
                con.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                dt2.Clear();
                dt2.Load(dr2);
                dataGridView1.DataSource = dt2;
                dataGridView1.Refresh();
                cmd2.CommandText = "select sum(montant) from Detail d,Commande co WHERE d.#NumComm=co.NumComm AND co.#CodeClt=" + comboClient.SelectedValue;
                txtChiffre.Text = cmd2.ExecuteScalar().ToString();



                cmd2.CommandText= "select #NumComm,#CodeArt,Qte,Montant from Detail d,Commande co WHERE d.#NumComm=co.NumComm AND co.#CodeClt=" + comboClient.SelectedValue;
                SqlDataReader dr3 = cmd2.ExecuteReader();
                dt3.Clear();
                dt3.Load(dr3);
                dataGridView2.DataSource = dt3;
                dataGridView2.Refresh();
                con.Close();
            }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cmd = new SqlCommand("Delete from Detail d,Commande co WHERE d.#NumComm=co.NumComm AND NumComm="+dataGridView1.CurrentCell.Value,con);
            cmd = new SqlCommand("DELETE FROM DETAIL WHERE #NumComm=" + dataGridView1.CurrentRow.Cells["NumComm"].Value, con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("DELETE FROM Commande WHERE NumComm=" + dataGridView1.CurrentRow.Cells["NumComm"].Value, con);
            cmd.ExecuteNonQuery();
            dataGridView1.Refresh();
            dataGridView2.Refresh();

            afficherCommande();
            afficherDetail();
            //dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            //dataGridView1.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.current.Show();
        }

        private void txtChiffre_TextChanged(object sender, EventArgs e)
        {
            if (txtChiffre.Text != "")
            {
                TVA = (double.Parse(txtChiffre.Text) / 100) * 20;
                txtTVA.Text = TVA.ToString();

                TTC = TVA + (double.Parse(txtChiffre.Text));
                txtTCC.Text = TTC.ToString();

                total = TVA / 100 * 10;
                txtTotal.Text = total.ToString();
            }
            else
            {
                txtTVA.Text = "";
                txtTCC.Text = "";
                txtTotal.Text = "";
            }
                

            
        }

        private void comboClient_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
