using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Desktop.Classes
{
    public class Niveis
    {
        //Atributos
        private int idNivel;
        private string nomeNivel;
        Banco db;
        //Propiedades
        public int IdNivel { get => idNivel; set => idNivel = value; }
        public string NomeNivel { get => nomeNivel; set => nomeNivel = value; }
        //Métodos construtores
        public Niveis(int idNivel, string nomeNivel)
        {
            this.IdNivel = idNivel;
            this.NomeNivel = nomeNivel;
        }
        public Niveis()
        { }
        //Métodos
        /// <summary>
        /// Inserindo nivel de acesso
        /// </summary>        
        public void InserirNivel(string _nome)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            { 
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "insert_nivel";
                comm.Parameters.Add("_nome", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = _nome;
                var dr = comm.ExecuteReader();
                while(dr.Read())
                {
                    this.IdNivel = dr.GetInt32(0);
                }
            }
            catch(Exception e)
            {
                e.Message.ToString();
            }
            finally
            {
                if (comm != null)
                    comm.Connection.Close();
                else
                    throw new Exception("Falha ao conectar-se com o banco de dados");
            }
        }
        /// <summary>
        /// Alterando nivel
        /// </summary>      
        public void AlterarNivel(int _id, string _nome)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "update_nivel";
                comm.Parameters.Add("_nome", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = _nome;
                comm.Parameters.Add("_id", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = _id;
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }
            finally
            {
                if (comm != null)
                    comm.Connection.Close();
                else
                    throw new Exception("Falha ao conectar-se com o banco de dados");
            }
        }
        /// <summary>
        /// Consultando nivel pelo ID
        /// </summary>        
        public void ConsultarNivel(int _id)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {                
                comm.CommandText = "select * from niveis where idNiveis = " + _id;                
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    this.IdNivel = dr.GetInt32(0);
                    this.NomeNivel = dr.GetString(1);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }
            finally
            {
                try
                {
                    if (comm != null)
                        comm.Connection.Close();
                    else
                        throw new Exception("Falha ao conectar-se com o banco de dados");
                }
                catch(Exception ex)
                {
                    ex.Message.ToString();
                }                
            }
        }
        /// <summary>
        /// Consultando nivel pelo nome
        /// </summary>        
        public void ConsultarNivel(string _nome)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {                
                comm.CommandText = "select * from niveis where NomeNivel = " + _nome;
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    this.IdNivel = dr.GetInt32(0);
                    this.NomeNivel = dr.GetString(1);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }
            finally
            {
                if (comm != null)
                    comm.Connection.Close();
                else
                    throw new Exception("Falha ao conectar-se com o banco de dados");
            }
        }
        public List<Niveis> ListarNiveis()
        {
            db = new Banco();
            Niveis n;
            List<Niveis> lista = new List<Niveis>();
            var comm = db.AbrirConexao();
            try
            {               
                comm.CommandText = "select * from niveis ";
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    n = new Niveis();
                    n.IdNivel = dr.GetInt32(0);
                    n.NomeNivel = dr.GetString(1);
                    lista.Add(n);
                }
                return lista;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return null;
            }
            finally
            {
                if (comm != null)
                    comm.Connection.Close();
                else
                    throw new Exception("Falha ao conectar-se com o banco de dados");
            }
        }
    }
}
