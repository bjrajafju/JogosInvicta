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
        private string nomeProduto = "";
        private Int32 idProd = 0;
        private double precoUnit = 0;
        private double desconto = 0;
        private string descricao ="";
        private Int16 stock = 0;
        private Int16 idCategoria = 0;
        private Byte avalProd = 0;
        private Image? foto = null;

        public Produto() {
        }
        public Produto(string nomeProduto, Int32 IdProd, double precoUnit, double desconto, string descricao, Int16 stock, Int16 idCategoria, Byte avalProd, Image foto)
        {
            this.nomeProduto = nomeProduto;
            this.idProd = IdProd;
            this.precoUnit = precoUnit;
            this.descricao = descricao;
            this.desconto = desconto;
            this.stock = stock;
            this.idCategoria = idCategoria;
            this.avalProd = avalProd;
            this.foto = foto;
        }


        public string NomeProduto { get { return nomeProduto; } set { nomeProduto = value; } }

        public double PrecoUnit { get { return precoUnit; } set { precoUnit = value; } }

        public double Desconto { get { return desconto; } set { desconto= value; } }
        public Image? Foto { get { return foto; } set { foto = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }

        public Int16 IdCategoria { get {  return idCategoria; } set { idCategoria = value; } }

        public Byte AvalProd { get { return avalProd; } set { avalProd = value; } }

        public Int16 Stock
        {
            get { return stock; } set { stock = value; }
        }
        public string StockStatus() { 
                if (stock > 20)
                {
                    return "Em Stock";
                }
                else if (stock > 0) { return "Poucas Unidades"; }
                else return "Esgotado";
        }



        public Int32 IdProd
        {
            get
            {
                return idProd;
            }
            set
            {
                idProd = value;
            } 
        }

    }
}
