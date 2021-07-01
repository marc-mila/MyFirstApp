using MyFirstApp.ForeachLoop;
using MyFirstApp.ForLoop;
using MyFirstApp.Inheritance;
using MyFirstApp.Interfaces;
using MyFirstApp.WhileLoop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInterfaces());
        }
    }
    
}
      
