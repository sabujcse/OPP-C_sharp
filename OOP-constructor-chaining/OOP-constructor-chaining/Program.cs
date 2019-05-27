using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_constructor_chaining
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mr. Sabuj", "Kumar", "Sarker");
            Console.WriteLine(person.Fullname());
            Console.ReadKey();
        }
    }
}
