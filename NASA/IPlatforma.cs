using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA
{
    public interface IPlatforma
    {
        String MasaStartowa { get; set; }
        void ZwolnijRakiete(Rakieta rakieta);
    }
}
