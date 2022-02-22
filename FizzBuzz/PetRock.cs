namespace FizzBuzz
{
    public class PetRock : IStrokable
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public PetRock(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public void Stroke()
        {
            Console.WriteLine("You have stroked the rock. It remains silent.");
        }
    }
}
