using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabloaneDeProiectare
{
    public class Tabel : AbstractElement
    {
        string nume;

        public Tabel()
        {

        }

        public override void accept(Visitor v)
        {
            v.visitTabel(this);
        }

        public override string Print()
        {
            return nume;
        }
    }
}
