using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabloaneDeProiectare.Visitors
{
    public class DocumentStatVisitor : Visitor
    {
        private int imageCounter = 0;
        private int tabelCounter = 0;
        private int paragrafCounter = 0;

        public DocumentStatVisitor()
        {

        }

        public int ImageCounter { get => imageCounter; set => imageCounter = value; }
        public int TabelCounter { get => tabelCounter; set => tabelCounter = value; }
        public int ParagrafCounter { get => paragrafCounter; set => paragrafCounter = value; }

        public void visitImage(Imagine image)
        {
            imageCounter++;
        }

        public void visitImageProxy(ImageProxy imageProxy)
        {
            imageCounter++;
        }

        public void visitParagraf(Paragraf paragraf)
        {
            paragrafCounter++;
        }

        public void visitSectiune(Sectiune sectiune)
        {
            foreach (IElement elem in sectiune.Elemente)
                elem.accept(this);
        }

        public void visitTabel(Tabel tabel)
        {
            tabelCounter++;
        }

        public string print()
        {
            string output = "";

            output += "Imagini: " + imageCounter.ToString() +
                "\r\n" + "Tabele: " + tabelCounter.ToString() +
                "\r\n" + "Paragrafe: " + paragrafCounter.ToString();

            return output;
        }
    }
}
