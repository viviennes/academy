using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA
{
    class HeavyFalcon3 : Rakieta
    {
        public HeavyFalcon3(string name) : base(name)
        {
        }

        protected override void UruchomZaplon()
        {
            Console.WriteLine("Uruchamiam zaplon HeavyFalcon3 o nazwie: " + PrzedstawRakiete());
        }
    }
}
