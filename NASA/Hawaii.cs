using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA
{
    class Hawaii : IPlatforma
    {
        public string MasaStartowa { get; set; }

        public void ZwolnijRakiete(Rakieta rakieta)
        {
            Console.WriteLine("Hawaii zwalnia rakietę " + rakieta.PrzedstawRakiete());
            rakieta.StartujRakiete();
        }
    }
}
