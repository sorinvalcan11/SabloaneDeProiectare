using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabloaneDeProiectare
{
    abstract class AlignStrategy
    {
        protected string text;

        public AlignStrategy(string text)
        {
            this.text = text;
        }

        public abstract string PrintAligned();
    }
}
