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
    public partial class ButaoCategoria : UserControl
    {
        public delegate void ButaoCategoriaPressed(object sender, StringEventArgs e);

        public event ButaoCategoriaPressed? OnButaoCategoriaPressed;


        string categoriaAssociada = "";
        public ButaoCategoria(string str)
        {
            categoriaAssociada = str;
            InitializeComponent();
            Click += ButaoCategoria_Click;
        }

        private void ButaoCategoria_Load(object sender, EventArgs e)
        {
            lblCategoryName.Text = categoriaAssociada;
        }

        private void ButaoCategoria_Click(object sender, EventArgs e)
        {
            OnButaoCategoriaPressed?.Invoke(sender, new StringEventArgs(categoriaAssociada));
        }

        private void lblCategoryName_Click(object sender, EventArgs e)
        {
            OnButaoCategoriaPressed?.Invoke(sender, new StringEventArgs(categoriaAssociada));
        }
    }
}
