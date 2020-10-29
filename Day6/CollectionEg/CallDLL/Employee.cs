using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NormalCalculator;

namespace CallDLL
{
    class Employee
    {
        class Employee
        {
            public int Eid { get; set; }
            public float salary { get; set; }



            static void Main()
            {
                //call the dll
                TaxCalculation taxCalculation = new TaxCalculation();
                taxCalculation.CalculateTax(900000.00f);
                Console.Read();



            }

}
