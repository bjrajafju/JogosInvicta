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
            return ((DataManagement.retrieveStrings(GlobalVars.strProvider, "Produtor","nomeProdutor","IdProdutor = " + produto.IdProd))[0][0] == nomeFornecedor);
        }

        public static bool filterCat(Produto produto, string nomeCat)
        {
            return ((DataManagement.retrieveStrings(GlobalVars.strProvider, "Categoria", "categoriaProduto", "IdCategoria = " + produto.IdCategoria))[0][0] == nomeCat);
        }

        public static bool filterFranchise(Produto produto, string nomeFranchise)
        {
            return ((DataManagement.retrieveStrings(GlobalVars.strProvider, "Franchise", "nomeFranchise", "IdFranchise = " + produto.IdFranchise))[0][0] == nomeFranchise);
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
