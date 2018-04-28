using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    //deklaracja delegaty
    public delegate void MathCalculation<T>(T x, T y);
    class Program
    {
        static void Main(string[] args)
        {
            //var m = new Math();

            //wskazanie dla delegaty do uzywania danej funkcji( metody )
            var delPointer = new MathCalculation<int>(Math.Add);

            //uruchomienie delegaty (zawolanie)
            delPointer(5, 4);

            //zarejestruj metode do delegaty
            delPointer += Math.Multiply;

            delPointer(6, 6); //lub delPointer.Invoke(6,6);
            delPointer.Invoke(1, 1);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lambdy:");
            Console.WriteLine();

            // LAMBDY

            //FUNC(delegacje)
            //podpiecie delegacji od FUNC do metody z klasy Math
            //to co bedzie jako ostatni arg to bedzie zwracane 
            Func<int, int, int> fnc = Math.AddWithResult;
            var tResult = fnc(3,3);
            Console.WriteLine($"Func<int,int,int> TResult: {tResult}");
            Console.WriteLine();

            //podpiecie delegata action pod funkcje 
            Action<string> act = System.Console.WriteLine;
            act("Hello world");

            Predicate<string> pdc = String.IsNullOrEmpty;
            Console.WriteLine(pdc(""));
        }
    }
}
