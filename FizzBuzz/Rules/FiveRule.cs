namespace FizzBuzz.Rules
{
    public class FiveRule : IRule
    {
        public List<string> Apply(List<string> previous, int number)
        {
            if (number % 5 != 0)
            {
                return previous;
            }

            var output = new List<string>(previous);
            output.Add("Buzz");
            return output;
        }
    }
}
