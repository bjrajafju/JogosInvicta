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


        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            shoppingAreaForm = new ShoppinArea();
            shoppingAreaForm.MdiParent = this;
            shoppingAreaForm.Dock = DockStyle.Fill;
            shoppingAreaForm.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
