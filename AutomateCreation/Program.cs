using System;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;

namespace Automates
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Dfa myDfa= Dfa.readDfa();
            //Application.Run(new DfaCreation(myDfa));
            Application.Run(new main());
        }
    }
}
