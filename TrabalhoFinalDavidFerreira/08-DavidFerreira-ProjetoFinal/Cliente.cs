using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DavidFerreira_ProjetoFinal
{
    public class Cliente
    {
        int id;
        string nomeCliente;
        string telefone;
        string email;
        string address;
        string codPostal;
        string cidade;
        Pais pais;
        string password;
        public Cliente(int id,string nC = "", string t = "", string e = "", string ad = "", string cp = "", string cid = "", Pais pais = null!, string password = "") {
            this.id = id;
            nomeCliente = nC;
            telefone = t;
            email = e;
            address = ad;
            codPostal = cp;
            cidade = cid;
            this.pais = pais;
            this.password = password;
        }

        public int Id { get { return id; } set { id = value; } }

        public string NomeCliente
        {
            get { return nomeCliente; } set { nomeCliente = value; }
        }

        public string Telefone
        {
            get { return telefone; } set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Address
        {
            get { return address; } set { address = value; }
        }

        public string CodPostal
        {
            get { return codPostal; } set { codPostal = value; }
        }
        public string Cidade
        {
            get { return cidade; } set { cidade = value; }
        }
        public Pais Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        public string Password
        {
            get { return password; } set { password = value; }
        }
    }

    public class Pais
    {
        int id;
        string nomePais;

        public Pais(int id, string pais) { this.id = id;nomePais = pais; }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NomePais { get { return nomePais; } set { nomePais = value; }}
    }
}
