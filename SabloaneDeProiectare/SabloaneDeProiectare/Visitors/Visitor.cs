using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabloaneDeProiectare
{
    public interface Visitor
    {
        void visitImageProxy(ImageProxy imageProxy);
        void visitImage(Imagine image);
        void visitParagraf(Paragraf paragraf);
        void visitTabel(Tabel tabel);
        void visitSectiune(Sectiune sectiune);
    }
}
