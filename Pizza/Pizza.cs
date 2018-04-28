using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Pizza
    {
        private String Name { get; set; }

        public static implicit operator Pizza(Kot v)
        {
            Console.WriteLine("Pizza z kota");
            return new Pizza();
        }

    }
}
