using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto01_ProgramacionIII
{
    static class Program
    {
        /// <summary>
        /// Autor: Jose Miguel Rojas
        /// Jose Carrillo Mendez
        /// Fecha: 2016/03/02
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Mdi_Principal());
        }
    }
}
