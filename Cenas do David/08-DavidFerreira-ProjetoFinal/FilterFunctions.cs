using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DavidFerreira_ProjetoFinal
{
    static public class FilterFunctions
    {
        public static bool filterProds(Produto produto, string nomeFornecedor)
        {
            return (produto.getProdutor() == nomeFornecedor);
        }

        public static bool filterCat(Produto produto, string nomeCat)
        {
            return ( produto.getCategoria()== nomeCat);
        }

        public static bool filterFranchise(Produto produto, string nomeFranchise)
        {
            return (produto.getFranchise() == nomeFranchise);
        }

        public static bool filterSearch(Produto produto, string nomeSearch)
        {
            return (produto.NomeProduto.ToLower().Contains(nomeSearch));
        }

        public static bool noFilter(Produto produto, string str = "")
        {
            return true;
        }
    }
}
