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

        public Produto Produto
        {
            get { return produto; }
            set { produto = value; }
        }

        public ShopItemControl(Produto p)
        {
            InitializeComponent();
            produto = p;
            loadShopItem();
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
                string precoComDescontoTexto = "Preço com Desconto: " + precoComDesconto + "€ ";
                string precoOriginalTexto = "Preço Unitário: " + produto.PrecoUnit + "€";

                string textoCompleto = precoComDescontoTexto + precoOriginalTexto;

                string precoAtual = produto.PrecoUnit.ToString();

                lblPrice.Text = textoCompleto;


                //DETALHES VISUAIS
                { 
                    int startIndex = textoCompleto.IndexOf(precoAtual);
                    if (startIndex >= 0)
                    {
                        lblPrice.Select(startIndex, precoAtual.Length);
                        lblPrice.SelectionFont = new Font(lblPrice.Font, FontStyle.Strikeout);
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

            if (produto.Foto != null)
            {
                pictureBox1.Image = produto.Foto;
            }

            return -1;
        }


    }
}
