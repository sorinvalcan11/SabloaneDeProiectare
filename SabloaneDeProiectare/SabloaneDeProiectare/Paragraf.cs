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

        public Paragraf()
        {

        }

        public override string Print()
        {
            return text;
        }
    }
}
