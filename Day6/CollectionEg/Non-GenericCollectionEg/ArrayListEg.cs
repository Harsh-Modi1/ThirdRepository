using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_GenericCollectionEg
{
    //Array list is a Collection of objects having heterogenous information.it grows dynamically (giving size is not required).
    //allows dynamic memory,can hold duplicate elements,Index is zero based,not supported for the multidimensional.
    class ArrayListEg
    {
        static void Main()
        {
            int[] arr = { 90, 60, 89, 10, 34 };
      
            for( int i = 0;i < arr.Length;i++ )
            {
                Console.Write(arr[i]);
                Console.Write(",");

            }

            Console.WriteLine("\n\nAfter Sorting\n");
            Array.Sort(arr);
         //   for (int i = 0; i < arr.Length; i++)
         //foreach(element in iterable-item)
         //var : implicit type variable
         foreach(var item in arr)
            {
                Console.Write(item);
                Console.Write(",");
            }

            Console.WriteLine("\n\n----------------ArrayList----------------");

            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(78.90);
            al.Add("Kalai");
            al.Add(90);
            al.Add("Sasi");

            foreach(var item in al)
            {
                Console.WriteLine("ArrayList : {0} ", item);
            }
            Console.WriteLine("\nCount : {0}", al.Count);  //count will give No of elements in array
            Console.WriteLine("Capacity : {0}", al.Capacity);
            Console.WriteLine("Contains : {0}\n", al.Contains("Lalitha"));
            //Console.Writeline("Contains:{0},al.Reverse()); //When arraylist has homogeneous collection

            al.Remove(78.90);  //to remove any element from array list

            foreach (var item in al)
            {
                Console.WriteLine("ArrayList : {0} ", item);
            }

            Console.Read();
        }
    }
}
