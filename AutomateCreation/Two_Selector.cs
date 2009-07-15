using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Automates
{
    public partial class Two_Selector : Form
    {
        public Two_Selector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ListAuto2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
