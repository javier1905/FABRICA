﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
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
            //Application.Run(new FormLogin());
            //Application.Run(new FormBASEtradicional());
            //Application.Run(new AREASform());
            //Application.Run(new CONTENEDORform());
            //Application.Run(new PUESTOSform());
            Application.Run(new TRABAJADORESform());
        }
    }
}
