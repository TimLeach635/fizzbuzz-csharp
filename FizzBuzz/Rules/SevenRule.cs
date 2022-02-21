namespace FizzBuzz.Rules
{
    public class SevenRule : IRule
    {
        public List<string> Apply(List<string> previous, int number)
        {
            if (number % 7 != 0)
            {
                return previous;
            }

            var output = new List<string>(previous);
            output.Add("Bang");
            return output;
        }
    }
}
