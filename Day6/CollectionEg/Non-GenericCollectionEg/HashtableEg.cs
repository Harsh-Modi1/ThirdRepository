using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_GenericCollectionEg
{
    //accepts information as key value pair
    //Not sorted in an order
    class HashtableEg
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Monday");
            ht.Add(3, "Wednesday");
            ht.Add(4, "Thursday");
            ht.Add("f", "Friday");
            ht.Add("fri", "Friday");

            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+ " "+d.Value);
            }
            Console.WriteLine("-------------Sorted List-------------");
            // sorted list will arrange order in ascending order

            SortedList st = new SortedList();
            st.Add(1, "Monday");
            st.Add(3, "Wednesday");
            st.Add(4, "Thursday");

            // for other datatype v need to created other sorted list
            SortedList st1 = new SortedList();
            st1.Add("b", "Bala");
            st1.Add("a", "anu");

            foreach (DictionaryEntry di in st)
            {
                Console.WriteLine(di.Key + " " + di.Value);
            }

            Console.Read();

        }
    }
}
