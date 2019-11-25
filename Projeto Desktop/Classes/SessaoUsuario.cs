using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Projeto_Desktop.Classes
{
    public class SessaoUsuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public bool Sessao { get; set; }
        public int Nivel { get; set; }
    }
}
