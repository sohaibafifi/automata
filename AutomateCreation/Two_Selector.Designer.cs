namespace Automates
{
    partial class Two_Selector
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
            this.listAuto1 = new System.Windows.Forms.ListBox();
            this.ListAuto2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listAuto1
            // 
            this.listAuto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listAuto1.FormattingEnabled = true;
            this.listAuto1.Location = new System.Drawing.Point(12, 12);
            this.listAuto1.Name = "listAuto1";
            this.listAuto1.Size = new System.Drawing.Size(171, 197);
            this.listAuto1.TabIndex = 0;
            // 
            // ListAuto2
            // 
            this.ListAuto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListAuto2.FormattingEnabled = true;
            this.ListAuto2.Location = new System.Drawing.Point(201, 12);
            this.ListAuto2.Name = "ListAuto2";
            this.ListAuto2.Size = new System.Drawing.Size(171, 197);
            this.ListAuto2.TabIndex = 1;
            this.ListAuto2.SelectedIndexChanged += new System.EventHandler(this.ListAuto2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(102, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Two_Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListAuto2);
            this.Controls.Add(this.listAuto1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Two_Selector";
            this.Text = "Selectionner deux automates";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox listAuto1;
        public System.Windows.Forms.ListBox ListAuto2;
    }
}