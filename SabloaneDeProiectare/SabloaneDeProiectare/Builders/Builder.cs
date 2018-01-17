using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabloaneDeProiectare.Builders
{
    public interface Builder
    {
        void Build();
        Carte GetResult();
    }
}
