using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Automates
{
    public partial class AutomateCreation : Form
    {
        public Nfa myNfa = new Nfa();
        public Dfa myDfa = new Dfa();
        public Dfa myCompDfa = new Dfa();
        public Dfa myRdDfa = new Dfa();

        public AutomateCreation()
        {
            this.InitializeComponent();
        }

        private void AutomateCreation_Load(object sender, EventArgs e)
        {
            NfaInfo.Controls[0].Text = "";
            DfaInfo.Controls[0].Text = "";
            ReducedInfo.Controls[0].Text = "";
            CompleteInfo.Controls[0].Text = "";
            this.Size = new Size(490, this.Size.Height);
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabetSelect.Items.Add(i);
            }
            for (char i = '0'; i <= '9'; i++)
            {
                alphabetSelect.Items.Add(i);
            }
            InitialState.Items.Add(States.Items[0]);
            InitialState.SelectedItem = InitialState.Items[0];
        }

        private void lettersIn_Click(object sender, EventArgs e)
        {
            int j = alphabetSelect.SelectedItems.Count;
            for (int i = 0; i < j; i++)
            {
                Alphabet.Items.Add(alphabetSelect.SelectedItems[0]);
                alphabetSelect.Items.Remove(alphabetSelect.SelectedItems[0]);
            }
        }

        private void lettersOut_Click(object sender, EventArgs e)
        {
            int j = Alphabet.SelectedItems.Count;
            for (int i = 0; i < j; i++)
            {
                alphabetSelect.Items.Add(Alphabet.SelectedItems[0]);
                Alphabet.Items.Remove(Alphabet.SelectedItems[0]);
            }
        }

        private void AddState_Click(object sender, EventArgs e)
        {
            string item = "S" + States.Items.Count.ToString();
            States.Items.Add(item);
            InitialState.Items.Add(item);
        }

        private void DeleteState_Click(object sender, EventArgs e)
        {
            int i = States.Items.Count - 1;
            if (i > 0)
            {
                States.Items.RemoveAt(i);
                InitialState.Items.RemoveAt(i);
            }
            else
                MessageBox.Show("There must be at least one State");
            if (InitialState.SelectedItem == null) InitialState.SelectedItem = InitialState.Items[0];
        }

        private void InstructionAdd_Click(object sender, EventArgs e)
        {
            if (stSI.SelectedItem != null && stXI.SelectedItem != null && stSJ.SelectedItems != null)
            {
                int Si = stSI.Items.IndexOf(stSI.SelectedItem);
                char xi = (char)stXI.SelectedItem;
                int Xi = myNfa.toIndex(xi);
                bool empty = InstructionList.Items.Count==0;
                foreach (string SjItem in stSJ.SelectedItems)
                {
                    int Sj = stSJ.Items.IndexOf(SjItem);
                    Instruction instr = new Instruction(Si,xi,Sj);
                    //string instrs = "(" + stSI.Items[Si] + "," + (char)stXI.SelectedItem + "," + stSJ.Items[Sj] + ")";
                    bool contains=false;
                    if (!empty)
                    {
                        contains=(myNfa.I[Si,Xi].Contains(Sj));
                    }
                    if (!contains)
                    {
                        InstructionList.Items.Add(instr);
                        if (myNfa.I[Si, Xi].Contains(-1))
                            myNfa.I[Si, Xi].Clear();
                        myNfa.I[Si, Xi].Add(Sj);
                        myNfa.I[Si, Xi].Sort();
                        if (ValidateInstructions.Enabled == false) ValidateInstructions.Enabled = true;
                    }
                }
                stSJ.SelectedItems.Clear();
            }
        }

        private void InstructionDelete_Click(object sender, EventArgs e)
        {
            if (InstructionList.SelectedItems != null)
            {
                for(int i=0;i<InstructionList.SelectedItems.Count;i++){
                    Instruction instr=(Instruction)InstructionList.SelectedItems[i];
                    int Si = instr.Si;
                    int Xi = myNfa.toIndex(instr.Xi);
                    int Sj = instr.Sj;
                    InstructionList.Items.Remove(InstructionList.SelectedItem);
                    if (myNfa.I[Si, Xi].Count == 1)
                    {
                        myNfa.I[Si, Xi].Clear();
                        myNfa.I[Si, Xi].Add(-1);
                    }
                    else
                        myNfa.I[Si, Xi].Remove(Sj);
                    if (ValidateInstructions.Enabled == false) ValidateInstructions.Enabled = true;
                }
            }
        }

        private void validateAlphaState_Click(object sender, EventArgs e)
        {
            if (Alphabet.Items.Count > 0)
            {
                AlphabetCreation.Enabled = StateCreation.Enabled = validateAlphaState.Enabled = false;
                group.Enabled = true;
                myNfa = new Nfa();
                myNfa.S0 = (int)States.Items.IndexOf(InitialState.SelectedItem);
                for (int i = 0; i < Alphabet.Items.Count; i++)
                {
                    myNfa.X.Add((char)Alphabet.Items[i]);
                    stXI.Items.Add(Alphabet.Items[i]);
                }
                myNfa.S = States.Items.Count;
                for (int i = 0; i < States.CheckedItems.Count; i++)
                    myNfa.F.Add(States.Items.IndexOf(States.CheckedItems[i]));
                int j = 0;
                for (; j < States.Items.Count; j++)
                {
                    stSI.Items.Add(States.Items[j]);
                    stSJ.Items.Add(States.Items[j]);
                }
            }
            else MessageBox.Show("The Alphabet must contain at least one letter!");
        }

        private void ChangeParam_Click(object sender, EventArgs e)
        {
            stSI.Items.Clear();
            stSJ.Items.Clear();
            stXI.Items.Clear();
            InstructionList.Items.Clear();
            AlphabetCreation.Enabled = StateCreation.Enabled = validateAlphaState.Enabled= true;
            group.Enabled = false;
        }

        private void ValidateInstructions_Click(object sender, EventArgs e)
        {
            this.myDfa = myNfa.toDfa();
            myCompDfa = myNfa.Complete();
            myRdDfa = this.myDfa.Reduce();
            ShowButtons.Enabled = true;
            Test.Enabled = true;
            ValidateInstructions.Enabled = false;
            for (int s = 0; s < myNfa.S; s++)
                foreach (char car in myNfa.X)
                    myNfa.I[s, myNfa.toIndex(car)].Sort();

            NfaInfo.Controls[0].Text = myNfa.toString() + "\n\nInstructions:\n" + myNfa.ItoStringTriplet();
            Dfa myDfa = myNfa.toDfa();
            DfaInfo.Controls[0].Text = myDfa.ToString() + "\n\n" + myNfa.StCorTabToString() + "\n\nInstructions:\n" + myDfa.ItoStringTriplet();
            Dfa myTempDfa = myDfa.Reduce();
            ReducedInfo.Controls[0].Text = myTempDfa.ToString() + "\n\n" + myNfa.StCorTabToString() + "\n\n" + myTempDfa.Rd_StoString() + "\nInstructions:\n" + myTempDfa.ItoStringTriplet();
            myTempDfa = myDfa.Complete();
            CompleteInfo.Controls[0].Text = myTempDfa.ToString() + "\n\n" + myNfa.StCorTabToString() + "\n\nInstructions:\n" + myTempDfa.ItoStringTriplet();
        }

        private void NfaInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myNfa.toString() + "\n\nInstructions:\n" + myNfa.ItoString(), "Paramètre de l'automate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DfaInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myDfa.ToString() + "\n\n" + myNfa.StCorTabToString() + "\nInstructions:\n" + myDfa.ItoString(), "Paramètre de l'automate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ReducedInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myRdDfa.ToString() + "\n\n" + myNfa.StCorTabToString() + "\n\n" + myRdDfa.Rd_StoString() + "\nInstructions:\n" + myRdDfa.ItoString(), "Paramètre de l'automate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CompleteInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myCompDfa.ToString() + "\n\n" + myNfa.StCorTabToString() + "\nInstructions:\n" + myCompDfa.ItoString(), "Paramètre de l'automate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Verify_Click(object sender, EventArgs e)
        {
            if (word.Text != null)
            {
                Dfa myDfa = myNfa.toDfa();
                string answer = (myDfa.Recognize(word.Text)) ? "The word is recognized by the Automata" : "The word is NOT recognized by the Automata";
                MessageBox.Show(answer);
            }
        }


        private void AlphabetCreation_EnabledChanged(object sender, EventArgs e)
        {
            StateCreation.Enabled = AlphabetCreation.Enabled;
            instructionCreate.Enabled = ValidateInstructions.Enabled = ShowButtons.Enabled=Test.Enabled=!AlphabetCreation.Enabled;
        }

        private void ValidateInstructions_EnabledChanged(object sender, EventArgs e)
        {
            ShowButtons.Enabled = Test.Enabled=!ValidateInstructions.Enabled;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Really!!", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            ShowMore.Text = ">";
            this.Size = new Size(490, this.Size.Height);
            ChangeParam_Click(this, null);
            Alphabet.Items.Clear();
            States.Items.Clear();
            InitialState.Items.Clear();
            alphabetSelect.Items.Clear();
            States.Items.Add("S0");
            AutomateCreation_Load(this, null);
        }

        private void ShowMore_Click(object sender, EventArgs e)
        {
            if (ShowMore.Text == ">")
            {
                ShowMore.Text = "<";
                this.Size = new Size(810, this.Size.Height);
            }
            else
            {
                ShowMore.Text = ">";
                this.Size = new Size(490, this.Size.Height);
            }
        }

        private void ShowButtons_EnabledChanged(object sender, EventArgs e)
        {
            ShowMore.Text = ">";
            this.Size = new Size(490, this.Size.Height);
            ShowMore.Enabled = ShowButtons.Enabled;
        }

        private void group_Enter(object sender, EventArgs e)
        {

        }
    }
}
