using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabloaneDeProiectare
{
    public class Capitol : AbstractElement
    {
        string titlu;

        public Capitol()
        {

        }

        public override void accept(Visitor v)
        {
            throw new NotImplementedException();
        }

        public override string Print()
        {
            return titlu;
        }
    }
}
