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
    public partial class MajClient : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=msi;Initial Catalog=Commerce;Integrated Security=True");
        DataSet ds = new DataSet();
        SqlDataAdapter adapter;
        BindingSource src = new BindingSource();
        public MajClient()
        {
            InitializeComponent();
        }

        private void MajClient_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("select * from client", con);
            adapter.Fill(ds, "cl");
            src.DataSource = ds.Tables["cl"];

            txtCodeCl.DataBindings.Add("Text", src, "CodeCl", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNom.DataBindings.Add("Text", src, "Nom", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPrenom.DataBindings.Add("Text", src, "Prenom", true, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", src, "Email", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTel.DataBindings.Add("Text", src, "tel", true, DataSourceUpdateMode.OnPropertyChanged);
            comboVille.DataBindings.Add("Text", src, "ville", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        
        void naviguer(int i)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            src.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            src.MoveLast();
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            src.MovePrevious();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            src.MoveFirst();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text == "Nouveau")
            {
                txtCodeCl.Enabled = true;
                btnModifier.Enabled = false;
                foreach(Control c in Controls)
                {
                    if (c is TextBox)
                        c.ResetText();
                }
                btnAjouter.Text = "Ajouter";
                //src.AddNew();
            }
            else
            {
                //src.EndEdit();
                try
                {
                    ds.Tables["cl"].Rows.Add(txtCodeCl.Text, txtNom.Text, txtPrenom.Text, txtEmail.Text, txtTel.Text, comboVille.Text);
                    btnAjouter.Text = "Nouveau";
                    btnModifier.Enabled = true;
                    MessageBox.Show("Client Bien Ajoute");
                    txtCodeCl.Enabled = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                
               
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder build = new SqlCommandBuilder(adapter);
                adapter.Update(ds.Tables["cl"]);
                MessageBox.Show("Bien enregistrer");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                src.EndEdit();
                MessageBox.Show("Client Bien Modifier");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                src.RemoveCurrent();
                MessageBox.Show("Client Bien Supprimer");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Ce client a des commandes, Impossible de supprimer");
            }
                
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (txtCodeClRechercher.Text != "")
                src.Filter = "codecl = '" + txtCodeClRechercher.Text + "'";
            else
                src.RemoveFilter();
            
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

        private void txtCodeCl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
