using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Automates
{
    public partial class GrammerCreation : Form
    {

        int initial = 0;
        public Grammer UserGrammer = new Grammer();


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
        private ComboBox Axiom;
        private Button RmF;
        private Button CopytoF;
        private Label V_label;
        private Label Variables_label;
        private ListBox VarsS_List;
        private ListBox Vars_List;
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
        private ListBox Productions;
        private ListBox VJ;
        private ListBox w;
        private ListBox VI;
        public TextBox Name_box;
        private Label label1;
        private Button annuler;
        private TextBox MotLu;

        public GrammerCreation()
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
            this.Axiom = new System.Windows.Forms.ComboBox();
            this.RmF = new System.Windows.Forms.Button();
            this.CopytoF = new System.Windows.Forms.Button();
            this.V_label = new System.Windows.Forms.Label();
            this.Variables_label = new System.Windows.Forms.Label();
            this.VarsS_List = new System.Windows.Forms.ListBox();
            this.Vars_List = new System.Windows.Forms.ListBox();
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
            this.Productions = new System.Windows.Forms.ListBox();
            this.VJ = new System.Windows.Forms.ListBox();
            this.w = new System.Windows.Forms.ListBox();
            this.VI = new System.Windows.Forms.ListBox();
            this.Name_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.Axiom);
            this.groupBox1.Controls.Add(this.RmF);
            this.groupBox1.Controls.Add(this.CopytoF);
            this.groupBox1.Controls.Add(this.V_label);
            this.groupBox1.Controls.Add(this.Variables_label);
            this.groupBox1.Controls.Add(this.VarsS_List);
            this.groupBox1.Controls.Add(this.Vars_List);
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
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "L\'axiom :";
            // 
            // Axiom
            // 
            this.Axiom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Axiom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Axiom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Axiom.FormattingEnabled = true;
            this.Axiom.Location = new System.Drawing.Point(277, 141);
            this.Axiom.Name = "Axiom";
            this.Axiom.Size = new System.Drawing.Size(92, 21);
            this.Axiom.Sorted = true;
            this.Axiom.TabIndex = 9;
            this.Axiom.SelectedIndexChanged += new System.EventHandler(this.Axiom_SelectedIndexChanged);
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
            this.RmF.Click += new System.EventHandler(this.RmV_Click);
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
            this.CopytoF.Click += new System.EventHandler(this.CopytoVar_Click);
            // 
            // V_label
            // 
            this.V_label.AutoSize = true;
            this.V_label.Location = new System.Drawing.Point(274, 35);
            this.V_label.Name = "V_label";
            this.V_label.Size = new System.Drawing.Size(20, 13);
            this.V_label.TabIndex = 5;
            this.V_label.Text = "V :";
            // 
            // Variables_label
            // 
            this.Variables_label.AutoSize = true;
            this.Variables_label.Location = new System.Drawing.Point(147, 35);
            this.Variables_label.Name = "Variables_label";
            this.Variables_label.Size = new System.Drawing.Size(56, 13);
            this.Variables_label.TabIndex = 4;
            this.Variables_label.Text = "Variables :";
            // 
            // VarsS_List
            // 
            this.VarsS_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VarsS_List.FormattingEnabled = true;
            this.VarsS_List.Location = new System.Drawing.Point(277, 55);
            this.VarsS_List.Name = "VarsS_List";
            this.VarsS_List.Size = new System.Drawing.Size(92, 67);
            this.VarsS_List.Sorted = true;
            this.VarsS_List.TabIndex = 3;
            // 
            // Vars_List
            // 
            this.Vars_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Vars_List.FormattingEnabled = true;
            this.Vars_List.Location = new System.Drawing.Point(147, 51);
            this.Vars_List.Name = "Vars_List";
            this.Vars_List.Size = new System.Drawing.Size(91, 106);
            this.Vars_List.TabIndex = 2;
            this.Vars_List.SelectedIndexChanged += new System.EventHandler(this.EtatsList_SelectedIndexChanged);
            this.Vars_List.DoubleClick += new System.EventHandler(this.EtatsList_DoubleClick);
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
            this.groupBox2.Controls.Add(this.VJ);
            this.groupBox2.Controls.Add(this.w);
            this.groupBox2.Controls.Add(this.VI);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(2, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 174);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            this.label6.Text = "Vj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "w";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Vi";
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
            this.groupBox4.Controls.Add(this.Productions);
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
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Productions";
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
            // Productions
            // 
            this.Productions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Productions.Enabled = false;
            this.Productions.FormattingEnabled = true;
            this.Productions.Location = new System.Drawing.Point(14, 29);
            this.Productions.Name = "Productions";
            this.Productions.Size = new System.Drawing.Size(151, 106);
            this.Productions.Sorted = true;
            this.Productions.TabIndex = 19;
            this.Productions.SelectedIndexChanged += new System.EventHandler(this.Productions_SelectedIndexChanged);
            // 
            // VJ
            // 
            this.VJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VJ.FormattingEnabled = true;
            this.VJ.Location = new System.Drawing.Point(151, 26);
            this.VJ.Name = "VJ";
            this.VJ.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.VJ.Size = new System.Drawing.Size(58, 106);
            this.VJ.TabIndex = 17;
            this.VJ.SelectedIndexChanged += new System.EventHandler(this.SJ_SelectedIndexChanged);
            // 
            // w
            // 
            this.w.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.w.FormattingEnabled = true;
            this.w.Location = new System.Drawing.Point(97, 25);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(43, 80);
            this.w.Sorted = true;
            this.w.TabIndex = 16;
            this.w.SelectedIndexChanged += new System.EventHandler(this.w_SelectedIndexChanged);
            // 
            // VI
            // 
            this.VI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VI.FormattingEnabled = true;
            this.VI.Location = new System.Drawing.Point(26, 26);
            this.VI.Name = "VI";
            this.VI.Size = new System.Drawing.Size(59, 106);
            this.VI.TabIndex = 3;
            this.VI.SelectedIndexChanged += new System.EventHandler(this.SI_SelectedIndexChanged);
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
            // GrammerCreation
            // 
            this.CancelButton = this.annuler;
            this.ClientSize = new System.Drawing.Size(453, 521);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GrammerCreation";
            this.Text = "Création de Grammer";
            this.Load += new System.EventHandler(this.Grammer_creation_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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


            if (!((VarsS_List.Items.Count > 0) & (Xlist.Items.Count > 0)))
            {
                MessageBox.Show("Verifier vos données !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserGrammer = new Grammer(new ArrayList(Xlist.Items), new ArrayList(VarsS_List.Items), (char)Axiom.SelectedItem);
            UserGrammer.X.Add(Automata.EPSILON);
            Valider2.Enabled = true;
            groupBox1.Enabled = false;
            groupBox3.Enabled = false;
            groupBox2.Enabled = true;
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
                Productions.Items.Clear();
                UserGrammer = new Grammer(new ArrayList(Xlist.Items), new ArrayList(Vars_List.Items), (char)Axiom.SelectedItem);
            }
        }

        private void ToX_Click(object sender, EventArgs e)
        {
            if (!(caracteres.SelectedItem == null))
            {
                if (!Xlist.Items.Contains(caracteres.SelectedItem))
                {
                    Xlist.Items.Add(caracteres.SelectedItem);
                    w.Items.Add(caracteres.SelectedItem);
                    caracteres.Items.Remove(caracteres.SelectedItem);
                }
            }
        }

        private void RmX_Click(object sender, EventArgs e)
        {
            w.Items.Remove(Xlist.SelectedItem);
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

        }

        private void EtatsFList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VarsS_List.Items.Count > 0)
                RmF.Enabled = true;
        }



        private void Axiom_SelectedIndexChanged(object sender, EventArgs e)
        {


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
            CopytoVar_Click(sender, e);
        }

        

        private void CopytoVar_Click(object sender, EventArgs e)
        {
            if (Vars_List.SelectedItem != null && !VarsS_List.Items.Contains(Vars_List.SelectedItem))
            {
                VarsS_List.Items.Add(Vars_List.SelectedItem);
                VI.Items.Add(Vars_List.SelectedItem);
                VJ.Items.Add(Vars_List.SelectedItem);
                Axiom.Items.Add(Vars_List.SelectedItem);
                Vars_List.Items.Remove(Vars_List.SelectedItem);
            }
            if (Axiom.SelectedItem == null)
                Axiom.SelectedItem = Axiom.Items[0];
        }

        private void RmV_Click(object sender, EventArgs e)
        {
            if (Vars_List.SelectedItem != null)
            {
                VarsS_List.Items.Remove(VarsS_List.SelectedItem);
                VI.Items.Remove(VarsS_List.SelectedItem);
                VJ.Items.Remove(VarsS_List.SelectedItem);
                Vars_List.Items.Add(VarsS_List.SelectedItem);
            }
        }

        private void w_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((VI.SelectedItem != null) & ((w.SelectedItem != null) || (MotLu.Text.Length > 0)))
            {
                Ajouter.Enabled = true;
                Productions.Enabled = true;
            }
        }
        private void SI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((VI.SelectedItem != null) & ((w.SelectedItem != null) || (MotLu.Text.Length > 0)))
            {
                Ajouter.Enabled = true;
                Productions.Enabled = true;
            }
        }
        private void SJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((VI.SelectedItem != null) & ((w.SelectedItem != null) || (MotLu.Text.Length > 0)))
            {
                Ajouter.Enabled = true;
                Productions.Enabled = true;
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {

            if (w.SelectedItems.Count > 0)
            {
                if (VJ.SelectedItems.Count == 0)
                {
                    string word = ((char)w.SelectedItem != Automata.EPSILON)?(w.SelectedItem.ToString()):("");

                    Grammer.ProductionRule prod = new Grammer.ProductionRule((char)VI.SelectedItem, word);
                    if (UserGrammer.AddProduction(prod) == 0)
                        Productions.Items.Add(prod);
                    

                }
                else
                {
                    string word = ((char)w.SelectedItem != Automata.EPSILON) ? (w.SelectedItem.ToString()) : ("");
                    foreach (char Vj in VJ.SelectedItems)
                    {
                        Grammer.ProductionRule prod = new Grammer.ProductionRule((char)VI.SelectedItem, word, Vj);
                        if (UserGrammer.AddProduction(prod) == 0)
                            Productions.Items.Add(prod);
                    }
                }
            }
            if (MotLu.Text.Length > 0)
            {
                string word = MotLu.Text;
                if (VJ.SelectedItems.Count == 0)
                {
                    Grammer.ProductionRule prod = new Grammer.ProductionRule((char)VI.SelectedItem, word);

                    switch (UserGrammer.AddProduction(prod))
                    {
                        case 0:
                            Productions.Items.Add(prod);
                            break;
                        case -3:
                            MessageBox.Show("Le mot contient un caractere qui n'appertient pas à l'alphabet definie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    foreach (char Vj in VJ.SelectedItems)
                    {
                        Grammer.ProductionRule prod = new Grammer.ProductionRule((char)VI.SelectedItem, word, Vj);

                        switch (UserGrammer.AddProduction(prod))
                        {
                            case 0:
                                Productions.Items.Add(prod);
                                break;
                            case -3:
                                MessageBox.Show("Le mot contient un caractere qui n'appertient pas à l'alphabet definie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            default:
                                break;
                        }
                    }

                }

            }
        }

        private void Productions_SelectedIndexChanged(object sender, EventArgs e)
        {
            supprimer.Enabled = true;
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (Productions.SelectedItem != null)
            {
                Grammer.ProductionRule prod = (Grammer.ProductionRule)Productions.SelectedItem;
                UserGrammer.RemoveProduction(prod);
                Productions.Items.Remove(prod);

            }
        }

        private void Valider2_Click(object sender, EventArgs e)
        {
            UserGrammer.toGfa();// teste de l'algorithme
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





        private void Grammer_creation_Load(object sender, EventArgs e)
        {
            for (char car = 'a'; car <= 'z'; car++)
                caracteres.Items.Add(car);
            for (char car = '0'; car <= '9'; car++)
                caracteres.Items.Add(car);

            w.Items.Add(Automata.EPSILON);
            for (char car = 'A'; car <= 'Z'; car++)
                Vars_List.Items.Add(car);


        }

        private void Name_box_TextChanged(object sender, EventArgs e)
        {
            UserGrammer.Name = Name_box.Text;
        }

        private void annuler_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }



}
