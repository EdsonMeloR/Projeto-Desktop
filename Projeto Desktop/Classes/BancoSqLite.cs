using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Desktop.Classes
{
    public class BancoSqLite
    {
        readonly SQLiteAsyncConnection banco;
        public BancoSqLite(string dbPath)
        {
            banco = new SQLiteAsyncConnection(dbPath);
            banco.CreateTableAsync<SessaoUsuario>().Wait();
        }
        public Task<List<SessaoUsuario>> ObterListaSessao()
        {
            return banco.Table<SessaoUsuario>().ToListAsync();
        }
        public Task<List<SessaoUsuario>> ObterSessaoAberta()
        {
            return banco.QueryAsync<SessaoUsuario>("SELECT * FROM SessaoUsuario WHERE Sessao = 1");
        }
        public Task<List<SessaoUsuario>> ObterId(string nome)
        {
            return banco.QueryAsync<SessaoUsuario>("SELECT * FROM SessaoUsuario WHERE User = " + nome + "");
        }
        public Task<SessaoUsuario> ObterUser(string nome)
        {
            return banco.Table<SessaoUsuario>().Where(i => i.Nome == nome).FirstOrDefaultAsync();
        }

        public Task<int> InserirSessao(SessaoUsuario sessao)
        {
            return banco.InsertAsync(sessao);
        }
        public Task<int> AtualizarSessao(SessaoUsuario sessao)
        {
            return banco.UpdateAsync(sessao);
        }
        public Task<int> DeletarSessao(SessaoUsuario sessao)
        {
            return banco.DeleteAsync(sessao);
        }
    }
}
