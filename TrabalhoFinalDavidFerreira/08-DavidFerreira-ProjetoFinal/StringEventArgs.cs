using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DavidFerreira_ProjetoFinal
{
    public class StringEventArgs : EventArgs
    {
        private string str;

        public string Str { get { return str;} set { str = value; } }

        public StringEventArgs(string s)
        {
            str= s;
        }
    }
}
