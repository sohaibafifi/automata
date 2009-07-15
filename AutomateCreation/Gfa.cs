using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Automates
{
    public class Gfa : Automata
    {
        
        public ArrayList Read = new ArrayList();
        protected PGfa PGfa_CV;
        
        public Gfa(ArrayList X, int S, int S0, ArrayList F, ArrayList[,] I)
        {
            setType(TYPE.Gfa);

            this.X = (ArrayList)X.Clone();
            if (!X.Contains(EPSILON))
                this.X.Add(EPSILON);


            this.Read = (ArrayList)X.Clone();
            this.S = S;
            this.S0 = S0;
            this.F = (ArrayList)F.Clone();
            InitI(I);
        }

        public Gfa()
        {
            setType(TYPE.Gfa);
            this.X.Add(EPSILON);
            InitI();
        }

		public override void InitI()
        {
            this.I = new ArrayList[this.S, this.Read.Count];
            for (int i = 0; i < this.S; i++)
                for (int j = 0; j < this.Read.Count; j++)
                    this.I[i, j] = new ArrayList();
        }

        public override void InitI(ArrayList[,] I)
        {
            this.I = new ArrayList[this.S, this.Read.Count];
            for (int i = 0; i < this.S; i++)
                for (int j = 0; j < this.Read.Count; j++)
                    if (i < I.GetLength(0))
                        this.I[i, j] = new ArrayList(I[i, j]);
                    else
                        this.I[i, j] = new ArrayList();
        }
		
        public void AddInstruction(int Si, String Word, int Sj)
        {
            if (this.I[Si, toIndex(Word)].Contains(Sj))
                return;
            this.I[Si, toIndex(Word)].Add(Sj);
            isConverted = false;
        }
        public void AddInstruction(int Si, Char Xi, int Sj)
        {
            AddInstruction(Si, Xi.ToString(), Sj);
        }
        public void AddInstruction(int Si, String Xi, ArrayList SjList)
        {
            foreach (int Sj in SjList)
                AddInstruction(Si, Xi, Sj);
            
        }
        public void AddInstruction(GfaInstruction instruction)
        {
            AddInstruction(instruction.Si, instruction.Xi, instruction.Sj);
            
        }

        public void RemoveInstruction(int Si, String Xi, int Sj)
        {
            this.I[Si, toIndex(Xi)].Remove(Sj);
            isConverted = false;
        }
        public void RemoveInstruction(GfaInstruction instruction)
        {
            RemoveInstruction(instruction.Si, instruction.Xi, instruction.Sj);
            
        }
        public void RemoveAllInstructions(int Si, String Xi)
        {
            this.I[Si, toIndex(Xi)].Clear();
        }

        public ArrayList getInstruction(int Si, String Xi)
        {
            return this.I[Si, toIndex(Xi)];
        }

        public void SortInstructions(int Si, String Xi)
        {
            this.I[Si, toIndex(Xi)].Sort();
        }
        
        

        
		
		
		
		
		public override PGfa getMirror()
        {
            return toPGfa().getMirror();
        }

        public int toIndex(String word)
        {
			if (word.Length == 1)
                return this.Read.IndexOf(word[0]);
            if (word == "")
                return this.Read.IndexOf(EPSILON);
            return this.Read.IndexOf(word);
        }

        public override PGfa toPGfa()
        {
             if (isConverted)
                return this.PGfa_CV;
            if (this.X.Count == this.Read.Count)
            {
                PGfa_CV = new PGfa(this.X, this.S, this.S0, this.F, this.I);
                return PGfa_CV;
            }

            int s = this.X.Count;

            for (int i = this.X.Count; i < this.Read.Count; i++)
                s += ((String) this.Read[i].ToString()).Length - 1;

            PGfa_CV = new PGfa(this.X, s, this.S0, this.F, this.I);
            if (!PGfa_CV.X.Contains(Automata.EPSILON))
                PGfa_CV.X.Add(Automata.EPSILON);
            s = this.S;
            for (int i = 0; i < this.S; i++)
            {
                for (int j = this.X.Count; (i < PGfa_CV.S) && (j < Read.Count) && (((String)Read[j].ToString()).Length > 0); j++)
                {
                    String temp = (String)Read[j].ToString();
                    
                    if (getInstruction(i, temp).Count > 0)
                    {
                        PGfa_CV.AddInstruction(i, temp[0], s++);
                        for (int k = 1; (k < temp.Length - 1) && (s <= PGfa_CV.S); k++)
                            PGfa_CV.AddInstruction(s - 1, temp[k], s++);
                        if (s <= PGfa_CV.S)
                            PGfa_CV.AddInstruction((s - 1), temp[temp.Length - 1], getInstruction(i, temp));
                        
                    }
                }
            }
            isConverted = true;
            return PGfa_CV;
        }
        public override Nfa toNfa()
        {
            if (!isConverted)
                toPGfa();
            return PGfa_CV.toNfa();
        }
        public override Dfa toDfa()
        {
            if (!isConverted)
                toPGfa();
            return PGfa_CV.toNfa().toDfa();
        }
        public override Dfa toComplete()
        {
            if (!isConverted)
                toPGfa();
            return PGfa_CV.toNfa().toDfa().toComplete();
        }
		public override Gfa toGfa()
        {
            Gfa temp = new Gfa(this.X , this.S , this.S0,this.F,(ArrayList[,])this.getInstructionTable());
            return temp;
        }
        public override Dfa toReduced()
        {
            if (!isConverted)
                toPGfa();
            
            return PGfa_CV.toNfa().toDfa().toReduced();
        }
        public override bool Recognize(String word)
        {
            if (!isConverted)
                toPGfa();
            return PGfa_CV.Recognize(word);
        }

        public override string trace(String word)
        {
            if (!isConverted)
                toPGfa();
            return PGfa_CV.trace(word);
        }
    }
}