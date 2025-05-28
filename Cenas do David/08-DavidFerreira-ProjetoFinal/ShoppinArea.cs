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

        public List<ButaoCategoria> butaoCategoriasTotais = new List<ButaoCategoria>();

        public Produto[]? produtosTotais;

        public List<string>? categoriasTotais = null;
        public List<string>? produtorTotais = null;
        public List<string>? franchiseTotais = null;
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
            produtosTotais = DataManagement.retrieveProducts(GlobalVars.strProvider);
            produtorTotais = DataManagement.mergeListListString(DataManagement.retrieveStrings(GlobalVars.strProvider, "Produtor","nomeProdutor"));
            franchiseTotais = DataManagement.mergeListListString(DataManagement.retrieveStrings(GlobalVars.strProvider, "Franchise", "NomeFranchise"));
            categoriasTotais = DataManagement.mergeListListString(DataManagement.retrieveStrings(GlobalVars.strProvider, "Categoria", "categoriaProduto"));

            for (int i = 0; i < produtorTotais?.Count; i++)
            {
                cboProdutores.Items.Add(produtorTotais[i]);
            }
            for (int i = 0; i < franchiseTotais?.Count; i++)
            {
                cboFranchise.Items.Add(franchiseTotais[i]);
            }

            for (int i = 0; i < categoriasTotais?.Count; i++)
            {
                butaoCategoriasTotais.Add(new ButaoCategoria(categoriasTotais[i]));
                fpnlCategorias.Controls.Add(butaoCategoriasTotais[i]);
                butaoCategoriasTotais[i].OnButaoCategoriaPressed += recievedCategory;
                butaoCategoriasTotais[i].Show();
            }

            if (produtosTotais != null)
            {
                loadShoppingItems(FilterFunctions.noFilter);

                //NESTE CASO ESPECÍFICO NÃO QUERO QUE ELE FAÇA O INDEXCHANGED
                //assim, descolo e volto a colar o método

                resetCboIndexes();
            }
        }

        public void recievedCategory(object sender, StringEventArgs e)
        {
            btnRefresh.Visible = true;
            loadShoppingItems(FilterFunctions.filterCat, e.Str);
            resetCboIndexes();
        }

        public void setBtnRefreshVisible(bool b)
        {
            btnRefresh.Visible=b;
        }

        public void resetCboIndexes()
        {
            cboFranchise.SelectedIndexChanged -= cboFranchise_SelectedIndexChanged;
            cboFranchise.SelectedIndex = 0;
            cboFranchise.SelectedIndexChanged += cboFranchise_SelectedIndexChanged;
            cboProdutores.SelectedIndexChanged -= cboProdutores_SelectedIndexChanged_1;
            cboProdutores.SelectedIndex = 0;
            cboProdutores.SelectedIndexChanged += cboProdutores_SelectedIndexChanged_1;
        }
        public void loadShoppingItems(Func<Produto, string, bool> filtro, string restriction = "")
        {
            if (restriction == "" && itemsTotais?.Count == produtosTotais?.Length)
            {
                return;
            }
            fpnlShopItems.Visible = false;
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
            if(itemsTotais.Count == 0)
            {
                Label lbl = new Label();
                lbl.Text = "Nenhum Produto Corresponde à Pesquisa";
                lbl.Font = new Font(lbl.Font.FontFamily, 20, FontStyle.Bold);
                lbl.AutoSize = true;
                fpnlShopItems.Controls.Add(lbl);
                lbl.Show();

            }
            fpnlShopItems.Visible = true;
            return;
        }

        private void cboFranchise_SelectedIndexChanged(object? sender, EventArgs e)
        {
            cboProdutores.SelectedIndexChanged -= cboProdutores_SelectedIndexChanged_1;
            cboProdutores.SelectedIndex = 0;
            cboProdutores.SelectedIndexChanged += cboProdutores_SelectedIndexChanged_1;
            //Valid Index
            if (cboFranchise.SelectedIndex < 1)
            {
                loadShoppingItems(FilterFunctions.noFilter);
            }
            else
            {
                btnRefresh.Visible = true;
                loadShoppingItems(FilterFunctions.filterFranchise, cboFranchise.SelectedItem.ToString());
            }
            //reset other stuff index
        }

        private void cboProdutores_SelectedIndexChanged_1(object? sender, EventArgs e)
        {
            cboFranchise.SelectedIndexChanged -= cboFranchise_SelectedIndexChanged;
            cboFranchise.SelectedIndex = 0;
            cboFranchise.SelectedIndexChanged += cboFranchise_SelectedIndexChanged;
            //Valid Index
            if (cboProdutores.SelectedIndex < 1)
            {
                loadShoppingItems(FilterFunctions.noFilter);
            }
            else
            {
                btnRefresh.Visible = true;
                loadShoppingItems(FilterFunctions.filterProds, cboProdutores.SelectedItem.ToString());
            }
            //reset other stuff index
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadShoppingItems(FilterFunctions.noFilter);
            btnRefresh.Visible = false;
            resetCboIndexes();
        }
    }
}
