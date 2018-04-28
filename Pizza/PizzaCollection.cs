using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class PizzaCollection<Pizza>
    {
        private Pizza[] _arr = new Pizza[100];

        public Pizza this[int i]
        {
            get
            {
                if (i > _arr.Length)
                {
                    Console.WriteLine("There's not enough pizza!");
                    return _arr[0];
                }
                return _arr[i];
            }
            set
            {
                _arr[i] = value;
            }
        }
    }
}
