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
    public partial class ShopItemControl : UserControl
    {
        private Produto produto = null!;

        public delegate void ProductSelectedEventHandler(object sender, ProdutoEventArgs e);
        public Produto Produto
        {
            get { return produto; }
            set { produto = value; }
        }

        public ShopItemControl(Produto p)
        {
            InitializeComponent();
            groupBox1.Click += Sent_OnClick;
            stockTextBox.Click += Sent_OnClick;
            lblPrice.Click += Sent_OnClick;
            lblProductName.Click += Sent_OnClick;
            pictureBox1.Click +=Sent_OnClick;
            produto = p;
            loadShopItem();
        }

        public event ProductSelectedEventHandler? ProductSelected;

        public void Sent_OnClick(object? sender, EventArgs e)
        {
            ProductSelected?.Invoke(this, new ProdutoEventArgs(produto));
        }

        public int loadShopItem()
        {
            lblProductName.Text = produto.NomeProduto;

            if (produto.Desconto == 0)
            {
                lblPrice.Text = "Preço Unitário: " + produto.PrecoUnit + "€";
            }
            else
            {
                double precoComDesconto = produto.PrecoUnit - (produto.PrecoUnit * produto.Desconto);
                precoComDesconto = Math.Round(precoComDesconto, 2);
                string precoComDescontoTexto = "Preço com Desconto: " + precoComDesconto + "€\n";
                string precoOriginalTexto = "Preço Unitário: " + produto.PrecoUnit + "€";

                string textoCompleto = precoComDescontoTexto + precoOriginalTexto;

                string precoAtual = precoComDesconto + "€";

                lblPrice.Text = textoCompleto;


                //DETALHES VISUAIS
                {
                    int startIndex = textoCompleto.IndexOf(precoAtual);
                    if (startIndex >= 0)
                    {
                        lblPrice.Select(startIndex, precoAtual.Length);
                        lblPrice.SelectionFont = new Font(lblPrice.Font, FontStyle.Bold);
                        lblPrice.SelectionColor = Color.Green;
                        lblPrice.Select(0, 0);
                    }
                }
                {
                    int startIndex = textoCompleto.IndexOf(precoOriginalTexto);
                    if (startIndex >= 0)
                    {
                        lblPrice.Select(startIndex, precoOriginalTexto.Length);
                        lblPrice.SelectionFont = new Font(lblPrice.Font, FontStyle.Strikeout);
                        lblPrice.SelectionColor = Color.Red;
                        lblPrice.Select(0, 0);
                    }
                }
            }


            pictureBox1.Image = produto.Foto;
            if (produto.StockStatus() == "Esgotado")
            {
                stockTextBox.ForeColor = GlobalVars.noStockColor;
            }
            else if (produto.StockStatus() == "Poucas Unidades")
            {
                stockTextBox.ForeColor = GlobalVars.limitedStockColor;
            } 
            else if (produto.StockStatus() == "Pré-reserva")
            {
                stockTextBox.ForeColor = GlobalVars.preOrder;
            }
            else
            {
                stockTextBox.ForeColor = GlobalVars.stockColor;
            }
            stockTextBox.Text = produto.StockStatus();

            return -1;
        }

    }
}
