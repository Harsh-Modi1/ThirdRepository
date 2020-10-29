using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeofClasses
{
    class Rules
    {

    }
    sealed class Banking:Rules
    {
        string Revenue;
        void Display()
        {
            Console.WriteLine("Banking Personal information");

        }
    }
   /* class SealedEg:Banking
    {
        
    }*/
    class MainApp
    {
        static void Main()
        {
            Banking b = new Banking();
            b.Display();
            Console.WriteLine();
        }
    }
}
