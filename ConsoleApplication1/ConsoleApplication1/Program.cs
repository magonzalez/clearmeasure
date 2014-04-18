using System;

namespace ConsoleApplication1
{
    using FizzBuzz.Lib;

    class Program
    {
        private const int First = Int32.MinValue;
        private const int Last = Int32.MaxValue;

        static void Main(string[] args)
        {
            var runner = new FizzBuzzRunner();
            runner.AddRule(3, 15, "FizzBuzz");
            runner.AddRule(2, 3, "Fizz");
            runner.AddRule(1, 5, "Buzz");

            RunOneAtATime(runner, 1, 100);
            RunAllAtOnce(runner, First, Last);

            Console.ReadLine();
        }

        private static void RunOneAtATime(FizzBuzzRunner runner, int first, int last)
        {
            for(var i = first; i <= last; i++)
            {
                Console.WriteLine(runner.RunSingleUsingRules(i));
            }
        }

        private static void RunAllAtOnce(FizzBuzzRunner runner, int first, int last)
        {
            var results = runner.RunUsingRules(first, last);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
