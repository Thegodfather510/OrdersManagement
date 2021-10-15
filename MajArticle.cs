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
    public partial class MajArticle : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=msi;Initial Catalog=Commerce;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        BindingSource source = new BindingSource();
        public MajArticle()
        {
            InitializeComponent();
        }

        private void MajArticle_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from article", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            source.DataSource = dt;

            txtCodeAr.DataBindings.Add("Text",source , "CodeArt", true, DataSourceUpdateMode.OnPropertyChanged);
            comboDesg.DataBindings.Add("Text", source, "Designation", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPrix.DataBindings.Add("Text", source, "PrixUnit", true, DataSourceUpdateMode.OnPropertyChanged);
            txtStock.DataBindings.Add("Text", source, "QuantityStock", true, DataSourceUpdateMode.OnPropertyChanged);


            con.Close();


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            source.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            source.MoveLast();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            source.MoveFirst();
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            source.MovePrevious();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO Article VALUES ('" + txtCodeAr.Text + "','" + comboDesg.Text + "','" + txtPrix.Text + "','" + txtStock.Text + "')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Article Bien Ajouter");
            con.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE Article SET Designation = '"+comboDesg.Text+"', PrixUnit = '"+txtPrix.Text+ "', QuantityStock = '" + txtStock.Text+"' WHERE CodeArt = '"+txtCodeAr.Text+"'",con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Article Bien Modifier");
            con.Close();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE FROM Article WHERE CodeArt ='" + txtCodeAr.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Article Bien Supprimer");
            con.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            //int i = 0;
            //cmd = new SqlCommand("select * from Article where CodeArt='" + txtCodeArRechercher.Text + "'", con);
            //con.Open();
            //i=cmd.ExecuteNonQuery();
            //if (i != 0)
            //{
            //    MessageBox.Show("L'article exist");
            //}
            //else
            //    MessageBox.Show("L'article n'exist pas");
            //con.Close();

            if (txtCodeArRechercher.Text != "")
                source.Filter = "codeArt = '" + txtCodeArRechercher.Text + "'";
            else
                source.RemoveFilter();



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.current.Show();

        }

        private void txtCodeAr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodeAr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
