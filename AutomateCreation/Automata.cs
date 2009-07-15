using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Automates;
using System.Drawing.Drawing2D;
using System.Drawing;

public abstract class Automata
{

    /// <summary>
    /// le mot vide  
    /// </summary>
    public const char EPSILON = 'ε';


    /// <summary>
    /// le nom de l'automate
    /// </summary>
    public String Name;


    /// <summary>
    /// le nombre des etats 
    /// </summary>
    public int S;


    /// <summary>
    /// l'etat initial
    /// </summary>
    public int S0;


    /// <summary>
    /// l'alphabet
    /// </summary>
    public ArrayList X = new ArrayList();


    /// <summary>
    ///les etats finaux 
    /// </summary>
    public ArrayList F = new ArrayList();

    /// <summary>
    /// la table de transitions
    /// </summary>
    protected ArrayList[,] I;

    // pour ne pas convertir un automate deja converti
    protected bool isConverted = false;

    /// <summary>
    /// Le plan de dessin 
    /// </summary>
    public Graphics Dessin;
    public Graphics grImage;
    public Bitmap AutoImage;

    /// <summary>
    /// le tableau des positions des etats dans le drawpanel
    /// </summary>
    public Point[] myPointArray;
    public bool DessinChanged;

    /// <summary>
    /// Enumuration des type des automates d'etats finis
    /// </summary>
    public enum TYPE
    {


        Dfa = 0, // automate d'etats finis deterministe
        Nfa = 1,// automate d'etats finis non deterministe
        PGfa = 2,// automate d'etats finis partialement généralisé
        Gfa = 3 // automate d'etats finis généralisé
    };

    // le type de l'automate
    protected TYPE AutType;

    /// <summary>
    /// Initialiser la table de transitions de l'automate
    /// </summary>
    public virtual void InitI()
    {

        this.I = new ArrayList[this.S, this.X.Count];
        for (int i = 0; i < this.S; i++)
            for (int j = 0; j < this.X.Count; j++)
                this.I[i, j] = new ArrayList();


    }


    /// <summary>
    /// Initiliser la table de transitions par des valeurs predefinies
    /// </summary>
    /// <param name="I">La table de transitions initiale</param>
    public virtual void InitI(ArrayList[,] I)
    {
        this.I = new ArrayList[this.S, this.X.Count];
        for (int i = 0; i < this.S; i++)
            for (int j = 0; j < this.X.Count; j++)
                if (i < I.GetLength(0) && j < I.GetLength(1))
                    if (I[i, j] != null)

                        this.I[i, j] = new ArrayList(I[i, j]);
                    else
                        this.I[i, j] = new ArrayList();
                else
                    this.I[i, j] = new ArrayList();
    }
    /// <summary>
    /// Ajouter un etat final
    /// </summary>
    /// <param name="Sf">Un etat à ajouter dans les etats finaux</param>
    public void AddFinalState(int Sf)
    {
        if (!this.F.Contains(Sf))
        {
            this.F.Add(Sf);
            isConverted = false;
        }
    }

    /// <summary>
    /// Supprimer un etat final
    /// </summary>
    /// <param name="Sf">Un etat à supprimer dans les etats finaux</param>
    public void RemoveFinalState(int Sf)
    {
        this.F.Remove(Sf);
        isConverted = false;
    }


    /// <summary>
    /// Ajouter un etat à l'automate
    /// </summary>
    public void AddState()
    {
        this.S++;
        isConverted = false;
    }

    /// <summary>
    /// Definir le nombre des etats de l'automate
    /// </summary>
    /// <param name="States">Le nombre des etats</param>
    public void SetStateNumber(int States)
    {
        this.S = States;
        InitI(this.I);
        isConverted = false;
    }

    /// <summary>
    /// Obtenir les transitions de Si lisant Xi
    /// </summary>
    /// <param name="Si">l'etat courant</param>
    /// <param name="Xi">Le caractere lu</param>
    /// <returns>ArrayList des etats suivants</returns>
    public virtual ArrayList getInstruction(int Si, char Xi)
    {
        return this.I[Si, toIndex(Xi)];
    }

    /// <summary>
    /// Obtenir la table des transitions
    /// </summary>
    /// <returns>Un int en cas d'un automate de type Dfa , et un arraylist dans les autres type</returns>
    public object getInstructionTable()
    {
        return this.I.Clone();
    }

    /// <summary>
    /// Obtenir le type de l'automate
    /// </summary>
    /// <returns>Type d e l'automate</returns>
    public TYPE getType()
    {
        return this.AutType;
    }


    /// <summary>
    /// Definir le type de l'automate
    /// </summary>
    /// <param name="type">Le type de l'automate</param>
    protected void setType(TYPE type)
    {
        this.AutType = type;
    }


    /// <summary>
    /// Obtenir l'automate de language miroire 
    /// </summary>
    /// <returns>Un automate de type PGfa</returns>
    public virtual PGfa getMirror()
    {
        PGfa Pgfa = new PGfa();
        Pgfa.X = (ArrayList)this.X.Clone();

        if (!Pgfa.X.Contains(PGfa.EPSILON))
            Pgfa.X.Insert(0, PGfa.EPSILON);
        Pgfa.S = this.S + 1;
        Pgfa.F.Add(this.S0);
        Pgfa.S0 = this.S;
        Pgfa.InitI();
        for (int i = 0; i < this.S; i++)
            foreach (char car in this.X)
                if (this.getType() == TYPE.Dfa)
                {
                    if (((Dfa)this).getInstruction(i, car) != -1)
                        Pgfa.AddInstruction(((Dfa)this).getInstruction(i, car), car, i);
                }
                else
                    foreach (int j in this.getInstruction(i, car))
                        Pgfa.AddInstruction(j, car, i);
        foreach (int s in this.F)
            Pgfa.AddInstruction(Pgfa.S0, PGfa.EPSILON, s);
        return Pgfa;
    }

    /// <summary>
    /// Obtenir l'automate du language complement
    /// </summary>
    /// <returns>Un automate de type Dfa</returns>
    public Dfa getComplementary()
    {
        Dfa temp = this.toComplete();
        ArrayList f = new ArrayList();
        for (int Fi = 0; Fi < temp.S; Fi++)
            if (!temp.F.Contains(Fi))
                f.Add(Fi);
        Dfa dfa = new Dfa(temp.X, temp.S, temp.S0, f, temp.getInstructionTable());
        return dfa;
    }

    /// <summary>
    /// Obtenir l'automate du language Iteration
    /// </summary>
    /// <returns>Un automate partiellement generalisé</returns>
    public PGfa getIteration()
    {
        PGfa temp = this.toPGfa();
        foreach (int Fi in temp.F)
            temp.AddInstruction(Fi, EPSILON, temp.S0);
        return temp;
    }

    /// <summary>
    /// Obtenir l'automate du language Iteration positive
    /// </summary>
    /// <returns>Un automate partiellement generalisé</returns>
    public PGfa getIterationPositive()
    {
        PGfa temp = this.toPGfa();
        int s0 = temp.S0;
        temp = new PGfa(temp.X, temp.S + 1, temp.S, temp.F, (ArrayList[,])temp.getInstructionTable());
        temp.AddInstruction(temp.S - 1, EPSILON, s0);
        foreach (int Fi in temp.F)
            temp.AddInstruction(Fi, EPSILON, s0);
        return temp;

    }



    /// <summary>
    /// Verifie si un arraylist contient des etats finaux
    /// </summary>
    /// <param name="Set">Arrayliste des etats </param>
    /// <returns>true en cas ou le Arrayliste contient au moins un etat final </returns>
    public Boolean containsFi(ArrayList Set)
    {
        return Intersect(Set, this.F);
    }

    /// <summary>
    /// Obtenir l'index du caractere dans l'alphabet
    /// </summary>
    /// <param name="car">caractere</param>
    /// <returns>L'index du caractere</returns>
    public int toIndex(char car)
    {
        return X.IndexOf(car);
    }

    #region static methods:

    /// <summary>
    /// Definir si deux ArrayList ont des etats communs
    /// </summary>
    /// <param name="Set1">Le premier ArrayListe des etats</param>
    /// <param name="Set2">Le deuxieme ArrayListe des etats</param>
    /// <returns>True si il existe des etats communs</returns>
    public static Boolean Intersect(ArrayList Set1, ArrayList Set2)
    {
        foreach (int i in Set1)
            if (Set2.Contains(i))
                return true;
        return false;
    }

    /// <summary>
    /// Verifie si deux Arraylistes d'etats sont égaux 
    /// </summary>
    /// <param name="A">Le premier ArrayListe des etats</param>
    /// <param name="B">Le deuxieme ArrayListe des etats</param>
    /// <returns>True si les deux ArrayListes sont égaux</returns>
    public static bool ArrayListEquals(ArrayList A, ArrayList B)
    {
        if (A.Count == B.Count)
        {
            int i = 0;
            for (; i < A.Count && B.Contains(A[i]); i++) ;
            if (i == A.Count)
                return true;
            else
                return false;
        }
        else return false;
    }

    /// <summary>
    /// Verefier si un ArrayListe des ArrayListes contient un  ArrayListe E
    /// </summary>
    /// <returns>Le rang du l'ArrayListe E dans Set, -1 sinon </returns>
    public static int contains(ArrayList Set, ArrayList E)
    {
        for (int i = 0; i < Set.Count && ((ArrayList)Set[i]).Count > 0; i++)
            if (((ArrayList)Set[i]).Count == E.Count)
            {
                int k = 0;
                for (; k < E.Count && E.Contains(((ArrayList)Set[i])[k]); k++) ;
                if (k == E.Count)
                    return i;
            }
        return -1;
    }

    /// <summary>
    /// Obtenir l'union des deux ArrayListes des etats
    /// </summary>
    /// <returns>L'union des ArrayListes</returns>
    public static ArrayList arrayListUnion(ArrayList A, ArrayList B)
    {
        ArrayList temp = new ArrayList(A);
        for (int i = 0; i < B.Count; i++)
        {
            if (!temp.Contains(B[i]))
                temp.Add(B[i]);
        }
        return temp;
    }

    /// <summary>
    /// Obtenir  l'automate qui defini l'union des deux languages definis par A et B
    /// </summary>
    /// <returns>Un automate de type PGfa</returns>
    public static PGfa Union(Automata A, Automata B)
    {
        PGfa a = A.toPGfa();
        PGfa b = B.toPGfa();
        PGfa aUb = new PGfa(arrayListUnion(a.X, b.X), a.S + b.S + 1);
        aUb.S0 = 0;
        foreach (int Fi in a.F)
            aUb.AddFinalState(Fi + 1);
        foreach (int Fi in b.F)
            aUb.AddFinalState(Fi + a.S + 1);
        for (int i = 0; i < a.S; i++)
            foreach (char car in a.X)
                foreach (int j in a.getInstruction(i, car))
                    aUb.AddInstruction(i + 1, car, j + 1);
        for (int i = 0; i < b.S; i++)
            foreach (char car in b.X)
                foreach (int j in b.getInstruction(i, car))
                    aUb.AddInstruction(i + a.S + 1, car, j + b.S + 1);
        aUb.AddInstruction(aUb.S0, EPSILON, new ArrayList { a.S0 + 1, b.S0 + a.S + 1 });
        return aUb;
    }

    /// <summary>
    /// Obtenir l'automate qui defini la concatenation de deux laguages definis par A et B
    /// </summary>
    /// <returns>Un automate de type PGfa</returns>
    public static PGfa Concatenation(Automata A, Automata B)
    {
        PGfa a = A.toPGfa();
        PGfa b = B.toPGfa();
        ArrayList f = new ArrayList();
        foreach (int Fi in b.F)
            f.Add(Fi + a.S);
        PGfa aCb = new PGfa(arrayListUnion(a.X, b.X), a.S + b.S, a.S0, f, (ArrayList[,])a.getInstructionTable());
        for (int i = 0; i < b.S; i++)
            foreach (char car in b.X)
                foreach (int j in b.getInstruction(i, car))
                    aCb.AddInstruction(i + a.S, car, j + b.S);
        foreach (int Fi in a.F)
            aCb.AddInstruction(Fi, EPSILON, b.S0 + a.S);
        return aCb;
    }
    #endregion

    /// <summary>
    /// Obtenir le grammaire qui defini le language defini par l'automate courant
    /// </summary>
    /// <returns>Un grammer equivalant</returns>
    public Grammer toGrammer()
    {
        Gfa auto = this.toGfa();
        ArrayList v = new ArrayList();
        for (char i = 'A'; i < auto.S + 'A'; i++)
            v.Add(i);
        if (v.Count == 0) v.Add('A');
        Grammer result = new Grammer(auto.X, v, (char)v[auto.S0]);
        for (int i = 0; i < this.S; i++)
            for (int k = 0; k < auto.Read.Count; k++)
            {
                string word = auto.Read[k].ToString();
                foreach (int j in auto.getInstruction(i, word))
                {
                    result.AddProduction(new Grammer.ProductionRule((char)result.V[i], word, (char)result.V[j]));
                    if (auto.F.Contains(j))
                        result.AddProduction(new Grammer.ProductionRule((char)result.V[i], word, Grammer.NOVARIABLE));

                }
            }
        return result;
    }


    #region les fonctions de dessin

    /// <summary>
    /// Initialisation des colonnes et des lignes du DataGridView
    /// </summary>
    /// <param name="Grid">Le DataGrid</param>
    public void Init_grid(System.Windows.Forms.DataGridView Grid)
    {

        Grid.Columns.Clear();
        Grid.Rows.Clear();
        //les colonnes
        if (this.getType() == Automata.TYPE.Gfa)
            for (int i = 0; i < ((Gfa)this).Read.Count; i++)
            {
                Grid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn());
                Grid.Columns[i].HeaderCell.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[i].HeaderText = ((Gfa)this).Read[i].ToString();
                Grid.Columns[i].Name = ((Gfa)this).Read[i].ToString();
                Grid.Columns[i].ReadOnly = true;
                Grid.Columns[i].Resizable = System.Windows.Forms.DataGridViewTriState.True;
                Grid.Columns[i].Width = (((Grid.Width - 57) / (((Gfa)this).Read.Count)));

            }
        else
            for (int i = 0; i < this.X.Count; i++)
            {
                Grid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn());
                Grid.Columns[i].HeaderCell.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[i].HeaderText = this.X[i].ToString();
                Grid.Columns[i].Name = this.X[i].ToString();
                Grid.Columns[i].ReadOnly = true;
                Grid.Columns[i].Resizable = System.Windows.Forms.DataGridViewTriState.True;
                Grid.Columns[i].Width = (((Grid.Width - 57) / (this.X.Count)));
            }


        //les lignes

        for (int i = 0; i < this.S; i++)
        {
            Grid.Rows.Add(new System.Windows.Forms.DataGridViewRow());
            if (this.S0 == i)
                Grid.Rows[i].HeaderCell.Value = ("[S" + i.ToString() + "]");
            else
                Grid.Rows[i].HeaderCell.Value = ("S" + i.ToString());
            Grid.Rows[i].Resizable = System.Windows.Forms.DataGridViewTriState.True;
        }
    }

    /// <summary>
    /// Afficher l'automate dans un DataGrid
    /// </summary>
    /// <param name="Grid">Le DataGridView</param>
    public void Afficher_grid(System.Windows.Forms.DataGridView Grid)
    {
        Init_grid(Grid);
        System.Windows.Forms.DataGridViewCellStyle Style_F = new System.Windows.Forms.DataGridViewCellStyle();
        Style_F.BackColor = System.Drawing.Color.Red;
        Style_F.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;


        if (this.getType() == Automata.TYPE.Gfa)
            for (int i = 0; i < this.S; i++)
                foreach (Object motOBJ in ((Gfa)this).Read)
                {
                    String mot = motOBJ.ToString();
                    string temp;
                    temp = "";
                    foreach (int j in ((Gfa)this).getInstruction(i, mot.ToString()))
                        if (this.F.Contains(j))
                            temp = temp + " [S" + j + "]";
                        else
                            temp = temp + " S" + j;
                    if (temp == "") temp = "-";
                    Grid.Rows[i].Cells[(((Gfa)this).Read.IndexOf(motOBJ))].Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                    Grid.Rows[i].Cells[(((Gfa)this).Read.IndexOf(motOBJ))].Value = temp;


                }

        else
            for (int i = 0; i < this.S; i++)
                foreach (char car in this.X)
                    if (this.getType() == TYPE.Dfa)
                    {

                        Grid.Rows[i].Cells[this.X.IndexOf(car)].Value = (((((Dfa)this).getInstruction(i, car)) != -1) ? ("S" + ((Dfa)this).getInstruction(i, car).ToString()) : ("-"));
                        Grid.Rows[i].Cells[this.X.IndexOf(car)].Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                        if (this.F.Contains(((Dfa)this).getInstruction(i, car)))
                            Grid.Rows[i].Cells[this.X.IndexOf(car)].Style = Style_F;
                    }
                    else
                    {
                        string temp;
                        temp = "";
                        foreach (int j in ((Automata)this).getInstruction(i, car))
                            if (this.F.Contains(j))
                                temp = temp + " [S" + j + "]";
                            else
                                temp = temp + " S" + j;
                        if (temp == "") temp = "-";
                        Grid.Rows[i].Cells[this.X.IndexOf(car)].Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                        Grid.Rows[i].Cells[this.X.IndexOf(car)].Value = temp;

                    }
    }


    /// <summary>
    /// Dessiner l'automate dans un Panel.
    /// </summary>
    /// <param name="DrawPanel">Le panel ou on va dessiner l'automate</param>
    /// <param name="fix">La methode de deplacement des etats dans le dessin
    /// true pour des emplacements fixes</param>
    public void Draw(System.Windows.Forms.Panel DrawPanel, bool fix)
    {

        Random Ran = new Random();

        Dessin = DrawPanel.CreateGraphics();
        AutoImage = new Bitmap(DrawPanel.Width, DrawPanel.Height);
        grImage = Graphics.FromImage(AutoImage);
        

        SolidBrush pinceau = new SolidBrush(Color.Blue);
        Pen myPen = new Pen(Color.Blue, 2);
        Font myfont = new Font("Verdana", 8, FontStyle.Bold);

        DrawPanel.Refresh();
        //Dessin.PixelOffsetMode = PixelOffsetMode.HighQuality;
        Dessin.SmoothingMode = SmoothingMode.AntiAlias;
        grImage.SmoothingMode = SmoothingMode.AntiAlias;


        Pen inipen = new Pen(Color.Coral, 5);
        inipen.CustomEndCap = new AdjustableArrowCap(3, 3, false);

        if (!DessinChanged)
            if (fix)
            {
                myPointArray = new Point[10];
                int[] TabX = new int[8];
                for (int i = 0; i < 8; i++)
                {
                    TabX[i] = (int)i * ((DrawPanel.Width - 40) / 7);
                }
                int[] TabY = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    TabY[i] = (int)i * ((DrawPanel.Height - 28) / 4);
                }

                #region myPointArray
                myPointArray[0] = new Point(TabX[4], TabY[0]);
                myPointArray[1] = new Point(TabX[0], TabY[2]);
                myPointArray[2] = new Point(TabX[7], TabY[2]);
                myPointArray[3] = new Point(TabX[5], TabY[3]);
                myPointArray[4] = new Point(TabX[5], TabY[1]);
                myPointArray[5] = new Point(TabX[2], TabY[3]);
                myPointArray[6] = new Point(TabX[3], TabY[0]);
                myPointArray[7] = new Point(TabX[4], TabY[4]);
                myPointArray[8] = new Point(TabX[2], TabY[1]);
                myPointArray[9] = new Point(TabX[3], TabY[4]);
                #endregion


            }
            else
            {
                myPointArray = new Point[this.S];
                //les restes sont calculés
                double alpha = (Math.PI * 2) / this.S;
                for (int i = 0; i < this.S; i++)
                {
                    myPointArray[i] = new Point((int)((Math.Cos((i - 1) * alpha) * (DrawPanel.Width / 2.75)) + DrawPanel.Width / 2.2), (int)((Math.Sin((i - 1) * alpha) * 90) + 100));

                }

            }

        if (this.S > 10)
            DrawPanel.BackColor = Color.Red;
        for (int i = 0; (i < this.S); i++)
        {
            Point p = myPointArray[i];
            Dessin.DrawEllipse(myPen, p.X, p.Y, 30, 30);
            grImage.DrawEllipse(myPen, p.X, p.Y, 30, 30);
            
            

            if (this.S0 == i) //etat ititial
            {

                Dessin.DrawLine(inipen, p.X - 40, p.Y + 5, p.X - 10, p.Y + 10);
                grImage.DrawLine(inipen, p.X - 40, p.Y + 5, p.X - 10, p.Y + 10);
            }
            if (this.F.Contains(i)) //etat final
            {
                grImage.DrawEllipse(myPen, p.X + 2, p.Y + 2, 30 - 4, 30 - 4);
                Dessin.DrawEllipse(myPen, p.X + 2, p.Y + 2, 30 - 4, 30 - 4);
            }

            for (int j = 0; (j < this.S) & (j < 10); j++)
            {

                String CsTran = "";
                if (this.getType() != TYPE.Gfa)
                    foreach (char car in this.X)
                    {
                        if (this.getType() == TYPE.Dfa)
                        {
                            if (((Dfa)this).getInstruction(i, car) == j)
                            {
                                CsTran += ((CsTran.Length == 0) ? (car.ToString()) : ("/" + car.ToString()));
                            }
                        }
                        else
                        {
                            if (((Automata)this).getInstruction(i, car).Contains(j))
                            {
                                CsTran += ((CsTran.Length == 0) ? (car.ToString()) : ("/" + car.ToString()));
                            }

                        }

                    }
                else
                    foreach (Object MotObj in ((Gfa)this).Read)
                    {
                        string Mot = MotObj.ToString();
                        if (((Gfa)this).getInstruction(i, Mot).Contains(j))
                        {
                            CsTran += ((CsTran.Length == 0) ? (Mot.ToString()) : ("/" + Mot));
                        }

                    }

                

                #region //DrawTransition(i, j, CsTran);
                AdjustableArrowCap Fleche = new AdjustableArrowCap(5, 5, true);
                Pen FlechePen = new Pen(Color.Red, 2);
                FlechePen.CustomEndCap = Fleche;
                if (CsTran.Length != 0)       // il existe une transition de Si vers Sj
                {
                    Point p1 = myPointArray[i];
                    Point p2 = myPointArray[j];

                    Point t1 = new Point();
                    Point t2 = new Point();
                    Point t3 = new Point();
                    Point t4 = new Point();


                    /*if (p2.X < p1.X)
                    {
                        t2.X = p1.X;
                        t1.X = p2.X + 30;
                        t3.X = t4.X = ((t1.X + t2.X) / 2) - (20 * i);
                    }
                    else {
                        t2.X = p1.X + 30;
                        t1.X = p2.X;
                        t3.X = t4.X = ((t1.X + t2.X) / 2) + (20 * i);
                    
                    }
                    
                    if (p2.Y < p1.Y)
                    {
                        t2.Y = p1.Y + 15;
                        t1.Y = p2.Y + 15;
                        t3.Y = t4.Y = ((t1.Y + t2.Y) / 2) - (20 * i);
                    }
                    else
                    {
                        t2.Y = p1.Y + 15;
                        t1.Y = p2.Y + 15;
                        t3.Y = t4.Y = ((t1.Y + t2.Y) / 2) + (20 * i);
                    }
                    

                    Dessin.DrawBezier(FlechePen,t1,t3 ,t4,t2);
                     */

                    if (p2 != p1)
                    {
                        
                        Dessin.DrawBezier(FlechePen, p1.X + ((p1.X > p2.X) ? (0) : (30)), p1.Y + 10 + (2 * i), ((p2.X + p1.X) / 2), ((6 * p1.Y + p2.Y) / 7) - 40 + Ran.Next(80), (p2.X + p1.X) / 2, ((6 * p1.Y + p2.Y) / 7) - 40 + Ran.Next(80), p2.X + ((p1.X > p2.X) ? (30) : (0)), p2.Y + 10 + +(2 * i));
                        Dessin.DrawString(CsTran, myfont, pinceau, ((p2.X + p1.X) / 2), (4 * p1.Y + p2.Y) / 5);
                        grImage.DrawBezier(FlechePen, p1.X + ((p1.X > p2.X) ? (0) : (30)), p1.Y + 10 + (2 * i), ((p2.X + p1.X) / 2), ((6 * p1.Y + p2.Y) / 7) - 40 + Ran.Next(80), (p2.X + p1.X) / 2, ((6 * p1.Y + p2.Y) / 7) - 40 + Ran.Next(80), p2.X + ((p1.X > p2.X) ? (30) : (0)), p2.Y + 10 + +(2 * i));
                        grImage.DrawString(CsTran, myfont, pinceau, ((p2.X + p1.X) / 2), (4 * p1.Y + p2.Y) / 5);

                    }
                    else //Si -> Si
                    {
                        
                        Dessin.DrawBezier(FlechePen, p1.X, p1.Y + 15, p1.X + 2, p1.Y + 60, p1.X + 25, p1.Y + 60, p1.X + 30, p1.Y + 15);
                        Dessin.DrawString(CsTran, myfont, pinceau, p1.X + 15, p1.Y + 30);

                        grImage.DrawBezier(FlechePen, p1.X, p1.Y + 15, p1.X + 2, p1.Y + 60, p1.X + 25, p1.Y + 60, p1.X + 30, p1.Y + 15);
                        grImage.DrawString(CsTran, myfont, pinceau, p1.X + 15, p1.Y + 30);
                    }
                    
                }
                SolidBrush Fill = new SolidBrush(Color.White);
                Dessin.FillEllipse(Fill, p.X + 3, p.Y + 3, 30 - 6, 30 - 6);
                Dessin.DrawString("S" + i, myfont, pinceau, (p.X + 5), (p.Y + 8));

                grImage.FillEllipse(Fill, p.X + 3, p.Y + 3, 30 - 6, 30 - 6);
                grImage.DrawString("S" + i, myfont, pinceau, (p.X + 5), (p.Y + 8));
                        
                #endregion
            }

        }
        
        

        //DrawPanel.Refresh();
    }

    #endregion


    #region abstract

    /// <summary>
    /// Reconnetre un mot
    /// </summary>
    /// <param name="word">le mot à tester</param>
    /// <returns>true si le mot est reconnu par l'automate</returns>
    public abstract bool Recognize(string word);

    /// <summary>
    /// Reconnetre un mot
    /// </summary>
    /// <param name="word">le mot à tester</param>
    /// <returns>retourne le traçage !</returns>
    public abstract string trace(string word);

    /// <summary>
    /// Convertir l'automte vers un automate de type Dfa equivalant
    /// </summary>
    /// <returns>Un automate deterministe</returns>
    public abstract Dfa toDfa();

    /// <summary>
    /// Convertir l'automte vers un automate Complet
    /// </summary>
    /// <returns>Un automate deterministe</returns>
    public abstract Dfa toComplete();

    /// <summary>
    /// Convertir l'automte vers un automate reduit
    /// </summary>
    /// <returns>Un automate deterministe</returns>
    public abstract Dfa toReduced();

    /// <summary>
    /// Convertir l'automte vers un automate de type Nfa equivalant
    /// </summary>
    /// <returns>Un automate non deterministe</returns>
    public abstract Nfa toNfa();

    /// <summary>
    /// Convertir l'automte vers un automate de type PGfa equivalant
    /// </summary>
    /// <returns>Un automate partiellement généralisé</returns>
    public abstract PGfa toPGfa();

    /// <summary>
    /// Convertir l'automte vers un automate de type Gfa equivalant
    /// </summary>
    /// <returns>Un automate généralisé</returns>
    public abstract Gfa toGfa();
    #endregion
}
