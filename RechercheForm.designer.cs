
namespace CommerceTP
{
    partial class RechercheForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RechercheForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboVille = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCodeCl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboDesg = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtCodeAr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radDetail = new System.Windows.Forms.RadioButton();
            this.radCommande = new System.Windows.Forms.RadioButton();
            this.radClient = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateCommande = new System.Windows.Forms.DateTimePicker();
            this.txtCommande = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMontantD = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtQuantiteD = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtArticleD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCommandD = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboVille);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtCodeCl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comboVille
            // 
            this.comboVille.FormattingEnabled = true;
            this.comboVille.Items.AddRange(new object[] {
            "Tangier",
            "Marrakesh",
            "Salé",
            "Meknes",
            "Rabat",
            "Oujda",
            "Kenitra",
            "Agadir",
            "Tetouan\t",
            "Temara",
            "Safi",
            "Mohammedia",
            "Khouribga",
            "El Jadida",
            "Beni Mellal",
            "Aït Melloul"});
            this.comboVille.Location = new System.Drawing.Point(212, 210);
            this.comboVille.Name = "comboVille";
            this.comboVille.Size = new System.Drawing.Size(169, 28);
            this.comboVille.TabIndex = 25;
            this.comboVille.SelectedIndexChanged += new System.EventHandler(this.txtCodeCl_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ville:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(212, 179);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(140, 27);
            this.txtTel.TabIndex = 23;
            this.txtTel.TextChanged += new System.EventHandler(this.txtCodeCl_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(212, 148);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 27);
            this.txtEmail.TabIndex = 22;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtCodeCl_TextChanged);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(212, 114);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(140, 27);
            this.txtPrenom.TabIndex = 21;
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtCodeCl_TextChanged);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(210, 77);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(140, 27);
            this.txtNom.TabIndex = 20;
            this.txtNom.TextChanged += new System.EventHandler(this.txtCodeCl_TextChanged);
            // 
            // txtCodeCl
            // 
            this.txtCodeCl.Location = new System.Drawing.Point(210, 47);
            this.txtCodeCl.Name = "txtCodeCl";
            this.txtCodeCl.Size = new System.Drawing.Size(140, 27);
            this.txtCodeCl.TabIndex = 19;
            this.txtCodeCl.TextChanged += new System.EventHandler(this.txtCodeCl_TextChanged);
            this.txtCodeCl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommandD_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telephone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Prenom:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nom: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Code Client:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboDesg);
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Controls.Add(this.txtPrix);
            this.panel1.Controls.Add(this.txtCodeAr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 298);
            this.panel1.TabIndex = 8;
            // 
            // comboDesg
            // 
            this.comboDesg.FormattingEnabled = true;
            this.comboDesg.Items.AddRange(new object[] {
            "Informatique",
            "Electronique",
            "E-commerce",
            "Beauty",
            "Nouveau"});
            this.comboDesg.Location = new System.Drawing.Point(220, 102);
            this.comboDesg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboDesg.Name = "comboDesg";
            this.comboDesg.Size = new System.Drawing.Size(143, 28);
            this.comboDesg.TabIndex = 55;
            this.comboDesg.SelectedIndexChanged += new System.EventHandler(this.txtCodeAr_TextChanged);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(223, 172);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(140, 27);
            this.txtStock.TabIndex = 54;
            this.txtStock.TextChanged += new System.EventHandler(this.txtCodeAr_TextChanged);
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(223, 139);
            this.txtPrix.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(140, 27);
            this.txtPrix.TabIndex = 53;
            this.txtPrix.TextChanged += new System.EventHandler(this.txtCodeAr_TextChanged);
            // 
            // txtCodeAr
            // 
            this.txtCodeAr.Location = new System.Drawing.Point(220, 71);
            this.txtCodeAr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodeAr.Name = "txtCodeAr";
            this.txtCodeAr.Size = new System.Drawing.Size(140, 27);
            this.txtCodeAr.TabIndex = 52;
            this.txtCodeAr.TextChanged += new System.EventHandler(this.txtCodeAr_TextChanged);
            this.txtCodeAr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommandD_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Stock:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Prix Unitaire:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(80, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Designation: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(79, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Code Article:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(560, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(740, 253);
            this.dataGridView1.TabIndex = 2;
            // 
            // radDetail
            // 
            this.radDetail.AutoSize = true;
            this.radDetail.ForeColor = System.Drawing.Color.White;
            this.radDetail.Location = new System.Drawing.Point(224, 65);
            this.radDetail.Name = "radDetail";
            this.radDetail.Size = new System.Drawing.Size(70, 24);
            this.radDetail.TabIndex = 6;
            this.radDetail.TabStop = true;
            this.radDetail.Text = "Detail";
            this.radDetail.UseVisualStyleBackColor = true;
            this.radDetail.CheckedChanged += new System.EventHandler(this.radCommande_CheckedChanged);
            // 
            // radCommande
            // 
            this.radCommande.AutoSize = true;
            this.radCommande.ForeColor = System.Drawing.Color.White;
            this.radCommande.Location = new System.Drawing.Point(80, 65);
            this.radCommande.Name = "radCommande";
            this.radCommande.Size = new System.Drawing.Size(107, 24);
            this.radCommande.TabIndex = 5;
            this.radCommande.TabStop = true;
            this.radCommande.Text = "Commande";
            this.radCommande.UseVisualStyleBackColor = true;
            this.radCommande.CheckedChanged += new System.EventHandler(this.radCommande_CheckedChanged);
            // 
            // radClient
            // 
            this.radClient.AutoSize = true;
            this.radClient.ForeColor = System.Drawing.Color.White;
            this.radClient.Location = new System.Drawing.Point(80, 22);
            this.radClient.Name = "radClient";
            this.radClient.Size = new System.Drawing.Size(68, 24);
            this.radClient.TabIndex = 3;
            this.radClient.TabStop = true;
            this.radClient.Text = "Client";
            this.radClient.UseVisualStyleBackColor = true;
            this.radClient.CheckedChanged += new System.EventHandler(this.radCommande_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(229, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Article";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radCommande_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dateCommande);
            this.panel2.Controls.Add(this.txtCommande);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 314);
            this.panel2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 187);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 27);
            this.textBox1.TabIndex = 43;
            this.textBox1.TextChanged += new System.EventHandler(this.txtCommande_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(98, 189);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Quantity Commande:";
            // 
            // dateCommande
            // 
            this.dateCommande.Location = new System.Drawing.Point(268, 151);
            this.dateCommande.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateCommande.Name = "dateCommande";
            this.dateCommande.Size = new System.Drawing.Size(140, 27);
            this.dateCommande.TabIndex = 41;
            this.dateCommande.ValueChanged += new System.EventHandler(this.txtCommande_TextChanged);
            // 
            // txtCommande
            // 
            this.txtCommande.Location = new System.Drawing.Point(268, 118);
            this.txtCommande.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCommande.Name = "txtCommande";
            this.txtCommande.Size = new System.Drawing.Size(140, 27);
            this.txtCommande.TabIndex = 40;
            this.txtCommande.TextChanged += new System.EventHandler(this.txtCommande_TextChanged);
            this.txtCommande.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommandD_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(124, 151);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Date Commande:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(124, 113);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "N Commande:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1261, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 41);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMontantD);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txtQuantiteD);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtArticleD);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtCommandD);
            this.panel3.Controls.Add(this.label16);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(1, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 354);
            this.panel3.TabIndex = 22;
            // 
            // txtMontantD
            // 
            this.txtMontantD.Location = new System.Drawing.Point(263, 217);
            this.txtMontantD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMontantD.Name = "txtMontantD";
            this.txtMontantD.Size = new System.Drawing.Size(140, 27);
            this.txtMontantD.TabIndex = 47;
            this.txtMontantD.TextChanged += new System.EventHandler(this.txtCommandD_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(119, 220);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 20);
            this.label17.TabIndex = 46;
            this.label17.Text = "Montant";
            // 
            // txtQuantiteD
            // 
            this.txtQuantiteD.Location = new System.Drawing.Point(263, 160);
            this.txtQuantiteD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuantiteD.Name = "txtQuantiteD";
            this.txtQuantiteD.Size = new System.Drawing.Size(140, 27);
            this.txtQuantiteD.TabIndex = 45;
            this.txtQuantiteD.TextChanged += new System.EventHandler(this.txtCommandD_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(119, 163);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 20);
            this.label15.TabIndex = 44;
            this.label15.Text = "Quanitite";
            // 
            // txtArticleD
            // 
            this.txtArticleD.Location = new System.Drawing.Point(263, 116);
            this.txtArticleD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtArticleD.Name = "txtArticleD";
            this.txtArticleD.Size = new System.Drawing.Size(140, 27);
            this.txtArticleD.TabIndex = 43;
            this.txtArticleD.TextChanged += new System.EventHandler(this.txtCommandD_TextChanged);
            this.txtArticleD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommandD_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(119, 119);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 42;
            this.label14.Text = "Code Article";
            // 
            // txtCommandD
            // 
            this.txtCommandD.Location = new System.Drawing.Point(263, 68);
            this.txtCommandD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCommandD.Name = "txtCommandD";
            this.txtCommandD.Size = new System.Drawing.Size(140, 27);
            this.txtCommandD.TabIndex = 40;
            this.txtCommandD.TextChanged += new System.EventHandler(this.txtCommandD_TextChanged);
            this.txtCommandD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommandD_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(119, 63);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "N Commande:";
            // 
            // RechercheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1312, 544);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radDetail);
            this.Controls.Add(this.radCommande);
            this.Controls.Add(this.radClient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RechercheForm";
            this.Text = "v";
            this.Load += new System.EventHandler(this.RechercheForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboVille;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCodeCl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radDetail;
        private System.Windows.Forms.RadioButton radCommande;
        private System.Windows.Forms.RadioButton radClient;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboDesg;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtCodeAr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateCommande;
        private System.Windows.Forms.TextBox txtCommande;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtArticleD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCommandD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMontantD;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtQuantiteD;
        private System.Windows.Forms.Label label15;
    }
}