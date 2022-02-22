namespace FizzBuzz
{
    public class Cat : Animal, IStrokable
    {
        public Cat(string name, int age) : base(4, "Meow!", age, name)
        { }
        
        public void Stroke()
        {
            Console.WriteLine("Purr!");
        }
    }
}
