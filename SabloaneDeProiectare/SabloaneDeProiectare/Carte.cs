using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabloaneDeProiectare
{
    class Carte
    {
        string titlu;
        List<Autor> autori;
        List<IElement> continut;
        Cuprins cuprins;

        public Carte()
        {
            continut = new List<IElement>();
        }

        public void Add(IElement element)
        {
            continut.Add(element);
        }

        public void accept(Visitors.Visitor v)
        {
            foreach(IElement element in continut)
            {
                element.accept(v);
            }
        }
    }
}
