using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Sectiune : IElement
    {
        string titlu;
        List<IElement> elemente = new List<IElement>();

        public Sectiune()
        {

        }

        public void Add(IElement newElement)
        {
            elemente.Add(newElement);
        }

        public void Remove(IElement element)
        {
            elemente.Remove(element);
        }

        public IElement GetElement(int index)
        {
            return elemente[index];
        }

        public string Print()
        {
            string textToPrint = titlu;

            foreach (IElement element in elemente)
                textToPrint +=element.Print();

            return textToPrint;
        }
    }
}
