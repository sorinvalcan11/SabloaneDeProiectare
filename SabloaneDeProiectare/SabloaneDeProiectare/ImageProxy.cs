﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabloaneDeProiectare
{
    public class ImageProxy : AbstractElement
    {
        private string fileName;
        private Imagine realImage = null;

        public ImageProxy(string fName)
        {
            fileName = fName;
        }

        public override void accept(Visitors.Visitor v)
        {
            v.visitImageProxy(this);
        }

        public override string Print()
        {
            realImage = new Imagine(fileName);

            return realImage.Print();
        }
    }
}
