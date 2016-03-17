using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class TestInterface : Testable
    {
        public void Test()
        {
            ISuper super = new Impl();
            super.DoSomething();
            Console.WriteLine("--------");

            AbsClass absCls = new Impl();
            absCls.execute();
            Console.WriteLine("--------");

            Impl impl = new Impl();
            impl.execute();
            Console.WriteLine("--------");
            AbsClass absImpl = impl;
            absImpl.execute();
            Console.WriteLine("--------");

            AbsClass impl2 = new Impl();
            impl2.VirtualMethod();

        }
    }

    /// <summary>
    /// 接口需要实现类去实现相应的方法，只是对功能的一个声明
    /// </summary>
    interface ISuper
    {
        void DoSomething();
    }

    /// <summary>
    /// 抽象类存在实现方法，是不完整的类，需要实现类去补充实现方式
    /// </summary>
    abstract class AbsClass
    {
        public void execute()
        {
            Console.WriteLine("Executing...");
            Run();
        }

        protected abstract void Run();

        public void NormalMethod()
        {
            Console.WriteLine("Abs-NormalMethod");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("Abs-VirtualMethod");
        }
    }

    class Impl : AbsClass, ISuper
    {
        public void DoSomething()
        {
            Console.WriteLine("Do sth.");
        }

        protected override void Run()
        {
            Console.WriteLine("Running...");
        }

        public new void NormalMethod() // normal method cannot be override
        {
            Console.WriteLine("Impl-NormalMethod");
        }

        public void VirtualMethod()
        {
            Console.WriteLine("Impl-VirtualMethod");
        }
    }
}
