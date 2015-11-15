namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string CheckForFizz(int num)
        {
            if (IsMultipleOfThree(num))
            {
                return "Fizz";
            }
            return num.ToString();
        }

        private static bool IsMultipleOfThree(int num)
        {
            return num % 3 == 0;
        }

        public string CheckForBuzz(int num)
        {
            if (num == 1)
            {
                return "1";
            }
            return "Buzz";
        }
    }
}
