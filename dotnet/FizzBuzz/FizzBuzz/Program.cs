using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var numbers = ExtractNumbers(args);
                PrintNumbers(numbers);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static IEnumerable<int> ExtractNumbers(string[] args)
        {
            var results = new List<int>();
            var failures = new List<string>();
            int value;

            foreach (var arg in args)
            {
                if (int.TryParse(arg, out value))
                    results.Add(value);
                else
                    failures.Add(arg);
            }

            if (failures.Count > 0)
                throw new ApplicationException("Invalid arguments, please supply valid integers: " + string.Join(", ", failures));

            return results;
        }

        private static string ParseNumber(int number)
        {
            if (IsFizzBuzz(number))
                return "FizzBuzz";
            else if (IsFizz(number))
                return "Fizz";
            else if (IsBuzz(number))
                return "Buzz";
            else
                return number.ToString();
        }

        private static bool IsFizzBuzz(int number)
        {
            return IsFizz(number) && IsBuzz(number);
        }

        private static bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        private static bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }
        
        private static void PrintNumbers(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine("{0}: {1}", number, ParseNumber(number));
            }
        }
    }
}


