using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DavidFerreira_ProjetoFinal
{
    public class LinhaEventArgs : EventArgs
    {
        private LinhasDoCarrinho line;

        public LinhasDoCarrinho Line { get { return line;} set { line= value; } }

        public LinhaEventArgs(LinhasDoCarrinho line)
        {
            this.line = line;
        }
    }
}
