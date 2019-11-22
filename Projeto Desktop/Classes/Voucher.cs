using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Desktop.Classes
{
    public class Voucher
    {
        //Atributos
        private int id;
        private string codigo;
        private DateTime dataInicio;
        private DateTime dataTermino;
        private Cliente cliente;
        Banco db;
        //Propiedades
        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public DateTime DataInicio { get => dataInicio; set => dataInicio = value; }
        public DateTime DataTermino { get => dataTermino; set => dataTermino = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        //Métodos construtores
        public Voucher(int id, string codigo, DateTime dataInicio, DateTime dataTermino, Cliente cliente)
        {
            this.id = id;
            this.codigo = codigo;
            this.dataInicio = dataInicio;
            this.dataTermino = dataTermino;
            this.Cliente = cliente;
        }
        public Voucher ()
        {
            Cliente = new Cliente();
        }
        //Métodos
        public void InserirVoucher(string codigo, DateTime dataInicio, DateTime dataTermino, int idCliente)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {                
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "insert_voucher";
                comm.Parameters.Add("codigo",MySqlDbType.VarChar).Value = codigo;
                comm.Parameters.Add("dataInicio", MySqlDbType.DateTime).Value = dataInicio;
                comm.Parameters.Add("dataTermino", MySqlDbType.DateTime).Value = dataTermino;
                comm.Parameters.Add("idcliente", MySqlDbType.Int32).Value = idCliente;
                comm.Parameters.Add("idplano", MySqlDbType.Int32).Value = idCliente;
                var dr = comm.ExecuteReader();
                while(dr.Read())                    
                {
                    this.Id = dr.GetInt32(0);
                    this.Codigo = dr.GetString(1);
                    this.dataInicio = dr.GetDateTime(2);
                    this.DataTermino = dr.GetDateTime(3);
                    this.Cliente.Id = dr.GetInt32(4);
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
    }
}
