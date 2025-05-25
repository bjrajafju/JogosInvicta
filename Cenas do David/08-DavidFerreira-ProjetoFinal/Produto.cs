using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ITM_DavidF_JogosInvicta
{
    public class Produto
    {
        private int Id;
        private string nomeProduto;
        private int IdProd;
        private decimal precoUnit;
        private decimal desconto;
        private string descricao;
        private int stock;
        private int idCategoria;
        private int avalProd;
        private Image foto;

        public string NomeProduto { get { return nomeProduto; } set { nomeProduto = value; } }

        public decimal PrecoUnit { get { return precoUnit; } set { precoUnit = value; } }

        public decimal Desconto { get { return desconto; } set { desconto= value; } }
        public Image Foto { get { return foto; } set { foto = value; } }
    }
}
