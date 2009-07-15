using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Automates
{
    /// <summary>
    /// La classe defini les automates de type Dfa : automates d'etats finis deterministe 
    /// </summary>
    public class Dfa : Automata
    {
        protected new int[,] I;  //instructions représentée comme table de transition
        protected ArrayList RdStateCorTab = new ArrayList();           //table de correspondance Dfa en Dfa Reduit
        protected ArrayList dejaVu = new ArrayList();
        protected ArrayList coAccessible = new ArrayList();

        /// <summary>
        /// Initialise une nouvelle instance de la classe Dfa
        ///     avec les valeurs passées en parametres
        /// </summary>
        /// <param name="X">L'alphabet de l'automate</param>
        /// <param name="S">Le nombre d'etats de l'automate</param>
        /// <param name="S0">L'etats inititial de l'automate</param>
        /// <param name="F">Les etats finaux de l'automate</param>
        /// <param name="I">La table de transitions de l'automate</param>
        public Dfa(ArrayList X, int S, int S0, ArrayList F, int[,] I)
        {
            setType(TYPE.Dfa);
            this.X = X;
            this.S = S;
            this.S0 = S0;
            this.F = F;
            InitI(I);
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Dfa
        /// avec un table des instructions vide .
        /// </summary>
        public Dfa()
        {
            setType(TYPE.Dfa);
            InitI();
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Dfa
        /// avec l'alphabet et le nombre d'etats passées en parametres.
        /// </summary>
        /// <param name="X">L'alphabet de l'automate</param>
        /// <param name="S">Le nombre d'etats</param>
        public Dfa(ArrayList X, int S)
        {
            this.X = X;
            this.S = S;
            setType(TYPE.Dfa);
            InitI();
        }



        /// <summary>
        /// Initialisation de I
        /// on initialise la table de transitions à -1  (-1 indique que l'instruction n'existe pas)
        /// </summary>
        public new void InitI()
        {
            this.I = new int[this.S, this.X.Count];
            for (int i = 0; i < this.S; i++)
                for (int j = 0; j < this.X.Count; j++)
                    I[i, j] = -1;
        }

        /// <summary>
        /// Initialisation de la table de transitions
        /// avec des transitions predefinies
        /// </summary>
        /// <param name="I">La table de transitions predefinies</param>
        public void InitI(int[,] I)
        {
            this.I = new int[this.S, this.X.Count];
            for (int i = 0; i < this.S; i++)
                for (int j = 0; j < this.X.Count; j++)
                    if (i < I.GetLength(0))
                        this.I[i, j] = I[i, j];
                    else
                        this.I[i, j] = -1;
        }

        /// <summary>
        /// Ajouter une transition Si -Xi-> Sj
        /// Cette fonction affiche un message pour confirmer le remplacement en cas d'existence de transition de Si lisant Xi
        /// Car l'automate est deterministe
        /// </summary>
        /// <param name="Si">l'etat courant.</param>
        /// <param name="Xi">Le caractere lu.</param>
        /// <param name="Sj">L'etat suivant .</param>
        /// <returns>retourne 0 en cas de succes ,1 en cas de remplacement et 2 si rien n'est fait</returns>
        public int AddInstruction(int Si, char Xi, int Sj)
        {
            int xi = toIndex(Xi);
            if (this.I[Si, xi] == -1)
            {
                this.I[Si, xi] = Sj;
                return 0;
            }
            else if (this.I[Si, xi] != Sj)
            {
                String message = "this automata is Deterministic,\nyou can't read the same letter '" + xi + "' to go from \nstate 'S" + Si + "' to two diffrent states 'S" + this.I[Si, xi] + "' and 'S" + Sj + "'!\n do you want to replace the instruction:\n(S" + Si + "," + Xi + ",S" + this.I[Si, xi] + ") with: (S" + Si + "," + Xi + ",S" + Sj + ") ?";
                if (MessageBox.Show(message, "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.I[Si, xi] = Sj;
                    return 1;
                }
            }
            return 2;
        }


        /// <summary>
        /// Ajouter une transition
        /// </summary>
        /// <param name="instruction">La transition à ajouter</param>
        /// <returns>retourne 0 en cas de succes ,1 en cas de remplacement et 2 si rien n'est fait</returns>
        public int AddInstruction(Instruction instruction)
        {
            return this.AddInstruction(instruction.Si, instruction.Xi, instruction.Sj);
        }
        public int AddInstruction(int Si, char Xi, int Sj, bool replace)
        {
            int xi = toIndex(Xi);
            if (this.I[Si, xi] == -1)
            {
                this.I[Si, xi] = Sj;
                return 0;
            }
            else if (this.I[Si, xi] != Sj)
            {
                if (replace)
                {
                    this.I[Si, xi] = Sj;
                    return 1;
                }
            }
            return 2;
        }

        /// <summary>
        /// Ajouter une transition
        /// </summary>
        /// <param name="instruction">La transition à ajouter</param>
        /// <param name="replace">true pour le remplacement en cas de l'existance de cette transition</param>
        /// <returns>retourne 0 en cas de succes ,1 en cas de remplacement et 2 sinon</returns>
        public int AddInstruction(Instruction instruction, bool replace)
        {
            return this.AddInstruction(instruction.Si, instruction.Xi, instruction.Sj, replace);
        }

        /// <summary>
        /// Supprimer une transition Si -Xi-> Sj
        /// </summary>
        /// <param name="Si">l'etat courant</param>
        /// <param name="Xi">Le caractere lu.</param>
        /// <param name="Sj">L'etat suivant</param>
        /// <returns>retourne 1 en cas d'inexistance de la transition à supprimer , 0 en cas de succes</returns>
        public int RemoveInstruction(int Si, char Xi, int Sj)
        {
            if (this.I[Si, toIndex(Xi)] == -1)
                return 1;
            this.I[Si, toIndex(Xi)] = -1;
            return 0;
        }

        /// <summary>
        /// Supprimer une transition Si -Xi-> Sj
        /// </summary>
        public int RemoveInstruction(Instruction instruction)
        {
            return this.RemoveInstruction(instruction.Si, instruction.Xi, instruction.Sj);
        }

        /// <summary>
        /// Obtenir l'etat suivant de Si lisant Xi 
        /// </summary>
        /// <param name="Si">l'etat courant</param>
        /// <param name="Xi">Le caractere lu.</param>
        /// <returns>l'etat suivant de Si lisant Xi (Sj)</returns>
        public new int getInstruction(int Si, char Xi)
        {
            return this.I[Si, toIndex(Xi)];
        }


        /// <summary>
        /// Reconettre un mot 
        /// </summary>
        /// <param name="word">Le mot à rencontre</param>
        /// <returns>True si le mot est reconné ,False sinon</returns>
        public override bool Recognize(string word)
        {
            if (word.Length == 0)                //si Mot vide
                if (this.F.Contains(S0))        //si l'etat initial est egalement final
                    return true;                //le mot est reconnu
                else                            //sinon
                    return false;               //le mot n'est pas reconnu
            int i = 0;
            int current_S = S0;
            while (i < word.Length)
            {
                if (!this.X.Contains(word[i]))
                    return false;
                if (I[current_S, toIndex(word[i])] != -1)    //si l'instruction existe:
                    current_S = I[current_S, toIndex(word[i++])]; //alors on lit le caractère et on passe à l'etat suivant
                else                                //sinon
                    return false;                   //bloquage ==> mot non reconnu
            }
            if (F.Contains(current_S)) return true; //si le dernier etat est un etat final ==> mot reconnu
            else return false;                      //sinon le mot n'est pas reconnu
        }

        public override string trace(string word)
        {
            if (word.Length == 0)                //si Mot vide
                if (this.F.Contains(S0))        //si l'etat initial est egalement final
                    return "\n fin avec succes";                //le mot est reconnu
                else                            //sinon
                    return "\n fin sans reconnetre le mot";               //le mot n'est pas reconnu
            int i = 0;
            int current_S = S0;
            string temp = "";
            while (i < word.Length)
            {
                if (!this.X.Contains(word[i]))
                {
                    temp += "\n le mot contient le caractere '" + word[i].ToString()+ "' qui n'est pas dans l'alphabet de l'automate";
                    return temp;
                }
                if (I[current_S, toIndex(word[i])] != -1)
                {    //si l'instruction existe:
                    current_S = I[current_S, toIndex(word[i])]; //alors on lit le caractère et on passe à l'etat suivant
                    temp += "\n S" + i.ToString() + "   |-- '"+ word[i].ToString()+"' --   S"+ current_S.ToString() ;
                    i++;
                }
                else
                {
                    temp += "\n blocage ";                             //sinon
                    return temp;                   //bloquage ==> mot non reconnu
                }
            }
            if (F.Contains(current_S))
            {
                temp += "\n fin avec succes";
                return temp; //si le dernier etat est un etat final ==> mot reconnu
            }
            else{
                temp += "\n fin sans reconnaitre le mot , mais le mot est lu";
                return temp;                      //sinon le mot n'est pas reconnu
            }
        }

        /// <summary>
        /// Verifier si l'automate est deja complet.
        /// </summary>
        /// <returns>True si l'automate est complet , False sinon</returns>
        public bool isComplete()
        {
            for (int i = 0; i < this.S; i++)
                foreach (char car in X)
                {                               //on parcours la table de transition
                    int c = toIndex(car);
                    if (this.I[i, c] == -1)     //si l'instruction n'existe pas
                    {
                        return false;
                    }
                }
            return true;
        }

        /// <summary>
        /// Verifier si l'automate est deja reduit
        /// </summary>
        /// <returns>True si l'automate est reduit ,  False sinon</returns>
        public bool isReduced()
        {
            CoAccessible(Closure(this.S0));
            if (coAccessible.Count == this.S)
                return true;
            else
                return false;
        }


        /// <summary>
        ///Fermeture transitive  
        ///la fonction retourne l'ensemble de tous les etats qu'on peut 
        /// atteindre à partir de l'état "state" en plus de "state" lui même
        /// </summary>
        protected ArrayList Closure(int state)
        {
            ArrayList temp = new ArrayList();
            temp.Add(state);
            for (int i = 0; i < temp.Count; i++)
            {
                int Si = (int)temp[i];
                foreach (char car in X)
                {
                    int c = toIndex(car);
                    if (!temp.Contains(I[Si, c]) && (I[Si, c] != -1))
                        temp.Add(I[Si, c]);
                }
            }
            return temp;
        }


        protected void CoAccessible(ArrayList set)
        {
            foreach (int i in set)
            {
                Co_Accessible(i);
            }
        }

        /// <summary>
        /// Verefier si un etat est coaccessible 
        /// </summary>
        /// <param name="state">L'etat à verifier</param>
        /// <returns>True si l'etat est coaccessible , False sinon</returns>
        protected bool Co_Accessible(int state)
        {
            if (!dejaVu.Contains(state))
            {
                dejaVu.Add(state);
                if (this.F.Contains(state))
                {
                    coAccessible.Add(state);
                    return true;
                }
                for (int j = 0; j < this.X.Count; j++)
                {
                    if (!dejaVu.Contains(I[state, j]) && I[state, j] != -1)
                    {
                        if (this.F.Contains(I[state, j]))
                        {
                            dejaVu.Add(I[state, j]);
                            coAccessible.Add(I[state, j]);
                            coAccessible.Add(state);
                            return true;
                        }
                        else
                        {
                            if (Co_Accessible(I[state, j]))
                            {
                                coAccessible.Add(state);
                                return true;
                            }
                        }
                    }
                }
            }
            else return coAccessible.Contains(state);
            return false;
        }




        public override Dfa toComplete()
        {
            if (this.isComplete())
                return this;
            Dfa Complet = new Dfa(this.X, this.S + 1, this.S0, this.F, this.I);
            for (int i = 0; i < this.S; i++)
                foreach (char car in this.X)
                    if (this.getInstruction(i, car) == -1)
                        Complet.AddInstruction(i, car, this.S);
            foreach (char car in this.X)
                Complet.AddInstruction(this.S, car, this.S);
            return Complet;
        }
        public override Dfa toReduced()
        {
            if (this.isReduced())
            {
                Dfa temp = new Dfa(this.X, this.S, this.S0, this.F, this.getInstructionTable());
                return temp;
            }
            Dfa Reduit = new Dfa();
            Reduit.X = this.X;
            coAccessible.Sort();
            if (coAccessible.Count != 0)
            {
                Reduit.S = coAccessible.Count;
                Reduit.InitI();
                Reduit.S0 = this.S0;
                for (int i = 0; i < coAccessible.Count; i++)
                {
                    Reduit.RdStateCorTab.Add(coAccessible[i]);
                    if (this.F.Contains(coAccessible[i]))
                        Reduit.F.Add(i);
                }
                for (int i = 0; i < Reduit.RdStateCorTab.Count; i++)
                    foreach (char car in X)
                    {                                       //on recopie les instruction consernant les etats de la table de correspondance
                        int c = toIndex(car);
                        int k = (int)Reduit.RdStateCorTab[i];
                        Reduit.I[i, c] = (Reduit.RdStateCorTab.Contains(this.I[k, c])) ? (int)Reduit.RdStateCorTab.IndexOf(this.I[k, c]) : -1;
                    }
            }
            return Reduit;
        }

        public override Dfa toDfa()
        {
           Dfa temp = new Dfa(this.X, this.S, this.S0, this.F, this.getInstructionTable());
            return temp;
        }
        public override Nfa toNfa()
        {
            return new Nfa(this.X, this.S, this.S0, this.F, InstrTabToArrayList());
        }
        public override PGfa toPGfa()
        {
            return new PGfa(this.X, this.S, this.S0, this.F, InstrTabToArrayList());
        }
        public override Gfa toGfa()
        {
            return new Gfa(this.X, this.S, this.S0, this.F, InstrTabToArrayList());
        }

        public ArrayList[,] InstrTabToArrayList()
        {
            ArrayList[,] temp = new ArrayList[this.S, this.X.Count];
            for (int i = 0; i < this.S; i++)
            {
                foreach (char car in this.X)
                {
                    temp[i, toIndex(car)] = new ArrayList();
                    if (this.getInstruction(i, car) != -1)
                        temp[i, toIndex(car)].Add(this.getInstruction(i, car));
                }
            }
            return temp;
        }


        public new int[,] getInstructionTable()
        {
            return this.I;
        }

        public string Rd_StoString()
        {
            string t = "Table de correspondance de Reduit et Dfa:\n";
            for (int i = 0; i < RdStateCorTab.Count; i++)
                t += "S" + i + "= S" + RdStateCorTab[i] + "\n";
            return t;
        }
        public string ItoStringTriplet()
        {
            string temp = "";
            for (int s = 0; s < this.S; s++)
            {
                int i = temp.Length;
                foreach (char car in this.X)
                {
                    int c = toIndex(car);
                    if (this.I[s, c] != (-1))
                        temp += "  (S" + s + "; '" + car + "' ;S" + this.I[s, c] + ")";
                }
                if (i != temp.Length)
                    temp += "\n";
            }
            return temp;
        }
        public string ItoString()
        {
            string temp = "\t";
            foreach (char car in this.X)
                temp += car + "\t";
            for (int s = 0; s < this.S; s++)
            {
                temp += "\nS" + s;
                foreach (char car in this.X)
                {
                    int c = toIndex(car);
                    temp += "\t";
                    if (this.I[s, c] != -1)
                        temp += "S" + this.I[s, c];
                    else
                        temp += "-";
                }
            }
            return temp;
        }


    }
}