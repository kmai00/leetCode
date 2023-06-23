using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace LeetCode
{
    // Given an array of nums and a postive k
    // Return whether it's possible to divide this array into sets of k consecutive numbers
    public class Problem1296
    {
        public bool IsPossibleDivide(int[] nums, int k)
        {
            if (nums.Length % k != 0)
            {
                return false;
            }

            var buckets = new List<Bucket>();
            var bucketAmount = nums.Length / k;

            for (var i = 0; i < bucketAmount; i++)
            {
                buckets.Add(new Bucket { RemainingSpot = k });
            }

            Array.Sort(nums);
            var bucketIndex = 0;
            var numberNeededDict = new Dictionary<int, int>(); // value, bucketIndex
            var numberIndex = 0;
            while (true)
            {
                if (numberIndex >= nums.Length)
                {
                    break;
                }
                var num = nums[numberIndex];

                if (bucketIndex >= buckets.Count) {
                    return false;
                }

                if (numberNeededDict.ContainsKey(num))
                {
                    bucketIndex = numberNeededDict[num];
                    numberNeededDict.Remove(num);
                }

                var currentBucket = buckets[bucketIndex];




                // If it's -1 or the same number, then we want to add to the current bucket
                if (currentBucket.NextNumber == null || currentBucket.NextNumber == num)
                {
                    // "Add it to bucket"
                    currentBucket.NextNumber = num + 1;
                    currentBucket.RemainingSpot--;

                    // Skip buckets that are full
                    if (currentBucket.RemainingSpot == 0)
                    {
                        buckets.Remove(currentBucket);
                        bucketIndex = 0;
                        if (buckets.Count == 0)
                        {
                            return true;
                        }
                        currentBucket = buckets[bucketIndex];
                    }

                    numberIndex++;

                    if (currentBucket.NextNumber.HasValue && !numberNeededDict.ContainsKey(currentBucket.NextNumber.Value))
                    {
                        numberNeededDict.Add(currentBucket.NextNumber.Value, bucketIndex);
                    }
                }
                else
                {
                    bucketIndex++;
                }

            }

            return !buckets.Any();

        }
    }

    public class Bucket
    {
        public int? NextNumber;
        public int RemainingSpot;
    }
}
