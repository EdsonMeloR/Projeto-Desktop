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
        { }
        //Métodos
        /// <summary>
        /// Associando plano ao cliente
        /// </summary>        
        public void AssociarPlanoCliente(DateTime dataInicio, DateTime dataTermino, double desconto, int idCliente, int idPlano)
        {
            db = new Banco();
            try
            {
                var comm = db.AbrirConexao();
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
        }
        /// <summary>
        /// Alterando plano já associado ao cliente
        /// </summary>
        public bool AlterarPlanoClinete(int _idplanocliente,double _desconto)
        {
            db = new Banco();
            try
            {
                var comm = db.AbrirConexao();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "update_planocliente";
                comm.Parameters.Add("_desconto", MySqlDbType.DateTime).Value = _desconto; 
                comm.Parameters.Add("_id", MySqlDbType.DateTime).Value = _idplanocliente;
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
        /// Consultando plano pelo id do cliente
        /// </summary>
        /// <param name="_id"></param>
        public void ConsultarPlanoClienteIdCliente(int _id)
        {
            db = new Banco();
            try
            {
                var comm = db.AbrirConexao();
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
            try
            {
                var comm = db.AbrirConexao();
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
        }
    }
}
