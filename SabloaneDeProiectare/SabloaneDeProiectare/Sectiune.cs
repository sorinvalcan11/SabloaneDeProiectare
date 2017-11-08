using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabloaneDeProiectare
{
    public class Sectiune : IElement
    {
        string titlu;
        List<IElement> elemente = new List<IElement>();

        public List<IElement> Elemente { get => elemente; set => elemente = value; }

        public Sectiune()
        {

        }

        public void Add(IElement newElement)
        {
            Elemente.Add(newElement);
        }

        public void Remove(IElement element)
        {
            Elemente.Remove(element);
        }

        public IElement GetElement(int index)
        {
            return Elemente[index];
        }

        public void accept(Visitor v)
        {
            foreach (AbstractElement elem in elemente)
                elem.accept(v);
        }

        public string Print()
        {
            string textToPrint = titlu;

            foreach (IElement element in Elemente)
                textToPrint +=element.Print();

            return textToPrint;
        }
    }
}
