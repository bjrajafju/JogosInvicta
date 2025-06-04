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
    public partial class CompraItem : UserControl
    {
        Compra Compra;
        List<CompraSubItem> subItems = new List<CompraSubItem>();
        public CompraItem(Compra c)
        {
            InitializeComponent();
            this.Click += Clicked;
            Compra = c;
            label1.Click += Clicked;
            lblDate.Click += Clicked;
            lblID.Click += Clicked;
            lblStatus.Click += Clicked;


            List<CompraProduto> compraProdutos = DataProcessing.retrieveCompraProduto(Compra.Id);

            for (int i = 0; i < compraProdutos.Count; i++)
            {
                subItems.Add(new CompraSubItem(compraProdutos[i]));
                pnlSubItems.Controls.Add(subItems[i]);
                subItems[i].Dock = DockStyle.Top;
                subItems[i].Visible = false;
            }

            lblDate.Text = Compra.DataCompra.ToString();
            lblID.Text = Compra.Id.ToString();
            lblStatus.Text = Compra.Estado.NomeEstado;
        }

        private void Clicked(object sender, EventArgs ev)
        {
            foreach (CompraSubItem c in pnlSubItems.Controls)
            {
                if(c.Visible) c.Visible = false;
                else c.Visible = true;
            }
        }
    }
}
