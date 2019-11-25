using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Desktop.Formularios;
using Projeto_Desktop.Classes;

namespace Projeto_Desktop
{
    static class Program
    {
        public static Usuario userLogado; //Objetos globais
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new FrmPrincipal());
            Application.Run(new FrmLogin());
        }
        
    }
}
