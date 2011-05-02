using System.Text;
using FizzBuzz.Objects;

namespace FizzBuzzKata
{
    public class FizzBuzzer : IFizzBuzzer
    {
        public string Get(int i)
        {
            var toReturn = i.ToString();

            var fizz = IsFizz(i);
            var buzz = IsBuzz(i);

            if (fizz || buzz)
                toReturn = GetFizzBuzzString(fizz, buzz);
            return toReturn;
        }

        private string GetFizzBuzzString(bool fizz, bool buzz)
        {
            //var sb = new StringBuilder();
            //if (fizz)
            //    sb.Append("Fizz");
            //if (buzz)
            //    sb.Append("Buzz");
            //return sb.ToString();

            if (fizz && buzz)
                return "FizzBuzz";


            if (fizz)
                return "Fizz";

            if (buzz)
                return "Buzz";

            return string.Empty;



        }

        private bool IsBuzz(int i)
        {
            return IsRestLessDividable(i, 5);
        }

        private bool IsFizz(int i)
        {
            return IsRestLessDividable(i, 3);
        }


        private bool IsRestLessDividable(int number, int modulo)
        {
            return number % modulo == 0;
        }

    }
}
