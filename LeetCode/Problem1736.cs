using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    // Latest Time By Replacing Hidden Digits
    // Easy
    //    You are given a string time in the form of hh:mm, where some of the digits in the string are hidden(represented by ?).

    //The valid times are those inclusively between 00:00 and 23:59.

    //Return the latest valid time you can get from time by replacing the hidden digits.
    public class Problem1736
    {
        public string MaximumTime(string time)
        {
            // single minute always 9
            // tenth minute is always 5

            // single hour is always 9 unless 2
            // tenth hour is always 2 unless single hour is greater than 3

            var latestTime = time;
            if (time[4] == '?')
            {
                latestTime = time.Remove(4);
                latestTime = latestTime + '9';
            }

            if (time[3] == '?')
            {
                latestTime = latestTime.Remove(3, 1);
                latestTime = latestTime.Insert(3, "5");
            }

            if (latestTime[1] == '?')
            {
                if (latestTime[0] < '2' && latestTime[0] != '?')
                {
                    latestTime = latestTime.Remove(1, 1);
                    latestTime = latestTime.Insert(1, "9");
                }
                else
                {
                    latestTime = latestTime.Remove(1, 1);
                    latestTime = latestTime.Insert(1, "3");
                }
            }

            if (latestTime[0] == '?')
            {
                if (latestTime[1] < '4')
                {
                    latestTime = latestTime.Remove(0, 1);
                    latestTime = latestTime.Insert(0, "2");
                }
                else
                {
                    latestTime = latestTime.Remove(0, 1);
                    latestTime = latestTime.Insert(0, "1");
                }
            }

            return latestTime;
        }
    }
}
