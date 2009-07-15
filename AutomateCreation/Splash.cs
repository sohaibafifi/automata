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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            for (double i = 0; i < 1; i += 0.1)
            {

                this.Opacity = i;
                this.Refresh();
                System.Threading.Thread.Sleep(20);
            }

            this.Refresh();
            for (int i = 0; i < 10; i++)
            {
                progress.PerformStep();
                System.Threading.Thread.Sleep(200);                
            }
            
            //System.Threading.Thread.Sleep(2000);
            
            for (double i = 0; i < 1; i += 0.1)
            {
               
                this.Opacity = this.Opacity - i;
                this.Refresh();
                System.Threading.Thread.Sleep(200);
            }
            this.Close();
        }
    }
}
