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
    public partial class ShoppingCart : Form
    {
        private List<LinhasDoCarrinho> lines = new List<LinhasDoCarrinho>();
        private Dictionary<string, CartItemControlcs> cartItemControlcs = new Dictionary<string, CartItemControlcs>();
        public ShoppingCart()
        {
            InitializeComponent();
            ResetShoppingCart();
        }

        private void ResetShoppingCart()
        {
            lines.Clear();
            pnlCartItems.Controls.Clear();
            foreach(var cart in cartItemControlcs)
            {
                cartItemControlcs[cart.Key].Dispose();
            }
            cartItemControlcs.Clear();
            
            pnlSkibidi.Visible = false;
            btnFinalise.Visible = false;
            lblTotalPrice.Text = "0€";
        }

        public void AddCartLine(LinhasDoCarrinho l)
        {
            foreach (var line in lines)
            {
                if (line.Product == l.Product)
                {
                    line.Quantidade += l.Quantidade;
                    cartItemControlcs[l.Product.NomeProduto].updateQuantity((int)line.Quantidade);
                    UpdateTotalPrice();
                    return;
                }
            }
            lines.Add(l);
            cartItemControlcs[l.Product.NomeProduto] = new CartItemControlcs(l);
            cartItemControlcs[l.Product.NomeProduto].DeleteProduct += DeleteProduct;
            cartItemControlcs[l.Product.NomeProduto].ChangeProductCount += ChangeProductCount;
            pnlCartItems.Controls.Add(cartItemControlcs[l.Product.NomeProduto]);
            cartItemControlcs[l.Product.NomeProduto].Dock = DockStyle.Top;
            UpdateTotalPrice();
            pnlSkibidi.Visible=true;
            btnFinalise.Visible = true;
        }

        public void DeleteProduct(object sender, LinhaEventArgs args)
        {
            lines.Remove(args.Line);
            pnlCartItems.Controls.Remove(cartItemControlcs[args.Line.Product.NomeProduto]);
            cartItemControlcs[args.Line.Product.NomeProduto].Dispose();
            if (lines.Count == 0) ResetShoppingCart();
            else UpdateTotalPrice();
        }

        public void ChangeProductCount(object sender, LinhaEventArgs args)
        {
            foreach (var line in lines)
            {
                if (line.Product == args.Line.Product)
                {
                    line.Quantidade = args.Line.Quantidade;
                }
            }
            UpdateTotalPrice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lines.Count > 0)
            {
                if (MessageBox.Show("Are you sure?", "Confirmação", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ResetShoppingCart();
                }
            } 
        }

        private void UpdateTotalPrice()
        {
            double totPrice = 0;

            for (int i = 0; i < lines.Count; i++)
            {
                totPrice += ((lines[i].Product.PrecoUnit - lines[i].Product.PrecoUnit * lines[i].Product.Desconto) * lines[i].Quantidade);
            }
            lblTotalPrice.Text = (Math.Round(totPrice,2)).ToString() + "€";
        }
    }
}
