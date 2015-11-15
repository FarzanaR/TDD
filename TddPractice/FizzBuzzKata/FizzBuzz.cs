namespace FizzBuzzKata
{
    public class FizzBuzz
    {

        public string CheckFizzBuzz(int num)
        {
            if (IsMultipleOfFive(num) && IsMultipleOfThree(num))
            {
                return "FizzBuzz";
            }
            else if (IsMultipleOfFive(num))
            {
                return "Buzz";
            }
            else if (IsMultipleOfThree(num))
            {
                return "Fizz";
            }
            return num.ToString();
        }

        private static bool IsMultipleOfThree(int num)
        {
            return num % 3 == 0;
        }

        private static bool IsMultipleOfFive(int num)
        {
            return num % 5 == 0;
        }
    }
}
