using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA
{
    class Falcon1 : Rakieta
    {
        public Falcon1(String name) : base(name) { }

        protected override void UruchomZaplon()
        {
            Console.WriteLine("Uruchamiam zaplon Falcon1 o nazwie: " + PrzedstawRakiete());
        }


    }
}
