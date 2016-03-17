using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class TestBed
    {
        static void Main(string[] args)
        {
            var test = new TestInterface();
            test.Test();
        }
    }
}
