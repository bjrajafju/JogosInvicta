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
        public delegate void ProductSelectedChangePage(object sender, ProdutoEventArgs e);

        public event ProductSelectedChangePage? OnProductSelectedChangePage;

        public Produto[]? produtosTotais;
        public Category[]? categoriasTotais;
        public Produtor[]? produtorTotais;
        public List<ShopItemControl>? itemsTotais = null;
        public ShoppinArea()
        {
            InitializeComponent();
        }

        public void sendEventToMenu(object sender, ProdutoEventArgs e)
        {
            OnProductSelectedChangePage?.Invoke(this, e);
        }

        private void ShoppinArea_Load(object sender, EventArgs e)
        {
            produtosTotais = DataRetrieval.retrieveProducts(GlobalVars.strProvider);
            produtorTotais = DataRetrieval.retrieveProdutores(GlobalVars.strProvider);

            for (int i = 0; i < produtorTotais.Length; i++)
            {
                cboProdutores.Items.Add(produtorTotais[i].StrProdutor);
            }

            if (produtosTotais != null)
            {
                loadShoppingItems(FilterFunctions.noFilter);

                //NESTE CASO ESPECÍFICO NÃO QUERO QUE ELE FAÇA O INDEXCHANGED
                //assim, descolo e volto a colar o método

                cboFranchise.SelectedIndexChanged -= cboFranchise_SelectedIndexChanged;
                cboFranchise.SelectedIndex = 0;
                cboFranchise.SelectedIndexChanged += cboFranchise_SelectedIndexChanged;
                cboProdutores.SelectedIndexChanged -= cboProdutores_SelectedIndexChanged_1;
                cboProdutores.SelectedIndex = 0;
                cboProdutores.SelectedIndexChanged += cboProdutores_SelectedIndexChanged_1;
            }
        }


        private void loadShoppingItems(Func<Produto, string, bool> filtro, string restriction = "")
        {
            if (itemsTotais != null)
            {
                fpnlShopItems.Controls.Clear();
                foreach (var item in itemsTotais)
                {
                    item.Dispose();
                }
                itemsTotais.Clear();
            }
            itemsTotais = new List<ShopItemControl>();
            int idxTotItems = 0;
            for (int i = 0; i < produtosTotais?.Length; i++)
            {
                if (filtro(produtosTotais[i], restriction))
                {
                    itemsTotais.Add(new ShopItemControl(produtosTotais[i]));
                    itemsTotais[idxTotItems].ProductSelected += sendEventToMenu;
                    fpnlShopItems.Controls.Add(itemsTotais[idxTotItems]);
                    itemsTotais[idxTotItems].Show();
                    idxTotItems++;
                }
            }


            return;
        }

        private void cboFranchise_SelectedIndexChanged(object? sender, EventArgs e)
        {
            //Valid Index
            if (cboFranchise.SelectedIndex < 1)
            {
                loadShoppingItems(FilterFunctions.noFilter);
            }
            else
            {

            }
            //reset other stuff index
        }

        private void cboProdutores_SelectedIndexChanged_1(object? sender, EventArgs e)
        {
            //Valid Index
            if (cboProdutores.SelectedIndex < 1)
            {
                loadShoppingItems(FilterFunctions.noFilter);
            }
            else
            {
                loadShoppingItems(FilterFunctions.filterProds, cboProdutores.SelectedItem.ToString());
            }
            //reset other stuff index
        }
    }
}
