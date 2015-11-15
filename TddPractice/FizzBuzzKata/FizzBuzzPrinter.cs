using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    class FizzBuzzPrinter
    {
        public static void Main()
        {
            var fizzBuzz = new FizzBuzz();
            Console.WriteLine("Start Fizz Buzz");
            Console.WriteLine("Printing numbers 1 - 100");
            for(int i =0; i<100; i++)
            {
                var result = fizzBuzz.CheckFizzBuzz(i);
                Console.WriteLine(result);
            }
            Console.WriteLine("Complete");
            Console.ReadKey();
        }
    }
}
