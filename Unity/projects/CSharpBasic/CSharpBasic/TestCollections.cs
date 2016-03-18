using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class TestCollections : Testable
    {
        public void Test()
        {
            #region System.Array, basic class of array
            int[] intArray = new int[5]{ 1, 2, 3, 4, 5};

            System.Array arr = intArray;

            foreach (var ele in arr)
            {
                Console.WriteLine("ele=" + ele);
            }
            #endregion

            #region initialize Array
            // array
            int[] a1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] a2= new int[] { 1, 2, 3, 4, 5 };
            int[] a3= { 1, 2, 3, 4, 5 };

            // 2d array
            int[,] b1= new int[2, 3]
            {
                { 1, 1, 1 },
                { 2, 2, 2 } 
            };
            int[,] b2= new int[,] 
            {
                { 1, 1, 1 },
                { 2, 2, 2 } 
            };
            int[,] b3= 
            {
                { 1, 1, 1 },
                { 2, 2, 2 } 
            };
            int[,] b4= new int[2, 3]; // allocate a space but all value is default 0

            // jagged array
            int[][] c1= new int[2][]
            { 
                new int[] { 1, 1 },
                new int[] { 2, 2, 2 }
            };
            int[][] c2= new int[][] 
            {
                new int[] { 1, 1 },
                new int[] { 2, 2, 2 }
            };
            int[][] c3 =
            {
                new int[] { 1, 1 },
                new int[] { 2, 2, 2 }
            };
            int[][] c4 = new int[2][];

            // mix
            int[][,] d1 = new int[2][,]
            {
                new int[2, 3]
                {
                    { 1, 1 , 1 },
                    { 2, 2, 2 }
                },
                new int[3, 4]
            };
            #endregion

            #region ArrayList
            ArrayList arrayList = new ArrayList();// store element as object and store the references, not recommeded
            arrayList.Add(0);
            arrayList.Add("str");
            arrayList.Add(false);
            Console.WriteLine("arrayList[0]=" + arrayList[0]);
            Console.WriteLine("arrayList[1]=" + arrayList[1]);
            Console.WriteLine("arrayList[2]=" + arrayList[2]);
            #endregion

            #region List<>
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.AddRange(new int[] { 2, 3 });
            list.Remove(3);
            list.Insert(2, 8);
            foreach (int item in list)
            {
                Console.WriteLine("item=" + item);
            }
            #endregion

            #region HashTable
            Hashtable ht = new Hashtable();
            ht.Add("key1", 1);
            ht.Add("key2", "str");
            Console.WriteLine("value of key1=" + ht["key1"]);
            Console.WriteLine("value of key3=" + ht["key3"]); // return null if key not exist
            #endregion

            #region Dictionary
            // thread un-safe, use ConcurrentDictionary instead 
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("key1", 0);
            dict.Add("key2", 1);
            Console.WriteLine("value of key1=" + dict["key1"]);
            try
            {
                Console.WriteLine("value of key3=" + dict["key3"]); // throws exception if key not exist
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion

            #region SortedList
            SortedList<int, int> st = new SortedList<int, int>();
            st.Add(4, 1);
            st.Add(2, 2);
            //st.Add(4, 3); // thows exception if key exist
            st.Add(5, 4);
            foreach (var item in st)
            {
                Console.WriteLine("item=" + item);
            }
            #endregion

            // stack, queue
        }
    }
}
