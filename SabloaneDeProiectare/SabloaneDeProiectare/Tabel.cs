using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Tabel : AbstractElement
    {
        string nume;

        public Tabel()
        {

        }

        public override string Print()
        {
            return nume;
        }
    }
}
