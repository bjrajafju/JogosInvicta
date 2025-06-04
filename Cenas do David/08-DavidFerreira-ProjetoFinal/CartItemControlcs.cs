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
    public partial class CartItemControlcs : UserControl
    {
        LinhasDoCarrinho linha;
        public delegate void ChangeProductPage(object sender, ProdutoEventArgs e);
        public event ChangeProductPage? ChangeProductPageRequest;
        public delegate void ChangeProductThings(object sender, LinhaEventArgs e);
        public event ChangeProductThings? ChangeProductCount;
        public event ChangeProductThings? DeleteProduct;

        public LinhasDoCarrinho Linha
        {
            get { return linha; }
            set { linha = value; }
        }
        public CartItemControlcs(LinhasDoCarrinho l)
        {
            linha = l;
            InitializeComponent();
            pictureBox1.Image = linha.Product.Foto;
            lblProductName.Text = linha.Product.NomeProduto;
            nupQuant.Value = (int)linha.Quantidade;
            updatePrice();
        }

        private void lblProductName_Click(object sender, EventArgs e)
        {
            ChangeProductPageRequest?.Invoke(sender, new ProdutoEventArgs(linha.Product));
        }

        private void nupQuant_ValueChanged(object sender, EventArgs e)
        {
            if (nupQuant.Value < 1)
            {
                nupQuant.Value = 1;
            }
            else
            {
                linha.Quantidade = (int)nupQuant.Value;
                updatePrice();
                ChangeProductCount?.Invoke(sender, new LinhaEventArgs(linha));
            }
        }

        private void updatePrice()
        {
            lblPrice.Text = (Math.Round(((linha.Product.PrecoUnit - linha.Product.PrecoUnit * linha.Product.Desconto) * (int)linha.Quantidade),2)).ToString() + "€";
        }

        public void updateQuantity(int n)
        {
            try
            {
                nupQuant.Value = n;
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Quantidade de Produtos excedendo stock");
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Tens a certeza?",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DeleteProduct?.Invoke(sender, new LinhaEventArgs(linha));
            }
        }
    }
}
