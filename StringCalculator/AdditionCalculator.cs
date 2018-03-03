using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class AdditionCalculator
    {
        public int AddNumbers(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var integers = ConvertToNumber(numbers);
            //I want the sum of integers + 0
            var sum = SumOfNumbers(integers, integers);
            //I want the sum of 2 integers
            return sum;
        }

        public int ConvertToNumber(string number)
        {
            return int.Parse(number);
        }

        public int SumOfNumbers(int a, int b)
        {
            int total;
            total = a + b;
            return total;
        }
    }
}
