using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabloaneDeProiectare.Singleton
{
    public class BookSingleton
    {
        private static Carte instance = null;

        private BookSingleton()
        {

        }

        public static Carte Instance
        {
            get 
            {
                if (instance == null)
                    instance = new Carte();

                return instance;
            }
        }
    }
}
