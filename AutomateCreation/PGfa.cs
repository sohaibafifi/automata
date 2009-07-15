using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Automates
{
    public class PGfa : Automata
    {


        protected Nfa Nfa_CV;           // l'automate non deterministe 
        /// <summary>
        /// initialisation de l'automate partiellement généralisé
        /// </summary>
        /// <param name="X">l'alphabet</param>
        /// <param name="S">le nom de l'automate</param>
        /// <param name="S0"></param>
        /// <param name="F"></param>
        /// <param name="I"></param>
		

        public PGfa(ArrayList X, int S, int S0, ArrayList F, ArrayList[,] I)
        {
            setType(TYPE.PGfa);
            this.X = (ArrayList)X.Clone();
            if (!X.Contains(EPSILON))
                this.X.Add(EPSILON);

            this.S = S;
            this.S0 = S0;
            this.F = (ArrayList)F.Clone();

            InitI(I);
        }
        public PGfa()
        {
            setType(TYPE.PGfa);
            this.X.Add(EPSILON);
            InitI();
        }
        public PGfa(ArrayList X, int S)
        {
            setType(TYPE.PGfa);
            if (!X.Contains(EPSILON))
                this.X.Add(EPSILON);
            this.X = (ArrayList)X.Clone();
            this.S = S;
            InitI();
        }
        /// <summary>
        /// ajouter une instruction à l'ensemble des instructions
        /// </summary>
        /// <param name="Si"></param>
        /// <param name="Xi"></param>
        /// <param name="Sj"></param>

        public void AddInstruction(int Si, char Xi, int Sj)
        {
            if (!this.I[Si, toIndex(Xi)].Contains(Sj))
                this.I[Si, toIndex(Xi)].Add(Sj);
            isConverted = false;
        }
        public void AddInstruction(int Si, char Xi, ArrayList SjList)
        {
            foreach (int Sj in SjList)
                AddInstruction(Si, Xi, Sj);
            isConverted = false;
        }
        public void AddInstruction(Instruction instruction)
        {
            AddInstruction(instruction.Si, instruction.Xi, instruction.Sj);
            isConverted = false;
        }
        /// <summary>
        /// supprimer l'instruction dont les parametres sont en entée
        /// </summary>
        /// <param name="Si"></param>
        /// <param name="Xi"></param>
        /// <param name="Sj"></param>

        public void RemoveInstruction(int Si, char Xi, int Sj)
        {
            this.I[Si, toIndex(Xi)].Remove(Sj);
            isConverted = false;
        }
        public void RemoveInstruction(Instruction instruction)
        {
            RemoveInstruction(instruction.Si, instruction.Xi, instruction.Sj);
            isConverted = false;
        }
        /// <summary>
        /// Supprimer toures les instructions de l'automate
        /// </summary>
        /// <param name="Si"></param>
        /// <param name="Xi"></param>
        public void RemoveAllInstructions(int Si, char Xi)
        {
            this.I[Si, toIndex(Xi)].Clear();
        }
        /// <summary>
        /// ordrer les instructions de l'automate
        /// </summary>
        /// <param name="Si"></param>
        /// <param name="Xi"></param>

        public void SortInstructions(int Si, char Xi)
        {
            this.I[Si, toIndex(Xi)].Sort();
        }
        /// <summary>
        /// obtenir l'etat final de l'instruction à partir des parametres en entrée
        /// </summary>
        /// <param name="Si"></param>
        /// <param name="Xi"></param>
        /// <returns></returns>

        public override ArrayList getInstruction(int Si, char Xi)
        {
            try
            {
                return this.I[Si, toIndex(Xi)];
            }
            catch (Exception)
            {
                return null;
                
            }
            
        }
        /// <summary>
        /// retourner un automate non deterministe à partir de l'automate patiellement généralisé
        /// </summary>
        /// <returns></returns>

        public override Nfa toNfa()
        {
            if (isConverted)
                return Nfa_CV;
            ArrayList x = (ArrayList)this.X.Clone();
            x.Remove(EPSILON);
            Nfa_CV = new Nfa(x, this.S, this.S0, this.F, new ArrayList[this.S, this.X.Count - 1]);

            for (int i = 0; i < this.S; i++)
                foreach (char car in Nfa_CV.X)
                {
                    Nfa_CV.AddInstruction(i, car, new ArrayList(this.getInstruction(i, car)));
                }
            for (int i = 0; i < this.S; i++)
            {
                foreach (int state in this.getInstruction(i, EPSILON))
                    foreach (char car in Nfa_CV.X)
                        Nfa_CV.AddInstruction(i, car, getInstruction(state, car));
                if (Intersect(this.getInstruction(i, EPSILON), Nfa_CV.F) && (!Nfa_CV.F.Contains(i)))
                    Nfa_CV.F.Add(i);
            }
            isConverted = true;
            return Nfa_CV;
        }
        /// <summary>
        /// retourner un automate deterministe à partir de l'automate patiellement généralisé
        /// </summary>
        /// <returns></returns>
        public override Dfa toDfa()
        {
            if (!isConverted)
                toNfa();
            return Nfa_CV.toDfa();
        }
        /// <summary>
        /// retourner un automate deterministe complet à partir de l'automate patiellement généralisé
        /// </summary>
        /// <returns></returns>
        public override Dfa toComplete()
        {
            if (!isConverted)
                toNfa();
            PGfa temp = new PGfa(this.X, this.S, this.S0, this.F, (ArrayList[,])this.getInstructionTable());
            return Nfa_CV.toDfa().toComplete();

        }
        /// <summary>
        /// retourner un automate deterministe reduit à partir de l'automate patiellement généralisé
        /// </summary>
        /// <returns></returns>
        public override Dfa toReduced()
        {
            if (!isConverted)
                toNfa();
            PGfa temp = new PGfa(this.X, this.S, this.S0, this.F, (ArrayList[,])this.getInstructionTable());
            return temp.toDfa().toReduced();
        }
		
        public override PGfa toPGfa()
        {
            PGfa temp = new PGfa(this.X, this.S, this.S0, this.F, (ArrayList[,])this.getInstructionTable());
            return temp;
        }
        /// <summary>
        /// retourner un automate généralisé à partir de l'automate patiellement généralisé
        /// </summary>
        /// <returns></returns>
        public override Gfa toGfa()
        {
            return new Gfa(this.X, this.S, this.S0, this.F, (ArrayList[,])this.getInstructionTable());
        }
        /// <summary>
        /// reconnaitre  le mot  en enreée
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>

        public override bool Recognize(String word)
        {
            if (!isConverted)
                toNfa();
            return Nfa_CV.Recognize(word);
        }
		
		
        public override string trace(String word)
        {
            if (!isConverted)
                toNfa();
            return Nfa_CV.trace(word);
        }






    }
}
