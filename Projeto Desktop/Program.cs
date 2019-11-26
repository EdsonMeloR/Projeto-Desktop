using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Desktop.Formularios;
using Projeto_Desktop.Classes;
using System.IO;

namespace Projeto_Desktop
{
    static class Program
    {
        public static Usuario userLogado; //Objetos globais
        static BancoSqLite bancoLocal;
        static SessaoUsuario Su;
        public static BancoSqLite BancoLocal
        {
            get
            {
                if (bancoLocal == null)
                {
                    bancoLocal = new BancoSqLite(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProjetoSQLite.db"));
                }
                return bancoLocal;
            }
        }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            var a = BancoLocal.ObterListaSessao();
            if (a.Result.Count == 1)
            {
                foreach (var user in a.Result)
                {
                    if (user.Sessao)
                    {
                        userLogado = new Usuario();
                        userLogado.ConsultarUsuario(user.Cpf);
                        Application.Run(new FrmPrincipal());                        
                    }
                    else
                    {
                        Application.Run(new FrmLogin());
                    }
                }
            }
            else
            {
                Su = new SessaoUsuario();
                BancoLocal.InserirSessao(Su);
                Application.Run(new FrmLogin());
            }
        }        
    }
}
