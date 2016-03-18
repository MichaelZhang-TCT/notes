using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class TestLogic : Testable
    {
        public void Test()
        {
            #region foreach
            List<int> list = new List<int>() { 1, 2, 3, 4 };
            foreach (int num in list) // list must implement IEnumerable
            {
                Console.WriteLine("num:" + num);
            }
            #endregion
        }
    }
}
