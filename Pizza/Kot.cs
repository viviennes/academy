using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Kot
    {
        private String name;

        public Kot(String name) 
        {
            this.name = name;
        }

        public static implicit operator Kot(Pizza v)
        {
            Console.WriteLine("Kot z pizzy");
            return new Kot("Pizza");
        }
    }
}
