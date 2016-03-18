using System;

namespace CSharpBasic
{
    class TestValueType : Testable
    {
        public void Test()
        {
            // Hello world
            Console.WriteLine("Hello world");
            /* 数据类型：
             * 1. 值类型
             *      * 在栈上直接存储值
             *      * bool, byte, char, int, long, short, float, double, enum, struct
             * 2. 引用类型
             *      * 在栈上存储引用，在堆上存储值
             */

            // int
            int i = 2;
            int i2 = new int();
            System.Int32 integer32 = i;
            ValueType valueType = i2;
            Console.WriteLine("int:" + valueType);

            // bool
            bool b = true;
            System.Boolean boolean = b;
            ValueType valueTypeBoolean = boolean;
            Console.WriteLine("bool:" + valueTypeBoolean);

            // struct
            Person person;
            person.name = "Ethan";
            Console.WriteLine("Name:" + person.name);

            Car car = new Car();
            car.name = "EcoSport";
            Console.WriteLine("Car Name:" + car.name);
        }

        /// <summary>
        ///  struct
        /// </summary>
        struct Person
        {
            public int age;
            public string name;
            public string lastName;
            public string firstName;
        }

        /// <summary>
        /// enum
        /// </summary>
        enum Day
        {
            Sunday = 0,
            Monday, 
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        struct AccessModifier
        {
            public string pub;
            private string priv;
            //protected string prot;
            internal string inter; // friendly, access int namespace
        }

        class Car
        {
            public string name;
            public int speed;

            public Car()
            {
                Console.WriteLine("Creating Car");
            }

            ~Car()
            {
                Console.WriteLine("Destroying Car");
            }
        }
    }
}
