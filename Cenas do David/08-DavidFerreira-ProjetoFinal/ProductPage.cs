using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_DavidFerreira_ProjetoFinal
{
    public partial class ProductPage : Form
    {
        private Produto? currentProduct;

        public delegate void AddedToCart(object sender, LinhaEventArgs args);
        public event AddedToCart? OnAddToCart;


        public ProductPage()
        {
            InitializeComponent();
        }

        public Produto? CurrentProduct
        {
            get { return currentProduct; }
            set { currentProduct = value; }
        }

        public void refreshProduct(Produto p)
        {
            if (p != null) { currentProduct = p; }
            else currentProduct = null;

            refreshPage();
        }
        public void refreshPage()
        {
            nupQuant.Enabled = true;
            nupQuant.Value = 0;
            txtDesciption.Text = "";
            txtInfo.Text = "";
            txtMainInfo.Text = "";
            pictureBox1.Image = currentProduct?.Foto;

            if(currentProduct.StockStatus() == "Esgotado")
            {
                nupQuant.Enabled = false;
            }

            txtMainInfo.Text = currentProduct.NomeProduto;
            txtMainInfo.SelectAll();
            txtMainInfo.SelectionFont = new Font(txtMainInfo.Font.FontFamily, 14, FontStyle.Bold);
            txtMainInfo.Select(0, 0);
            txtMainInfo.AppendText("\n");
            if (currentProduct.Desconto > 0)
            {
                string oldPrice = "Preço Invicta: " + currentProduct.PrecoUnit + "€";

                txtMainInfo.AppendText(oldPrice);
                int start = txtMainInfo.Text.IndexOf(oldPrice);
                if (start >= 0)
                {
                    txtMainInfo.Select(start, oldPrice.Length);
                    txtMainInfo.SelectionFont = new Font(txtMainInfo.Font.FontFamily, 14, FontStyle.Strikeout);
                    txtMainInfo.SelectionColor = Color.Gray;
                    txtMainInfo.Select(0, 0);
                }
                txtMainInfo.AppendText("\n");
                string newPrice = "PROMOÇÃO INVICTA: " + Math.Round((currentProduct.PrecoUnit - currentProduct.PrecoUnit * currentProduct.Desconto), 2) + "€";

                txtMainInfo.AppendText(newPrice);
                int st = txtMainInfo.Text.IndexOf(newPrice);
                if (st >= 0)
                {
                    txtMainInfo.Select(st, newPrice.Length);
                    txtMainInfo.SelectionFont = new Font(txtMainInfo.Font.FontFamily, 16, FontStyle.Bold);
                    txtMainInfo.SelectionColor = Color.Red;
                    txtMainInfo.Select(0, 0);
                }

            }
            else
            {
                string price = "Preço Invicta: " + currentProduct.PrecoUnit + "€";

                txtMainInfo.AppendText(price);
                int start = txtMainInfo.Text.IndexOf(price);
                if (start >= 0)
                {
                    txtMainInfo.Select(start, price.Length);
                    txtMainInfo.SelectionFont = new Font(txtMainInfo.Font.FontFamily, 16);
                    txtMainInfo.SelectionColor = Color.Navy;
                    txtMainInfo.Select(0, 0);
                }
            }

            txtMainInfo.AppendText("\n");

            txtMainInfo.AppendText("Disponibilidade: " + currentProduct.StockStatus());
            int stckStart = txtMainInfo.Text.IndexOf(currentProduct.StockStatus());
            if (stckStart >= 0)
            {
                txtMainInfo.Select(stckStart, currentProduct.StockStatus().Length);
                txtMainInfo.SelectionFont = new Font(txtMainInfo.Font, FontStyle.Bold);
                switch (currentProduct.StockStatus())
                {
                    case "Esgotado":
                        txtMainInfo.SelectionColor = GlobalVars.noStockColor;
                        break;
                    case "Poucas Unidades":
                        txtMainInfo.SelectionColor = GlobalVars.limitedStockColor;
                        break;
                    case "Pré-Reserva":
                        txtMainInfo.SelectionColor = GlobalVars.preOrder;
                        break;
                    default:
                        txtMainInfo.SelectionColor = GlobalVars.stockColor;
                        break;
                }
                txtMainInfo.Select(0, 0);
            }
            txtMainInfo.AppendText("\n");
            txtMainInfo.AppendText("Avaliação: " +currentProduct.AvalProd.ToString() + "/10🌟");

            txtDesciption.Text = currentProduct.Descricao;

            txtInfo.AppendText("Produtor: "+(DataManagement.retrieveStrings(GlobalVars.strProvider, "Produtor", "nomeProdutor", "IdProdutor = " + currentProduct.IdProd))[0][0].ToString() + '\n');
            txtInfo.AppendText("Categoria: " + (DataManagement.retrieveStrings(GlobalVars.strProvider, "Categoria", "categoriaProduto", "IdCategoria = " + currentProduct.IdCategoria))[0][0].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnAddToCart?.Invoke(sender, new LinhaEventArgs(new LinhasDoCarrinho(currentProduct, (int)nupQuant.Value)));

            //NÃO ESQUECER DE VERIFICAR DA PRÓXIMA VEZ SE JÁ INTRODUZIU ESTE ITEM
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //MIGHT CHANGE THIS TBH
            if(nupQuant.Value == 0)
            {
                 btnAddToCart.Enabled = false;
            } else { btnAddToCart.Enabled = true; }
        }
    }
}
