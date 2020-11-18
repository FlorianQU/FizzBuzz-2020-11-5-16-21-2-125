using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Say(int count)
        {
            if (count == 3)
            {
                return "Fizz";
            }

            if (count == 5)
            {
                return "Buzz";
            }

            if (count == 7)
            {
                return "Whizz";
            }

            return count.ToString();
        }
    }
}
