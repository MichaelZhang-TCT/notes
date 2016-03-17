using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class TestClass : Testable
    {
        public void Test()
        {
            // object
            Person person = new Person(21);

            // public method
            Console.WriteLine("age=" + person.GetAge());
            person.GrowUp();
            Console.WriteLine("age=" + person.GetAge());

            // static method
            Person.SayHello();

            // property
            person.Name = "Jack";
            Console.WriteLine("Name=" + person.Name);

            person.gender = "male";
            Console.WriteLine("Gender=" + person.gender);

            person.National = "China";
            Console.WriteLine("National=" + person.National);
        }
    }

    class Person // default access modifier is "internal" which can access in namespace
    {
        // field
        int mAge; // default access modifier of field and method is "private" which can only access in this Class

        // property
        public string Name { get; set; }

        public string gender;

        private string national;
        public string National
        {
            get
            {
                return national + "CON";
            }

            set
            {
                national = value + "_";
            }
        }

        // default constructor
        public Person()
        {
        }

        // custom constructor
        public Person(int age)
        {
            mAge = age;
        }

        // method
        public int GetAge()
        {
            return mAge;
        }

        public void GrowUp()
        {
            Console.WriteLine("Grow up");
            mAge++;
        }

        // static method
        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
