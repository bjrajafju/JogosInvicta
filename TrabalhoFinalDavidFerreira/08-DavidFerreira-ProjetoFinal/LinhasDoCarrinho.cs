using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DavidFerreira_ProjetoFinal
{
    public class LinhasDoCarrinho
    {
        Produto product;
        int quantidade;

        public LinhasDoCarrinho(Produto p, int q=0) { product = p;quantidade = q; }

        public Produto Product { get { return product; } set { product = value; } }

        public int Quantidade { get { return quantidade; } set { quantidade = value; } }
    }
}
