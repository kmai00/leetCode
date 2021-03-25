using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    // 412. Fizz Buzz
    // Easy

    // Write a program that outputs the string representation of numbers from 1 to n.
    // But for multiples of three it should output “Fizz” instead of the number and for the multiples of five output “Buzz”. For numbers which are multiples of both three and five output “FizzBuzz”.

    public class Problem412
    {
        public IList<string> FizzBuzz(int n)
        {
            var result = new List<string>();
            for (var i = 1; i <= n; i++)
            {
                string phrase = i.ToString();

                var isThreeDivisble = i % 3 == 0;
                var isFiveDivisible = i % 5 == 0;

                if (isThreeDivisble)
                {
                    phrase = "Fizz";
                }

                if (isFiveDivisible)
                {
                    phrase = "Buzz";
                }

                if (isFiveDivisible && isThreeDivisble)
                {
                    phrase = "FizzBuzz";
                }

                result.Add(phrase);
            }

            return result;
        }
    }
}
