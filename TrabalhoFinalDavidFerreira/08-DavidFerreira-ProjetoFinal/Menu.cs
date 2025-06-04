using _08_DavidFerreira_ProjetoFinal;
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

    public partial class Menu : Form
    {
        private ShoppinArea shoppingAreaForm = null!;
        private ProductPage productPage = null!;
        private Login loginPage = null!;
        private Registar registryPage = null!;
        private PerfilUtilizador perfilUtilizador = null!;
        private ShoppingCart ShoppingCart = null!;
        private ComprasPrevias ComprasPrevias = null!;

        private Cliente Customer = null!;
        public Menu()
        {
            GlobalVars.QuantidadeCompras = DataManagement.RowsCount(GlobalVars.strProvider, "Compra");
            InitializeComponent();
            this.FormClosing += MenuClose;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            AccountOptionsLoggedOut acc = new AccountOptionsLoggedOut();
            acc.LoginClicked += LoginLoad;
            acc.RegisterClicked += RegisterLoad;
            pnlAccountOptions.Controls.Add(acc);
            acc.Dock = DockStyle.Top;

            pnlAccountOptions.Size = new Size(0, pnlAccountOptions.Size.Height);
            Size = new Size(1250, 750);
            MinimumSize = new Size(1250, 750);

            ShoppingCart = new ShoppingCart();
            ShoppingCart.MdiParent = this;
            ShoppingCart.Dock = DockStyle.Fill;
            ShoppingCart.Show();
            ShoppingCart.ChangeProductPageRequest += detailedItemLoad;
            ShoppingCart.returnHome += returnToHome;
            ShoppingCart.finaliseCart += FinalizarCompra;

            shoppingAreaForm = new ShoppinArea();
            shoppingAreaForm.OnProductSelectedChangePage += detailedItemLoad;
            shoppingAreaForm.MdiParent = this;
            shoppingAreaForm.Dock = DockStyle.Fill;
            shoppingAreaForm.Show();
        }

        private void MenuClose(object? sender, EventArgs args)
        {

            List<LinhasDoCarrinho> Lines = ShoppingCart.Linhas;
            if (Lines.Count > 0)
            {
                if (MessageBox.Show("Pretende guardar o seu carrinho para aceder de novo quando voltar? \nATENÇÃO: O SEU CARRINHO SERÁ IRRECUPERÁVEL", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<string> cols = new List<string>();
                    cols.Add("IdCliente");
                    cols.Add("IdProduto");
                    cols.Add("Quantidade");
                    for (int i = 0; i < Lines.Count; i++)
                    {
                        List<string> vals = new List<string>();
                        vals.Add(Customer.Id.ToString());
                        vals.Add(Lines[i].Product.Id.ToString());
                        vals.Add(Lines[i].Quantidade.ToString());
                        DataManagement.insertIntoDatabase(GlobalVars.strProvider, "LinhasCarrinho", cols, vals);
                    }
                }
            }
        }

        private void FinalizarCompra(object? sender, EventArgs args)
        {
            {
                List<string> cols1 = new List<string>();
                cols1.Add("IdCompra");
                cols1.Add("Data");
                cols1.Add("IdEstado");
                cols1.Add("IdCliente");

                List<string> values = new List<string>();
                values.Add((++GlobalVars.QuantidadeCompras).ToString());
                values.Add("#" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "#");
                values.Add("3");
                values.Add(Customer.Id.ToString());

                int n = DataManagement.insertIntoDatabase(GlobalVars.strProvider, "Compra", cols1, values);
                if (n != GlobalVars.aOk) MessageBox.Show(n.ToString());
            }
            List<string> cols = new List<string>();
            cols.Add("IdCompra");
            cols.Add("IdProduto");
            cols.Add("Quantidade");

            for (int i = 0; i < ShoppingCart.Linhas.Count; i++)
            {
                List<string> values = new List<string>();
                values.Add((GlobalVars.QuantidadeCompras).ToString());
                values.Add(ShoppingCart.Linhas[i].Product.Id.ToString());
                values.Add(ShoppingCart.Linhas[i].Quantidade.ToString());
                int n = DataManagement.insertIntoDatabase(GlobalVars.strProvider, "CompraProduto", cols, values);

                if (n != GlobalVars.aOk) MessageBox.Show(n.ToString());
            }
            ComprasPrevias = null;
        }

        public void accountLoggedIn(object sender, StringEventArgs e)
        {
            Customer = DataProcessing.retrieveSingleClient(Convert.ToInt32(e.Str));
            pnlAccountOptions.Controls.Clear();
            shoppingAreaForm.Activate();
            AccountOptionsLoggedIn acc = new AccountOptionsLoggedIn();
            acc.logout += Logout;
            acc.perfilAccess += ProfileLoad;
            acc.comprasPrevias += ComprasPreviasLoad;
            pnlAccountOptions.Controls.Add(acc);

            List<LinhasDoCarrinho> lines = DataProcessing.retrieveShoppingLines(Customer.Id);

            for (int i = 0; i < lines.Count; i++)
            {
                ShoppingCart.AddCartLine(lines[i]);
            }
            int n = DataManagement.removeFromDatabase(GlobalVars.strProvider, "LinhasCarrinho", "IdCliente=" + Customer.Id);
            if (n != GlobalVars.aOk)
            {
                MessageBox.Show(n.ToString());
            }
        }

        private void LoginLoad(object? sender, EventArgs e)
        {
            if (loginPage != null)
            {

            }
            else
            {
                loginPage = new Login();
                loginPage.MdiParent = this;
                loginPage.Dock = DockStyle.Fill;
                loginPage.onSucessfulLogin += accountLoggedIn;

            }
            while (pnlAccountOptions.Size.Width > 0)
            {
                pnlAccountOptions.Size = new Size(pnlAccountOptions.Size.Width - 10, pnlAccountOptions.Size.Height);
            }
            loginPage.Show();
            loginPage.Activate();
        }

        private void Logout(object? sender, EventArgs e)
        {
            pnlAccountOptions.Controls.Clear();
            pnlAccountOptions.Size = new Size(0, pnlAccountOptions.Size.Height);
            AccountOptionsLoggedOut acc = new AccountOptionsLoggedOut();
            acc.LoginClicked += LoginLoad;
            acc.RegisterClicked += RegisterLoad;
            pnlAccountOptions.Controls.Add(acc);
            acc.Dock = DockStyle.Top;
            shoppingAreaForm.Activate();
            perfilUtilizador = null;
            ComprasPrevias = null;
            GC.Collect();
        }

        private void returnToHome(object? sender, EventArgs e)
        {
            if (shoppingAreaForm != null) { shoppingAreaForm.Activate(); shoppingAreaForm.loadShoppingItems(FilterFunctions.noFilter); shoppingAreaForm.resetCboIndexes(); }
        }


        private void RegisterLoad(object? sender, EventArgs e)
        {
            if (registryPage != null)
            {

            }
            else
            {
                registryPage = new Registar();
                registryPage.MdiParent = this;
                registryPage.onSucessfulRegistry += LoginLoad;
                registryPage.onCanceledRegistry += returnToHome;
                registryPage.Dock = DockStyle.Fill;
            }
            while (pnlAccountOptions.Size.Width > 0)
            {
                pnlAccountOptions.Size = new Size(pnlAccountOptions.Size.Width - 10, pnlAccountOptions.Size.Height);
            }
            registryPage.Show();
            registryPage.resetTxtBoxes();
            registryPage.Activate();

        }

        private void detailedItemLoad(object sender, ProdutoEventArgs e)
        {
            if (productPage == null)
            {
                productPage = new ProductPage();
                productPage.MdiParent = this;
                productPage.Dock = DockStyle.Fill;
                productPage.OnAddToCart += AddShoppingCart;
                productPage.Show();
            }

            productPage.refreshProduct(e.Produto);
            productPage.Activate();
        }


        public void AddShoppingCart(object sender, LinhaEventArgs l)
        {
            if (Customer == null)
            {
                if (MessageBox.Show("Não está logged in para aceder ao seu carrinho. Gostaria de dar login?", "Atenção", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    LoginLoad(this, EventArgs.Empty);
                }
                return;
            }
            ShoppingCart.AddCartLine(l.Line);

            if (MessageBox.Show("Adicionado ao carrinho com sucesso! Pretende ver o seu carrinho?", "Sucesso!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ShoppingCart.Activate();
            }
            else
            {
                shoppingAreaForm.Activate();
            }
        }


        private void ProfileLoad(object? sender, EventArgs e)
        {
            if (perfilUtilizador == null)
            {
                perfilUtilizador = new PerfilUtilizador(ref Customer);
                perfilUtilizador.MdiParent = this;
                perfilUtilizador.Dock = DockStyle.Fill;
                perfilUtilizador.returnHome += returnToHome;
                perfilUtilizador.deleteAccount += DeleteAccount;
            }

            while (pnlAccountOptions.Size.Width > 0)
            {
                pnlAccountOptions.Size = new Size(pnlAccountOptions.Size.Width - 10, pnlAccountOptions.Size.Height);
            }
            perfilUtilizador.Activate();
            perfilUtilizador.Show();
        }


        private void ComprasPreviasLoad(object sender, EventArgs e)
        {
            if (ComprasPrevias == null)
            {
                ComprasPrevias = new ComprasPrevias(DataProcessing.retrieveCompras(Customer));
                ComprasPrevias.MdiParent = this;
                ComprasPrevias.Dock = DockStyle.Fill;
                ComprasPrevias.Show();
            }
            while (pnlAccountOptions.Size.Width > 0)
            {
                pnlAccountOptions.Size = new Size(pnlAccountOptions.Size.Width - 10, pnlAccountOptions.Size.Height);
            }
            ComprasPrevias.Activate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            returnToHome(sender, e);
        }

        private void lblAppName_Click(object sender, EventArgs e)
        {
            returnToHome(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            shoppingAreaForm.resetCboIndexes();
            shoppingAreaForm.Activate();
            if (txtSearch.Text.Trim() == "")
            {
                shoppingAreaForm.loadShoppingItems(FilterFunctions.noFilter);
            }
            else
            {
                shoppingAreaForm.loadShoppingItems(FilterFunctions.filterSearch, txtSearch.Text.Trim().ToLower());
            }
            txtSearch.Text = "";
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (pnlAccountOptions.Size.Width == 0)
            {
                while (pnlAccountOptions.Size.Width < 80)
                {
                    pnlAccountOptions.Size = new Size(pnlAccountOptions.Size.Width + 10, pnlAccountOptions.Size.Height);
                }
            }
            else
            {
                while (pnlAccountOptions.Size.Width > 0)
                {
                    pnlAccountOptions.Size = new Size(pnlAccountOptions.Size.Width - 10, pnlAccountOptions.Size.Height);
                }
            }
        }

        private void btnCart_Click(object? sender, EventArgs e)
        {
            if (ShoppingCart != null) ShoppingCart.Activate();
        }

        private void DeleteAccount(object? sender, EventArgs e)
        {
            List<Compra> compras = DataProcessing.retrieveCompras(Customer);

            for (int i = 0; i < compras.Count; i++)
            {
                int n = DataManagement.removeFromDatabase(GlobalVars.strProvider, "CompraProduto", "IdCompra=" + compras[i].Id);
                if (n != GlobalVars.aOk) MessageBox.Show(n.ToString());
            }

            int ret = DataManagement.removeFromDatabase(GlobalVars.strProvider, "Compra", "IdCliente =" + Customer.Id);
            if (ret != GlobalVars.aOk)
            {
                MessageBox.Show(ret.ToString());
            }

            int lastOne = DataManagement.removeFromDatabase(GlobalVars.strProvider, "Cliente", "IdCliente=" + Customer.Id);
            if (lastOne == GlobalVars.aOk)
            {
                MessageBox.Show("Conta Eliminada com Sucesso!");
                Logout(sender, e);
            }
            else
            {
                MessageBox.Show(lastOne.ToString());
            }
        }
    }
}
