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
            return (DataRetrieval.retrieveProdutorFromIdx(GlobalVars.strProvider,produto.IdProd) == nomeFornecedor);
        }

        public static bool noFilter(Produto produto, string str = "")
        {
            return true;
        }
    }
}
