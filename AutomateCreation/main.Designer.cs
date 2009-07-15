namespace Automates
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Automates_tree = new System.Windows.Forms.TreeView();
            this.transition_Grid = new System.Windows.Forms.DataGridView();
            this.Drawpanel = new System.Windows.Forms.Panel();
            this.refrech = new System.Windows.Forms.LinkLabel();
            this.fixe = new System.Windows.Forms.RadioButton();
            this.Pellipse = new System.Windows.Forms.RadioButton();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.automateTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauMI = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvDeterministeMI = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvNonDeterministeMI = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvPartiellementGénéraliséMI = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvGénéraliséMI = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvFromGrammaireMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerMI = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderLeDessinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ouvrirUnWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_ws = new System.Windows.Forms.ToolStripMenuItem();
            this.separator = new System.Windows.Forms.ToolStripSeparator();
            this.quiterMI = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.miroirMI = new System.Windows.Forms.ToolStripMenuItem();
            this.complementMI = new System.Windows.Forms.ToolStripMenuItem();
            this.itérationMI = new System.Windows.Forms.ToolStripMenuItem();
            this.itérationPositiveMI = new System.Windows.Forms.ToolStripMenuItem();
            this.concaténationMI = new System.Windows.Forms.ToolStripMenuItem();
            this.unionMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDuProgrammeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.refrech2 = new System.Windows.Forms.LinkLabel();
            this.savews = new System.Windows.Forms.SaveFileDialog();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.info = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveAutomateDialog = new System.Windows.Forms.SaveFileDialog();
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.Actualiser_icon = new System.Windows.Forms.ToolStripButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openAutoDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Type_label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.GrammerRTF = new System.Windows.Forms.RichTextBox();
            this.test = new System.Windows.Forms.TabPage();
            this.Trace_result = new System.Windows.Forms.RichTextBox();
            this.Tracer_btn = new System.Windows.Forms.Button();
            this.Mot_test = new System.Windows.Forms.TextBox();
            this.openws = new System.Windows.Forms.OpenFileDialog();
            this.saveImage = new System.Windows.Forms.SaveFileDialog();
            this.saveGrammaire = new System.Windows.Forms.SaveFileDialog();
            this.RightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SupprimerRight = new System.Windows.Forms.ToolStripMenuItem();
            this.GrammaireRight = new System.Windows.Forms.ToolStripMenuItem();
            this.DessinRight = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenRight = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.transition_Grid)).BeginInit();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusbar.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.test.SuspendLayout();
            this.RightMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Automates_tree
            // 
            this.Automates_tree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Automates_tree.Location = new System.Drawing.Point(16, 138);
            this.Automates_tree.Name = "Automates_tree";
            this.Automates_tree.Size = new System.Drawing.Size(200, 442);
            this.Automates_tree.TabIndex = 2;
            this.Automates_tree.DoubleClick += new System.EventHandler(this.Automates_tree_DoubleClick);
            this.Automates_tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Automates_tree_AfterSelect);
            this.Automates_tree.MouseHover += new System.EventHandler(this.Automates_tree_MouseHover);
            this.Automates_tree.MouseLeave += new System.EventHandler(this.resetInfo);
            this.Automates_tree.Click += new System.EventHandler(this.Automates_tree_Click);
            // 
            // transition_Grid
            // 
            this.transition_Grid.AllowUserToAddRows = false;
            this.transition_Grid.AllowUserToDeleteRows = false;
            this.transition_Grid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.transition_Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.transition_Grid.BackgroundColor = System.Drawing.Color.White;
            this.transition_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.transition_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transition_Grid.Location = new System.Drawing.Point(0, 32);
            this.transition_Grid.Name = "transition_Grid";
            this.transition_Grid.ReadOnly = true;
            this.transition_Grid.RowHeadersWidth = 55;
            this.transition_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.transition_Grid.Size = new System.Drawing.Size(455, 439);
            this.transition_Grid.TabIndex = 3;
            // 
            // Drawpanel
            // 
            this.Drawpanel.BackColor = System.Drawing.Color.White;
            this.Drawpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Drawpanel.Location = new System.Drawing.Point(3, 97);
            this.Drawpanel.Name = "Drawpanel";
            this.Drawpanel.Size = new System.Drawing.Size(448, 268);
            this.Drawpanel.TabIndex = 4;
            this.Drawpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Drawpanel_Paint);
            this.Drawpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drawpanel_MouseMove);
            this.Drawpanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Drawpanel_MouseClick);
            this.Drawpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drawpanel_MouseDown);
            this.Drawpanel.MouseHover += new System.EventHandler(this.Drawpanel_MouseHover);
            this.Drawpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drawpanel_MouseUp);
            this.Drawpanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.Drawpanel_DragEnter);
            // 
            // refrech
            // 
            this.refrech.AutoSize = true;
            this.refrech.BackColor = System.Drawing.Color.Transparent;
            this.refrech.Image = global::Automates.Properties.Resources.page_refresh;
            this.refrech.Location = new System.Drawing.Point(36, 77);
            this.refrech.Name = "refrech";
            this.refrech.Size = new System.Drawing.Size(16, 13);
            this.refrech.TabIndex = 5;
            this.refrech.TabStop = true;
            this.refrech.Text = "   ";
            this.refrech.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refrech_LinkClicked);
            // 
            // fixe
            // 
            this.fixe.AutoSize = true;
            this.fixe.BackColor = System.Drawing.Color.Transparent;
            this.fixe.Checked = true;
            this.fixe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fixe.Location = new System.Drawing.Point(122, 75);
            this.fixe.Name = "fixe";
            this.fixe.Size = new System.Drawing.Size(77, 17);
            this.fixe.TabIndex = 6;
            this.fixe.TabStop = true;
            this.fixe.Text = "Pointx fixés";
            this.fixe.UseVisualStyleBackColor = false;
            this.fixe.MouseLeave += new System.EventHandler(this.resetInfo);
            this.fixe.CheckedChanged += new System.EventHandler(this.fixe_CheckedChanged);
            this.fixe.MouseHover += new System.EventHandler(this.fixe_MouseHover);
            // 
            // Pellipse
            // 
            this.Pellipse.AutoSize = true;
            this.Pellipse.BackColor = System.Drawing.Color.Transparent;
            this.Pellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pellipse.Location = new System.Drawing.Point(206, 75);
            this.Pellipse.Name = "Pellipse";
            this.Pellipse.Size = new System.Drawing.Size(153, 17);
            this.Pellipse.TabIndex = 7;
            this.Pellipse.Text = "Pointx alignés sur un ellipse";
            this.Pellipse.UseVisualStyleBackColor = false;
            this.Pellipse.MouseLeave += new System.EventHandler(this.resetInfo);
            this.Pellipse.CheckedChanged += new System.EventHandler(this.fixe_CheckedChanged);
            this.Pellipse.MouseHover += new System.EventHandler(this.Pellipse_MouseHover);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MainMenu.BackgroundImage = global::Automates.Properties.Resources.menu;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automateTSMI,
            this.operationsTSMI,
            this.HelpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenu.Size = new System.Drawing.Size(700, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // automateTSMI
            // 
            this.automateTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauMI,
            this.ouvrirMI,
            this.toolStripTextBox1,
            this.enregistrerMI,
            this.sauvegarderLeDessinToolStripMenuItem,
            this.toolStripSeparator1,
            this.ouvrirUnWorkspaceToolStripMenuItem,
            this.Save_ws,
            this.separator,
            this.quiterMI});
            this.automateTSMI.Name = "automateTSMI";
            this.automateTSMI.Size = new System.Drawing.Size(66, 20);
            this.automateTSMI.Text = "Automate";
            // 
            // nouveauMI
            // 
            this.nouveauMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvDeterministeMI,
            this.nouvNonDeterministeMI,
            this.nouvPartiellementGénéraliséMI,
            this.nouvGénéraliséMI,
            this.nouvFromGrammaireMI});
            this.nouveauMI.Image = global::Automates.Properties.Resources.page_edit;
            this.nouveauMI.Name = "nouveauMI";
            this.nouveauMI.Size = new System.Drawing.Size(270, 22);
            this.nouveauMI.Text = "Nouveau Automate...";
            // 
            // nouvDeterministeMI
            // 
            this.nouvDeterministeMI.Name = "nouvDeterministeMI";
            this.nouvDeterministeMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.nouvDeterministeMI.Size = new System.Drawing.Size(231, 22);
            this.nouvDeterministeMI.Text = "Deterministe";
            this.nouvDeterministeMI.Click += new System.EventHandler(this.nouvDeterministeMI_Click);
            // 
            // nouvNonDeterministeMI
            // 
            this.nouvNonDeterministeMI.Name = "nouvNonDeterministeMI";
            this.nouvNonDeterministeMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouvNonDeterministeMI.Size = new System.Drawing.Size(231, 22);
            this.nouvNonDeterministeMI.Text = "Non-Deterministe";
            this.nouvNonDeterministeMI.Click += new System.EventHandler(this.nouvNonDeterministeMI_Click);
            // 
            // nouvPartiellementGénéraliséMI
            // 
            this.nouvPartiellementGénéraliséMI.Name = "nouvPartiellementGénéraliséMI";
            this.nouvPartiellementGénéraliséMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.nouvPartiellementGénéraliséMI.Size = new System.Drawing.Size(231, 22);
            this.nouvPartiellementGénéraliséMI.Text = "Partiellement Généralisé";
            this.nouvPartiellementGénéraliséMI.Click += new System.EventHandler(this.nouvPartiellementGénéraliséMI_Click);
            // 
            // nouvGénéraliséMI
            // 
            this.nouvGénéraliséMI.Name = "nouvGénéraliséMI";
            this.nouvGénéraliséMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.nouvGénéraliséMI.Size = new System.Drawing.Size(231, 22);
            this.nouvGénéraliséMI.Text = "Généralisé";
            this.nouvGénéraliséMI.Click += new System.EventHandler(this.nouvGénéraliséMI_Click);
            // 
            // nouvFromGrammaireMI
            // 
            this.nouvFromGrammaireMI.Name = "nouvFromGrammaireMI";
            this.nouvFromGrammaireMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.nouvFromGrammaireMI.Size = new System.Drawing.Size(231, 22);
            this.nouvFromGrammaireMI.Text = "à partir d\'une Grammaire";
            this.nouvFromGrammaireMI.Click += new System.EventHandler(this.nouvFromGrammaireMI_Click);
            // 
            // ouvrirMI
            // 
            this.ouvrirMI.Image = global::Automates.Properties.Resources.book_open;
            this.ouvrirMI.Name = "ouvrirMI";
            this.ouvrirMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ouvrirMI.Size = new System.Drawing.Size(270, 22);
            this.ouvrirMI.Text = "Ouvrir...";
            this.ouvrirMI.Click += new System.EventHandler(this.ouvrirMI_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Image = global::Automates.Properties.Resources.page_white_word;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.toolStripTextBox1.Size = new System.Drawing.Size(270, 22);
            this.toolStripTextBox1.Text = "Exporter le grammaire en \"RTF\"";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // enregistrerMI
            // 
            this.enregistrerMI.Enabled = false;
            this.enregistrerMI.Image = global::Automates.Properties.Resources.page_save;
            this.enregistrerMI.Name = "enregistrerMI";
            this.enregistrerMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.enregistrerMI.Size = new System.Drawing.Size(270, 22);
            this.enregistrerMI.Text = "Enregistrer...";
            this.enregistrerMI.Click += new System.EventHandler(this.enregistrerMI_Click);
            // 
            // sauvegarderLeDessinToolStripMenuItem
            // 
            this.sauvegarderLeDessinToolStripMenuItem.Image = global::Automates.Properties.Resources.chart_line;
            this.sauvegarderLeDessinToolStripMenuItem.Name = "sauvegarderLeDessinToolStripMenuItem";
            this.sauvegarderLeDessinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.sauvegarderLeDessinToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.sauvegarderLeDessinToolStripMenuItem.Text = "Sauvegarder le dessin";
            this.sauvegarderLeDessinToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderLeDessinToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // ouvrirUnWorkspaceToolStripMenuItem
            // 
            this.ouvrirUnWorkspaceToolStripMenuItem.Image = global::Automates.Properties.Resources.box;
            this.ouvrirUnWorkspaceToolStripMenuItem.Name = "ouvrirUnWorkspaceToolStripMenuItem";
            this.ouvrirUnWorkspaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.O)));
            this.ouvrirUnWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.ouvrirUnWorkspaceToolStripMenuItem.Text = "Ouvrir un workspace";
            this.ouvrirUnWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.ouvrirUnWorkspaceToolStripMenuItem_Click);
            // 
            // Save_ws
            // 
            this.Save_ws.Name = "Save_ws";
            this.Save_ws.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.Save_ws.Size = new System.Drawing.Size(270, 22);
            this.Save_ws.Text = "Enregistrer le workspace ...";
            this.Save_ws.Click += new System.EventHandler(this.Save_ws_Click);
            // 
            // separator
            // 
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(267, 6);
            // 
            // quiterMI
            // 
            this.quiterMI.Name = "quiterMI";
            this.quiterMI.Size = new System.Drawing.Size(270, 22);
            this.quiterMI.Text = "Quitter";
            this.quiterMI.Click += new System.EventHandler(this.quiterMI_Click);
            // 
            // operationsTSMI
            // 
            this.operationsTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miroirMI,
            this.complementMI,
            this.itérationMI,
            this.itérationPositiveMI,
            this.concaténationMI,
            this.unionMI});
            this.operationsTSMI.Name = "operationsTSMI";
            this.operationsTSMI.Size = new System.Drawing.Size(72, 20);
            this.operationsTSMI.Text = "Operations";
            // 
            // miroirMI
            // 
            this.miroirMI.Image = global::Automates.Properties.Resources.arrow_undo;
            this.miroirMI.Name = "miroirMI";
            this.miroirMI.Size = new System.Drawing.Size(156, 22);
            this.miroirMI.Text = "Miroir";
            this.miroirMI.Click += new System.EventHandler(this.miroirMI_Click);
            // 
            // complementMI
            // 
            this.complementMI.Image = global::Automates.Properties.Resources.arrow_switch;
            this.complementMI.Name = "complementMI";
            this.complementMI.Size = new System.Drawing.Size(156, 22);
            this.complementMI.Text = "Complement";
            this.complementMI.Click += new System.EventHandler(this.complementMI_Click);
            // 
            // itérationMI
            // 
            this.itérationMI.Image = global::Automates.Properties.Resources.arrow_rotate_anticlockwise;
            this.itérationMI.Name = "itérationMI";
            this.itérationMI.Size = new System.Drawing.Size(156, 22);
            this.itérationMI.Text = "Itération";
            this.itérationMI.Click += new System.EventHandler(this.itérationMI_Click);
            // 
            // itérationPositiveMI
            // 
            this.itérationPositiveMI.Image = global::Automates.Properties.Resources.add;
            this.itérationPositiveMI.Name = "itérationPositiveMI";
            this.itérationPositiveMI.Size = new System.Drawing.Size(156, 22);
            this.itérationPositiveMI.Text = "Itération Positive";
            this.itérationPositiveMI.Click += new System.EventHandler(this.itérationPositiveMI_Click);
            // 
            // concaténationMI
            // 
            this.concaténationMI.Image = global::Automates.Properties.Resources.attach;
            this.concaténationMI.Name = "concaténationMI";
            this.concaténationMI.Size = new System.Drawing.Size(156, 22);
            this.concaténationMI.Text = "Concaténation";
            this.concaténationMI.Click += new System.EventHandler(this.concaténationMI_Click);
            // 
            // unionMI
            // 
            this.unionMI.Image = global::Automates.Properties.Resources.arrow_join;
            this.unionMI.Name = "unionMI";
            this.unionMI.Size = new System.Drawing.Size(156, 22);
            this.unionMI.Text = "Union";
            this.unionMI.Click += new System.EventHandler(this.unionMI_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideToolStripMenuItem,
            this.aProposDuProgrammeToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.HelpToolStripMenuItem.Text = "?";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Image = global::Automates.Properties.Resources.help;
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.aideToolStripMenuItem.Text = "Aide ";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // aProposDuProgrammeToolStripMenuItem
            // 
            this.aProposDuProgrammeToolStripMenuItem.Image = global::Automates.Properties.Resources.information;
            this.aProposDuProgrammeToolStripMenuItem.Name = "aProposDuProgrammeToolStripMenuItem";
            this.aProposDuProgrammeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.aProposDuProgrammeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.aProposDuProgrammeToolStripMenuItem.Text = "A propos du programme";
            this.aProposDuProgrammeToolStripMenuItem.Click += new System.EventHandler(this.aProposDuProgrammeToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Automates.Properties.Resources.body;
            this.pictureBox1.Location = new System.Drawing.Point(0, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // refrech2
            // 
            this.refrech2.AutoSize = true;
            this.refrech2.BackColor = System.Drawing.Color.Transparent;
            this.refrech2.Location = new System.Drawing.Point(51, 77);
            this.refrech2.Name = "refrech2";
            this.refrech2.Size = new System.Drawing.Size(53, 13);
            this.refrech2.TabIndex = 10;
            this.refrech2.TabStop = true;
            this.refrech2.Text = "Actualiser";
            this.refrech2.MouseLeave += new System.EventHandler(this.resetInfo);
            this.refrech2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refrech_LinkClicked);
            this.refrech2.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // savews
            // 
            this.savews.CheckFileExists = true;
            this.savews.CheckPathExists = false;
            this.savews.DefaultExt = "aws";
            this.savews.FileName = "Workspace.aws";
            this.savews.Filter = "Automates workspace files (*.aws)|*.aws";
            this.savews.Title = "Enregister le workspace sous ...";
            this.savews.ValidateNames = false;
            // 
            // statusbar
            // 
            this.statusbar.AutoSize = false;
            this.statusbar.BackgroundImage = global::Automates.Properties.Resources.footer;
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info});
            this.statusbar.Location = new System.Drawing.Point(0, 589);
            this.statusbar.Name = "statusbar";
            this.statusbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusbar.Size = new System.Drawing.Size(700, 30);
            this.statusbar.SizingGrip = false;
            this.statusbar.TabIndex = 11;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.ForeColor = System.Drawing.Color.Lavender;
            this.info.Image = global::Automates.Properties.Resources.information;
            this.info.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(241, 25);
            this.info.Text = "Créer un nouveau automate à partir du menu";
            // 
            // saveAutomateDialog
            // 
            this.saveAutomateDialog.DefaultExt = "aut";
            this.saveAutomateDialog.FileName = "automate.aut";
            this.saveAutomateDialog.Filter = "Automate files (*.aut)|*.aut";
            this.saveAutomateDialog.Title = "Sauvegarder l\'automate sous ..";
            this.saveAutomateDialog.ValidateNames = false;
            // 
            // Menu
            // 
            this.Menu.BackgroundImage = global::Automates.Properties.Resources.menu_r;
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Actualiser_icon});
            this.Menu.Location = new System.Drawing.Point(0, 24);
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu.Size = new System.Drawing.Size(700, 25);
            this.Menu.TabIndex = 12;
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // Actualiser_icon
            // 
            this.Actualiser_icon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Actualiser_icon.Image = global::Automates.Properties.Resources.page_refresh;
            this.Actualiser_icon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Actualiser_icon.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.Actualiser_icon.Name = "Actualiser_icon";
            this.Actualiser_icon.Size = new System.Drawing.Size(74, 22);
            this.Actualiser_icon.Text = "Actualiser";
            this.Actualiser_icon.Click += new System.EventHandler(this.Actualiser_icon_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Automates.Properties.Resources.Tree_bg;
            this.pictureBox3.Location = new System.Drawing.Point(15, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(203, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // openAutoDialog
            // 
            this.openAutoDialog.CheckFileExists = false;
            this.openAutoDialog.FileName = "openFileDialog1";
            this.openAutoDialog.Filter = "Automate files (*.aut)|*.aut";
            this.openAutoDialog.ShowReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.test);
            this.tabControl1.Location = new System.Drawing.Point(223, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(463, 484);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Type_label);
            this.tabPage1.Controls.Add(this.transition_Grid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(455, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "L\'automate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Type_label
            // 
            this.Type_label.AutoSize = true;
            this.Type_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_label.Location = new System.Drawing.Point(12, 7);
            this.Type_label.Name = "Type_label";
            this.Type_label.Size = new System.Drawing.Size(272, 19);
            this.Type_label.TabIndex = 4;
            this.Type_label.Text = "Ajouter ou selectionner un automate !";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Drawpanel);
            this.tabPage2.Controls.Add(this.refrech);
            this.tabPage2.Controls.Add(this.fixe);
            this.tabPage2.Controls.Add(this.Pellipse);
            this.tabPage2.Controls.Add(this.refrech2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(455, 455);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Le graph";
            this.tabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.GrammerRTF);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(455, 455);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "La grammaire";
            this.tabPage3.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage3_Paint);
            // 
            // GrammerRTF
            // 
            this.GrammerRTF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrammerRTF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrammerRTF.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrammerRTF.Location = new System.Drawing.Point(0, 0);
            this.GrammerRTF.Name = "GrammerRTF";
            this.GrammerRTF.ReadOnly = true;
            this.GrammerRTF.Size = new System.Drawing.Size(453, 453);
            this.GrammerRTF.TabIndex = 0;
            this.GrammerRTF.Text = "";
            this.GrammerRTF.TextChanged += new System.EventHandler(this.GrammerRTF_TextChanged);
            // 
            // test
            // 
            this.test.Controls.Add(this.Trace_result);
            this.test.Controls.Add(this.Tracer_btn);
            this.test.Controls.Add(this.Mot_test);
            this.test.Location = new System.Drawing.Point(4, 25);
            this.test.Name = "test";
            this.test.Padding = new System.Windows.Forms.Padding(3);
            this.test.Size = new System.Drawing.Size(455, 455);
            this.test.TabIndex = 1;
            this.test.Text = "Tester avec un mot";
            this.test.UseVisualStyleBackColor = true;
            // 
            // Trace_result
            // 
            this.Trace_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Trace_result.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trace_result.Location = new System.Drawing.Point(69, 104);
            this.Trace_result.Name = "Trace_result";
            this.Trace_result.ReadOnly = true;
            this.Trace_result.Size = new System.Drawing.Size(325, 211);
            this.Trace_result.TabIndex = 3;
            this.Trace_result.Text = "";
            // 
            // Tracer_btn
            // 
            this.Tracer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tracer_btn.Location = new System.Drawing.Point(154, 59);
            this.Tracer_btn.Name = "Tracer_btn";
            this.Tracer_btn.Size = new System.Drawing.Size(155, 32);
            this.Tracer_btn.TabIndex = 1;
            this.Tracer_btn.Text = "trace";
            this.Tracer_btn.UseVisualStyleBackColor = true;
            this.Tracer_btn.Click += new System.EventHandler(this.Tracer_btn_Click);
            // 
            // Mot_test
            // 
            this.Mot_test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mot_test.Location = new System.Drawing.Point(69, 28);
            this.Mot_test.Name = "Mot_test";
            this.Mot_test.Size = new System.Drawing.Size(325, 20);
            this.Mot_test.TabIndex = 0;
            this.Mot_test.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mot_test.TextChanged += new System.EventHandler(this.Mot_test_TextChanged);
            // 
            // openws
            // 
            this.openws.CheckFileExists = false;
            this.openws.FileName = "Workspace.aws";
            this.openws.Filter = "Automates workspace files (*.aws)|*.aws";
            // 
            // saveImage
            // 
            this.saveImage.DefaultExt = "jpeg";
            this.saveImage.FileName = "Automate.jpg";
            this.saveImage.Filter = "Automate files (*.jpg)|*.jpg";
            this.saveImage.Title = "Sauvegarder l\'image sous ..";
            this.saveImage.ValidateNames = false;
            // 
            // saveGrammaire
            // 
            this.saveGrammaire.DefaultExt = "rtf";
            this.saveGrammaire.FileName = "Grammaire.rtf";
            this.saveGrammaire.Filter = "Automate files (*.rtf)|*.rtf";
            this.saveGrammaire.Title = "exporter le grammaire ..";
            this.saveGrammaire.ValidateNames = false;
            // 
            // RightMenu
            // 
            this.RightMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenRight,
            this.DessinRight,
            this.GrammaireRight,
            this.SupprimerRight});
            this.RightMenu.Name = "RightMenu";
            this.RightMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.RightMenu.ShowImageMargin = false;
            this.RightMenu.Size = new System.Drawing.Size(194, 114);
            // 
            // SupprimerRight
            // 
            this.SupprimerRight.Enabled = false;
            this.SupprimerRight.Name = "SupprimerRight";
            this.SupprimerRight.Size = new System.Drawing.Size(193, 22);
            this.SupprimerRight.Text = "Supprimer";
            // 
            // GrammaireRight
            // 
            this.GrammaireRight.Name = "GrammaireRight";
            this.GrammaireRight.Size = new System.Drawing.Size(193, 22);
            this.GrammaireRight.Text = "Afficher le grammaire";
            this.GrammaireRight.Click += new System.EventHandler(this.GrammaireRight_Click);
            // 
            // DessinRight
            // 
            this.DessinRight.Name = "DessinRight";
            this.DessinRight.Size = new System.Drawing.Size(224, 22);
            this.DessinRight.Text = "Afficher le dessin";
            this.DessinRight.Click += new System.EventHandler(this.DessinRight_Click);
            // 
            // OpenRight
            // 
            this.OpenRight.Name = "OpenRight";
            this.OpenRight.Size = new System.Drawing.Size(193, 22);
            this.OpenRight.Text = "Afficher la table de transitions";
            this.OpenRight.Click += new System.EventHandler(this.OpenRight_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Automates.Properties.Resources.line;
            this.ClientSize = new System.Drawing.Size(700, 619);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Automates_tree);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "Automates (Tp de Théorie des languages)";
            this.Load += new System.EventHandler(this.main_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.main_KeyPress);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.transition_Grid)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.test.ResumeLayout(false);
            this.test.PerformLayout();
            this.RightMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem automateTSMI;
        private System.Windows.Forms.ToolStripMenuItem nouveauMI;
        private System.Windows.Forms.ToolStripMenuItem nouvDeterministeMI;
        private System.Windows.Forms.ToolStripMenuItem nouvNonDeterministeMI;
        private System.Windows.Forms.ToolStripMenuItem nouvPartiellementGénéraliséMI;
        private System.Windows.Forms.ToolStripMenuItem nouvGénéraliséMI;
        private System.Windows.Forms.ToolStripMenuItem nouvFromGrammaireMI;
        private System.Windows.Forms.ToolStripMenuItem ouvrirMI;
        private System.Windows.Forms.ToolStripMenuItem enregistrerMI;
        private System.Windows.Forms.ToolStripMenuItem Save_ws;
        private System.Windows.Forms.ToolStripSeparator separator;
        private System.Windows.Forms.ToolStripMenuItem quiterMI;
        private System.Windows.Forms.ToolStripMenuItem operationsTSMI;
        private System.Windows.Forms.ToolStripMenuItem miroirMI;
        private System.Windows.Forms.ToolStripMenuItem complementMI;
        private System.Windows.Forms.ToolStripMenuItem itérationMI;
        private System.Windows.Forms.ToolStripMenuItem itérationPositiveMI;
        private System.Windows.Forms.ToolStripMenuItem concaténationMI;
        private System.Windows.Forms.ToolStripMenuItem unionMI;
        private System.Windows.Forms.TreeView Automates_tree;
        private System.Windows.Forms.DataGridView transition_Grid;
        public System.Windows.Forms.Panel Drawpanel;
        private System.Windows.Forms.LinkLabel refrech;
        private System.Windows.Forms.RadioButton fixe;
        private System.Windows.Forms.RadioButton Pellipse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel refrech2;
        private System.Windows.Forms.SaveFileDialog savews;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.SaveFileDialog saveAutomateDialog;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripButton Actualiser_icon;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripStatusLabel info;
        private System.Windows.Forms.OpenFileDialog openAutoDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox GrammerRTF;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDuProgrammeToolStripMenuItem;
        private System.Windows.Forms.Label Type_label;
        private System.Windows.Forms.TabPage test;
        private System.Windows.Forms.Button Tracer_btn;
        private System.Windows.Forms.TextBox Mot_test;
        private System.Windows.Forms.RichTextBox Trace_result;
        private System.Windows.Forms.ToolStripMenuItem ouvrirUnWorkspaceToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openws;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderLeDessinToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveImage;
        private System.Windows.Forms.SaveFileDialog saveGrammaire;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1;
        private System.Windows.Forms.ContextMenuStrip RightMenu;
        private System.Windows.Forms.ToolStripMenuItem SupprimerRight;
        private System.Windows.Forms.ToolStripMenuItem GrammaireRight;
        private System.Windows.Forms.ToolStripMenuItem DessinRight;
        private System.Windows.Forms.ToolStripMenuItem OpenRight;
    }
}