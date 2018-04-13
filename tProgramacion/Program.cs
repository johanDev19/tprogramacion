using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tProgramacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {

            //nombre y matricula de los participantes
            //Ricky Suriel Zabala 15-EISN-1-296
            //Ramón Emilio De Jesús Brito 14-EIST-1-127
            //Johan Humberto Guzman Gil 14-SISM-1-001
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
