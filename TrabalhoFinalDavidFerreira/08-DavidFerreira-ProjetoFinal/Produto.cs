using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DavidFerreira_ProjetoFinal
{
    public class Produto
    {
        private int id;
        private string nomeProduto = "";
        private Produtor produtor = null;
        private double precoUnit = 0;
        private double desconto = 0;
        private string descricao ="";
        private Int16 stock = 0;
        private Categoria categoria = null;
        private Byte avalProd = 0;
        private Image? foto = null;
        private Franchise franchise = null;
        public Produto() {
        }
        public Produto(int id, string nomeProduto, Produtor Produtor, double precoUnit, double desconto, string descricao, Int16 stock, Categoria idCategoria, Byte avalProd, Franchise franchise, Image foto)
        {
            this.id = id;
            this.nomeProduto = nomeProduto;
            this.produtor = Produtor;
            this.precoUnit = precoUnit;
            this.descricao = descricao;
            this.desconto = desconto;
            this.stock = stock;
            this.categoria = idCategoria;
            this.avalProd = avalProd;
            this.foto = foto;
            this.franchise = franchise;
        }

        public int Id { get { return id; }  set { id = value; } }
        public string NomeProduto { get { return nomeProduto; } set { nomeProduto = value; } }

        public double PrecoUnit { get { return precoUnit; } set { precoUnit = value; } }

        public double Desconto { get { return desconto; } set { desconto= value; } }
        public Image? Foto { get { return foto; } set { foto = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }

        public Categoria Categoria { get {  return categoria; } set { categoria = value; } }

        public Byte AvalProd { get { return avalProd; } set { avalProd = value; } }

        public Int16 Stock
        {
            get { return stock; } set { stock = value; }
        }
        public string StockStatus() { 
                if (stock > 5)
                {
                    return "Em Stock";
                }
                else if (stock > 0) { return "Poucas Unidades"; }
                else return "Esgotado";
        }

        public Produtor Produtor
        {
            get
            {
                return produtor;
            }
            set
            {
                produtor = value;
            } 
        }

        public Franchise Franchise { get { return franchise; } set { franchise = value; }}


    }

    public class Categoria
    {
        int id;
        string name;
        public int IdCategoria { get { return id; } set { id = value; } }
        public string NomeCat { get { return name; } set { name = value; } }

        public Categoria(int id = 0, string name = "")
        {
            this.id = id;
            this.name = name;
        }
    }

    public class  Franchise
    {
        int id;
         string name;
        public int IdFranchise { get { return id; } set { id = value; } }
        public string NomeFra { get { return name; } set { name = value; } }

        public Franchise(int id = 0, string name = "")
        {
            this.id = id;
            this.name = name;
        }
    }

    public class Produtor
    {
        int id;
        string name;
        public int IdProdutor { get { return id; } set { id = value; } }
        public string NomeProd { get { return name; } set { name = value; } }

        public Produtor(int id = 0, string name = "")
        {
            this.id = id;
            this.name = name;
        }
    }
}
