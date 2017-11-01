using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabloaneDeProiectare
{
    class AlignLeft : AlignStrategy
    {
        public AlignLeft(string text) : base(text)
        {
            
        }

        public override string PrintAligned()
        {
            return "***" + text;
        }
    }
}
