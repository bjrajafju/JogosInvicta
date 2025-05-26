using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DavidFerreira_ProjetoFinal
{
    public class ProdutoEventArgs : EventArgs
    {
        private Produto prod;

        public Produto Produto { get { return prod;} set { prod = value; } }

        public ProdutoEventArgs(Produto produto)
        {
            prod = produto;
        }
    }
}
