namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string FizzBuzz(int number)
        {
            string output = "";

            if (number % 3 == 0)
            {
                output += "Fizz";
            }

            if (number % 5 == 0)
            {
                output += "Buzz";
            }

            if (output == "")
            {
                return number.ToString();
            }

            return output;
        }
    }
}
