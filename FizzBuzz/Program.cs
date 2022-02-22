using System;
using FizzBuzz.Rules;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<IStrokable> petShop = new List<IStrokable>
            {
                new Dog("Benji", 2),
                new Dog("Winston", 3),
                new Cat("Wendy", 10),
                new Dog("Rover", 12),
                new Penguin("Salvador", 6),
                new PetRock("Rocky", 15000000),
            };

            List<Animal> animals = new List<Animal>
            {
                new Dog("Benji", 2),
                new Dog("Winston", 3),
                new Cat("Wendy", 10),
                new Dog("Rover", 12),
                new Penguin("Salvador", 6),
                new Chicken("Buck", 5),
            };

            Console.WriteLine(Dog.GetDogNoise());

            foreach(IStrokable pet in petShop)
            {
                // pet.Stroke();
            }

            foreach(Animal animal in animals)
            {
                // animal.MakeNoise();
            }

            List<IApplyable> rules = new List<IApplyable>()
            {
                new DivisibleRule(3, "Fizz"),
                new DivisibleRule(5, "Buzz"),
                new DivisibleRule(7, "Bang"),
                new OverwriteRule(11, "Bong"),
                new ReverseRule(17),
            };

            FizzBuzzer daniel = new FizzBuzzer(rules);

            for (int i = 1; i <= 110; i++)
            {
                // Console.WriteLine(daniel.FizzBuzz(i));
            }
        }
    }
}
