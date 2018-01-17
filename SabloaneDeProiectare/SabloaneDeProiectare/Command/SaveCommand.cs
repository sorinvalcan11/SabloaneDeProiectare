using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabloaneDeProiectare.Command
{
    public class SaveCommand : ICommand
    {
        public SaveCommand()
        {

        }

        public void execute()
        {
            Visitors.SaveXmlVisitor visit = new Visitors.SaveXmlVisitor();

            Carte book = Singleton.BookSingleton.Instance;

            book.accept(visit);

            visit.SaveFile("D:\\Carte.xml");
        }
    }
}
