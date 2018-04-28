using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA
{
    class Falcon2 : Rakieta
    {
        public Falcon2(string name) : base(name)
        {
        }

        protected override void UruchomZaplon()
        {
            Console.WriteLine("Uruchamiam zaplon Falcon2 o nazwie: " + PrzedstawRakiete());
        }
    }
}
