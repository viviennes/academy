using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            PizzaCollection<Pizza> pizzaCollection = new PizzaCollection<Pizza>();
            for(int i = 0; i < 3; i++)
            {
                pizzaCollection[i] = new Pizza();
            }
            */

            ////////////////////////////////////////////////////////////////////////////

            /*
            Pizza pizza = new Pizza();
            Kot kot = pizza;
             */

            ////////////////////////////////////////////////////////////////////////////

            String str = "Ala ma kota";
            var a = str.WordCounter();
            Console.WriteLine(a);


        }
    }
}
