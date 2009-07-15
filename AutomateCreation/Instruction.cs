using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Automates
{
    public class Instruction
    {
        public int Si;
        public char Xi;
        public int Sj;
        public Instruction(int Si, char Xi, int Sj)
        {
            this.Si = Si;
            this.Xi = Xi;
            this.Sj = Sj;
        }
        public override string ToString()
        {
            return "(S"+Si+" , "+Xi+" , S"+Sj+")";
        }
        public bool Equals(Instruction instruction)
        {
            return (this.Si == instruction.Si) && (this.Xi == instruction.Xi) && (this.Sj == instruction.Sj);
        }
    }
}
