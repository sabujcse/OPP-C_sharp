using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_constructor_chaining
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private int loyalityPoint;
        //Constructor-Chaining Example ::: 
        public Person()
        {
            loyalityPoint = 10;
        }
        public Person(string firstName, string lastName):this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Person(string firstName, string middleName, string lastName) : this( firstName,lastName)
        {
            this.middleName = middleName;
        }
        public string Fullname()
        {
            return firstName + " " + middleName + " " + lastName+" "+"LoyalityPoint: "+loyalityPoint;
        }

    }
}
