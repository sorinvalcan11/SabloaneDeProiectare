using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace SabloaneDeProiectare.Builders
{
    class JsonBuilder : Builder
    {
        private Carte book;
        private string path;

        public JsonBuilder(string path)
        {
            this.path = path;
        }

        public void Build()
        {
            book = new Carte();

            dynamic obj = JObject.Parse(File.ReadAllText(path));

            string x = obj.Class;
        }

        public Carte GetResult()
        {
            throw new NotImplementedException();
        }
    }
}
