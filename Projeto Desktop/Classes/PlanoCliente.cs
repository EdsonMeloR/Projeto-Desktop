using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projeto_Desktop.Classes
{
    public class PlanoCliente
    {
        //Atributos
        private int id;
        private DateTime dataInicio;
        private DateTime dataTermino;
        private double desconto;
        private Cliente idCliente;
        private Plano idPlano;
        Banco db;
        //Propiedades
        public int Id { get => id; set => id = value; }
        public DateTime DataInicio { get => dataInicio; set => dataInicio = value; }
        public DateTime DataTermino { get => dataTermino; set => dataTermino = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public Cliente IdCliente { get => idCliente; set => idCliente = value; }
        public Plano IdPlano { get => idPlano; set => idPlano = value; }
        //Métodos construtores
        public PlanoCliente(int id, DateTime dataInicio, DateTime dataTermino, double desconto, Cliente idCliente, Plano idPlano)
        {
            this.id = id;
            this.dataInicio = dataInicio;
            this.dataTermino = dataTermino;
            this.desconto = desconto;
            this.idCliente = idCliente;
            this.idPlano = idPlano;
        }
        public PlanoCliente()
        {
            IdCliente = new Cliente();
            IdPlano = new Plano();
        }
        //Métodos
        /// <summary>
        /// Associando plano ao cliente
        /// </summary>        
        public void AssociarPlanoCliente(DateTime dataInicio, DateTime dataTermino, double desconto, int idCliente, int idPlano)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {                
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "insert_planocliente";
                comm.Parameters.Add("_datainicio", MySqlDbType.DateTime).Value = dataInicio;
                comm.Parameters.Add("_datatermino", MySqlDbType.DateTime).Value = dataTermino;
                comm.Parameters.Add("_desconto", MySqlDbType.Decimal).Value = desconto;
                comm.Parameters.Add("_idcliente", MySqlDbType.Int32).Value = idCliente;
                comm.Parameters.Add("_idplano", MySqlDbType.Int32).Value = idPlano;
                this.Id = Convert.ToInt32(comm.ExecuteScalar());
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
        /// Alterando plano já associado ao cliente
        /// </summary>
        public bool AlterarPlanoCliente(int _idplanocliente,double _desconto)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "update_planocliente";
                comm.Parameters.Add("_desconto", MySqlDbType.Decimal).Value = _desconto; 
                comm.Parameters.Add("_id", MySqlDbType.Int32).Value = _idplanocliente;
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
                if (comm != null)
                    comm.Connection.Close();
                else
                    throw new Exception("Falha ao conectar-se com o banco de dados");
            }
        }
        /// <summary>
        /// Consultando plano pelo id do cliente
        /// </summary>
        /// <param name="_id"></param>
        public void ConsultarPlanoClienteIdCliente(int _id)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {
                comm.CommandText = "select * from planocliente where idCliente = " + _id;
                var dr = comm.ExecuteReader();
                while(dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                    this.DataInicio = dr.GetDateTime(1);
                    this.DataTermino = dr.GetDateTime(2);
                    this.Desconto = dr.GetDouble(3);
                    this.IdCliente.Id = dr.GetInt32(4);
                    this.IdPlano.Id = dr.GetInt32(5);
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

        public void ConsultarPlanoClienteAtivo(int _id)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {
                comm.CommandText = "select * from planocliente where idCliente = " + _id + " && now() < DataTermino";
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                    this.DataInicio = dr.GetDateTime(1);
                    this.DataTermino = dr.GetDateTime(2);
                    this.Desconto = dr.GetDouble(3);
                    this.IdCliente.Id = dr.GetInt32(4);
                    this.IdPlano.Id = dr.GetInt32(5);
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
        /// <summary>
        /// Listando planos associado á clientes
        /// </summary>
        /// <returns></returns>
        public List<PlanoCliente> ListarPlanoCLiente()
        {
            db = new Banco();
            PlanoCliente pc;
            List<PlanoCliente> lista = new List<PlanoCliente>();
            var comm = db.AbrirConexao();
            try
            {
                comm.CommandText = "select * from planocliente";
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    pc = new PlanoCliente();
                    pc.Id = dr.GetInt32(0);
                    pc.DataInicio = dr.GetDateTime(1);
                    pc.DataTermino = dr.GetDateTime(2);
                    pc.Desconto = dr.GetDouble(3);
                    pc.IdCliente.Id = dr.GetInt32(4);
                    pc.IdPlano.Id = dr.GetInt32(5);
                    lista.Add(pc);
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
        /// <summary>
        /// Alterar Plano Associado ao Cliente
        /// </summary>
        /// <Retorno>True, se for alterado com sucesso. False em caso de falha ao alterar</Retorno>
        public bool AlterarPlanoAssociado(int idPlanoCliente,int idPlano, int idCliente, DateTime dataInicio , DateTime dataTermino,double desconto )
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "alterar_planocliente";
                comm.Parameters.Add("_idPlanoCliente", MySqlDbType.Int32).Value = idPlanoCliente;
                comm.Parameters.Add("_DataInicio", MySqlDbType.DateTime).Value = dataInicio;
                comm.Parameters.Add("_DataTermino", MySqlDbType.DateTime).Value = dataTermino;
                comm.Parameters.Add("_Desconto", MySqlDbType.Decimal).Value = desconto;
                comm.Parameters.Add("_idPlano", MySqlDbType.Int32).Value = idPlano;
                comm.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                e.Message.ToString();
                return false;
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
