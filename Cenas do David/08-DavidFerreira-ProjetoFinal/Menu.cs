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

        private int customerId = -1;
        public Menu()
        {
            InitializeComponent();
        }
        
        private void Menu_Load(object sender, EventArgs e)
        {
            AccountOptionsLoggedOut acc = new AccountOptionsLoggedOut();
            acc.LoginClicked += LoginLoad;
            acc.RegisterClicked += RegisterLoad;
            pnlAccountOptions.Controls.Add(acc);
            acc.Dock = DockStyle.Top;

            pnlAccountOptions.Size = new Size(0,pnlAccountOptions.Size.Height);
            Size = new Size(1250, 750);
            MinimumSize = new Size(1250, 750);

            shoppingAreaForm = new ShoppinArea();
            shoppingAreaForm.OnProductSelectedChangePage += detailedItemLoad;
            shoppingAreaForm.MdiParent = this;
            shoppingAreaForm.Dock = DockStyle.Fill;
            shoppingAreaForm.Show();
        }


        public void accountLoggedIn(object sender, StringEventArgs e)
        {
            customerId = Convert.ToInt32(e.Str);
            pnlAccountOptions.Controls.Clear();
            shoppingAreaForm.Activate();
            AccountOptionsLoggedIn acc = new AccountOptionsLoggedIn();
            acc.logout += Logout;
            pnlAccountOptions.Controls.Add(acc);
        }

        private void LoginLoad(object? sender, EventArgs e)
        {
            if (loginPage != null)
            {
                loginPage.Activate();
            } else
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
        }

        private void Logout(object? sender, EventArgs e)
        {
            pnlAccountOptions.Controls.Clear();
            pnlAccountOptions.Size = new Size(0,pnlAccountOptions.Size.Height);
            AccountOptionsLoggedOut acc = new AccountOptionsLoggedOut();
            acc.LoginClicked += LoginLoad;
            acc.RegisterClicked += RegisterLoad;
            pnlAccountOptions.Controls.Add(acc);
            acc.Dock = DockStyle.Top;
        }

        private void returnToHome(object? sender, EventArgs e)
        {
            if(shoppingAreaForm != null) { shoppingAreaForm.Activate(); }
        }

        private void RegisterLoad(object? sender, EventArgs e)
        {
            if (registryPage != null)
            {
                registryPage.Activate();
            }
            else
            {
                registryPage = new Registar();
                registryPage.MdiParent = this;
                registryPage.onSucessfulRegistry += returnToHome;
                registryPage.Dock = DockStyle.Fill;
            }
            while (pnlAccountOptions.Size.Width > 0)
            {
                pnlAccountOptions.Size = new Size(pnlAccountOptions.Size.Width - 10, pnlAccountOptions.Size.Height);
            }
            registryPage.Show();
        }

        private void detailedItemLoad(object sender, ProdutoEventArgs e)
        {
            if (productPage == null)
            {
                productPage = new ProductPage();
                productPage.MdiParent = this;
                productPage.Dock = DockStyle.Fill;
                productPage.Show();
            }
            else
            {
                productPage.Activate();
            }

            productPage.refreshProduct(e.Produto);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            shoppingAreaForm.resetCboIndexes();
            shoppingAreaForm.Activate();
            shoppingAreaForm.loadShoppingItems(FilterFunctions.noFilter);
        }

        private void lblAppName_Click(object sender, EventArgs e)
        {
            shoppingAreaForm.resetCboIndexes();
            shoppingAreaForm.Activate();
            shoppingAreaForm.loadShoppingItems(FilterFunctions.noFilter);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            shoppingAreaForm.resetCboIndexes();
            shoppingAreaForm.Activate();
            if (txtSearch.Text.Trim() == "")
            {
                shoppingAreaForm.setBtnRefreshVisible(false);
                shoppingAreaForm.loadShoppingItems(FilterFunctions.noFilter);
            }
            else
            {
                shoppingAreaForm.setBtnRefreshVisible(true);
                shoppingAreaForm.loadShoppingItems(FilterFunctions.filterSearch, txtSearch.Text.Trim().ToLower());
            }
            txtSearch.Text = "";
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if(pnlAccountOptions.Size.Width == 0)
            {
                while(pnlAccountOptions.Size.Width < 80)
                {
                    pnlAccountOptions.Size = new Size(pnlAccountOptions.Size.Width+10,pnlAccountOptions.Size.Height);
                }
            } else
            {
                while (pnlAccountOptions.Size.Width > 0)
                {
                    pnlAccountOptions.Size = new Size(pnlAccountOptions.Size.Width - 10, pnlAccountOptions.Size.Height);
                }
            }
        }
    }
}
