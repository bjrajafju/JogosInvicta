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
    public partial class ShoppinArea : Form
    {
        public Produto[] produtosTotais;
        public ShopItemControl[] itemsTotais;
        public ShoppinArea()
        {
            InitializeComponent();
        }


        private void ShoppinArea_Load(object sender, EventArgs e)
        {

            string strProvider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = .\\..\\..\\..\\..\\..\\06-08-DanielSilva-DavidFerreira-Empresa.accdb;Persist Security Info = False";

            produtosTotais = ProdutosRetrieval.retrieveProducts(strProvider);

            if (produtosTotais != null)
            {
                loadShoppingItems();

                //NESTE CASO ESPECÍFICO NÃO QUERO QUE ELE FAÇA O INDEXCHANGED
                //assim, descolo e volto a colar o método

                cboFranchise.SelectedIndexChanged -= cboFranchise_SelectedIndexChanged;
                cboFranchise.SelectedIndex = 0;
                cboFranchise.SelectedIndexChanged += cboFranchise_SelectedIndexChanged;
                cboProdutores.SelectedIndexChanged -= cboProdutores_SelectedIndexChanged;
                cboProdutores.SelectedIndex = 0;
                cboFranchise.SelectedIndexChanged += cboProdutores_SelectedIndexChanged;


            }

        }


        private void loadShoppingItems()
        {
            itemsTotais = new ShopItemControl[produtosTotais.Length];

            for(int i = 0; i< produtosTotais.Length; i++)
            {
                itemsTotais[i]= new ShopItemControl(produtosTotais[i]);
                fpnlShopItems.Controls.Add(itemsTotais[i]);
                itemsTotais[i].Show();
            }


            return;
        }

        private void cboProdutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Valid Index
            if (cboProdutores.SelectedIndex > 1)
            {

            }
            else
            {
                loadShoppingItems();
            }
            //reset other stuff index
        }

        private void cboFranchise_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Valid Index
            if (cboFranchise.SelectedIndex > 1)
            {

            }
            else
            {
                loadShoppingItems();
            }
            //reset other stuff index
        }

    }
}
