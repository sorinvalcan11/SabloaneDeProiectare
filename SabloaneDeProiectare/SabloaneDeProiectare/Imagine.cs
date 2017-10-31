using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Imagine : IElement
    {
        private string nume;

        public Imagine()
        {

        }

        public void Add(IElement newElement)
        {
            throw new InvalidOperationException();
        }

        public void Remove(IElement element)
        {
            throw new InvalidOperationException();
        }

        public IElement GetElement(int index)
        {
            throw new InvalidOperationException();
        }

        public string Print()
        {
            return "Numele imaginii este: " + nume;
        }
    }
}
