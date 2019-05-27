using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class_Object
{
    class Person
    {
        //Class Design 
        //propertity/data/attribute
        private string firstName;
        private string middleName;
        private string lastname;

        //Resposibility/usability/activity
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string MiddleName
        {
            get { return middleName; }
            set {
                if (value.Length <3)
                {
                    middleName = FirstName; // controlling the field use property
                                            // Field Private . but controling field using property . 

                }
                else
                {
                    middleName = value;
                }
                
            }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + Lastname;
        }
    }
}
