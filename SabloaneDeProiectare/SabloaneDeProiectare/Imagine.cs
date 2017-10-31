﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Imagine : AbstractElement
    {
        private string fileName;
        private string imageData;

        public Imagine(string fName)
        {
            fileName = fName;
            imageData = LoadImage(fileName);
        }

        private string LoadImage(string path)
        {
            return "Image data";
        }

        public override string Print()
        {
            return "Numele imaginii este: " + fileName;
        }
    }
}
