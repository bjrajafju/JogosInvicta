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

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            shoppingAreaForm = new ShoppinArea();
            shoppingAreaForm.OnProductSelectedChangePage += detailedItemLoad;
            shoppingAreaForm.MdiParent = this;
            shoppingAreaForm.Dock = DockStyle.Fill;
            shoppingAreaForm.Show();
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
            shoppingAreaForm.Activate();
        }

        private void lblAppName_Click(object sender, EventArgs e)
        {
            shoppingAreaForm.Activate();
        }
    }
}
