using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_DavidFerreira_ProjetoFinal
{
    public partial class CompraSubItem : UserControl
    {
        CompraProduto linha;
        public delegate void ChangeProductPage(object sender, ProdutoEventArgs e);
        public event ChangeProductPage? ChangeProductPageRequest;
        public delegate void ChangeProductThings(object sender, LinhaEventArgs e);
        public event ChangeProductThings? ChangeProductCount;
        public event ChangeProductThings? DeleteProduct;

        public CompraProduto Linha
        {
            get { return linha; }
            set { linha = value; }
        }
        public CompraSubItem(CompraProduto l)
        {
            linha = l;
            InitializeComponent();
            pictureBox1.Image = linha.Product.Foto;
            lblProductName.Text = linha.Product.NomeProduto;
            lblPrice.Text = (Math.Round(((linha.Product.PrecoUnit - linha.Product.PrecoUnit * linha.Product.Desconto) * (int)linha.Quantidade), 2)).ToString() + "€";
            lblQuantity .Text = linha.Quantidade.ToString();
        }

        private void lblProductName_Click(object sender, EventArgs e)
        {
            ChangeProductPageRequest?.Invoke(sender, new ProdutoEventArgs(linha.Product));
        }

    }
}
