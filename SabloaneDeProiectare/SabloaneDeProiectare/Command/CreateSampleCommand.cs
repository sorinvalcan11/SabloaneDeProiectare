using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabloaneDeProiectare.Command
{
    class CreateSampleCommand : ICommand
    {
        public CreateSampleCommand()
        {

        }

        public void execute()
        {
            Carte book = Singleton.BookSingleton.Instance;

            book.Clear();

            Sectiune s = new Sectiune();
            s.Add(new Paragraf("Paragraf1"));
            s.Add(new Imagine("Poza1"));
            s.Add(new Tabel("Tabel1"));

            book.Add(s);
        }
    }
}
