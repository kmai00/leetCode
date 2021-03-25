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
            var phrase = string.Empty;
            for (var i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    phrase = "Fizz";
                }

                if (i % 5 == 0)
                {
                    phrase += "Buzz";
                }

                // This seems redundant;
                if (string.IsNullOrEmpty(phrase))
                {
                    result.Add(i.ToString());
                }
                else
                {
                    result.Add(phrase);
                }

                phrase = string.Empty;
            }

            return result;
        }
    }
}
