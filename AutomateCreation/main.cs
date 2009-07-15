using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.IO;

namespace Automates
{

    public partial class main : Form
    {
        public ArrayList Automates_list = new ArrayList();
        public Auto Selected;
        public int dragEtat;
        public bool clicked = false;
        public main()
        {
            InitializeComponent();
        }

        private void nouvDeterministeMI_Click(object sender, EventArgs e)
        {
            DfaCreation newDfa = new DfaCreation();
            newDfa.Name_box.Text = "Automate" + Automates_list.Count;

            if (newDfa.ShowDialog() == DialogResult.OK)
            {
                Auto UserAuto = new Auto(newDfa.UserDfa);
                UserAuto.type = Automata.TYPE.Dfa;
                AjouterDfa(UserAuto);
                
            }


        }


        private void nouvNonDeterministeMI_Click(object sender, EventArgs e)
        {
            NfaCreation newNfa = new NfaCreation();
            newNfa.Name_box.Text = "Automate" + Automates_list.Count;

            if (newNfa.ShowDialog() == DialogResult.OK)
            {
                Auto UserAuto = new Auto(newNfa.UserNfa);
                UserAuto.type = Automata.TYPE.Nfa;
                AjouterNfa(UserAuto);
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            Splash splash = new Splash();
            splash.ShowDialog();

        }

        private void Automates_tree_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                Selected = getautomate(Automates_tree.SelectedNode.Text);
                //////////////////////////////
                if (Selected.Automate == null) return;
                //////////////////////////////
                Grammer UserGrammer = new Grammer();
                switch (Selected.type)
                {
                    case Automata.TYPE.Dfa:
                        ((Dfa)Selected.Automate).Afficher_grid(transition_Grid);
                        ((Dfa)Selected.Automate).Draw(Drawpanel, true);
                        UserGrammer = ((Dfa)Selected.Automate).toGrammer();
                        GrammerRTF.Text = UserGrammer.ToString();
                        break;
                    case Automata.TYPE.Nfa:

                        ((Nfa)Selected.Automate).Afficher_grid(transition_Grid);
                        ((Nfa)Selected.Automate).Draw(Drawpanel, true);
                        UserGrammer = ((Nfa)Selected.Automate).toGrammer();
                        GrammerRTF.Text = UserGrammer.ToString();
                        break;
                    case Automata.TYPE.PGfa:
                        ((PGfa)Selected.Automate).Afficher_grid(transition_Grid);
                        ((PGfa)Selected.Automate).Draw(Drawpanel, true);
                        UserGrammer = ((PGfa)Selected.Automate).toGrammer();
                        GrammerRTF.Text = UserGrammer.ToString();
                        break;
                    case Automata.TYPE.Gfa:
                        ((Gfa)Selected.Automate).Afficher_grid(transition_Grid);
                        ((Gfa)Selected.Automate).Draw(Drawpanel, true);
                        try
                        {
                            UserGrammer = ((Gfa)Selected.Automate).toGrammer();
                        }
                        catch (Exception)
                        {
                            break;
                        }



                        break;
                    default:
                        break;


                }
                UserGrammer.AfficherGrammair(GrammerRTF);

                Type_label.Text = "L'automate : " + ((Automata)Selected.Automate).Name + "  de type : " + Selected.type.ToString();
            }
            catch (Exception)
            {
                Type_label.Text = "L'automate : " + ((Automata)Selected.Automate).Name + "  de type : " + Selected.type.ToString() + "!!!";
            }
        }


        private void refrech_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Selected.Automate != null)
                ((Automata)Selected.Automate).Draw(Drawpanel, fixe.Checked);

        }


        // retourne un automate selon le Name (nous avons choisi le nom comme id)
        public Auto getautomate(string Name)
        {
            foreach (Auto auto in Automates_list)
                if (((Automata)auto.Automate).Name == Name)
                    return auto;
            return new Auto(null);
        }


        private void ouvrirMI_Click(object sender, EventArgs e)
        {
            if (openAutoDialog.ShowDialog() != DialogResult.Cancel)
            {
                AutomateReader Reader = new AutomateReader();

                Auto Auto = Reader.read(openAutoDialog.FileName);
                switch (Auto.type)
                {
                    case Automata.TYPE.Dfa:
                        AjouterDfa(Auto);
                        break;
                    case Automata.TYPE.Nfa:
                        AjouterNfa(Auto);
                        break;
                    case Automata.TYPE.PGfa:
                        AjouterPGfa(Auto);
                        break;
                    case Automata.TYPE.Gfa:
                        AjouterGfa(Auto);
                        break;
                    default:
                        break;
                }




            }
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Save_ws_Click(object sender, EventArgs e)
        {
            if (Automates_list.Count == 0)
            {
                MessageBox.Show("Vous n'avez pas créer des automates \n votre workspace est vide !!", "Workspace vide !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (savews.ShowDialog() != DialogResult.Cancel)
                {
                    workspace WorkSpace = new workspace();
                    WorkSpace.save(Automates_list, savews.FileName);
                }
            }
        }

        private void Automates_tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            enregistrerMI.Enabled = true;
        }

        private void enregistrerMI_Click(object sender, EventArgs e)
        {
            if (saveAutomateDialog.ShowDialog() != DialogResult.Cancel)
            {
                AutomateSaver Saver = new AutomateSaver();
                Saver.Save((Automata)Selected.Automate, saveAutomateDialog.FileName);

            }
        }

        private void main_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void main_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void actualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Info("Actualiser le DrawPanel pour voire le dessin autrement !");
        }

        private void refrech2_MouseLeave(object sender, EventArgs e)
        {
            Info("");
        }

        private void Info(String Info)
        {
            info.Text = Info;
        }

        private void resetInfo(object sender, EventArgs e)
        {
            info.Text = "";
        }

        private void Pellipse_MouseHover(object sender, EventArgs e)
        {
            Info("Choisir ce mode pour voire les cercles des états alignées sur un ellipse");
        }

        private void fixe_MouseHover(object sender, EventArgs e)
        {
            Info("Choisir ce mode pour voire les cercles des états positionné sur des places prédéfinis (max 10 états) ");
        }

        private void Automates_tree_MouseHover(object sender, EventArgs e)
        {
            Info("Selectionner l'automate pour voire les détails");
        }

        

        public int getEtat(Point p) {
            int i = 0;
            bool found = false;
            for (; i < ((Automata)Selected.Automate).myPointArray.Length; i++)
            {
                Point pos = ((Automata)Selected.Automate).myPointArray[i];
                if (((p.X >= pos.X) && (p.X <= pos.X + 30)) && ((p.Y >= pos.Y) && (p.Y <= pos.Y + 30)))
                {
                    found = true;
                    break;
                }
            }
            if (found) return i;
            return -1;
            
        }

        private void nouvPartiellementGénéraliséMI_Click(object sender, EventArgs e)
        {

            PGfaCreation newPGfa = new PGfaCreation();
            newPGfa.Name_box.Text = "Automate" + Automates_list.Count;

            if (newPGfa.ShowDialog() == DialogResult.OK)
            {
                Auto UserAuto = new Auto(newPGfa.UserPGfa);
                UserAuto.type = Automata.TYPE.PGfa;
                AjouterPGfa(UserAuto);
            }

        }

        private void nouvGénéraliséMI_Click(object sender, EventArgs e)
        {
            GfaCreation newGfa = new GfaCreation();
            newGfa.Name_box.Text = "Automate" + Automates_list.Count;

            if (newGfa.ShowDialog() == DialogResult.OK)
            {
                Auto UserAuto = new Auto(newGfa.UserGfa);
                UserAuto.type = Automata.TYPE.Gfa;
                AjouterGfa(UserAuto);
            }

        }

        private void nouvFromGrammaireMI_Click(object sender, EventArgs e)
        {
            GrammerCreation GrammerForm = new GrammerCreation();
            if (GrammerForm.ShowDialog() == DialogResult.OK)
            {
                Gfa GGfa = GrammerForm.UserGrammer.toGfa();
                Auto UserAuto = new Auto(GGfa);
                UserAuto.type = Automata.TYPE.Gfa;
                ((Automata)UserAuto.Automate).Name = "Automate"+Automates_list.Count;
                AjouterGfa(UserAuto);
            }
            
            

        }

        private void tabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GrammerRTF_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Paint(object sender, PaintEventArgs e)
        {
            if (Selected.Automate != null)
                ((Automata)Selected.Automate).toGrammer().AfficherGrammair(GrammerRTF);
        }

        private void Actualiser_icon_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
            if (Selected.Automate != null)
                ((Automata)Selected.Automate).Draw(Drawpanel, fixe.Checked);
        }


        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process HelpProcess = new Process();
                HelpProcess.StartInfo.FileName = Directory.GetCurrentDirectory() + "/AutomateCreation.chm";
                HelpProcess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n " + Directory.GetCurrentDirectory() + @"\help.chm", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Tracer_btn_Click(object sender, EventArgs e)
        {
            Trace_result.Text = "";
            if (Selected.Automate != null)
            {
                if (((Automata)Selected.Automate).Recognize(Mot_test.Text))
                    Mot_test.BackColor = Color.GreenYellow;
                else
                    Mot_test.BackColor = Color.Pink;
                Trace_result.Text = ((Automata)Selected.Automate).trace(Mot_test.Text);
            }
        }

        private void Mot_test_TextChanged(object sender, EventArgs e)
        {
            Mot_test.BackColor = Color.White;
        }

        private void miroirMI_Click(object sender, EventArgs e)
        {
            if (Selected.Automate != null)
            {
                PGfa UserPGfa = new PGfa();

                UserPGfa = ((Automata)Selected.Automate).getMirror();
                UserPGfa.Name = "Automate" + Automates_list.Count;
                Auto UserAuto = new Auto(UserPGfa);
                UserAuto.type = Automata.TYPE.PGfa;
                AjouterPGfa(UserAuto);
            }
        }

        private void complementMI_Click(object sender, EventArgs e)
        {
            if (Selected.Automate != null)
            {
                Dfa UserDfa = new Dfa();

                UserDfa = ((Automata)Selected.Automate).getComplementary();
                UserDfa.Name = "Automate" + Automates_list.Count;
                Auto UserAuto = new Auto(UserDfa);
                UserAuto.type = Automata.TYPE.Dfa;
                AjouterDfa(UserAuto);
            }
        }

        private void itérationMI_Click(object sender, EventArgs e)
        {
            if (Selected.Automate != null)
            {
                PGfa UserPGfa = new PGfa();

                UserPGfa = ((Automata)Selected.Automate).getIteration();
                UserPGfa.Name = "Automate" + Automates_list.Count;
                Auto UserAuto = new Auto(UserPGfa);
                UserAuto.type = Automata.TYPE.PGfa;
                AjouterPGfa(UserAuto);

            }

        }

        private void itérationPositiveMI_Click(object sender, EventArgs e)
        {
            if (Selected.Automate != null)
            {
                PGfa UserPGfa = new PGfa();

                UserPGfa = ((Automata)Selected.Automate).getIterationPositive();
                UserPGfa.Name = "Automate" + Automates_list.Count;
                Auto UserAuto = new Auto(UserPGfa);
                UserAuto.type = Automata.TYPE.PGfa;
                AjouterPGfa(UserAuto);

            }

        }

        private void concaténationMI_Click(object sender, EventArgs e)
        {
            if (Automates_list.Count == 0)
                return;
            Two_Selector Selector = new Two_Selector();
            foreach (Auto automate in Automates_list)
            {
                Selector.listAuto1.Items.Add(automate.ToString());
                Selector.ListAuto2.Items.Add(automate.ToString());
            }
            Selector.listAuto1.SelectedIndex = 0;
            Selector.ListAuto2.SelectedIndex = 0;
            if (Selector.ShowDialog() == DialogResult.OK)
            {
                Auto Automate1 = getautomate(Selector.listAuto1.SelectedItem.ToString());
                Auto Automate2 = getautomate(Selector.ListAuto2.SelectedItem.ToString());

                PGfa UserPGfa = Automata.Concatenation(((Automata)Automate1.Automate), ((Automata)Automate2.Automate));

                UserPGfa = ((Automata)Selected.Automate).getIterationPositive();
                UserPGfa.Name = "Automate" + Automates_list.Count;
                Auto UserAuto = new Auto(UserPGfa);
                UserAuto.type = Automata.TYPE.PGfa;

                AjouterPGfa(UserAuto);

            }

        }

        private void unionMI_Click(object sender, EventArgs e)
        {
            if (Automates_list.Count == 0)
                return;
            Two_Selector Selector = new Two_Selector();
            foreach (Auto automate in Automates_list)
            {
                Selector.listAuto1.Items.Add(automate.ToString());
                Selector.ListAuto2.Items.Add(automate.ToString());
            }
            Selector.listAuto1.SelectedIndex = 0;
            Selector.ListAuto2.SelectedIndex = 0;
            if (Selector.ShowDialog() == DialogResult.OK)
            {
                Auto Automate1 = getautomate(Selector.listAuto1.SelectedItem.ToString());
                Auto Automate2 = getautomate(Selector.ListAuto2.SelectedItem.ToString());

                PGfa UserPGfa = Automata.Union(((Automata)Automate1.Automate), ((Automata)Automate2.Automate));

                UserPGfa = ((Automata)Selected.Automate).getIterationPositive();
                UserPGfa.Name = "Automate" + Automates_list.Count;
                Auto UserAuto = new Auto(UserPGfa);
                UserAuto.type = Automata.TYPE.PGfa;
                AjouterPGfa(UserAuto);
            }

        }
        public void AjouterNfa(Auto UserAuto)
        {
            if (UserAuto.Automate == null) return;
            Selected = UserAuto;
            

            Automates_list.Add(UserAuto);

            // l'automate Dfa 
            Dfa UserDfa = new Dfa();
            UserDfa = ((Nfa)UserAuto.Automate).toDfa();
            UserDfa.Name = ((Nfa)UserAuto.Automate).Name + "[Dfa]";

            Auto UserAuto_Dfa = new Auto(UserDfa);
            UserAuto_Dfa.type = Automata.TYPE.Dfa;
            Automates_list.Add(UserAuto_Dfa);

            // l'automate Nfa 
            Nfa UserNfa_ = new Nfa();
            UserNfa_ = ((Nfa)UserAuto.Automate).toNfa();
            UserNfa_.Name = ((Nfa)UserAuto.Automate).Name + "[Nfa]";

            Auto UserAuto_Nfa_ = new Auto(UserNfa_);
            UserAuto_Nfa_.type = Automata.TYPE.Nfa;
            Automates_list.Add(UserAuto_Nfa_);

            // l'automate PGfa 
            PGfa UserPGfa = new PGfa();
            UserPGfa = ((Nfa)UserAuto.Automate).toPGfa();
            UserPGfa.Name = ((Nfa)UserAuto.Automate).Name + "[PGfa]";

            Auto UserAuto_PGfa = new Auto(UserPGfa);
            UserAuto_PGfa.type = Automata.TYPE.PGfa;
            Automates_list.Add(UserAuto_PGfa);

            // l'automate Gfa 
            Gfa UserGfa = new Gfa();
            UserGfa = ((Nfa)UserAuto.Automate).toGfa();
            UserGfa.Name = ((Nfa)UserAuto.Automate).Name + "[Gfa]";

            Auto UserAuto_Gfa = new Auto(UserGfa);
            UserAuto_Gfa.type = Automata.TYPE.Gfa;
            Automates_list.Add(UserAuto_Gfa);


            // l'automate reduit
            Dfa UserDfa_reduit = new Dfa();
            UserDfa_reduit = ((Nfa)UserAuto.Automate).toReduced();
            UserDfa_reduit.Name = ((Nfa)UserAuto.Automate).Name + "[Reduit]";

            Auto UserAuto_DfaReduit = new Auto(UserDfa_reduit);
            UserAuto_DfaReduit.type = Automata.TYPE.Dfa;
            Automates_list.Add(UserAuto_DfaReduit);


            // l'automate complet
            Dfa UserDfa_complet = new Dfa();
            UserDfa_complet = ((Nfa)UserAuto.Automate).toComplete();
            UserDfa_complet.Name = ((Nfa)UserAuto.Automate).Name + "[Complet]";

            Auto UserAuto_DfaComplet = new Auto(UserDfa_complet);
            UserAuto_DfaComplet.type = Automata.TYPE.Dfa;
            Automates_list.Add(UserAuto_DfaComplet);


            TreeNode node_automate = new TreeNode(UserAuto.ToString());
            TreeNode node_automate_Dfa = new TreeNode(UserAuto_Dfa.ToString());
            TreeNode node_automate_Nfa = new TreeNode(UserAuto_Nfa_.ToString());
            TreeNode node_automate_PGfa = new TreeNode(UserAuto_PGfa.ToString());
            TreeNode node_automate_Gfa = new TreeNode(UserAuto_Gfa.ToString());
            TreeNode node_automate_DfaReduit = new TreeNode(UserAuto_DfaReduit.ToString());
            TreeNode node_automate_DfaComplet = new TreeNode(UserAuto_DfaComplet.ToString());
            node_automate.ContextMenuStrip = RightMenu;
            node_automate_Dfa.ContextMenuStrip = RightMenu;
            node_automate_Nfa.ContextMenuStrip = RightMenu;
            node_automate_PGfa.ContextMenuStrip = RightMenu;
            node_automate_Gfa.ContextMenuStrip = RightMenu;
            node_automate_DfaReduit.ContextMenuStrip = RightMenu;
            node_automate_DfaComplet.ContextMenuStrip = RightMenu;

            node_automate.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto.type);
            node_automate_Dfa.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_Dfa.type);
            node_automate_Nfa.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_Nfa_.type);
            node_automate_PGfa.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_PGfa.type);
            node_automate_Gfa.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_Gfa.type);
            node_automate_DfaReduit.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_DfaReduit.type);
            node_automate_DfaComplet.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_DfaComplet.type);

            node_automate.Nodes.Add(node_automate_Dfa);
            node_automate.Nodes.Add(node_automate_Nfa);
            node_automate.Nodes.Add(node_automate_PGfa);
            node_automate.Nodes.Add(node_automate_Gfa);
            node_automate.Nodes.Add(node_automate_DfaReduit);
            node_automate.Nodes.Add(node_automate_DfaComplet);
            Automates_tree.Nodes.Add(node_automate);

            //node_automate.Nodes.Add(node_automate);
            node_automate.Expand();

            ((Nfa)UserAuto.Automate).Draw(Drawpanel, true);
            ((Nfa)UserAuto.Automate).Afficher_grid(transition_Grid);
            Type_label.Text = "L'automate : " + ((Automata)Selected.Automate).Name + "  de type : " + Selected.type.ToString();
            Drawpanel.Refresh();


        }

        public void AjouterDfa(Auto UserAuto) {
            if (UserAuto.Automate == null) return;
            Selected = UserAuto;

            Automates_list.Add(UserAuto);

            // l'automate Dfa 
            Dfa UserDfa_ = new Dfa();
            UserDfa_ = ((Dfa)UserAuto.Automate).toDfa();
            UserDfa_.Name = ((Dfa)UserAuto.Automate).Name + "[Dfa]";

            Auto UserAuto_Dfa_ = new Auto(UserDfa_);
            UserAuto_Dfa_.type = Automata.TYPE.Dfa;
            Automates_list.Add(UserAuto_Dfa_);

            // l'automate Nfa 
            Nfa UserNfa_ = new Nfa();
            UserNfa_ = ((Dfa)UserAuto.Automate).toNfa();
            UserNfa_.Name = ((Dfa)UserAuto.Automate).Name + "[Nfa]";

            Auto UserAuto_Nfa_ = new Auto(UserNfa_);
            UserAuto_Nfa_.type = Automata.TYPE.Nfa;
            Automates_list.Add(UserAuto_Nfa_);

            // l'automate PGfa 
            PGfa UserPGfa = new PGfa();
            UserPGfa = ((Dfa)UserAuto.Automate).toPGfa();
            UserPGfa.Name = ((Dfa)UserAuto.Automate).Name + "[PGfa]";

            Auto UserAuto_PGfa = new Auto(UserPGfa);
            UserAuto_PGfa.type = Automata.TYPE.PGfa;
            Automates_list.Add(UserAuto_PGfa);

            // l'automate Gfa 
            Gfa UserGfa = new Gfa();
            UserGfa = ((Dfa)UserAuto.Automate).toGfa();
            UserGfa.Name = ((Dfa)UserAuto.Automate).Name + "[Gfa]";

            Auto UserAuto_Gfa = new Auto(UserGfa);
            UserAuto_Gfa.type = Automata.TYPE.Gfa;
            Automates_list.Add(UserAuto_Gfa);


            // l'automate reduit
            Dfa UserDfa_reduit = new Dfa();
            UserDfa_reduit = ((Dfa)UserAuto.Automate).toReduced();
            UserDfa_reduit.Name = ((Dfa)UserAuto.Automate).Name + "[Reduit]";

            Auto UserAuto_DfaReduit = new Auto(UserDfa_reduit);
            UserAuto_DfaReduit.type = Automata.TYPE.Dfa;
            Automates_list.Add(UserAuto_DfaReduit);


            // l'automate complet
            Dfa UserDfa_complet = new Dfa();
            UserDfa_complet = ((Dfa)UserAuto.Automate).toComplete();
            UserDfa_complet.Name = ((Dfa)UserAuto.Automate).Name + "[Complet]";

            Auto UserAuto_DfaComplet = new Auto(UserDfa_complet);
            UserAuto_DfaComplet.type = Automata.TYPE.Dfa;
            Automates_list.Add(UserAuto_DfaComplet);


            TreeNode node_automate = new TreeNode(UserAuto.ToString());
            TreeNode node_automate_Dfa = new TreeNode(UserAuto_Dfa_.ToString());
            TreeNode node_automate_Nfa = new TreeNode(UserAuto_Nfa_.ToString());
            TreeNode node_automate_PGfa = new TreeNode(UserAuto_PGfa.ToString());
            TreeNode node_automate_Gfa = new TreeNode(UserAuto_Gfa.ToString());
            TreeNode node_automate_DfaReduit = new TreeNode(UserAuto_DfaReduit.ToString());
            TreeNode node_automate_DfaComplet = new TreeNode(UserAuto_DfaComplet.ToString());

            node_automate.ContextMenuStrip = RightMenu;
            node_automate_Dfa.ContextMenuStrip = RightMenu;
            node_automate_Nfa.ContextMenuStrip = RightMenu;
            node_automate_PGfa.ContextMenuStrip = RightMenu;
            node_automate_Gfa.ContextMenuStrip = RightMenu;
            node_automate_DfaReduit.ContextMenuStrip = RightMenu;
            node_automate_DfaComplet.ContextMenuStrip = RightMenu;

            node_automate.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto.type);
            node_automate_Dfa.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_Dfa_.type);
            node_automate_Nfa.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_Nfa_.type);
            node_automate_PGfa.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_PGfa.type);
            node_automate_Gfa.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_Gfa.type);
            node_automate_DfaReduit.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_DfaReduit.type);
            node_automate_DfaComplet.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_DfaComplet.type);

            node_automate.Nodes.Add(node_automate_Dfa);
            node_automate.Nodes.Add(node_automate_Nfa);
            node_automate.Nodes.Add(node_automate_PGfa);
            node_automate.Nodes.Add(node_automate_Gfa);
            node_automate.Nodes.Add(node_automate_DfaReduit);
            node_automate.Nodes.Add(node_automate_DfaComplet);
            Automates_tree.Nodes.Add(node_automate);

            //node_automate.Nodes.Add(node_automate);
            node_automate.Expand();

            ((Dfa)UserAuto.Automate).Draw(Drawpanel, true);
            ((Dfa)UserAuto.Automate).Afficher_grid(transition_Grid);
            Type_label.Text = "L'automate : " + ((Automata)Selected.Automate).Name + "  de type : " + Selected.type.ToString();
            Drawpanel.Refresh();
        
        
        }

        public void AjouterPGfa(Auto UserAuto) {
            if (UserAuto.Automate == null) return;
            Selected = UserAuto;

            Automates_list.Add(UserAuto);

            // l'automate Dfa 
            Dfa UserDfa = new Dfa();
            UserDfa = ((PGfa)UserAuto.Automate).toDfa();
            UserDfa.Name = ((PGfa)UserAuto.Automate).Name + "[Dfa]";

            Auto UserAuto_Dfa = new Auto(UserDfa);
            UserAuto_Dfa.type = Automata.TYPE.Dfa;
            Automates_list.Add(UserAuto_Dfa);

            // l'automate Nfa 
            Nfa UserNfa = new Nfa();
            UserNfa = ((PGfa)UserAuto.Automate).toNfa();
            UserNfa.Name = ((PGfa)UserAuto.Automate).Name + "[Nfa]";

            Auto UserAuto_Nfa = new Auto(UserNfa);
            UserAuto_Nfa.type = Automata.TYPE.Nfa;
            Automates_list.Add(UserAuto_Nfa);

            // l'automate PGfa 
            PGfa UserPGfa_ = new PGfa();
            UserPGfa_ = ((PGfa)UserAuto.Automate).toPGfa();
            UserPGfa_.Name = ((PGfa)UserAuto.Automate).Name + "[PGfa]";

            Auto UserAuto_PGfa_ = new Auto(UserPGfa_);
            UserAuto_PGfa_.type = Automata.TYPE.PGfa;
            Automates_list.Add(UserAuto_PGfa_);

            // l'automate Gfa 
            Gfa UserGfa = new Gfa();
            UserGfa = ((PGfa)UserAuto.Automate).toGfa();
            UserGfa.Name = ((PGfa)UserAuto.Automate).Name + "[Gfa]";

            Auto UserAuto_Gfa = new Auto(UserGfa);
            UserAuto_Gfa.type = Automata.TYPE.Gfa;
            Automates_list.Add(UserAuto_Gfa);


            // l'automate reduit
            Dfa UserDfa_reduit = new Dfa();
            UserDfa_reduit = ((PGfa)UserAuto.Automate).toReduced();
            UserDfa_reduit.Name = ((PGfa)UserAuto.Automate).Name + "[Reduit]";

            Auto UserAuto_DfaReduit = new Auto(UserDfa_reduit);
            UserAuto_DfaReduit.type = Automata.TYPE.Dfa;
            Automates_list.Add(UserAuto_DfaReduit);


            // l'automate complet
            Dfa UserDfa_complet = new Dfa();
            UserDfa_complet = ((PGfa)UserAuto.Automate).toComplete();
            UserDfa_complet.Name = ((PGfa)UserAuto.Automate).Name + "[Complet]";

            Auto UserAuto_DfaComplet = new Auto(UserDfa_complet);
            UserAuto_DfaComplet.type = Automata.TYPE.Dfa;
            Automates_list.Add(UserAuto_DfaComplet);


            TreeNode node_automate = new TreeNode(UserAuto.ToString());
            TreeNode node_automate_Dfa = new TreeNode(UserAuto_Dfa.ToString());
            TreeNode node_automate_Nfa = new TreeNode(UserAuto_Nfa.ToString());
            TreeNode node_automate_PGfa = new TreeNode(UserAuto_PGfa_.ToString());
            TreeNode node_automate_Gfa = new TreeNode(UserAuto_Gfa.ToString());
            TreeNode node_automate_DfaReduit = new TreeNode(UserAuto_DfaReduit.ToString());
            TreeNode node_automate_DfaComplet = new TreeNode(UserAuto_DfaComplet.ToString());

            node_automate.ContextMenuStrip = RightMenu;
            node_automate_Dfa.ContextMenuStrip = RightMenu;
            node_automate_Nfa.ContextMenuStrip = RightMenu;
            node_automate_PGfa.ContextMenuStrip = RightMenu;
            node_automate_Gfa.ContextMenuStrip = RightMenu;
            node_automate_DfaReduit.ContextMenuStrip = RightMenu;
            node_automate_DfaComplet.ContextMenuStrip = RightMenu;

            node_automate.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto.type);
            node_automate_Dfa.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_Dfa.type);
            node_automate_Nfa.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_Nfa.type);
            node_automate_PGfa.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_PGfa_.type);
            node_automate_Gfa.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_Gfa.type);
            node_automate_DfaReduit.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_DfaReduit.type);
            node_automate_DfaComplet.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_DfaComplet.type);

            node_automate.Nodes.Add(node_automate_Dfa);
            node_automate.Nodes.Add(node_automate_Nfa);
            node_automate.Nodes.Add(node_automate_PGfa);
            node_automate.Nodes.Add(node_automate_Gfa);
            node_automate.Nodes.Add(node_automate_DfaReduit);
            node_automate.Nodes.Add(node_automate_DfaComplet);
            Automates_tree.Nodes.Add(node_automate);

            //node_automate.Nodes.Add(node_automate);
            node_automate.Expand();

            ((PGfa)UserAuto.Automate).Draw(Drawpanel, true);
            ((PGfa)UserAuto.Automate).Afficher_grid(transition_Grid);
            Type_label.Text = "L'automate : " + ((Automata)Selected.Automate).Name + "  de type : " + Selected.type.ToString();
            Drawpanel.Refresh();
        }

        public void AjouterGfa(Auto UserAuto) {
            if (UserAuto.Automate == null) return;
            
            Selected = UserAuto;

            Automates_list.Add(UserAuto);

            // l'automate Dfa 
            Dfa UserDfa = new Dfa();
            UserDfa = ((Gfa)UserAuto.Automate).toDfa();
            UserDfa.Name = ((Gfa)UserAuto.Automate).Name + "[Dfa]";

            Auto UserAuto_Dfa = new Auto(UserDfa);
            UserAuto_Dfa.type = Automata.TYPE.Dfa;
            Automates_list.Add(UserAuto_Dfa);

            // l'automate Nfa 
            Nfa UserNfa = new Nfa();
            UserNfa = ((Gfa)UserAuto.Automate).toNfa();
            UserNfa.Name = ((Gfa)UserAuto.Automate).Name + "[Nfa]";

            Auto UserAuto_Nfa = new Auto(UserNfa);
            UserAuto_Nfa.type = Automata.TYPE.Nfa;
            Automates_list.Add(UserAuto_Nfa);

            // l'automate PGfa 
            PGfa UserPGfa = new PGfa();
            UserPGfa = ((Gfa)UserAuto.Automate).toPGfa();
            UserPGfa.Name = ((Gfa)UserAuto.Automate).Name + "[PGfa]";

            Auto UserAuto_PGfa = new Auto(UserPGfa);
            UserAuto_PGfa.type = Automata.TYPE.PGfa;
            Automates_list.Add(UserAuto_PGfa);

            // l'automate Gfa 
            Gfa UserGfa_ = new Gfa();
            UserGfa_ = ((Gfa)UserAuto.Automate).toGfa();
            UserGfa_.Name = ((Gfa)UserAuto.Automate).Name + "[Gfa]";

            Auto UserAuto_Gfa_ = new Auto(UserGfa_);
            UserAuto_Gfa_.type = Automata.TYPE.Gfa;
            Automates_list.Add(UserAuto_Gfa_);


            // l'automate reduit
            Dfa UserDfa_reduit = new Dfa();
            UserDfa_reduit = ((Gfa)UserAuto.Automate).toReduced();
            UserDfa_reduit.Name = ((Gfa)UserAuto.Automate).Name + "[Reduit]";

            Auto UserAuto_DfaReduit = new Auto(UserDfa_reduit);
            UserAuto_DfaReduit.type = Automata.TYPE.Dfa;
            Automates_list.Add(UserAuto_DfaReduit);


            // l'automate complet
            Dfa UserDfa_complet = new Dfa();
            UserDfa_complet = ((Gfa)UserAuto.Automate).toComplete();
            UserDfa_complet.Name = ((Gfa)UserAuto.Automate).Name + "[Complet]";

            Auto UserAuto_DfaComplet = new Auto(UserDfa_complet);
            UserAuto_DfaComplet.type = Automata.TYPE.Dfa;
            Automates_list.Add(UserAuto_DfaComplet);


            TreeNode node_automate = new TreeNode(UserAuto.ToString());
            TreeNode node_automate_Dfa = new TreeNode(UserAuto_Dfa.ToString());
            TreeNode node_automate_Nfa = new TreeNode(UserAuto_Nfa.ToString());
            TreeNode node_automate_PGfa = new TreeNode(UserAuto_PGfa.ToString());
            TreeNode node_automate_Gfa = new TreeNode(UserAuto_Gfa_.ToString());
            TreeNode node_automate_DfaReduit = new TreeNode(UserAuto_DfaReduit.ToString());
            TreeNode node_automate_DfaComplet = new TreeNode(UserAuto_DfaComplet.ToString());

            node_automate.ContextMenuStrip = RightMenu;
            node_automate_Dfa.ContextMenuStrip = RightMenu;
            node_automate_Nfa.ContextMenuStrip = RightMenu;
            node_automate_PGfa.ContextMenuStrip = RightMenu;
            node_automate_Gfa.ContextMenuStrip = RightMenu;
            node_automate_DfaReduit.ContextMenuStrip = RightMenu;
            node_automate_DfaComplet.ContextMenuStrip = RightMenu;


            node_automate.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto.type);
            node_automate_Dfa.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_Dfa.type);
            node_automate_Nfa.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_Nfa.type);
            node_automate_PGfa.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_PGfa.type);
            node_automate_Gfa.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_Gfa_.type);
            node_automate_DfaReduit.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_DfaReduit.type);
            node_automate_DfaComplet.ToolTipText = Enum.GetName(typeof(Automata.TYPE), UserAuto_DfaComplet.type);

            node_automate.Nodes.Add(node_automate_Dfa);
            node_automate.Nodes.Add(node_automate_Nfa);
            node_automate.Nodes.Add(node_automate_PGfa);
            node_automate.Nodes.Add(node_automate_Gfa);
            node_automate.Nodes.Add(node_automate_DfaReduit);
            node_automate.Nodes.Add(node_automate_DfaComplet);
            Automates_tree.Nodes.Add(node_automate);

            //node_automate.Nodes.Add(node_automate);
            node_automate.Expand();

            ((Gfa)UserAuto.Automate).Draw(Drawpanel, true);
            ((Gfa)UserAuto.Automate).Afficher_grid(transition_Grid);
            Type_label.Text = "L'automate : " + ((Automata)Selected.Automate).Name + "  de type : " + Selected.type.ToString();
            Drawpanel.Refresh();
        
        
        }

        private void quiterMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ouvrirUnWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openws.ShowDialog() != DialogResult.Cancel) {
                workspace WorkSpace = new workspace();
                ArrayList temp = new ArrayList(WorkSpace.read(openws.FileName));
                foreach (Auto auto in temp)
                {
                    switch (auto.type)
                    {
                        case Automata.TYPE.Dfa:
                            AjouterDfa(auto);
                            break;
                        case Automata.TYPE.Nfa:
                            AjouterNfa(auto);
                            break;
                        case Automata.TYPE.PGfa:
                            AjouterPGfa(auto);
                            break;
                        case Automata.TYPE.Gfa:
                            AjouterGfa(auto);
                            break;
                        default:
                            break;
                    }
                }
            
            
            
            }
        }

        private void aProposDuProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void Drawpanel_Paint(object sender, PaintEventArgs e)
        {
            if(Selected.Automate != null)
                ((Automata)Selected.Automate).Dessin.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        }

        private void Drawpanel_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        private void Drawpanel_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            dragEtat = getEtat(e.Location);
            label1.Text = dragEtat.ToString();
        }

        private void Drawpanel_MouseHover(object sender, EventArgs e)
        {
            
            
            
        }

        private void Drawpanel_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void Drawpanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (dragEtat != -1)
            {
                clicked = true;
                ((Automata)Selected.Automate).myPointArray[dragEtat] = (new Point(e.X, e.Y));
                ((Automata)Selected.Automate).DessinChanged = true;
                ((Automata)Selected.Automate).Draw(Drawpanel, fixe.Checked);
                label1.Text = e.X.ToString() + "   " + e.Y.ToString();
            }
            

        }

        private void Drawpanel_MouseMove(object sender, MouseEventArgs e)
        {

            if (clicked && (dragEtat!=-1))
            {
                ///todo : fix the border limites
                if ((((e.X+30) <= Drawpanel.Width) && ((e.Y+30) <= Drawpanel.Height)) && ((e.X >= 0) && (e.Y >= 0)))
                {
                    ((Automata)Selected.Automate).myPointArray[dragEtat] = (new Point(e.X, e.Y));
                    ((Automata)Selected.Automate).DessinChanged = true;
                    ((Automata)Selected.Automate).Draw(Drawpanel, fixe.Checked);
                    label1.Text = e.X.ToString() + "   " + e.Y.ToString() + " -> "+Drawpanel.Width + "  "+Drawpanel.Height;
                }
            }
        }

        private void fixe_CheckedChanged(object sender, EventArgs e)
        {
            ((Automata)Selected.Automate).DessinChanged = false;
        }



        private void sauvegarderLeDessinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveImage.ShowDialog() != DialogResult.Cancel) 
                if(((Automata)Selected.Automate) != null)
                    ((Automata)Selected.Automate).AutoImage.Save(saveImage.FileName);
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            if (saveGrammaire.ShowDialog() != DialogResult.Cancel)
                if (((Automata)Selected.Automate) != null)
                    saveRTF(GrammerRTF, saveGrammaire.FileName);
        }


        public void saveRTF(RichTextBox rtf, string path)
        {

            StreamWriter sw = null;

            if (File.Exists(path))
            {
                File.Delete(path);

            }

            // Le fichier n'existe pas. On le crée.
            sw = new StreamWriter(path);
            sw.WriteLine(rtf.Rtf);
            sw.Close();
            sw = null;


        }

        private void Automates_tree_Click(object sender, EventArgs e)
        {
            
        }

        private void Automates_tree_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void DessinRight_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(((TreeView)(((ToolStripMenuItem)sender).GetCurrentParent().Parent)).GetType().ToString());
            
            if (Automates_tree.SelectedNode == null)
                Automates_tree.SelectedNode = Automates_tree.Nodes[0];
            Selected = getautomate(Automates_tree.SelectedNode.Text);
            
            tabControl1.SelectedTab = tabControl1.TabPages[1];
            if (Selected.Automate != null)
                ((Automata)Selected.Automate).Draw(Drawpanel, fixe.Checked);     

        }

        private void Automates_tree_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void Automates_tree_MouseClick_2(object sender, MouseEventArgs e)
        {

        }

        private void OpenRight_Click(object sender, EventArgs e)
        {
            if (Automates_tree.SelectedNode == null)
                Automates_tree.SelectedNode = Automates_tree.Nodes[0];
            Selected = getautomate(Automates_tree.SelectedNode.Text);

            tabControl1.SelectedTab = tabControl1.TabPages[0];
            
        }

        private void GrammaireRight_Click(object sender, EventArgs e)
        {
            if (Automates_tree.SelectedNode == null)
                Automates_tree.SelectedNode = Automates_tree.Nodes[0];
            Selected = getautomate(Automates_tree.SelectedNode.Text);

            tabControl1.SelectedTab = tabControl1.TabPages[2];
        }
    
    }

    

}
