using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneric
{
    public class MyClass<T> where T : class, IAkademia
    {
        public void getMyType(ref T arg)
        {         
            Console.WriteLine(arg.GetType());
        }
        
    }
}
