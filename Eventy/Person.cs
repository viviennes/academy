using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventyWinForms
{
    public delegate string MyWelcomeDelegate(string str);

    class Person
    {
        public event MyWelcomeDelegate myEvent;
        public Person()
        {
            this.myEvent += new MyWelcomeDelegate(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return String.Format($"Hello {username}");
        }

        static void Main(string[] args)
        {
            Person obj1 = new Person();

            Console.WriteLine(obj1.myEvent("World!"));
        }

    }
}
