namespace FizzBuzz
{
    public class Dog : Animal, IStrokable
    {
        public Dog(string name, int age) : base(4, "Woof!", age, name)
        {
            Dog.LatinName = "canis lupus domesticus";
        }

        public void Stroke()
        {
            Console.WriteLine("Happy woof!");
            Console.WriteLine(Age);
        }

        public string StrokeNoise()
        {
            return "Happy woof!";
        }

        public void GiveTreat(string treat)
        {
            if (treat == "Dog biscuit")
            {
                Console.WriteLine("Yum!");
            }
            else
            {
                Console.WriteLine("Yuck!");
            }
        }

        public static string GetDogNoise()
        {
            return "Woof";
        }
    }
}
