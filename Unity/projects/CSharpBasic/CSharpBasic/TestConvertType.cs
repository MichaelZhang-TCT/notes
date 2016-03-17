using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class TestConvertType : Testable
    {
        public void Test()
        {
            // 1. implicitly - from smaller range to larger
            int i = 10;
            long l = i; // from int to long
            float f = i; // from int to float

            SubClass subCls = new SubClass();
            BaseClass baseCls = subCls; // from sub-class to base

            // 2. explicitlyy - from larger range to smaller
            f = 2.05F;
            i = (int)f; // loss something, equivalent to Math.ceil

            // cast exception
            baseCls = new BaseClass();
            try
            {
                subCls = (SubClass)baseCls;
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // safe casting
            baseCls = new SubClass();
            subCls = (SubClass)baseCls;

            // 3. is
            if (baseCls is SubClass)
            {
                subCls = (SubClass)baseCls;
            }
            else
            {
                Console.WriteLine("baseCls is not a SubClass object");
            }

            // 4. as, only work with reference type or nullable type
            baseCls = new BaseClass();
            subCls = baseCls as SubClass;
            if (subCls == null)
            {
                Console.WriteLine("cannot convert baseCls to SubClass");
            }

            // 5. convert method
            string numStr = "2";
            int num = -1;
            try
            {
                num = Convert.ToInt32(numStr);
                num = Int32.Parse(numStr);
                num = int.Parse(numStr);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            numStr = "2f";
            if (Int32.TryParse(numStr, out num))
            {
                Console.WriteLine("try parse successful, num=" + num);
            }
            else
            {
                Console.WriteLine("try parse failed, num=" + num); // default value is 0 if try parse failed
            }

            // 6. boxing, unboxing
            // boxing - from value type to reference type
            // unboxing - from reference type to value type
            int intValue = 100;
            object obj = intValue; // boxing, just implicitly convert, and move the value from stack to heap

            intValue = (int)obj; // unboxing, just explicitly convert, will throw NPE

            // 7. nullable
            int? nullableInt = null; // nullable int, auto boxing and can be null
            Nullable<int> nullableInt2 = null; // equivalent to above method

            Console.WriteLine("nullableInt=" + (nullableInt.HasValue ? nullableInt.Value : -1));
            Console.WriteLine("nullableInt2=" + nullableInt2.GetValueOrDefault());

            // 8. ??
            int int8 = nullableInt ?? 500;
            Console.WriteLine("int8=" + int8);

            string raw = null;
            string str8 = raw ?? "default";
            Console.WriteLine("str8=" + str8);

        }

        class BaseClass
        {
        }

        class SubClass : BaseClass
        {
        }
    }
}
