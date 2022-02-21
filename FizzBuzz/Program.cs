using System;
using FizzBuzz.Rules;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var rules = new List<IRule>()
            {
                new ThreeRule(),
                new FiveRule(),
                new SevenRule(),
            };

            var fizzBuzzer = new FizzBuzzer(rules);

            for (int i = 1; i <= 110; i++)
            {
                Console.WriteLine(fizzBuzzer.FizzBuzz(i));
            }
        }
    }
}
