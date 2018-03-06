using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _1SA_2SE_Hauser_Maxilmilian
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
