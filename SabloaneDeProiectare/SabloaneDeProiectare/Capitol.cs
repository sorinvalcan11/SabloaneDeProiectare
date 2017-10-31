using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Capitol : AbstractElement
    {
        string titlu;

        public Capitol()
        {

        }

        public override string Print()
        {
            return titlu;
        }
    }
}
