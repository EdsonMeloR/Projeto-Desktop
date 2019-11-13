using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Projeto_Desktop.Classes
{
    public class Cliente
    {
        //Atributos Privados
        private int id;
        private string razaoSocial;
        private string cnpj;
        private string email;
        private string inscricaoEstadual;
        private string senha;
        private string telefone;
        private string nomeContato;
        //Propiedades
        public int Id { get => id; set => id = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Email { get => email; set => email = value; }
        public string InscricaoEstadual { get => inscricaoEstadual; set => inscricaoEstadual = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string NomeContato { get => nomeContato; set => nomeContato = value; }
        //Métodos Construtores
        public Cliente(int id, string razaoSocial, string cnpj, string email, string inscricaoEstadual, string senha, string telefone, string nomeContato)
        {
            this.Id = id;
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.Email = email;
            this.InscricaoEstadual = inscricaoEstadual;
            this.Senha = senha;
            this.Telefone = telefone;
            this.NomeContato = nomeContato;
        }
        public Cliente()
        { }
        //Métodos
        public void InserirCliente(string _razaoSocial, string _cnpj, string _email, string _inscricaoEstadual, string _senha, string _telefone, string _nomeContato)
        { }
        public void AlterarCliente()
        { }
        public void ConsultarClienteId(int id)
        { }
        public List<Cliente> ListarCliente()
        { }
        public void AlterarSenhaCliente()
        { }
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
