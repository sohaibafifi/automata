using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Automates
{
    public class GfaInstruction
    {
        public int Si;
        public String Xi;
        public int Sj;
        
        public GfaInstruction(int Si, string Xi, int Sj)
        {
            this.Si = Si;
            if (Xi.Length == 0)
                this.Xi = Automata.EPSILON.ToString();
            else
                this.Xi = Xi;
            this.Sj = Sj;
        }
        public GfaInstruction(int Si, char Xi, int Sj)
        {
            this.Si = Si;
            this.Xi = Xi.ToString();
            this.Sj = Sj;
        }
        public override string ToString()
        {
            return "(S" + Si + "," + Xi + ",S" + Sj + ")";
        }
        public bool Equals(GfaInstruction instruction)
        {
            return (this.Si == instruction.Si) && (this.Xi.Equals(instruction.Xi)) && (this.Sj == instruction.Sj);
        }
    }
}
