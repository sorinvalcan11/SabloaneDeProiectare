using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class AbstractElement : IElement
    {
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

        public abstract string Print();

    }
}
