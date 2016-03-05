using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Validate all fields - including negatives
 * Add login functions - check
 * Add admin functions - check
 * Add UI enhancements
 * Add extra richmond shit
 * Consider multiple accounts and account specific labels
 * Make pretty
 * */

namespace Project_2___MIchael_Feuerstein
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
            Application.Run(new FormLogin());
        }
    }
}
