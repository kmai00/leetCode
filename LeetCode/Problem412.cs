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
            var threeTracker = 0;
            var fiveTracker = 0;
            var phrase = string.Empty;
            for (var i = 1; i <= n; i++)
            {
                threeTracker++;
                fiveTracker++;

                var isThree = threeTracker == 3;
                var isFive = fiveTracker == 5;

                if (isThree)
                {
                    phrase = "Fizz";
                    threeTracker = 0;
                }

                if (isFive)
                {
                    phrase = "Buzz";
                    fiveTracker = 0;
                }

                if (isThree && isFive)
                {
                    phrase = "FizzBuzz";
                    threeTracker = 0;
                    fiveTracker = 0;
                }


                if (phrase.Length == 0)
                {
                    phrase = i.ToString();
                }


                result.Add(phrase);
                phrase = string.Empty;
            }

            return result;
        }
    }
}
