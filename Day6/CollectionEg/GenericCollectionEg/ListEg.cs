using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionEg
{
    class ListEg
    {
        static void Main()
        {
            List<int> lt = new List<int>();
            lt.Add(10);
            lt.Add(89);
            lt.Add(20);
            // lt.Add("WOW"); error cant add string as Datatype is int

            lt.Sort();
            lt.Reverse();

            foreach (int item in lt)
            {
                Console.WriteLine(item);
            }
//-----------------------------------------------------------------------------------------

            Console.WriteLine("\nRemoving Information at index 1");
            lt.RemoveAt(1);
            foreach (int item in lt)
            {
                Console.WriteLine(item);
            }

            Console.Read();


        }
    }
}
