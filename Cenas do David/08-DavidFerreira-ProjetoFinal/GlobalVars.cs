using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DavidFerreira_ProjetoFinal
{
    static public class GlobalVars
    {
        public const string strProvider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = .\\..\\..\\..\\..\\..\\06-08-DanielSilva-DavidFerreira-Empresa.accdb;Persist Security Info = False";

        public const int formatError = -200;
        public const int dbError = -400;
        public const int aOk = 69420;

        static public Color noStockColor = Color.Tomato;

        static public Color stockColor = Color.LawnGreen;

        static public Color limitedStockColor = Color.Yellow;

        static public Color preOrder = Color.AliceBlue;

        static public int QuantidadeCompras = DataManagement.RowsCount(strProvider, "Compra");
    }
}
