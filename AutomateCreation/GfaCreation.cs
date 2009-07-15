using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Automates
{
    public partial class GfaCreation : Form
    {

        int initial = 0;
        public Gfa UserGfa = new Gfa();
        ArrayList GfaTransitions = new ArrayList();

        private Panel panel1;
        private Button Modifier1;
        private Button Valide1;
        private GroupBox groupBox3;
        private Label label3;
        private ListBox Xlist;
        private Button RmX;
        private ListBox caracteres;
        private Button ToX;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox initialList;
        private Button RmF;
        private Button CopytoF;
        private Label labelEtatsFinaux;
        private Label labelEtats;
        private ListBox EtatsFList;
        private ListBox EtatsList;
        private Label NbEtatLabel;
        private Panel panel2;
        private Button Valider2;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button Ajouter;
        private GroupBox groupBox4;
        private Label label7;
        private Button supprimer;
        private ListBox transitions;
        private ListBox SJ;
        private ListBox SiXSj;
        private ListBox SI;
        public TextBox Name_box;
        private Label label1;
        private Button annuler;
        private TextBox MotLu;
        private NumericUpDown Nbetats;

        public GfaCreation()
        {
            InitializeComponent();
            
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Modifier1 = new System.Windows.Forms.Button();
            this.Valide1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Xlist = new System.Windows.Forms.ListBox();
            this.RmX = new System.Windows.Forms.Button();
            this.caracteres = new System.Windows.Forms.ListBox();
            this.ToX = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.initialList = new System.Windows.Forms.ComboBox();
            this.RmF = new System.Windows.Forms.Button();
            this.CopytoF = new System.Windows.Forms.Button();
            this.labelEtatsFinaux = new System.Windows.Forms.Label();
            this.labelEtats = new System.Windows.Forms.Label();
            this.EtatsFList = new System.Windows.Forms.ListBox();
            this.EtatsList = new System.Windows.Forms.ListBox();
            this.NbEtatLabel = new System.Windows.Forms.Label();
            this.Nbetats = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.annuler = new System.Windows.Forms.Button();
            this.Valider2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MotLu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Ajouter = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.supprimer = new System.Windows.Forms.Button();
            this.transitions = new System.Windows.Forms.ListBox();
            this.SJ = new System.Windows.Forms.ListBox();
            this.SiXSj = new System.Windows.Forms.ListBox();
            this.SI = new System.Windows.Forms.ListBox();
            this.Name_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nbetats)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Modifier1);
            this.panel1.Controls.Add(this.Valide1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(48, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 222);
            this.panel1.TabIndex = 29;
            // 
            // Modifier1
            // 
            this.Modifier1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modifier1.Location = new System.Drawing.Point(10, 184);
            this.Modifier1.Name = "Modifier1";
            this.Modifier1.Size = new System.Drawing.Size(172, 31);
            this.Modifier1.TabIndex = 32;
            this.Modifier1.Text = "Modifier entrées";
            this.Modifier1.UseVisualStyleBackColor = true;
            this.Modifier1.Click += new System.EventHandler(this.Modifier1_Click);
            // 
            // Valide1
            // 
            this.Valide1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Valide1.Location = new System.Drawing.Point(186, 184);
            this.Valide1.Name = "Valide1";
            this.Valide1.Size = new System.Drawing.Size(201, 31);
            this.Valide1.TabIndex = 31;
            this.Valide1.Text = "Valider les entrées";
            this.Valide1.UseVisualStyleBackColor = true;
            this.Valide1.Click += new System.EventHandler(this.Valide1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Xlist);
            this.groupBox3.Controls.Add(this.RmX);
            this.groupBox3.Controls.Add(this.caracteres);
            this.groupBox3.Controls.Add(this.ToX);
            this.groupBox3.Location = new System.Drawing.Point(10, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 174);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "L\'alphabet :";
            // 
            // Xlist
            // 
            this.Xlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Xlist.FormattingEnabled = true;
            this.Xlist.Location = new System.Drawing.Point(82, 48);
            this.Xlist.Name = "Xlist";
            this.Xlist.Size = new System.Drawing.Size(47, 106);
            this.Xlist.Sorted = true;
            this.Xlist.TabIndex = 11;
            this.Xlist.SelectedIndexChanged += new System.EventHandler(this.Xlist_SelectedIndexChanged);
            this.Xlist.DoubleClick += new System.EventHandler(this.Xlist_DoubleClick);
            // 
            // RmX
            // 
            this.RmX.AutoSize = true;
            this.RmX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RmX.Enabled = false;
            this.RmX.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.RmX.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.RmX.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.RmX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RmX.Image = global::Automates.Properties.Resources.action_back1;
            this.RmX.Location = new System.Drawing.Point(57, 79);
            this.RmX.Name = "RmX";
            this.RmX.Size = new System.Drawing.Size(24, 25);
            this.RmX.TabIndex = 15;
            this.RmX.UseVisualStyleBackColor = true;
            this.RmX.Click += new System.EventHandler(this.RmX_Click);
            // 
            // caracteres
            // 
            this.caracteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caracteres.FormattingEnabled = true;
            this.caracteres.Location = new System.Drawing.Point(14, 48);
            this.caracteres.Name = "caracteres";
            this.caracteres.Size = new System.Drawing.Size(43, 106);
            this.caracteres.Sorted = true;
            this.caracteres.TabIndex = 10;
            this.caracteres.SelectedIndexChanged += new System.EventHandler(this.caracteres_SelectedIndexChanged);
            this.caracteres.DoubleClick += new System.EventHandler(this.caracteres_DoubleClick);
            // 
            // ToX
            // 
            this.ToX.AutoSize = true;
            this.ToX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToX.Enabled = false;
            this.ToX.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ToX.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.ToX.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.ToX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToX.Image = global::Automates.Properties.Resources.action_forward1;
            this.ToX.Location = new System.Drawing.Point(57, 48);
            this.ToX.Name = "ToX";
            this.ToX.Size = new System.Drawing.Size(24, 25);
            this.ToX.TabIndex = 14;
            this.ToX.UseVisualStyleBackColor = true;
            this.ToX.Click += new System.EventHandler(this.ToX_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.initialList);
            this.groupBox1.Controls.Add(this.RmF);
            this.groupBox1.Controls.Add(this.CopytoF);
            this.groupBox1.Controls.Add(this.labelEtatsFinaux);
            this.groupBox1.Controls.Add(this.labelEtats);
            this.groupBox1.Controls.Add(this.EtatsFList);
            this.groupBox1.Controls.Add(this.EtatsList);
            this.groupBox1.Controls.Add(this.NbEtatLabel);
            this.groupBox1.Controls.Add(this.Nbetats);
            this.groupBox1.Location = new System.Drawing.Point(10, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 174);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Etat initial:";
            // 
            // initialList
            // 
            this.initialList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.initialList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.initialList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initialList.FormattingEnabled = true;
            this.initialList.Location = new System.Drawing.Point(277, 141);
            this.initialList.Name = "initialList";
            this.initialList.Size = new System.Drawing.Size(92, 21);
            this.initialList.Sorted = true;
            this.initialList.TabIndex = 9;
            this.initialList.SelectedIndexChanged += new System.EventHandler(this.initialList_SelectedIndexChanged);
            // 
            // RmF
            // 
            this.RmF.AutoSize = true;
            this.RmF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RmF.Enabled = false;
            this.RmF.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.RmF.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.RmF.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.RmF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RmF.Image = global::Automates.Properties.Resources.action_back1;
            this.RmF.Location = new System.Drawing.Point(247, 84);
            this.RmF.Name = "RmF";
            this.RmF.Size = new System.Drawing.Size(24, 25);
            this.RmF.TabIndex = 8;
            this.RmF.UseVisualStyleBackColor = true;
            this.RmF.Click += new System.EventHandler(this.RmF_Click);
            // 
            // CopytoF
            // 
            this.CopytoF.AutoSize = true;
            this.CopytoF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopytoF.Enabled = false;
            this.CopytoF.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.CopytoF.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.CopytoF.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.CopytoF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopytoF.Image = global::Automates.Properties.Resources.action_forward1;
            this.CopytoF.Location = new System.Drawing.Point(247, 53);
            this.CopytoF.Name = "CopytoF";
            this.CopytoF.Size = new System.Drawing.Size(24, 25);
            this.CopytoF.TabIndex = 6;
            this.CopytoF.UseVisualStyleBackColor = true;
            this.CopytoF.Click += new System.EventHandler(this.CopytoF_Click);
            // 
            // labelEtatsFinaux
            // 
            this.labelEtatsFinaux.AutoSize = true;
            this.labelEtatsFinaux.Location = new System.Drawing.Point(274, 35);
            this.labelEtatsFinaux.Name = "labelEtatsFinaux";
            this.labelEtatsFinaux.Size = new System.Drawing.Size(65, 13);
            this.labelEtatsFinaux.TabIndex = 5;
            this.labelEtatsFinaux.Text = "Etats finaux:";
            // 
            // labelEtats
            // 
            this.labelEtats.AutoSize = true;
            this.labelEtats.Location = new System.Drawing.Point(147, 35);
            this.labelEtats.Name = "labelEtats";
            this.labelEtats.Size = new System.Drawing.Size(37, 13);
            this.labelEtats.TabIndex = 4;
            this.labelEtats.Text = "Etats :";
            // 
            // EtatsFList
            // 
            this.EtatsFList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EtatsFList.FormattingEnabled = true;
            this.EtatsFList.Location = new System.Drawing.Point(277, 55);
            this.EtatsFList.Name = "EtatsFList";
            this.EtatsFList.Size = new System.Drawing.Size(92, 67);
            this.EtatsFList.Sorted = true;
            this.EtatsFList.TabIndex = 3;
            this.EtatsFList.DoubleClick += new System.EventHandler(this.EtatsFList_DoubleClick);
            // 
            // EtatsList
            // 
            this.EtatsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EtatsList.FormattingEnabled = true;
            this.EtatsList.Location = new System.Drawing.Point(147, 51);
            this.EtatsList.Name = "EtatsList";
            this.EtatsList.Size = new System.Drawing.Size(91, 106);
            this.EtatsList.TabIndex = 2;
            this.EtatsList.SelectedIndexChanged += new System.EventHandler(this.EtatsList_SelectedIndexChanged);
            this.EtatsList.DoubleClick += new System.EventHandler(this.EtatsList_DoubleClick);
            // 
            // NbEtatLabel
            // 
            this.NbEtatLabel.AutoSize = true;
            this.NbEtatLabel.Location = new System.Drawing.Point(147, 15);
            this.NbEtatLabel.Name = "NbEtatLabel";
            this.NbEtatLabel.Size = new System.Drawing.Size(87, 13);
            this.NbEtatLabel.TabIndex = 1;
            this.NbEtatLabel.Text = "Nombre d\'états : ";
            // 
            // Nbetats
            // 
            this.Nbetats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nbetats.Location = new System.Drawing.Point(244, 11);
            this.Nbetats.Name = "Nbetats";
            this.Nbetats.Size = new System.Drawing.Size(125, 20);
            this.Nbetats.TabIndex = 0;
            this.Nbetats.ValueChanged += new System.EventHandler(this.Nbetats_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.annuler);
            this.panel2.Controls.Add(this.Valider2);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(48, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 222);
            this.panel2.TabIndex = 30;
            // 
            // annuler
            // 
            this.annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annuler.Location = new System.Drawing.Point(9, 186);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(179, 31);
            this.annuler.TabIndex = 30;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // Valider2
            // 
            this.Valider2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Valider2.Enabled = false;
            this.Valider2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Valider2.Location = new System.Drawing.Point(194, 186);
            this.Valider2.Name = "Valider2";
            this.Valider2.Size = new System.Drawing.Size(194, 31);
            this.Valider2.TabIndex = 29;
            this.Valider2.Text = "Valider l\'automate";
            this.Valider2.UseVisualStyleBackColor = true;
            this.Valider2.Click += new System.EventHandler(this.Valider2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MotLu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Ajouter);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.SJ);
            this.groupBox2.Controls.Add(this.SiXSj);
            this.groupBox2.Controls.Add(this.SI);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(2, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 174);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // MotLu
            // 
            this.MotLu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MotLu.Location = new System.Drawing.Point(97, 111);
            this.MotLu.Name = "MotLu";
            this.MotLu.Size = new System.Drawing.Size(43, 20);
            this.MotLu.TabIndex = 23;
            this.MotLu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Sj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "char lu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Si";
            // 
            // Ajouter
            // 
            this.Ajouter.Enabled = false;
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Location = new System.Drawing.Point(26, 134);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(181, 27);
            this.Ajouter.TabIndex = 19;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.supprimer);
            this.groupBox4.Controls.Add(this.transitions);
            this.groupBox4.Location = new System.Drawing.Point(213, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 174);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Instructions";
            // 
            // supprimer
            // 
            this.supprimer.Enabled = false;
            this.supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimer.Location = new System.Drawing.Point(14, 141);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(151, 27);
            this.supprimer.TabIndex = 20;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // transitions
            // 
            this.transitions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transitions.Enabled = false;
            this.transitions.FormattingEnabled = true;
            this.transitions.Location = new System.Drawing.Point(14, 29);
            this.transitions.Name = "transitions";
            this.transitions.Size = new System.Drawing.Size(151, 106);
            this.transitions.Sorted = true;
            this.transitions.TabIndex = 19;
            this.transitions.SelectedIndexChanged += new System.EventHandler(this.transitions_SelectedIndexChanged);
            // 
            // SJ
            // 
            this.SJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SJ.FormattingEnabled = true;
            this.SJ.Location = new System.Drawing.Point(151, 26);
            this.SJ.Name = "SJ";
            this.SJ.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SJ.Size = new System.Drawing.Size(58, 106);
            this.SJ.TabIndex = 17;
            this.SJ.SelectedIndexChanged += new System.EventHandler(this.SJ_SelectedIndexChanged);
            // 
            // SiXSj
            // 
            this.SiXSj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SiXSj.FormattingEnabled = true;
            this.SiXSj.Location = new System.Drawing.Point(97, 25);
            this.SiXSj.Name = "SiXSj";
            this.SiXSj.Size = new System.Drawing.Size(43, 80);
            this.SiXSj.Sorted = true;
            this.SiXSj.TabIndex = 16;
            this.SiXSj.SelectedIndexChanged += new System.EventHandler(this.SiXSj_SelectedIndexChanged);
            // 
            // SI
            // 
            this.SI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SI.FormattingEnabled = true;
            this.SI.Location = new System.Drawing.Point(26, 26);
            this.SI.Name = "SI";
            this.SI.Size = new System.Drawing.Size(59, 106);
            this.SI.TabIndex = 3;
            this.SI.SelectedIndexChanged += new System.EventHandler(this.SI_SelectedIndexChanged);
            // 
            // Name_box
            // 
            this.Name_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_box.Location = new System.Drawing.Point(159, 20);
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(136, 20);
            this.Name_box.TabIndex = 31;
            this.Name_box.TextChanged += new System.EventHandler(this.Name_box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nom : ";
            // 
            // GfaCreation
            // 
            this.CancelButton = this.annuler;
            this.ClientSize = new System.Drawing.Size(453, 521);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GfaCreation";
            this.Text = "Création de Gfa";
            this.Load += new System.EventHandler(this.Gfa_creation_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nbetats)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        private void Valide1_Click(object sender, EventArgs e)
        {

            
            if (!((EtatsFList.Items.Count > 0) & (Xlist.Items.Count > 0)))
            {
                MessageBox.Show("Verifier vos données !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserGfa.X.Clear();
            UserGfa.F.Clear();
            foreach (object car in Xlist.Items)
                UserGfa.X.Add(car);
            UserGfa.X.Add(Automata.EPSILON);
            UserGfa.S = (int)Nbetats.Value;
            UserGfa.S0 = initial;
            foreach (object etat in EtatsFList.Items)
                UserGfa.F.Add(ToInt((string)etat));

            Valider2.Enabled = true;
            groupBox1.Enabled = false;
            groupBox3.Enabled = false;
            groupBox2.Enabled = true;
            UserGfa.InitI();
        }

        private void Modifier1_Click(object sender, EventArgs e)
        {
            DialogResult resAlert;
            resAlert = MessageBox.Show("Voulez allez perdre vos instructions !", "alert !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resAlert == DialogResult.OK)
            {
                Valider2.Enabled = false;
                groupBox1.Enabled = true;
                groupBox3.Enabled = true;
                groupBox2.Enabled = false;
                transitions.Items.Clear();
                UserGfa.InitI();
            }
        }

        private void ToX_Click(object sender, EventArgs e)
        {
            if (!(caracteres.SelectedItem == null))
            {
                if (!Xlist.Items.Contains(caracteres.SelectedItem))
                {
                    Xlist.Items.Add(caracteres.SelectedItem);
                    SiXSj.Items.Add(caracteres.SelectedItem);
                    caracteres.Items.Remove(caracteres.SelectedItem);
                    string x = "X = {";
                    foreach (char car in Xlist.Items)
                        x += ((Char.Equals(car, (char)Xlist.Items[0])) ? " " : " , ") + car;
                    x += "}";
                    //labelX.Text = x;

                }
            }
        }

        private void RmX_Click(object sender, EventArgs e)
        {
            SiXSj.Items.Remove(Xlist.SelectedItem);
            caracteres.Items.Add(Xlist.SelectedItem);
            Xlist.Items.Remove(Xlist.SelectedItem);
            string x = "X = {";
            foreach (char car in Xlist.Items)
                x += ((Char.Equals(car, (char)Xlist.Items[0])) ? " " : " , ") + car;
            x += "}";
            //labelX.Text = x;
        }

        private void caracteres_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToX.Enabled = true;
        }

        private void Xlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            RmX.Enabled = true;
        }

        private void EtatsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Nbetats.Value > 0)
                CopytoF.Enabled = true;
        }

        private void EtatsFList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EtatsFList.Items.Count > 0)
                RmF.Enabled = true;
        }

        private void Nbetats_ValueChanged(object sender, EventArgs e)
        {
            EtatsList.Items.Clear();
            SI.Items.Clear();
            SJ.Items.Clear();
            initialList.Items.Clear();
            if (Nbetats.Value == 0)
                CopytoF.Enabled = false;
            string s = "S = {";
            for (int i = 0; i < Nbetats.Value; i++)
            {
                s += ((i == 0) ? " " : " , ") + "S" + i;
                EtatsList.Items.Add("S" + i);
                SI.Items.Add("S" + i);
                SJ.Items.Add("S" + i);
                initialList.Items.Add("S" + i);


            }
            s += "}";
            //labelS.Text = s;

            if (initialList.SelectedItem == null && EtatsList.Items.Count > 0)
                initialList.SelectedItem = EtatsList.Items[0];
            if (!EtatsList.Items.Contains(initialList.SelectedItem))
                initialList.SelectedItem = EtatsList.Items[0];
            bool nexist = false;
            object etat = null;
            foreach (object etatf in EtatsFList.Items)
                if (!EtatsList.Items.Contains(etatf))
                {
                    nexist = true;
                    etat = etatf;
                }
            if (nexist && (etat != null)) EtatsFList.Items.Remove(etat);






        }

        private void initialList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!EtatsList.Items.Contains(initialList.Text))
                initialList.Text = (string)EtatsList.Items[initial];
            else
                initial = EtatsList.Items.IndexOf(initialList.Text);
        }

        private void caracteres_DoubleClick(object sender, EventArgs e)
        {
            ToX_Click(sender, e);
        }

        private void Xlist_DoubleClick(object sender, EventArgs e)
        {
            ToX_Click(sender, e);
        }

        private void EtatsList_DoubleClick(object sender, EventArgs e)
        {
            if (EtatsList.SelectedItem != null && !EtatsFList.Items.Contains(EtatsList.SelectedItem))
                EtatsFList.Items.Add(EtatsList.SelectedItem);

            string f = "F = {";
            foreach (string etatf in EtatsFList.Items)
                f += ((Char.Equals(etatf, (string)EtatsFList.Items[0])) ? " " : " , ") + etatf;
            f += "}";
            //labelF.Text = f;
        }

        private void SI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((SI.SelectedItem != null) & (SJ.SelectedItem != null) & (SiXSj.SelectedItem != null))
            {
                Ajouter.Enabled = true;
                transitions.Enabled = true;
            }
        }

        private void CopytoF_Click(object sender, EventArgs e)
        {
            if (EtatsList.SelectedItem != null && !EtatsFList.Items.Contains(EtatsList.SelectedItem))
                EtatsFList.Items.Add(EtatsList.SelectedItem);

            string f = "F = {";
            foreach (string etatf in EtatsFList.Items)
                f += ((Char.Equals(etatf, (string)EtatsFList.Items[0])) ? " " : " , ") + etatf;
            f += "}";
            // labelF.Text = f;
        }

        private void RmF_Click(object sender, EventArgs e)
        {
            if (EtatsList.SelectedItem != null)
                EtatsFList.Items.Remove(EtatsFList.SelectedItem);

        }

        private void SiXSj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((SI.SelectedItem != null) & (SJ.SelectedItem != null) & (SiXSj.SelectedItem != null))
            {
                Ajouter.Enabled = true;
                transitions.Enabled = true;
            }
        }

        private void SJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((SI.SelectedItem != null) & (SJ.SelectedItem != null) & (SiXSj.SelectedItem != null))
            {
                Ajouter.Enabled = true;
                transitions.Enabled = true;
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            int Si = (int)SI.SelectedIndex;
            char car = (char)UserGfa.X[SiXSj.SelectedIndex];
            foreach (string j in SJ.SelectedItems)
            {
                int Sj = SJ.Items.IndexOf(j);
                GfaInstruction trip = new GfaInstruction(Si, car, Sj);

                if (instructionExists(trip)==-1)
                {
                    transitions.Items.Add(trip);
                    GfaTransitions.Add(trip);

                    
                }
            }
            if (MotLu.Text.Length > 0)
            {
                foreach (char x in MotLu.Text)
                    if (!SiXSj.Items.Contains(x))
                    {
                        MessageBox.Show("La lettre '" + x + "' n'est pas dans l'alphabet!");
                        return;
                    }
                foreach (string SjItem in SJ.SelectedItems)
                {
                    int Sj = SJ.Items.IndexOf(SjItem);
                    GfaInstruction trip = new GfaInstruction(Si, MotLu.Text, Sj);
                    if (instructionExists(trip) == -1)
                    {
                        transitions.Items.Add(trip);
                        GfaTransitions.Add(trip);
                        if (!UserGfa.Read.Contains(MotLu.Text))
                            UserGfa.Read.Add(MotLu.Text);
                    }
                }
                MotLu.Text = "";
            }

        }
        
        private int instructionExists(GfaInstruction instruction)
        {
            foreach (GfaInstruction inst in GfaTransitions)
                if (inst.Equals(instruction))
                    return GfaTransitions.IndexOf(inst);
            return -1;
        }
        private void transitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            supprimer.Enabled = true;
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (transitions.SelectedItem != null)
            {
                GfaInstruction trip = (GfaInstruction)transitions.SelectedItem;
                UserGfa.RemoveInstruction(trip);
                transitions.Items.Remove(trip);
            }
        }

        private void Valider2_Click(object sender, EventArgs e)
        {
            //UserGfa.InitII();
            UserGfa.X.Clear();
            UserGfa.F.Clear();
            foreach (object car in Xlist.Items)
                UserGfa.X.Add(car);
            UserGfa.X.Add(Automata.EPSILON);
            UserGfa.Read.AddRange((ArrayList)UserGfa.X.Clone());
            
            UserGfa.S = (int)Nbetats.Value;
            UserGfa.S0 = initial;
            foreach (object etat in EtatsFList.Items)
                UserGfa.F.Add(ToInt((string)etat));
            UserGfa.InitI();
            
            foreach (GfaInstruction instruction in GfaTransitions)
                UserGfa.AddInstruction(instruction);
            this.DialogResult = DialogResult.OK;
            this.Close();


            
        }

        public int ToInt(String etat)
        {
            for (int i = 0; i < 100; i++)
            {
                if (string.Equals("S" + i, etat))
                    return i;

            }
            return -1;
        }

        

        

        private void Gfa_creation_Load(object sender, EventArgs e)
        {
            for (char car = 'a'; car <= 'z'; car++)
                caracteres.Items.Add(car);
            for (char car = '0'; car <= '9'; car++)
                caracteres.Items.Add(car);
            
            SiXSj.Items.Add(Automata.EPSILON);
            UserGfa.InitI();
            

        }

        private void Name_box_TextChanged(object sender, EventArgs e)
        {
            UserGfa.Name = Name_box.Text;
        }

        private void annuler_Click(object sender, EventArgs e)
        {

        }

        private void EtatsFList_DoubleClick(object sender, EventArgs e)
        {
            if (EtatsList.SelectedItem != null)
                EtatsFList.Items.Remove(EtatsFList.SelectedItem);
        }
    }

    

}
