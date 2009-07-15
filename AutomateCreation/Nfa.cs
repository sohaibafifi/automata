using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Automates
{


    public class Nfa : Automata
    {
        protected Dfa Dfa_CV;
        protected ArrayList StCorTab;

        /// <summary>
        /// Constructeur , créer un Automate d'etats finis non deterministe
        /// </summary>
        /// <remarks>
        /// <font color="#FF0000">Nfa </font>(en anglais) : automate d'etats finis non
        /// deterministe .
        /// </remarks>
        /// <param name="X">L'alphabet</param>
        /// <param name="S">Le nombre d'etats</param>
        /// <param name="S0">L'etat initial</param>
        /// <param name="F">Les etats finaux</param>
        /// <param name="I">Le table de transitions</param>
        public Nfa(ArrayList X, int S, int S0, ArrayList F, ArrayList[,] I)
        {
            setType(TYPE.Nfa);
            this.X = X;
            this.S = S;
            this.S0 = S0;
            this.F = F;
            InitI(I);
        }

        /// <summary>
        /// Initialisation de l'automate d'etats finis non deterministe
        /// </summary>
        public Nfa()
        {
            setType(TYPE.Nfa);
            InitI();
        }

        /// <summary>
        /// Ajouter une instruction au table des instructions de l'automate
        /// </summary>
        /// <param name="Si">l'etat actual</param>
        /// <param name="Xi">le caractere lu</param>
        /// <param name="Sj">l'etat suivant</param>
        public void AddInstruction(int Si, char Xi, int Sj)
        {
            if (!this.I[Si, toIndex(Xi)].Contains(Sj))
                this.I[Si, toIndex(Xi)].Add(Sj);
            isConverted = false;
        }
        /// <summary>
        /// Ajouter une instruction au table des instructions de l'automate
        /// </summary>
        /// <param name="Si">l'etat actual</param>
        /// <param name="Xi">le caractere lu</param>
        /// <param name="SjList">les etats suivants </param>
        public void AddInstruction(int Si, char Xi, ArrayList SjList)
        {
            if (SjList != null)
            {
                foreach (int Sj in SjList)
                    AddInstruction(Si, Xi, Sj);
                isConverted = false;
            }
        }
        /// <summary>
        /// Ajouter une instruction au table des instructions de l'automate
        /// </summary>
        /// <param name="instruction">l'instruction à ajouter</param>
        public void AddInstruction(Instruction instruction)
        {
            AddInstruction(instruction.Si, instruction.Xi, instruction.Sj);
            isConverted = false;
        }

        /// <summary>
        /// Supprimer une instruction
        /// </summary>
        /// <param name="Si">Si</param>
        /// <param name="Xi">le caractere lu</param>
        /// <param name="Sj">l'etat suivant</param>
        public void RemoveInstruction(int Si, char Xi, int Sj)
        {
            this.I[Si, toIndex(Xi)].Remove(Sj);
            isConverted = false;
        }
        /// <summary>
        /// Supprimer une instruction
        /// </summary>
        /// <param name="instruction">l'instruction à supprimer</param>
        public void RemoveInstruction(Instruction instruction)
        {
            RemoveInstruction(instruction.Si, instruction.Xi, instruction.Sj);
            isConverted = false;
        }
        /// <summary>
        /// Supprimer tous les instructions de Si lisant Xi
        /// </summary>
        /// <param name="Si">l'etat Si</param>
        /// <param name="Xi">Le caractere lu</param>
        public void RemoveAllInstructions(int Si, char Xi)
        {
            this.I[Si, toIndex(Xi)].Clear();
            isConverted = false;
        }

        /// <summary>
        /// trier les instructions de Si lisant Xi
        /// </summary>
        /// <param name="Si">L'etat Si</param>
        /// <param name="Xi">Le caractere lu</param>
        public void SortInstructions(int Si, char Xi)
        {
            this.I[Si, toIndex(Xi)].Sort();
        }


        /// <summary>
        /// Convertir l'automate Nfa courant vers un automate Dfa equivalant.
        /// </summary>
        /// <returns>Un automate de type Dfa</returns>
        public override Dfa toDfa()
        {
            if (isConverted)
            {
                return Dfa_CV;
            }
            else
            {
                Dfa_CV = new Dfa();//le nouveau automate Dfa à construire

                Dfa_CV.X = this.X;
                ArrayList temp = new ArrayList();
                temp.Add(this.S0);
                StCorTab = new ArrayList();
                StCorTab.Add(temp);                        //on rajoute l'état initial et l'insère dans StCorTab
                Dfa_CV.S = 1;
                if (this.F.Contains(this.S0))                   //si l'état initial est egalement final on l'insère dans la liste des états finaux
                    Dfa_CV.F.Add(this.S0);
                ArrayList instructions = new ArrayList();
                //on parcours les élement de la table StCorTab (cette table est mis à jour à l'interieur)
                for (int etat = 0; etat < Dfa_CV.S; etat++)
                {
                    if (((ArrayList)StCorTab[etat]).Count == 1)
                    {
                        if (this.F.Contains(((ArrayList)StCorTab[etat])[0]))
                            Dfa_CV.F.Add(etat);
                    }
                    foreach (char car in X)
                    {                   //pour chaque lettre de X
                        int c = toIndex(car);
                        temp = new ArrayList();
                        foreach (int Si in ((ArrayList)StCorTab[etat]))       //puisque on a plusieurs etats de départ (dans les instruction)
                            if (Si < this.S)
                                if (I[Si, c].Count != 0)
                                    temp = arrayListUnion(temp, I[Si, c]);   //on fait l'union des ensembles d'arrivé de chaque etat de départ
                        if (temp.Count != 0)
                        {                  //si l'ensemble d'arrivée n'est pas vide (l'instruction existe)
                            temp.Sort();
                            int index = contains(StCorTab, temp);
                            if (index == -1)                    //si cet ensemble d'etats n'est pas encore renommé(s'il n'existe pas dans StCorTab)
                            {
                                instructions.Add(new Instruction(etat, car, Dfa_CV.S));       //on recopie l'instrucion (avec les nouveau nom)
                                StCorTab.Add(temp);           //on le renomme (on l'insère dans StCorTab
                                //on vérifie si cet état et final, si c'est le cas on l'insère dans la liste des états finaux
                                if (temp.Count == 1)            //cas d'un état simple
                                {
                                    if (this.F.Contains(temp))
                                        Dfa_CV.F.Add(Dfa_CV.S);
                                }
                                else                            //cas d'un ensemble d'état
                                {
                                    if (Intersect(temp, this.F))
                                        Dfa_CV.F.Add(Dfa_CV.S);
                                }
                                Dfa_CV.S++;                     //on ajoute un état à S
                            }
                            else
                                instructions.Add(new Instruction(etat, car, index));    //si l'état est déjà renommé on recopie l'instrucion directement
                        }
                    }
                }
                Dfa_CV.InitI();
                foreach (Instruction instruction in instructions)
                    Dfa_CV.AddInstruction(instruction);
                Dfa_CV.F.Sort();
                isConverted = true;
                return Dfa_CV;
            }
        }



        /// <summary>
        /// Convertir l'automate courant vers un automate complet equivalant
        /// </summary>
        /// <returns>l'automate Dfa complet equivalant</returns>
        public override Dfa toComplete()
        {
            Dfa Complet = new Dfa(Dfa_CV.X, Dfa_CV.S, Dfa_CV.S0, Dfa_CV.F, Dfa_CV.getInstructionTable());
            return (isConverted) ? Complet : this.toDfa().toComplete();
        }

        /// <summary>
        /// Convertir l'automate courant vers un automate reduit equivalant
        /// </summary>
        /// <returns>Automate de type Dfa reduit</returns>
        public override Dfa toReduced()
        {
            Dfa reduit = new Dfa(Dfa_CV.X, Dfa_CV.S, Dfa_CV.S0, Dfa_CV.F, Dfa_CV.getInstructionTable());
            return (isConverted) ? reduit : this.toDfa().toReduced();
        }

        public override Nfa toNfa()
        {
            Nfa temp = new Nfa(this.X, this.S, this.S0, this.F, (ArrayList[,])this.getInstructionTable());
            return temp;
        }
        public override PGfa toPGfa()
        {
            return new PGfa(this.X, this.S, this.S0, this.F, (ArrayList[,])this.getInstructionTable());
        }
        public override Gfa toGfa()
        {

            return new Gfa(this.X, this.S, this.S0, this.F, (ArrayList[,])this.getInstructionTable());

        }
        public override bool Recognize(string word)
        {
            return toDfa().Recognize(word);
        }

        public override string trace(string word)
        {
            return toDfa().trace(word);
        }
    }
}