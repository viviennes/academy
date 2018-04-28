using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA
{
    class Program
    {
        static void Main(string[] args)
        {
            Rakieta falcon1 = new Falcon1("TomekF1");
            Rakieta falcon2 = new Falcon2("JasiekF2");
            Rakieta falcon3 = new HeavyFalcon3("KrzysiekHF3");

            IPlatforma platforma1 = new Hawaii();
            IPlatforma platforma2 = new Canaveral();

            platforma1.ZwolnijRakiete(falcon1);
            Console.WriteLine();
            platforma1.ZwolnijRakiete(falcon2);
            Console.WriteLine();

            HeavyFalcon3 hf3;
            hf3 = falcon1 as HeavyFalcon3;
            if(hf3 != null) platforma1.ZwolnijRakiete(falcon1);
            Console.WriteLine();

            Rakieta rakieta;
            rakieta = falcon3 as Rakieta;
            if (rakieta != null) platforma1.ZwolnijRakiete(rakieta);
            Console.WriteLine();

            Hawaii hawaii; 
            hawaii = platforma2 as Hawaii;
            if (hawaii != null)  hawaii.ZwolnijRakiete(falcon1);
            Console.WriteLine();

            double d1 = 1.000001;
            double d2 = 0.000001;
            Console.WriteLine((decimal)(d1-d2) == 1.0m);

        }
    }
}
