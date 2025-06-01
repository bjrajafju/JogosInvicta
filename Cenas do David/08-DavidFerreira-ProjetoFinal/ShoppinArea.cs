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

        public List<Produto>? produtosTotais;

        public List<ShopItemControl>? itemsTotais = null;
        public ShoppinArea()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        public void sendEventToMenu(object sender, ProdutoEventArgs e)
        {
            OnProductSelectedChangePage?.Invoke(this, e);
        }

        private void ShoppinArea_Load(object sender, EventArgs e)
        {
            produtosTotais = DataManagement.retrieveProducts(GlobalVars.strProvider);
            List<string>? produtorTotais = DataManagement.retrieveSingleColumn(GlobalVars.strProvider, "Produtor","nomeProdutor");
            List<string>? franchiseTotais = DataManagement.retrieveSingleColumn(GlobalVars.strProvider, "Franchise", "NomeFranchise");
            List<string>? categoriasTotais = DataManagement.retrieveSingleColumn(GlobalVars.strProvider, "Categoria", "categoriaProduto");
            
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

            if (produtosTotais?.Count > 0)
            {
                loadShoppingItems(FilterFunctions.noFilter);

                //NESTE CASO ESPECÍFICO NÃO QUERO QUE ELE FAÇA O INDEXCHANGED
                //assim, descolo e volto a colar o método

                resetCboIndexes();
            }
            GC.Collect();
        }

        public void recievedCategory(object sender, StringEventArgs e)
        {
            loadShoppingItems(FilterFunctions.filterCat, e.Str);
            resetCboIndexes();
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
            if (restriction == "" && itemsTotais?.Count == produtosTotais?.Count)
            {
                return;
            }
            fpnlShopItems.SuspendLayout();
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
            for (int i = 0; i < produtosTotais?.Count; i++)
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
            if(restriction == "")
            {
                btnRefresh.Visible = false;
            } else btnRefresh.Visible = true;
            if (itemsTotais.Count == 0)
            {
                Label lbl = new Label();
                lbl.Text = "Nenhum Produto Corresponde à Pesquisa";
                lbl.Font = new Font(lbl.Font.FontFamily, 20, FontStyle.Bold);
                lbl.AutoSize = true;
                fpnlShopItems.Controls.Add(lbl);
                lbl.Show();

            }
            fpnlShopItems.ResumeLayout();
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
                if(cboFranchise.SelectedItem !=null) loadShoppingItems(FilterFunctions.filterFranchise, cboFranchise.SelectedItem.ToString());
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
                loadShoppingItems(FilterFunctions.filterProds, cboProdutores.SelectedItem.ToString());
            }
            //reset other stuff index
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadShoppingItems(FilterFunctions.noFilter);
            resetCboIndexes();
        }
    }
}
