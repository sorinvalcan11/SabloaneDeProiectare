using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public interface IElement
    {
        void Add(IElement newElement);
        void Remove(IElement element);
        IElement GetElement(int index);
        string Print();
    }
}
