using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(); //Object Create
            //propertity initalization using object
            person.FirstName = "Dipto";  
            person.MiddleName = "Kumar";
            person.Lastname = "Saha";
            Console.WriteLine(person.GetFullName());
            Console.ReadKey();

        }
    }
}
