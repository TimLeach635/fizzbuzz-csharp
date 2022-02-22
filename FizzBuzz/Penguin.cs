namespace FizzBuzz
{
    public class Penguin : Animal, IStrokable
    {
        public Penguin(string name, int age) : base(2, "Squawk!", age, name)
        { }

        public void Stroke()
        {
            Console.WriteLine("Peep!");
        }
    }
}
