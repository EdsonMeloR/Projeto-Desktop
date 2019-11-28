using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projeto_Desktop.Classes
{
    public class ItensNotaTransporte
    {
        //Atributos
        private Carga idCarga;
        private NotaTransporte idNotaTransporte;
        Banco db;
        //Propiedades
        public Carga IdCarga { get => idCarga; set => idCarga = value; }
        public NotaTransporte IdNotaTransporte { get => idNotaTransporte; set => idNotaTransporte = value; }
        //Métodos Construtores
        public ItensNotaTransporte(Carga idCarga, NotaTransporte idNotaTransporte)
        {
            this.IdCarga = idCarga;
            this.IdNotaTransporte = idNotaTransporte;
        }
        public ItensNotaTransporte()
        { }
        //Métodos
        public void InserirItensNotaTransporte(int idcarga, int idnota)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {                
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "insert_itensnotatransporte";
                comm.Parameters.Add("_idcarga", MySqlDbType.Int32).Value = idcarga;
                comm.Parameters.Add("_idnotatransporte", MySqlDbType.Int32).Value = idnota;
                comm.ExecuteNonQuery();             
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
    }
}
