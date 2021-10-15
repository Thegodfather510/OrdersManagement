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
    public partial class SaisieCommande : Form
    {
        public SaisieCommande()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=msi;Initial Catalog=Commerce;Integrated Security=True");
        SqlDataAdapter adapter;
        SqlDataAdapter adapterClient;
        SqlDataAdapter adapterDetail;
        SqlDataAdapter adapterCommande;
        BindingSource src2 = new BindingSource();
        BindingSource src = new BindingSource();
        BindingSource src3 = new BindingSource();
        DataSet ds = new DataSet();
        private void SaisieCommande_Load(object sender, EventArgs e)
        { 
            adapter = new SqlDataAdapter("select * from article", con);
            adapter.Fill(ds, "art");
            src.DataSource = ds.Tables["art"];
            dataGridView2.DataSource = src;

            adapterClient = new SqlDataAdapter("select * from client", con);
            adapterClient.Fill(ds, "clt");
            src2.DataSource = ds.Tables["clt"];

            txtNom.DataBindings.Add("Text", src2, "Nom", true, DataSourceUpdateMode.OnPropertyChanged);
            txtVille.DataBindings.Add("Text", src2, "ville", true, DataSourceUpdateMode.OnPropertyChanged);

            txtDesignation.DataBindings.Add("Text", src, "Designation", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPU.DataBindings.Add("Text", src, "PrixUnit", true, DataSourceUpdateMode.OnPropertyChanged);
            txtQuantity.DataBindings.Add("Text", src, "QuantityStock", true, DataSourceUpdateMode.OnPropertyChanged);

            comboClient.DataSource = src2;
            comboClient.ValueMember = "CodeCl";

            comboArticle.DataSource = src;
            comboArticle.ValueMember = "CodeArt";

            adapterDetail = new SqlDataAdapter("select * from detail", con);
            adapterDetail.Fill(ds, "det");
            src3.DataSource = ds.Tables["det"];

            adapterCommande = new SqlDataAdapter("select * from commande", con);
            adapterCommande.Fill(ds, "commande");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            src.MoveNext();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double result = 0;
                double quantityCommande = double.Parse(textBox1.Text);
                int quantityStock = int.Parse(txtQuantity.Text);
                double quantityPrice = double.Parse(txtPU.Text);

                if (quantityCommande <= quantityStock)
                {
                    result = (quantityCommande * quantityPrice);
                    txtTotal.Text = Math.Round(result, 2).ToString();
                }
                else
                    MessageBox.Show("Stock insufissant");
            }

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text == "Nouveau")
            {
                btnAjouter.Text = "Valider";
                foreach(Control c in Controls)
                {
                    if (c is TextBox)
                        c.ResetText();
                }
            }
                
            else
            {
                ds.Tables["commande"].Rows.Add(txtCommande.Text, dateCommande.Value.ToShortDateString(), comboClient.Text, textBox1.Text);
                ds.Tables["det"].Rows.Add(txtCommande.Text, comboArticle.Text, textBox1.Text, /*Math.Round(double.Parse(txtTotal.Text), 2).ToString()*/ Convert.ToDecimal(txtTotal.Text));
                MessageBox.Show("Bien Ajouter");
                //btnAjouter.Text = "Nouveau";
            }
        }

        private void btnEnregister_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder build = new SqlCommandBuilder(adapterCommande);
            SqlCommandBuilder build2 = new SqlCommandBuilder(adapterDetail);
            adapterCommande.Update(ds.Tables["commande"]);
            adapterDetail.Update(ds.Tables["det"]);
            MessageBox.Show("Bien enregistrer");
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtTotal.MaxLength = 10;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.current.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void comboClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCommande_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
