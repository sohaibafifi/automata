namespace Automates
{
    partial class AutomateCreation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AlphabetCreation = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Alphabet = new System.Windows.Forms.ListBox();
            this.lettersOut = new System.Windows.Forms.Button();
            this.lettersIn = new System.Windows.Forms.Button();
            this.alphabetSelect = new System.Windows.Forms.ListBox();
            this.StateCreation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StateDelete = new System.Windows.Forms.Button();
            this.StateAdd = new System.Windows.Forms.Button();
            this.slctInitState = new System.Windows.Forms.Label();
            this.InitialState = new System.Windows.Forms.ComboBox();
            this.States = new System.Windows.Forms.CheckedListBox();
            this.Info = new System.Windows.Forms.TabControl();
            this.NfaInfo = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.DfaInfo = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.ReducedInfo = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.CompleteInfo = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.GroupBox();
            this.Test = new System.Windows.Forms.GroupBox();
            this.word = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ValidateInstructions = new System.Windows.Forms.Button();
            this.instructionCreate = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.InstructionDelete = new System.Windows.Forms.Button();
            this.InstructionAdd = new System.Windows.Forms.Button();
            this.InstructionList = new System.Windows.Forms.ListBox();
            this.stXI = new System.Windows.Forms.ComboBox();
            this.stSI = new System.Windows.Forms.ComboBox();
            this.validateAlphaState = new System.Windows.Forms.Button();
            this.ChangeParam = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ShowMore = new System.Windows.Forms.Button();
            this.CompleteInfoButton = new System.Windows.Forms.Button();
            this.ReducedInfoButton = new System.Windows.Forms.Button();
            this.DfaInfoButton = new System.Windows.Forms.Button();
            this.NfaInfoButton = new System.Windows.Forms.Button();
            this.ShowButtons = new System.Windows.Forms.GroupBox();
            this.stSJ = new System.Windows.Forms.ListBox();
            this.AlphabetCreation.SuspendLayout();
            this.StateCreation.SuspendLayout();
            this.Info.SuspendLayout();
            this.NfaInfo.SuspendLayout();
            this.DfaInfo.SuspendLayout();
            this.ReducedInfo.SuspendLayout();
            this.CompleteInfo.SuspendLayout();
            this.group.SuspendLayout();
            this.Test.SuspendLayout();
            this.instructionCreate.SuspendLayout();
            this.ShowButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlphabetCreation
            // 
            this.AlphabetCreation.Controls.Add(this.label2);
            this.AlphabetCreation.Controls.Add(this.Alphabet);
            this.AlphabetCreation.Controls.Add(this.lettersOut);
            this.AlphabetCreation.Controls.Add(this.lettersIn);
            this.AlphabetCreation.Controls.Add(this.alphabetSelect);
            this.AlphabetCreation.Location = new System.Drawing.Point(12, 12);
            this.AlphabetCreation.Name = "AlphabetCreation";
            this.AlphabetCreation.Size = new System.Drawing.Size(184, 119);
            this.AlphabetCreation.TabIndex = 0;
            this.AlphabetCreation.TabStop = false;
            this.AlphabetCreation.Text = "Alphabet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected";
            // 
            // Alphabet
            // 
            this.Alphabet.FormattingEnabled = true;
            this.Alphabet.Location = new System.Drawing.Point(137, 16);
            this.Alphabet.Name = "Alphabet";
            this.Alphabet.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Alphabet.Size = new System.Drawing.Size(36, 95);
            this.Alphabet.Sorted = true;
            this.Alphabet.TabIndex = 3;
            this.Alphabet.DoubleClick += new System.EventHandler(this.lettersOut_Click);
            // 
            // lettersOut
            // 
            this.lettersOut.Location = new System.Drawing.Point(69, 66);
            this.lettersOut.Name = "lettersOut";
            this.lettersOut.Size = new System.Drawing.Size(50, 23);
            this.lettersOut.TabIndex = 2;
            this.lettersOut.Text = "<<";
            this.lettersOut.UseVisualStyleBackColor = true;
            this.lettersOut.Click += new System.EventHandler(this.lettersOut_Click);
            // 
            // lettersIn
            // 
            this.lettersIn.Location = new System.Drawing.Point(69, 37);
            this.lettersIn.Name = "lettersIn";
            this.lettersIn.Size = new System.Drawing.Size(50, 23);
            this.lettersIn.TabIndex = 1;
            this.lettersIn.Text = ">>";
            this.lettersIn.UseVisualStyleBackColor = true;
            this.lettersIn.Click += new System.EventHandler(this.lettersIn_Click);
            // 
            // alphabetSelect
            // 
            this.alphabetSelect.FormattingEnabled = true;
            this.alphabetSelect.Location = new System.Drawing.Point(11, 16);
            this.alphabetSelect.Name = "alphabetSelect";
            this.alphabetSelect.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.alphabetSelect.Size = new System.Drawing.Size(36, 95);
            this.alphabetSelect.Sorted = true;
            this.alphabetSelect.TabIndex = 0;
            this.alphabetSelect.DoubleClick += new System.EventHandler(this.lettersIn_Click);
            // 
            // StateCreation
            // 
            this.StateCreation.Controls.Add(this.label1);
            this.StateCreation.Controls.Add(this.StateDelete);
            this.StateCreation.Controls.Add(this.StateAdd);
            this.StateCreation.Controls.Add(this.slctInitState);
            this.StateCreation.Controls.Add(this.InitialState);
            this.StateCreation.Controls.Add(this.States);
            this.StateCreation.Location = new System.Drawing.Point(202, 12);
            this.StateCreation.Name = "StateCreation";
            this.StateCreation.Size = new System.Drawing.Size(261, 119);
            this.StateCreation.TabIndex = 1;
            this.StateCreation.TabStop = false;
            this.StateCreation.Text = "Etats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please check the final states";
            // 
            // StateDelete
            // 
            this.StateDelete.Location = new System.Drawing.Point(73, 62);
            this.StateDelete.Name = "StateDelete";
            this.StateDelete.Size = new System.Drawing.Size(75, 23);
            this.StateDelete.TabIndex = 3;
            this.StateDelete.Text = "Delete State";
            this.StateDelete.UseVisualStyleBackColor = true;
            this.StateDelete.Click += new System.EventHandler(this.DeleteState_Click);
            // 
            // StateAdd
            // 
            this.StateAdd.Location = new System.Drawing.Point(73, 35);
            this.StateAdd.Name = "StateAdd";
            this.StateAdd.Size = new System.Drawing.Size(75, 23);
            this.StateAdd.TabIndex = 2;
            this.StateAdd.Text = "Add State";
            this.StateAdd.UseVisualStyleBackColor = true;
            this.StateAdd.Click += new System.EventHandler(this.AddState_Click);
            // 
            // slctInitState
            // 
            this.slctInitState.AutoSize = true;
            this.slctInitState.Location = new System.Drawing.Point(158, 16);
            this.slctInitState.Name = "slctInitState";
            this.slctInitState.Size = new System.Drawing.Size(89, 13);
            this.slctInitState.TabIndex = 2;
            this.slctInitState.Text = "Select initial state";
            // 
            // InitialState
            // 
            this.InitialState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.InitialState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.InitialState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InitialState.FormattingEnabled = true;
            this.InitialState.Location = new System.Drawing.Point(161, 37);
            this.InitialState.Name = "InitialState";
            this.InitialState.Size = new System.Drawing.Size(86, 21);
            this.InitialState.TabIndex = 1;
            // 
            // States
            // 
            this.States.CheckOnClick = true;
            this.States.FormattingEnabled = true;
            this.States.Items.AddRange(new object[] {
            "S0"});
            this.States.Location = new System.Drawing.Point(12, 16);
            this.States.Name = "States";
            this.States.Size = new System.Drawing.Size(55, 94);
            this.States.TabIndex = 0;
            // 
            // Info
            // 
            this.Info.Controls.Add(this.NfaInfo);
            this.Info.Controls.Add(this.DfaInfo);
            this.Info.Controls.Add(this.ReducedInfo);
            this.Info.Controls.Add(this.CompleteInfo);
            this.Info.Location = new System.Drawing.Point(483, 18);
            this.Info.Name = "Info";
            this.Info.SelectedIndex = 0;
            this.Info.Size = new System.Drawing.Size(311, 339);
            this.Info.TabIndex = 15;
            // 
            // NfaInfo
            // 
            this.NfaInfo.AutoScroll = true;
            this.NfaInfo.BackColor = System.Drawing.Color.White;
            this.NfaInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NfaInfo.Controls.Add(this.label4);
            this.NfaInfo.Location = new System.Drawing.Point(4, 22);
            this.NfaInfo.Name = "NfaInfo";
            this.NfaInfo.Padding = new System.Windows.Forms.Padding(3);
            this.NfaInfo.Size = new System.Drawing.Size(303, 313);
            this.NfaInfo.TabIndex = 0;
            this.NfaInfo.Text = "Param. Nfa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nfa Information:";
            // 
            // DfaInfo
            // 
            this.DfaInfo.AutoScroll = true;
            this.DfaInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DfaInfo.Controls.Add(this.label5);
            this.DfaInfo.Location = new System.Drawing.Point(4, 22);
            this.DfaInfo.Name = "DfaInfo";
            this.DfaInfo.Padding = new System.Windows.Forms.Padding(3);
            this.DfaInfo.Size = new System.Drawing.Size(303, 313);
            this.DfaInfo.TabIndex = 1;
            this.DfaInfo.Text = "Param. Dfa (EQ)";
            this.DfaInfo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dfa (Equivalent) Information:";
            // 
            // ReducedInfo
            // 
            this.ReducedInfo.AutoScroll = true;
            this.ReducedInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ReducedInfo.Controls.Add(this.label6);
            this.ReducedInfo.Location = new System.Drawing.Point(4, 22);
            this.ReducedInfo.Name = "ReducedInfo";
            this.ReducedInfo.Padding = new System.Windows.Forms.Padding(3);
            this.ReducedInfo.Size = new System.Drawing.Size(303, 313);
            this.ReducedInfo.TabIndex = 2;
            this.ReducedInfo.Text = "Param. Reduced";
            this.ReducedInfo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Reduced Nfa Information:";
            // 
            // CompleteInfo
            // 
            this.CompleteInfo.AutoScroll = true;
            this.CompleteInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CompleteInfo.Controls.Add(this.label7);
            this.CompleteInfo.Location = new System.Drawing.Point(4, 22);
            this.CompleteInfo.Name = "CompleteInfo";
            this.CompleteInfo.Padding = new System.Windows.Forms.Padding(3);
            this.CompleteInfo.Size = new System.Drawing.Size(303, 313);
            this.CompleteInfo.TabIndex = 3;
            this.CompleteInfo.Text = "Param. Complete";
            this.CompleteInfo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Complete Nfa Information:";
            // 
            // group
            // 
            this.group.Controls.Add(this.Test);
            this.group.Controls.Add(this.ShowButtons);
            this.group.Controls.Add(this.ValidateInstructions);
            this.group.Controls.Add(this.instructionCreate);
            this.group.Enabled = false;
            this.group.Location = new System.Drawing.Point(10, 168);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(453, 189);
            this.group.TabIndex = 21;
            this.group.TabStop = false;
            this.group.Enter += new System.EventHandler(this.group_Enter);
            // 
            // Test
            // 
            this.Test.Controls.Add(this.word);
            this.Test.Controls.Add(this.label3);
            this.Test.Controls.Add(this.button1);
            this.Test.Enabled = false;
            this.Test.Location = new System.Drawing.Point(109, 147);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(234, 36);
            this.Test.TabIndex = 24;
            this.Test.TabStop = false;
            // 
            // word
            // 
            this.word.Location = new System.Drawing.Point(40, 12);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(113, 20);
            this.word.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Word";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "verify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Verify_Click);
            // 
            // ValidateInstructions
            // 
            this.ValidateInstructions.Location = new System.Drawing.Point(262, 54);
            this.ValidateInstructions.Name = "ValidateInstructions";
            this.ValidateInstructions.Size = new System.Drawing.Size(75, 39);
            this.ValidateInstructions.TabIndex = 22;
            this.ValidateInstructions.Text = "Validate Instructions";
            this.ValidateInstructions.UseVisualStyleBackColor = true;
            this.ValidateInstructions.Click += new System.EventHandler(this.ValidateInstructions_Click);
            this.ValidateInstructions.EnabledChanged += new System.EventHandler(this.ValidateInstructions_EnabledChanged);
            // 
            // instructionCreate
            // 
            this.instructionCreate.Controls.Add(this.stSJ);
            this.instructionCreate.Controls.Add(this.label10);
            this.instructionCreate.Controls.Add(this.label9);
            this.instructionCreate.Controls.Add(this.label8);
            this.instructionCreate.Controls.Add(this.InstructionDelete);
            this.instructionCreate.Controls.Add(this.InstructionAdd);
            this.instructionCreate.Controls.Add(this.InstructionList);
            this.instructionCreate.Controls.Add(this.stXI);
            this.instructionCreate.Controls.Add(this.stSI);
            this.instructionCreate.Location = new System.Drawing.Point(6, 8);
            this.instructionCreate.Name = "instructionCreate";
            this.instructionCreate.Size = new System.Drawing.Size(241, 139);
            this.instructionCreate.TabIndex = 21;
            this.instructionCreate.TabStop = false;
            this.instructionCreate.Text = "Instructions";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Sj";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Xi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Si";
            // 
            // InstructionDelete
            // 
            this.InstructionDelete.Location = new System.Drawing.Point(17, 99);
            this.InstructionDelete.Name = "InstructionDelete";
            this.InstructionDelete.Size = new System.Drawing.Size(75, 23);
            this.InstructionDelete.TabIndex = 5;
            this.InstructionDelete.Text = "Delete";
            this.InstructionDelete.UseVisualStyleBackColor = true;
            this.InstructionDelete.Click += new System.EventHandler(this.InstructionDelete_Click);
            // 
            // InstructionAdd
            // 
            this.InstructionAdd.Location = new System.Drawing.Point(24, 63);
            this.InstructionAdd.Name = "InstructionAdd";
            this.InstructionAdd.Size = new System.Drawing.Size(61, 23);
            this.InstructionAdd.TabIndex = 4;
            this.InstructionAdd.Text = ">>";
            this.InstructionAdd.UseVisualStyleBackColor = true;
            this.InstructionAdd.Click += new System.EventHandler(this.InstructionAdd_Click);
            // 
            // InstructionList
            // 
            this.InstructionList.FormattingEnabled = true;
            this.InstructionList.Location = new System.Drawing.Point(157, 12);
            this.InstructionList.Name = "InstructionList";
            this.InstructionList.Size = new System.Drawing.Size(78, 121);
            this.InstructionList.TabIndex = 3;
            this.InstructionList.DoubleClick += new System.EventHandler(this.InstructionDelete_Click);
            // 
            // stXI
            // 
            this.stXI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stXI.FormattingEnabled = true;
            this.stXI.Location = new System.Drawing.Point(57, 36);
            this.stXI.Name = "stXI";
            this.stXI.Size = new System.Drawing.Size(40, 21);
            this.stXI.TabIndex = 1;
            // 
            // stSI
            // 
            this.stSI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stSI.FormattingEnabled = true;
            this.stSI.Location = new System.Drawing.Point(11, 36);
            this.stSI.Name = "stSI";
            this.stSI.Size = new System.Drawing.Size(40, 21);
            this.stSI.TabIndex = 0;
            // 
            // validateAlphaState
            // 
            this.validateAlphaState.Location = new System.Drawing.Point(88, 142);
            this.validateAlphaState.Name = "validateAlphaState";
            this.validateAlphaState.Size = new System.Drawing.Size(75, 23);
            this.validateAlphaState.TabIndex = 3;
            this.validateAlphaState.Text = "Validate";
            this.validateAlphaState.UseVisualStyleBackColor = true;
            this.validateAlphaState.Click += new System.EventHandler(this.validateAlphaState_Click);
            // 
            // ChangeParam
            // 
            this.ChangeParam.Location = new System.Drawing.Point(202, 142);
            this.ChangeParam.Name = "ChangeParam";
            this.ChangeParam.Size = new System.Drawing.Size(119, 23);
            this.ChangeParam.TabIndex = 5;
            this.ChangeParam.Text = "Change Parameters";
            this.ChangeParam.UseVisualStyleBackColor = true;
            this.ChangeParam.Click += new System.EventHandler(this.ChangeParam_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(327, 142);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear All";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ShowMore
            // 
            this.ShowMore.Enabled = false;
            this.ShowMore.Location = new System.Drawing.Point(466, 119);
            this.ShowMore.Name = "ShowMore";
            this.ShowMore.Size = new System.Drawing.Size(15, 70);
            this.ShowMore.TabIndex = 1;
            this.ShowMore.Text = ">";
            this.ShowMore.UseVisualStyleBackColor = true;
            this.ShowMore.Click += new System.EventHandler(this.ShowMore_Click);
            // 
            // CompleteInfoButton
            // 
            this.CompleteInfoButton.Location = new System.Drawing.Point(11, 107);
            this.CompleteInfoButton.Name = "CompleteInfoButton";
            this.CompleteInfoButton.Size = new System.Drawing.Size(75, 23);
            this.CompleteInfoButton.TabIndex = 18;
            this.CompleteInfoButton.Text = "Complete";
            this.CompleteInfoButton.UseVisualStyleBackColor = true;
            this.CompleteInfoButton.Click += new System.EventHandler(this.CompleteInfo_Click);
            // 
            // ReducedInfoButton
            // 
            this.ReducedInfoButton.Location = new System.Drawing.Point(11, 78);
            this.ReducedInfoButton.Name = "ReducedInfoButton";
            this.ReducedInfoButton.Size = new System.Drawing.Size(75, 23);
            this.ReducedInfoButton.TabIndex = 19;
            this.ReducedInfoButton.Text = "Reduced";
            this.ReducedInfoButton.UseVisualStyleBackColor = true;
            this.ReducedInfoButton.Click += new System.EventHandler(this.ReducedInfo_Click);
            // 
            // DfaInfoButton
            // 
            this.DfaInfoButton.Location = new System.Drawing.Point(11, 49);
            this.DfaInfoButton.Name = "DfaInfoButton";
            this.DfaInfoButton.Size = new System.Drawing.Size(75, 23);
            this.DfaInfoButton.TabIndex = 20;
            this.DfaInfoButton.Text = "Dfa";
            this.DfaInfoButton.UseVisualStyleBackColor = true;
            this.DfaInfoButton.Click += new System.EventHandler(this.DfaInfo_Click);
            // 
            // NfaInfoButton
            // 
            this.NfaInfoButton.Location = new System.Drawing.Point(11, 20);
            this.NfaInfoButton.Name = "NfaInfoButton";
            this.NfaInfoButton.Size = new System.Drawing.Size(75, 23);
            this.NfaInfoButton.TabIndex = 21;
            this.NfaInfoButton.Text = "Nfa";
            this.NfaInfoButton.UseVisualStyleBackColor = true;
            this.NfaInfoButton.Click += new System.EventHandler(this.NfaInfo_Click);
            // 
            // ShowButtons
            // 
            this.ShowButtons.Controls.Add(this.NfaInfoButton);
            this.ShowButtons.Controls.Add(this.DfaInfoButton);
            this.ShowButtons.Controls.Add(this.ReducedInfoButton);
            this.ShowButtons.Controls.Add(this.CompleteInfoButton);
            this.ShowButtons.Enabled = false;
            this.ShowButtons.Location = new System.Drawing.Point(352, 8);
            this.ShowButtons.Name = "ShowButtons";
            this.ShowButtons.Size = new System.Drawing.Size(94, 139);
            this.ShowButtons.TabIndex = 23;
            this.ShowButtons.TabStop = false;
            this.ShowButtons.Text = "Show...";
            this.ShowButtons.EnabledChanged += new System.EventHandler(this.ShowButtons_EnabledChanged);
            // 
            // stSJ
            // 
            this.stSJ.FormattingEnabled = true;
            this.stSJ.Location = new System.Drawing.Point(105, 36);
            this.stSJ.Name = "stSJ";
            this.stSJ.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.stSJ.Size = new System.Drawing.Size(46, 82);
            this.stSJ.TabIndex = 9;
            this.stSJ.DoubleClick += new System.EventHandler(this.InstructionAdd_Click);
            // 
            // AutomateCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(802, 363);
            this.Controls.Add(this.ShowMore);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.group);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.ChangeParam);
            this.Controls.Add(this.validateAlphaState);
            this.Controls.Add(this.StateCreation);
            this.Controls.Add(this.AlphabetCreation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AutomateCreation";
            this.Text = "Automata creation";
            this.Load += new System.EventHandler(this.AutomateCreation_Load);
            this.AlphabetCreation.ResumeLayout(false);
            this.AlphabetCreation.PerformLayout();
            this.StateCreation.ResumeLayout(false);
            this.StateCreation.PerformLayout();
            this.Info.ResumeLayout(false);
            this.NfaInfo.ResumeLayout(false);
            this.NfaInfo.PerformLayout();
            this.DfaInfo.ResumeLayout(false);
            this.DfaInfo.PerformLayout();
            this.ReducedInfo.ResumeLayout(false);
            this.ReducedInfo.PerformLayout();
            this.CompleteInfo.ResumeLayout(false);
            this.CompleteInfo.PerformLayout();
            this.group.ResumeLayout(false);
            this.Test.ResumeLayout(false);
            this.Test.PerformLayout();
            this.instructionCreate.ResumeLayout(false);
            this.instructionCreate.PerformLayout();
            this.ShowButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AlphabetCreation;
        private System.Windows.Forms.ListBox alphabetSelect;
        private System.Windows.Forms.ListBox Alphabet;
        private System.Windows.Forms.Button lettersOut;
        private System.Windows.Forms.Button lettersIn;
        private System.Windows.Forms.GroupBox StateCreation;
        private System.Windows.Forms.Button StateDelete;
        private System.Windows.Forms.Button StateAdd;
        private System.Windows.Forms.Label slctInitState;
        private System.Windows.Forms.ComboBox InitialState;
        private System.Windows.Forms.CheckedListBox States;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl Info;
        private System.Windows.Forms.TabPage NfaInfo;
        private System.Windows.Forms.TabPage DfaInfo;
        private System.Windows.Forms.TabPage ReducedInfo;
        private System.Windows.Forms.TabPage CompleteInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Button validateAlphaState;
        private System.Windows.Forms.Button ChangeParam;
        private System.Windows.Forms.GroupBox Test;
        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ValidateInstructions;
        private System.Windows.Forms.GroupBox instructionCreate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button InstructionDelete;
        private System.Windows.Forms.Button InstructionAdd;
        private System.Windows.Forms.ListBox InstructionList;
        private System.Windows.Forms.ComboBox stXI;
        private System.Windows.Forms.ComboBox stSI;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ShowMore;
        private System.Windows.Forms.GroupBox ShowButtons;
        private System.Windows.Forms.Button NfaInfoButton;
        private System.Windows.Forms.Button DfaInfoButton;
        private System.Windows.Forms.Button ReducedInfoButton;
        private System.Windows.Forms.Button CompleteInfoButton;
        private System.Windows.Forms.ListBox stSJ;
    }
}
