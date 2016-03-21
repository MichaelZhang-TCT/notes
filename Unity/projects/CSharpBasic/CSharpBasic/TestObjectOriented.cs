using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class TestObjectOriented : Testable
    {
        public void Test()
        {
            #region Encapsulation
            Console.WriteLine("Encapsulation------");
            Encapsulation en = new Encapsulation();
            en.Talk();
            en.Age = 10;
            Console.WriteLine("age=" + en.Age);

            // assembly: physical collections, exe, dll
            // namesapce: logical collections
            #endregion

            #region Inheritance
            Console.WriteLine("Inheritance------");
            Animal animal = new Dog(3);
            animal.Age = 2;
            animal.Bite();
            animal.Jump();
            Dog dog = (Dog)animal;
            dog.Jump();
            #endregion

            #region Polymorphism
            Console.WriteLine("Polymorphism------");
            // 1. static polymorphism: define during compiling : overload
            // overload method can seperate by the count or the type of arguments, not by the return type

            // operator overload
            Complex c1 = new Complex();
            Complex c2 = new Complex();
            c1.Number = 1;
            c2.Number = 2;
            Console.WriteLine("c3=" + (c1 + c2).Number);

            // 2. dynamic polymorphism: define during runtime
            // override
            Animal animal2 = new Dog();
            Animal animal3 = new Cat();
            animal2.Bite();
            animal3.Bite();

            Console.WriteLine("c1 + c2 = " + (c1 + c2));
            #endregion
        }
    }

    //Encapsulation
    class Encapsulation
    {
        // supply by access modifier
        // public, private, protected
        // internal, internal protected: access in same assembly
        // default for class is "internal"
        // default for field and method is "private"

        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value + 10;
            }
        }

        public void Talk()
        {
            SayHello();
        }

        private void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }

    // Inheriance
    class Animal
    {
        public int Age { get; set; }

        public Animal() // constructor
        {
            Console.WriteLine("Animal created");
        }

        public Animal(int age)
        {
            Age = age;
            Console.WriteLine("Animal created with age " + Age);
        }

        ~Animal() // destructor
        {
            Console.WriteLine("Animal destroyed");
        }

        public virtual void Bite() // seek for the override method in subclass
        {
            Console.WriteLine("Animal bite");
        }

        public void Jump()
        {
            Console.WriteLine("Animal jump");
        }

        public virtual void Sit()
        {
            Console.WriteLine("Animal Sit");
        }
    }

    class Dog : Animal // a sealed class cannot be inherit
    {
        public Dog()
        {
            Console.WriteLine("Dog created");
        }

        public Dog(int age) : base(age)
        {
            Console.WriteLine("Dog created with age " + Age);
        }

        public override void Bite()
        {
            Console.WriteLine("Dog bite");
        }

        public new void Jump() // autometically add "new" to such method
        {
            Console.WriteLine("Dog jump");
        }

        public sealed override void Sit() // the sealed method cannot be override, must use with "override"
        {
            //base.Sit();
            Console.WriteLine("Dog sit");
        }
    }

    // Polymorphism
    class Complex
    {
        public int Number { get; set; }

        // overload operator +
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c = new Complex();
            c.Number = c1.Number + c2.Number;

            return c;
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }

    class Cat : Animal
    {
        public override void Bite()
        {
            Console.WriteLine("Cat won't bite");
        }
    }
}
