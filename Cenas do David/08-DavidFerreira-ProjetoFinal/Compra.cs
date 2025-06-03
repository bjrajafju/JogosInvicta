using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DavidFerreira_ProjetoFinal
{
    public class Compra
    {
        int id;
        Cliente cliente;
        DateTime dataCompra;
        Estado estado;

        public Compra(int id, Cliente c, DateTime dataCompra, Estado estado)
        {
            this.id = id;
            this.cliente = c;
            this.dataCompra = dataCompra;
            this.estado = estado;
        }

        public int Id { get { return id; } set { id = value; } }
        public Cliente Cliente { get { return cliente; } set { cliente = value; } }
        public DateTime DataCompra { get { return dataCompra; } set { dataCompra = value; } }
        public Estado Estado { get { return estado; } set { estado = value; } }
    }
    public class Estado
    {
        int id;
        string nomeEstado;

        public Estado(int id, string estado) { this.id = id; nomeEstado = estado; }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NomeEstado { get { return nomeEstado; } set { nomeEstado = value; } }
    }

    public class CompraProduto
    {
        public Produto produto;
        public int quantidade;

        public CompraProduto(Produto p, int q)
        {
            produto = p;
            quantidade = q;
        }

        public Produto Product { get { return produto; } set { produto = value; } }
        public int Quantidade { get { return quantidade; } set { quantidade = value; } }
    }
}
