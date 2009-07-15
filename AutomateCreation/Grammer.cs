using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Automates
{
	 /// <summary>
    /// la classe qui definit une grammaire
    /// </summary>
    public class Grammer
    {
        public const char NOVARIABLE = 'ε';                     // le mot vide
        public String Name;                                     // le nom de la grammaire
        public ArrayList X = new ArrayList();                   // l'alphabet
        public ArrayList V = new ArrayList();                   // les variables
        protected ArrayList Read = new ArrayList();             
        public char S;                                          // l'axiome
        public ArrayList[] P;                                   // les regles de production
        protected Gfa Gfa_CV;
        protected ArrayList StCorTab;
        
        /// <summary>
        /// initialisation de la grammaire
        /// </summary>
        /// <param name="X">l'alphabet</param>
        /// <param name="V">les variables</param>
        /// <param name="S">l'axiome</param>
        public Grammer(ArrayList X, ArrayList V, char S)
        {
            this.X = (ArrayList)X.Clone();
            this.V = V;
            this.S = S;
            this.P = new ArrayList[V.Count];
            for (int i = 0; i < V.Count; i++)
                P[i] = new ArrayList();
        }
        public Grammer() { }

		/// <summary>
        /// La definition des regles de productions
        /// </summary>
        public struct ProductionRule
        {
             public char A;         // la varible de depart
            public String W;       // le mot apres la derivation   
            public char B;         // la variable d'arrivée
            public ProductionRule(char a, string w, char b)
            {
                this.A = a;
                this.W = w;
                this.B = b;
            }
            public ProductionRule(char a, string w)
            {
                this.A = a;
                this.W = w;
                this.B = NOVARIABLE;
            }
            public override String ToString()
            {
                if (B == NOVARIABLE)
                    if (W.Length == 0)
                        return A + "->" + Automata.EPSILON;
                    else
                        return A + "->" + W;
                else
                    return A + "->" + W + B;
            }
        }
/// <summary>
        /// Obtenir la variable d'arrivée
        /// </summary>
        /// <param name="production"></param>
        /// <returns></returns>
        public char getVar(String production)
        {
            return production[production.Length - 1];
        }
        /// <summary>
        /// Obtenir le mot dans la production 
        /// </summary>
        /// <param name="production"></param>
        /// <returns></returns>
        public String getWord(String production)
        {
            return production.Substring(0, production.Length - 1);
        }
        /// <summary>
        /// Ajouter la production en entée à l'ensemble des regles des productions
        /// </summary>
        /// <param name="production"></param>
        /// <returns></returns>
        public int AddProduction(ProductionRule production)
        {
            if (getProductions(production.A).Contains(production.W + production.B))
                return 1;   // production existe
            if (!this.V.Contains(production.A) || (!this.V.Contains(production.B) && production.B != NOVARIABLE))
                return -2;  //erreur: Variable n'existe pas
            if (!InAlphabet(production.W))
                return -3;  //error: word not in X
            this.P[toIndex(production.A)].Add(production.W + production.B);
            if (!this.Read.Contains(production.W) && (production.W.Length > 1))
                this.Read.Add(production.W);
            return 0;       //instruction ajoutée avec succée
        }
        /// <summary>
        /// supprimer la regle de l'ensemble des regles des productions
        /// </summary>
        /// <param name="production"></param>
        public void RemoveProduction(ProductionRule production)
        {
            this.P[toIndex(production.A)].Remove(production.W + production.B);
        }
        /// <summary>
        /// trouver la regle de production à partir de la variable de depart
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public ArrayList getProductions(char A)
        {
            return this.P[toIndex(A)];
        }
        /// <summary>
        /// Donner l'index de la variable dans l'ensemble V
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int toIndex(char A)
        {
            return this.V.IndexOf(A);
        }
        /// <summary>
        /// le caractere en entrée est alpha-numerique
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool isValidLetter(char c)
        {
            return Char.IsLower(c) || Char.IsDigit(c);
        }
        /// <summary>
        /// retourner si le mot en entrée contient des caracteres valide
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        protected bool InAlphabet(String word)
        {
            foreach (Char c in word)
                if (!this.X.Contains(c) || !isValidLetter(c))
                    return false;
            return true;
        }
        /// <summary>
        /// ajouter une variable à l'ensemble V
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int AddVariable(char A)
        {
            if (this.V.Contains(A))

                return 1;   //erreur: Variable existe dèjà
            if (!Char.IsUpper(A))

                return -1;  //erreur: Variable doit etre en majuscule
            this.V.Add(A);

            return 0;       // Variable est bien ajoutée
        }
        /// <summary>
        /// ajouter une lettre à l'alphabet
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int AddLetter(char c)
        {
            if (this.X.Contains(c))

                return 1;   // erreur: lettre existe deja 
            if (!isValidLetter(c))

                return -1;  // erreur: lettre doit etre en miniscule
            this.X.Add(c);

            return 0;       // lettre est bien ajoutée
        }
        /// <summary>
        /// Transformer la grammaire en un automate généralisé
        /// </summary>
        /// <returns></returns>
        public Gfa toGfa()
        {
            Gfa_CV = new Gfa();
            Gfa_CV.Name = this.Name + "_Gfa";
            Gfa_CV.X = new ArrayList(this.X);
            Gfa_CV.X.Insert(0, Automata.EPSILON);
            int Fi = this.V.Count;
            Gfa_CV.SetStateNumber(Fi + 1);
            Gfa_CV.AddFinalState(Fi);
            Gfa_CV.S0 = this.V.IndexOf(this.S);
            StCorTab = this.V;
            Gfa_CV.Read = new ArrayList(Gfa_CV.X);
            Gfa_CV.Read.AddRange(this.Read);
            Gfa_CV.InitI();
            foreach (char A in this.V)
                foreach (String production in this.getProductions(A))
                {
                    Char B = getVar(production);
                    string W = getWord(production);
                    if (B != NOVARIABLE)
                        Gfa_CV.AddInstruction(V.IndexOf(A), W, V.IndexOf(B));
                    else
                        Gfa_CV.AddInstruction(V.IndexOf(A), W, Fi);
                }
            return Gfa_CV;
        }
        public override string ToString()
        {
            String temp = "X= {";
            int i = 0;
            for (; i < X.Count - 1; i++)
                temp += X[i] + ", ";
            temp += X[i] + "}\nV= {";
            for (i = 0; i < V.Count - 1; i++)
                temp += V[i] + ", ";
            temp += V[i] + "}\nAxiom= ";
            temp += S + "\nP={\n";
            foreach (char var in this.V)
            {
                if (getProductions(var).Count > 0)
                {
                    temp += var + "->";
                    foreach (String production in this.getProductions(var))
                    {
                        Char B = production[production.Length - 1];
                        string W = production.Remove(production.Length - 1);
                        if (B == NOVARIABLE)
                            if (W.Length == 0)
                                temp += Automata.EPSILON;
                            else
                                temp += W;
                        else
                            temp += W + B;
                        if (getProductions(var).IndexOf(production) + 1 != getProductions(var).Count)
                            temp += "/";
                    }
                    temp += "\n";
                }
            }
            temp += "}";
            return temp;
        }

        /// <summary>
        /// affichage de grammmaire en couleurs
        /// </summary>
        /// <param name="RTF"></param>
        public void AfficherGrammair(System.Windows.Forms.RichTextBox RTF)
        {
            string temp = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1036{\fonttbl{\f0\fswiss\fcharset0 Arial;}}
{\colortbl ;\red0\green0\blue0;\red255\green0\blue0;\red0\green128\blue0;}
{\*\generator Msftedit 5.41.15.1507;}\viewkind4\uc1\pard\cf1\f0\fs20 ";
            temp += @"X = \{\cf2 ";

            temp += X[0];
            for (int i = 1; i < X.Count - 1; i++)
                if ((char)X[i] != Automata.EPSILON)
                    temp += ", "+ X[i] ;
            
            temp += @"\cf1\}\par";
            temp += @"\cf0 V = \{\cf3 ";
            temp += V[0];
            for (int i = 1; i < V.Count - 1; i++)
                temp +=  ", " + V[i] ;
            
               
            temp += @"\cf0\}\par Axiome = \cf3 ";
            temp += S + @"\par \par \cf1 P = \{\par \b";
            
            foreach (char var in this.V)
            {
                if (getProductions(var).Count > 0)
                {
                    temp += @"\tab " + var + " -> ";
                    foreach (String production in this.getProductions(var))
                    {
                        Char B = production[production.Length - 1];
                        string W = production.Remove(production.Length - 1);
                        if (B == NOVARIABLE)
                            if (W.Length == 0)
                                temp += Automata.EPSILON;
                            else
                                temp += W;
                        else
                            temp += W + B;
                        if (getProductions(var).IndexOf(production) + 1 != getProductions(var).Count)
                            temp += " / ";
                    }
                    temp += @"\par";
                }
            }
            
            temp += @"\b0\} \par}";

            RTF.Rtf = temp;
            
        }

       

    }

}
