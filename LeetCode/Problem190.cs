using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Problem190
    {
        // Moding 2 on n is looking at the current bit on the right side
        // As we push reversed more, we can determine to add 1 bit 
        // It's like truncating- looking and then dropping the bit we just evaulate


        // With the string method, I needed to pad the 32 bit or else the signs will get all messed up
        // Or it wouldn't have added correctly
        public uint reverseBits(uint n)
        {
            uint reversed = 0;
            for (int i = 0; i < 32; i++)
            {
                reversed = reversed << 1;
                if (n % 2 == 1)
                    reversed++;
                n = n >> 1;
            }
            return reversed;
        }
    }
}
