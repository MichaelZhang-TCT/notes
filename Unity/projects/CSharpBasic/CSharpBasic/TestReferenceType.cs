using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class TestReferenceType : Testable
    {
        public void Test()
        {
            /* Reference Type: Store reference in stack, store value in heap
             * * object(System.Object)
             * * string(System.String)
             * * dynamic(System.Dynamic) check type in runtime
             */

            // 1. object
            object obj = new object();
            System.Object obj2 = new System.Object();
            Console.WriteLine("obj is a " + obj.GetType());
            Console.WriteLine("obj2.ToString=" + obj.ToString()); // ToString method of System.Object only returns the type

            int integer = 5;
            Console.WriteLine("int.ToString=" + integer.ToString()); // Int32 override the ToString method to return it's value

            // 2. string
            string fullName = "Ethan Ye";
            Console.WriteLine("Name: " + fullName);

            // combo
            string firstName = "Ethan";
            string lastName = "Ye";
            string comboName = firstName + " " + lastName;
            Console.WriteLine("Name: " + comboName);

            // ==
            if (fullName == comboName) // use == to compare two strings, String overrode '==' operator
            {
                Console.WriteLine("Correct name");
            }
            else
            {
                Console.WriteLine("Wrong name");
            }

            // string to char
            char char2 = fullName[2];
            Console.WriteLine("char2=" + char2);

            // unicode
            string splash = "\\"; // \
            string f = "\u0066"; // f
            string lf = "\n";
            Console.WriteLine("unicode=" + splash + ", " + f + ", " + lf);

            // @
            string noAtStr = "\u0085";
            string atStr = @"\u0085";
            Console.WriteLine("noAtStr=" + noAtStr + ", " + atStr);

            // contains
            if (fullName.Contains("n"))
            {
                Console.WriteLine(fullName + @" contains 'n'");
            }

            // length
            Console.WriteLine("Length of " + fullName + "=" + fullName.Length);

            // index of
            Console.WriteLine(@"first index of 'e' is " + (fullName + "efe").IndexOf("e"));
            Console.WriteLine(@"index of 'b' is " + fullName.IndexOf('b'));

            // StringBuilder
            StringBuilder builder = new StringBuilder("StringBuilder");
            builder.Append(" ").Append("bbe");
            builder.AppendFormat(", name={0}", fullName);
            Console.WriteLine("builder=" + builder.ToString());

            // format
            string formatStr = "formatStr={0}";
            Console.WriteLine(string.Format(formatStr, "str"));
        }
    }
}
