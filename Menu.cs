using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommerceTP
{
    public partial class Menu : Form
    {
        public static Menu current;
        public static Menu test;
        public Menu()
        {
            current = this;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListNom listNom = new ListNom();
            this.Hide();
            listNom.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VilleClient villeClient = new VilleClient();
            this.Hide();
            villeClient.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientNombre clientNombre = new ClientNombre();
            this.Hide();
            clientNombre.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MajClient majClient = new MajClient();
            this.Hide();
            majClient.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MajArticle majArticle = new MajArticle();
            this.Hide();
            majArticle.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaisieCommande saisieCommande = new SaisieCommande();
            this.Hide();
            saisieCommande.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ConsulterCommande consulterCommande = new ConsulterCommande();
            this.Hide();
            consulterCommande.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RechercheForm rechercheForm = new RechercheForm();
            this.Hide();
            rechercheForm.Show();
        }
    }
}
