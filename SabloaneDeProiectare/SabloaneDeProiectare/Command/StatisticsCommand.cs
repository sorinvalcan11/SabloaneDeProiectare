using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabloaneDeProiectare.Command
{
    class StatisticsCommand : ICommand
    {
        public StatisticsCommand()
        {
            
        }

        public void execute()
        {
            Visitors.DocumentStatVisitor visit = new Visitors.DocumentStatVisitor();

            Carte book = Singleton.BookSingleton.Instance;

            book.accept(visit);

            System.Windows.Forms.MessageBox.Show(visit.print());
        }
    }
}
