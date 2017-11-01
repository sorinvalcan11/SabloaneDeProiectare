using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabloaneDeProiectare
{
    class AlignRight : AlignStrategy
    {
        public AlignRight(string text) : base(text)
        {

        }

        public override string PrintAligned()
        {
            return text + "***";
        }
    }
}
