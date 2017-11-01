using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Paragraf : AbstractElement
    {
        string text;

        private SabloaneDeProiectare.AlignStrategy alignAlgorithm = null;

        public Paragraf()
        {

        }

        public override string Print()
        {
            if (alignAlgorithm != null)
                return alignAlgorithm.PrintAligned();

            return text;
        }
    }
}
