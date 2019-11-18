using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Projeto_Desktop.Classes
{
    public class Usuario
    {
        //Atributos
        private int id;
        private string nome;
        private string cpf;
        private string telefone;
        private string senha;
        private string email;
        private Niveis idNivel;
        Banco db;
        //Propiedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Email { get => email; set => email = value; }
        public Niveis IdNivel { get => idNivel; set => idNivel = value; }
        //Métodos construtores
        public Usuario(int id, string nome, string cpf, string telefone, string senha, string email, Niveis idNivel)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.senha = senha;
            this.email = email;
            this.idNivel = idNivel;
        }
        public Usuario()
        { }
        //Métodos
        /// <summary>
        /// Inserindo usuario
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="telefone"></param>
        /// <param name="senha"></param>
        /// <param name="email"></param>
        /// <param name="idNivel"></param>
        public void InserirUsuario(string nome, string cpf, string telefone, string senha, string email, int idNivel)
        {
            db = new Banco();
            try
            {
                var comm = db.AbrirConexao();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "insert_usuario";
                comm.Parameters.Add("_nome", MySqlDbType.VarChar).Value = nome;
                comm.Parameters.Add("_cpf", MySqlDbType.VarChar).Value = cpf;
                comm.Parameters.Add("_telefone", MySqlDbType.VarChar).Value = telefone;
                comm.Parameters.Add("_senha", MySqlDbType.VarChar).Value = GerarSenhaMd5(senha);
                comm.Parameters.Add("_email", MySqlDbType.VarChar).Value = email;
                comm.Parameters.Add("_nivel", MySqlDbType.Int32).Value = idNivel;
                this.Id = Convert.ToInt32(comm.ExecuteScalar());                
            }
            catch(Exception e)
            {
                e.Message.ToString();
            }
        }
        /// <summary>
        /// Alterando dados usuario
        /// </summary>
        public bool AlterarUsuario(int id, string telefone, string email)
        {
            db = new Banco();
            try
            {
                var comm = db.AbrirConexao();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "update_usuario";                
                comm.Parameters.Add("_telefone", MySqlDbType.VarChar).Value = telefone;                
                comm.Parameters.Add("_email", MySqlDbType.VarChar).Value = email;
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        /// <summary>
        /// Consultando usuario pelo id
        /// </summary>
        /// <param name="id"></param>
        public void ConsultarUsuario(int id)
        {
            db = new Banco();
            try
            {
                var comm = db.AbrirConexao();
                comm.CommandText = "select * from usuario where idUsuario = " + id;
                var dr = comm.ExecuteReader();              
                while(dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                    this.Nome = dr.GetString(1);
                    this.Cpf = dr.GetString(2);
                    this.Telefone = dr.GetString(3);
                    this.Senha = dr.GetString(4);
                    this.Email = dr.GetString(5);
                    this.IdNivel.IdNivel = dr.GetInt32(6);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();                
            }
        }
        /// <summary>
        /// Gerando lista de usuarios
        /// </summary>
        /// <returns></returns>
        public List<Usuario> ListarUsuarios()
        {
            db = new Banco();
            Usuario user;
            List<Usuario> lista = new List<Usuario>();
            try
            {
                var comm = db.AbrirConexao();
                comm.CommandText = "select * from usuario";
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    user = new Usuario();
                    user.Id = dr.GetInt32(0);
                    user.Nome = dr.GetString(1);
                    user.Cpf = dr.GetString(2);
                    user.Telefone = dr.GetString(3);
                    user.Senha = dr.GetString(4);
                    user.Email = dr.GetString(5);
                    user.IdNivel.IdNivel = dr.GetInt32(6);
                    lista.Add(user);
                }
                return lista;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return null;
            }            
        }
        public bool EfetuarLogin(string cpf, string senha)
        {
            db = new Banco();
            try
            {
                var comm = db.AbrirConexao();
                comm.CommandText = "select * from usuario where Cpf = '" + cpf + "' && Senha = '"+GerarSenhaMd5(senha)+"'";
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                    this.Nome = dr.GetString(1);
                    this.Cpf = dr.GetString(2);
                    this.Telefone = dr.GetString(3);
                    this.Senha = dr.GetString(4);
                    this.Email = dr.GetString(5);
                    this.IdNivel.IdNivel = dr.GetInt32(6);
                }
                return true;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }        
        /// <summary>
        /// Gera uma senha em md5
        /// </summary>            
        public string GerarSenhaMd5(string senha)
        {
            var hash = MD5.Create();
            byte[] chave = hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < chave.Length; i++)
            {
                builder.Append(chave[i].ToString("X2"));
            }
            return builder.ToString();
        }
    }
}
