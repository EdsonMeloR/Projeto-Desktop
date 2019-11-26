using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projeto_Desktop.Classes
{
    public class Plano
    {
        //atributos
        private int id;
        private string nomePlano;
        private string descricaoPlano;
        private double valorPlano;
        private int duracaoPlano;
        private int limitePedido;
        Banco db;
        //Propiedades
        public int Id { get => id; set => id = value; }
        public string NomePlano { get => nomePlano; set => nomePlano = value; }
        public string DescricaoPlano { get => descricaoPlano; set => descricaoPlano = value; }
        public double ValorPlano { get => valorPlano; set => valorPlano = value; }
        public int DuracaoPlano { get => duracaoPlano; set => duracaoPlano = value; }
        public int LimitePedido { get => limitePedido; set => limitePedido = value; }
        //Métodos construtores
        public Plano(int id, string nomePlano, string descricaoPlano, double valorPlano, int duracaoPlano, int limitePedido)
        {
            this.id = id;
            this.nomePlano = nomePlano;
            this.descricaoPlano = descricaoPlano;
            this.valorPlano = valorPlano;
            this.duracaoPlano = duracaoPlano;
            this.limitePedido = limitePedido;
        }
        public Plano()
        { }
        //Métodos
        /// <summary>
        /// Inserindo um novo plano
        /// </summary>       
        public void InserirPlano(string nomePlano, string descricaoPlano, double valorPlano, int duracaoPlano, int limitePedido)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "insert_planos";
                comm.Parameters.Add("_nomeplano", MySqlDbType.VarChar).Value = nomePlano;
                comm.Parameters.Add("_descricao", MySqlDbType.VarChar).Value = descricaoPlano;
                comm.Parameters.Add("_valor", MySqlDbType.Decimal).Value = valorPlano;
                comm.Parameters.Add("_duracaoplano", MySqlDbType.Int32).Value = duracaoPlano;
                comm.Parameters.Add("_limitepedidos", MySqlDbType.Int32).Value = limitePedido;
                this.Id = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }
            finally
            {
                comm.Connection.Close();
            }
        }
        /// <summary>
        /// Alterando Plano
        /// </summary>
        public bool AlterarPlano(int _id, string nomePlano, string descricaoPlano, double valorPlano, int duracaoPlano, int limitePedido)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "update_planos";
                comm.Parameters.Add("_nomeplano", MySqlDbType.VarChar).Value = nomePlano;
                comm.Parameters.Add("_descricao", MySqlDbType.VarChar).Value = descricaoPlano;
                comm.Parameters.Add("_valor", MySqlDbType.Decimal).Value = valorPlano;
                comm.Parameters.Add("_duracaoplano", MySqlDbType.Int32).Value = duracaoPlano;
                comm.Parameters.Add("_limitepedidos", MySqlDbType.Int32).Value = limitePedido;
                comm.Parameters.Add("_id", MySqlDbType.Int32).Value = _id;
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
            finally
            {
                comm.Connection.Close();
            }
        }
        /// <summary>
        /// Consultando plano e retornando consulta para os métodos
        /// </summary>        
        public void ConsultarPlanoId(int _id)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {
                comm.CommandText = "select * from planos where idPlanos = " + _id;
                var dr = comm.ExecuteReader();
                while(dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                    this.NomePlano = dr.GetString(1);
                    this.DescricaoPlano = dr.GetString(2);
                    this.ValorPlano = dr.GetDouble(3);
                    this.DuracaoPlano = dr.GetInt32(4);
                    this.LimitePedido = dr.GetInt32(5);
                }
            }
            catch(Exception e)
            {
                e.Message.ToString();
            }
            finally
            {
                comm.Connection.Close();
            }
        }
        /// <summary>
        /// Gera uma lista de planos
        /// </summary>
        /// <returns>Entrega uma lista de planos List<Plano> </returns>
        public List<Plano> ListarPlanos()
        {
            db = new Banco();
            Plano p;
            List<Plano> lista = new List<Plano>();
            var comm = db.AbrirConexao();
            try
            {                
                comm.CommandText = "select * from planos ";
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    p = new Plano();
                    p.Id = dr.GetInt32(0);
                    p.NomePlano = dr.GetString(1);
                    p.DescricaoPlano = dr.GetString(2);
                    p.ValorPlano = dr.GetDouble(3);
                    p.DuracaoPlano = dr.GetInt32(4);
                    p.LimitePedido = dr.GetInt32(5);
                    lista.Add(p);
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
                comm.Connection.Close();
            }
        }
    }
}
