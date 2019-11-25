using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projeto_Desktop.Classes
{
    public class Veiculo
    {
        //Atributos
        private int id;
        private string placa;
        private string marca;
        private string modelo;
        private string renavam;
        private double pesoMaximo;
        private double altura;
        private double largura;
        private double comprimento;
        private double custoPorKm;
        private int eixos;
        Banco db;
        //Propiedades
        public int Id { get => id; set => id = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Renavam { get => renavam; set => renavam = value; }
        public double PesoMaximo { get => pesoMaximo; set => pesoMaximo = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Largura { get => largura; set => largura = value; }
        public double Comprimento { get => comprimento; set => comprimento = value; }
        public double CustoPorKm { get => custoPorKm; set => custoPorKm = value; }
        public int Eixos { get => eixos; set => eixos = value; }

        //Métodos Construtores
        public Veiculo(int id,string placa, string marca, string modelo, string renavam, double pesoMaximo, double altura, double largura, double comprimento,double custo,int eixos)
        {
            this.id = id;
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo;
            this.renavam = renavam;
            this.pesoMaximo = pesoMaximo;
            this.altura = altura;
            this.largura = largura;
            this.comprimento = comprimento;
            this.custoPorKm = custo;
            this.eixos = eixos;
        }
        public Veiculo()
        { }
        //Métodos
        /// <summary>
        /// Inserindo veiculo
        /// </summary>
        public void InserirVeiculo(string placa, string marca, string modelo, string renavam, double pesoMaximo, double altura, double largura, double comprimento,int eixo,double custo)
        {
            db = new Banco();
            try
            {
                var comm = db.AbrirConexao();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "insert_veiculo";
                comm.Parameters.Add("_placa", MySqlDbType.VarChar).Value = placa;
                comm.Parameters.Add("_marca", MySqlDbType.VarChar).Value = marca;
                comm.Parameters.Add("_modelo", MySqlDbType.VarChar).Value = modelo;
                comm.Parameters.Add("_renavam", MySqlDbType.VarChar).Value = renavam;
                comm.Parameters.Add("_pesoMaximo", MySqlDbType.Decimal).Value = pesoMaximo;
                comm.Parameters.Add("_altura", MySqlDbType.Decimal).Value = altura;
                comm.Parameters.Add("_largura", MySqlDbType.Decimal).Value = largura;
                comm.Parameters.Add("_comprimento", MySqlDbType.Decimal).Value = comprimento;
                comm.Parameters.Add("_eixo", MySqlDbType.Int32).Value = eixo;
                comm.Parameters.Add("_custo", MySqlDbType.Decimal).Value = custo;
                var dr = comm.ExecuteReader();
                while(dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                }
                comm.Connection.Close();
            }
            catch(Exception e)
            {
                e.Message.ToString();
            }
        }
        /// <summary>
        /// Alterar veiculo
        /// </summary>        
        public bool AlterarVeiculo(int id, double pesoMaximo, double altura, double largura, double comprimento)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {                
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "update_veiculo";
                comm.Parameters.Add("_id", MySqlDbType.Int32).Value = id;
                comm.Parameters.Add("_pesoMaximo", MySqlDbType.Decimal).Value = pesoMaximo;
                comm.Parameters.Add("_altura", MySqlDbType.Decimal).Value = altura;
                comm.Parameters.Add("_largura", MySqlDbType.Decimal).Value = largura;
                comm.Parameters.Add("_comprimento", MySqlDbType.Decimal).Value = comprimento;
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
        /// Consultar veiculo pelo id
        /// </summary>
        public void ConsultarVeiculoId(int id)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {                              
                comm.CommandText = "select * from veiculo where idVeiculo = " + id;
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                    this.Placa = dr.GetString(1);
                    this.Marca = dr.GetString(2);
                    this.Modelo = dr.GetString(3);
                    this.Renavam = dr.GetString(4);
                    this.PesoMaximo = dr.GetDouble(5);
                    this.Altura = dr.GetDouble(6);
                    this.Largura = dr.GetDouble(7);
                    this.Comprimento = dr.GetDouble(8);
                    this.Eixos = dr.GetInt32(9);
                    this.CustoPorKm = dr.GetDouble(10);
                }
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
        /// Consultando veiculo pela placa
        /// </summary>
        /// <param name="placa"></param>
        public void ConsultarVeiculoPlaca(string placa)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {               
                comm.CommandText = "select * from veiculo where Placa = '" + placa + "'";
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                    this.Placa = dr.GetString(1);
                    this.Marca = dr.GetString(2);
                    this.Modelo = dr.GetString(3);
                    this.Renavam = dr.GetString(4);
                    this.PesoMaximo = dr.GetDouble(5);
                    this.Altura = dr.GetDouble(6);
                    this.Largura = dr.GetDouble(7);
                    this.Comprimento = dr.GetDouble(8);
                    this.Eixos = dr.GetInt32(9);
                    this.CustoPorKm = dr.GetDouble(10);
                }
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
        /// Gerando lista de veiculos
        /// </summary>
        public List<Veiculo> ListarVeiculos()
        {
            db = new Banco();
            Veiculo v;
            List<Veiculo> lista = new List<Veiculo>();
            var comm = db.AbrirConexao();
            try
            {                
                comm.CommandText = "select * from veiculo";
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    v = new Veiculo();
                    v.Id = dr.GetInt32(0);
                    v.Placa = dr.GetString(1);
                    v.Marca = dr.GetString(2);
                    v.Modelo = dr.GetString(3);
                    v.Renavam = dr.GetString(4);
                    v.PesoMaximo = dr.GetDouble(5);
                    v.Altura = dr.GetDouble(6);
                    v.Largura = dr.GetDouble(7);
                    v.Comprimento = dr.GetDouble(8);
                    v.Eixos = dr.GetInt32(9);
                    v.CustoPorKm = dr.GetDouble(10);
                    lista.Add(v);
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
        /// <summary>
        /// Listando todos os veiculos que estão disponiveis para novas entregas
        /// </summary>
        public List<Veiculo> ListarVeiculosDisponiveis(List<Veiculo> lista)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            List<Veiculo> veiculos = new List<Veiculo>();
            Veiculo v;
            try
            {
                foreach(var ve in lista)
                {
                    v = new Veiculo();
                    v.ConsultarVeiculoId(ve.Id);
                    veiculos.Add(v);                    
                }
                return veiculos;
            }
            catch(Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
            finally
            {
                comm.Connection.Close();
            }
        }
    }
}
