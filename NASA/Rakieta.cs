using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA
{
    public abstract class Rakieta 
    {
        private String _name { get; }
        public Rakieta(String name)
        {
            this._name = name;
        }

        public void StartujRakiete()
        {
            UruchomZaplon();
            Console.WriteLine("Start rakiety: " + PrzedstawRakiete());
               
        }

        public String PrzedstawRakiete()
        {
            return _name;
        }

        abstract protected void UruchomZaplon();

    }
}
