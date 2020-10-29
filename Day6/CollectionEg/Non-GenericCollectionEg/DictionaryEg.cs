using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_GenericCollectionEg
{
    class DictionaryEg
    {
        static void Main()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(8, "A");
            dt.Add(7, "B");
            dt.Add(10, "s");

            Console.WriteLine("Contains : {0}", dt.ContainsKey(7));
            Console.WriteLine("Count : {0}", dt.Count());

            foreach(KeyValuePair<int,string> k in dt)
            {
                Console.WriteLine(k.Key +" "+ k.Value);
            }

            Console.Read();
        }
    }
}
