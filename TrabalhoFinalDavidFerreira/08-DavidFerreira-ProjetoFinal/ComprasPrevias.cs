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
    public partial class ComprasPrevias : Form
    {
        List<Compra> compras = new List<Compra>();
        List<CompraItem> compraItems = new List<CompraItem>();

        public ComprasPrevias(List<Compra> list)
        {
            InitializeComponent();
            compras = list;
            for (int i = 0; i < compras.Count; i++)
            {
                compraItems.Add(new CompraItem(compras[i]));
                pnlCompraItems.Controls.Add(compraItems[i]);
                compraItems[i].Dock = DockStyle.Top;
            }
        }

        private void ComprasPrevias_Load(object sender, EventArgs e)
        {

        }
    }
}
