﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projeto_Desktop.Classes
{
    public class Pedido
    {
        //Atributos
        private int id;
        private string situacao;
        private DateTime dataPedido;
        private bool retirar;
        private Usuario idUsuario;
        Banco db;
        //Propiedades
        public int Id { get => id; set => id = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public DateTime DataPedido { get => dataPedido; set => dataPedido = value; }
        public bool Retirar { get => retirar; set => retirar = value; }
        public Usuario IdUsuario { get => idUsuario; set => idUsuario = value; }
        //Métodos construtores
        public Pedido(int id, string situacao, DateTime dataPedido, bool retirar, Usuario idUsuario)
        {
            this.id = id;
            this.situacao = situacao;
            this.dataPedido = dataPedido;
            this.retirar = retirar;
            this.idUsuario = idUsuario;
        }
        public Pedido()
        { }
        //Métodos
        /// <summary>
        /// Inserindo um novo pedido
        /// </summary>
        public void InserirPedido(string situacao, bool retirar, int idUsuario,int idCliente)
        {
            db = new Banco();
            try
            {
                var comm = db.AbrirConexao();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "insert_pedido";
                comm.Parameters.Add("_situacao", MySqlDbType.VarChar).Value = situacao;                
                comm.Parameters.Add("_retirar", MySqlDbType.Bit).Value = retirar;
                comm.Parameters.Add("_idusuario", MySqlDbType.Int32).Value = idUsuario;
                comm.Parameters.Add("_idcliente", MySqlDbType.Int32).Value = idCliente;
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                    this.DataPedido = dr.GetDateTime(2);
                }
            }
            catch(Exception e)
            {
                e.Message.ToString();
            }
        }     
        /// <summary>
        /// Alterando pedido
        /// </summary>        
        /// <returns>Retorna true se alterar com sucesso e false se falhar</returns>
        public bool AlterarPedido(string situacao,int id)
        {
            db = new Banco();
            try
            {
                var comm = db.AbrirConexao();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "update_pedido";
                comm.Parameters.Add("_situacao", MySqlDbType.VarChar).Value = situacao;
                comm.Parameters.Add("_idpedido", MySqlDbType.Int32).Value = id;
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public void ConsultarPedido(int id)
        {
            db = new Banco();
            try
            {
                var comm = db.AbrirConexao();
                comm.CommandText = "select * from pedidos where idPedidos = " + id;                
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                    this.Situacao = dr.GetString(1);
                    this.DataPedido = dr.GetDateTime(2);
                    this.Retirar = dr.GetBoolean(3);
                    this.IdUsuario.Id = dr.GetInt32(4);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }
        }
        public MySqlDataReader ConsultarPedidosCliente(int idCliente,int idPedido)
        {
            db = new Banco();
            try
            {
                var comm = db.AbrirConexao();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "viewPedidosClientes";
                return comm.ExecuteReader();
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return null;
            }
        }
    }
}
