﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLunaMConexionBDv4
{
    internal static class Program
    {
        /// <summary>  
        /// Punto de entrada principal para la aplicación.  
        /// </summary>  
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin()); // Corrección: Se debe instanciar directamente la clase frmLogin.  
        }
    }
}
