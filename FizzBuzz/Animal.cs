namespace FizzBuzz
{
    public class Animal
    {
        public int NumberOfLegs { get; }
        public string Noise { get; }
        private int _age;
        public int Age {
            get
            {
                return _age;
            }

            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("age", "Age must be non-negative");
                }
            }
        }
        public string Name { get; set; }

        public static string LatinName { get; set; }

        public Animal(int numberOfLegs, string noise, int age, string name)
        {
            NumberOfLegs = numberOfLegs;
            Noise = noise;
            Age = age;
            Name = name;
        }

        public void MakeNoise()
        {
            Console.WriteLine(Noise);
            Console.WriteLine(Age);
        }
    }
}
