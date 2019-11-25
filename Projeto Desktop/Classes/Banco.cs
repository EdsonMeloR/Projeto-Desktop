using MySql.Data.MySqlClient;
using System;

namespace Projeto_Desktop.Classes
{
    public class Banco
    {        
        MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder();      

        public Banco()//Método Construtor
        { }        
        public MySqlCommand AbrirConexao()//Método abre conexão com banco de dados
        {
            stringBuilder.Database = "softklee_prosperity";
            stringBuilder.Server = "softkleen.com.br";
            stringBuilder.Port = 3306;
            stringBuilder.UserID = "softklee_prosperity";
            stringBuilder.Password = "senac@prosp";
            MySqlCommand comm;
            try
            {
                var cn = new MySqlConnection(stringBuilder.ToString());
                cn.Open();
                comm = new MySqlCommand
                {
                    Connection = cn
                };                
                return comm;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }
    }
}
