using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace SabloaneDeProiectare.Visitors
{
    public class SaveXmlVisitor : Visitor
    {
        private string xmlString;

        public SaveXmlVisitor()
        {
            xmlString += "<Carte>\n";
        }

        public void visitImage(Imagine image)
        {
            xmlString += "<Imagine>\n" + image.Print() + "\n</Imagine>\n";
        }

        public void visitImageProxy(ImageProxy imageProxy)
        {
            xmlString += "<Imagine>\n" + imageProxy.Print() + "\n</Imagine>\n";
        }

        public void visitParagraf(Paragraf paragraf)
        {
            xmlString += "<Paragraf>\n" + paragraf.Print() + "\n</Paragraf>\n";
        }

        public void visitSectiune(Sectiune sectiune)
        {
            xmlString += "<Sectiune>\n";

            sectiune.accept(this);

            xmlString += "\n</Sectiune>\n";
        }

        public void visitTabel(Tabel tabel)
        {
            xmlString += "<Tabel>\n" + tabel.Print() + "\n</Tabel>\n";
        }

        public void SaveFile(string path)
        {
            xmlString += "</Carte>";

            File.WriteAllText(path, xmlString);
        }
    }
}
