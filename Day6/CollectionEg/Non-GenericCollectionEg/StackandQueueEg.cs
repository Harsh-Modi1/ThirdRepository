using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_GenericCollectionEg
{
    class StackandQueueEg
    {
        static void Main()
        {


            Console.WriteLine("-------------------------Stack-----------------------");

            Stack s = new Stack();
            s.Push("Java");
            s.Push(10);
            s.Push("dbms");
            s.Push(20.89);

            foreach(object item in s)
            {
                Console.WriteLine(item);
            }
            //----------------------------------------------------------------------

            Console.WriteLine("-------------------------Pop-----------------------");
            s.Pop();                       //push the element out of the stack or delete element from the stack
            Console.WriteLine("\nPopped 1 time\n");    //it will remove the last value 
            foreach (object item in s)
            {
                Console.WriteLine(item);
            }

            //--------------------------------------------------------------------------

            Console.WriteLine("-------------------------Peek-----------------------");

            Console.WriteLine("\nPeek : {0}",s.Peek()); // Shows current top element of the stack
            foreach (object item in s)
            {
                Console.WriteLine(item);
            }

            //------------------------------------------------------------------------

            Console.WriteLine("-------------------------Queue-----------------------");

            Queue q = new Queue();
            q.Enqueue("Hari");
            q.Enqueue("Jai");
            q.Enqueue("Shivam");

            foreach (object item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nRemove the element : {0}\n", q.Dequeue());

            foreach (object item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Top element in queuee : {0}", q.Peek());
            Console.Read();

        }
    }
}
