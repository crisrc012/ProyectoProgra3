using System;
using System.Windows.Forms;
using Proyecto_call_PL.Menu;

namespace Proyecto_call_PL
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Bootstrap.Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_menu_PL());
        }
    }
}
