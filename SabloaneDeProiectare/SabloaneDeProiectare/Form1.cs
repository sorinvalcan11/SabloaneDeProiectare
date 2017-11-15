using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabloaneDeProiectare
{
    public partial class Form1 : Form
    {
        private Carte book;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitCarte()
        {
            book = new Carte();

            book.Add(new Imagine("Imagine1"));
            book.Add(new Paragraf("Paragraf1"));

            Sectiune s = new Sectiune();
            s.Add(new Tabel("Tabel1"));
            s.Add(new Paragraf("Paragraf2"));
            s.Add(new Paragraf("Paragraf3"));

            book.Add(s);

            book.Add(new ImageProxy("Imagine2"));
        }

        private void documentStatVisitorButton_Click(object sender, EventArgs e)
        {
            InitCarte();

            Visitors.SaveXmlVisitor saveXml = new Visitors.SaveXmlVisitor();

            book.accept(saveXml);

            saveXml.SaveFile("D:\\book.xml");

            MessageBox.Show("Save done!");
        }
    }
}
