using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DavidFerreira_ProjetoFinal
{
    internal class LinhasDoCarrinho
    {
        Produto? product;
        int? quantidade;

        public LinhasDoCarrinho() { }

        public Produto? Product { get { return product; } set { product = value; } }

        public int? Quantidade { get { return quantidade; } set { quantidade = value; } }
    }
}
