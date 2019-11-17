using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Desktop.Classes
{
    public class Banco
    {        
        MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder();      

        public Banco()//Método Construtor
        { }        
        public MySqlCommand AbrirConexao(out string Erro)//Método que abre conexão com banco de dados
        {
            stringBuilder.Database = "prosperitydb";
            stringBuilder.Server = "192.168.1.17";
            stringBuilder.Port = 3306;
            stringBuilder.UserID = "remote";
            stringBuilder.Password = "edsonmelo710";
            MySqlCommand comm;
            try
            {
                var cn = new MySqlConnection(stringBuilder.ToString());
                cn.Open();
                comm = new MySqlCommand
                {
                    Connection = cn
                };
                Erro = "";
                return comm;
            }
            catch (Exception ex)
            {
                Erro = "Erro capturado: " + ex.Message.ToString();
                return comm = null;
            }
        }
    }
}
