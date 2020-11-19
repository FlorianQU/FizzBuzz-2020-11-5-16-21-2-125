using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Say(int count)
        {
            string sayContent = string.Empty;

            if (count % 3 == 0)
            {
                sayContent += "Fizz";
            }

            if (count % 5 == 0)
            {
                sayContent += "Buzz";
            }

            if (count % 7 == 0)
            {
                sayContent += "Whizz";
            }

            return sayContent == null ? count.ToString() : sayContent;
        }
    }
}
