using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSumOfEvenNumLessFourMillion
{
    class Program
    {
        static void Main(string[] args)
        {

            int intTotal = 0;
            int intSequence = 1;
            int intAdder = 1;

            while(intSequence < 4000000)
            {
                intSequence = intSequence + intAdder;
                intAdder = intSequence - intAdder;

                //check if number is even
                if (intSequence % 2 == 0)
                    intTotal = intTotal + intSequence;
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("====>>>>>>>> Fibonacci Sum Of Even Numbers Less than Four Million: " + intTotal);
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
