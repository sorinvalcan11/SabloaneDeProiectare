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

        public Tabel(string nume)
        {
            this.nume = nume;
        }

        public override void accept(Visitors.Visitor v)
        {
            v.visitTabel(this);
        }

        public override string Print()
        {
            return nume;
        }
    }
}
