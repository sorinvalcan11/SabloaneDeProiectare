﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SabloaneDeProiectare;

namespace SabloaneDeProiectare
{
    public class Paragraf : AbstractElement
    {
        string text;

        private SabloaneDeProiectare.AlignStrategy alignAlgorithm = null;

        public Paragraf(string text)
        {
            this.text = text;
        }

        internal AlignStrategy AlignAlgorithm { get => alignAlgorithm; set => alignAlgorithm = value; }

        public override void accept(Visitors.Visitor v)
        {
            v.visitParagraf(this);
        }

        public override string Print()
        {
            if (alignAlgorithm != null)
                return alignAlgorithm.PrintAligned();

            return text;
        }
    }
}
