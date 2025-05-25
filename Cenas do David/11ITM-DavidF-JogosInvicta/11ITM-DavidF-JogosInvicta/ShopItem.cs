using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11ITM_DavidF_JogosInvicta
{
    public partial class ShopItem : Form
    {
        private Produto produto;

        public ShopItem(Produto p)
        {
            InitializeComponent();
            p = produto;
            loadShopItem();
        }

        public int loadShopItem()
        {
            lblProductName.Text = produto.NomeProduto;

            if(produto.Desconto == 0)
            {
                lblPrice.Text = "Preço Unitário: " + produto.PrecoUnit+ "€";
            } else
            {
                decimal precoComDesconto = produto.PrecoUnit - (produto.PrecoUnit * produto.Desconto);

                string precoComDescontoTexto = "Preço com Desconto: " + precoComDesconto + "€ ";
                string precoOriginalTexto = "Preço Unitário: " + produto.PrecoUnit + "€";

                string textoCompleto = precoComDescontoTexto + precoOriginalTexto;

                lblPrice.Text = textoCompleto;

                
                int startIndex = textoCompleto.IndexOf(precoOriginalTexto);
                if (startIndex >= 0)
                {
                    lblPrice.Select(startIndex, precoOriginalTexto.Length);
                    lblPrice.SelectionFont = new Font(lblPrice.Font, FontStyle.Strikeout);
                    lblPrice.Select(0, 0);
                }
            }

            return -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
