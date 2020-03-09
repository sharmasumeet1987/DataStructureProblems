using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    class Problems
    {
        // Print squares till n
        public static int PrintSquares(int n)
        {
            if (n == 1) {
                Console.Write($"{n} ");
                return 1; }
            else
            {
                int prev = PrintSquares(n / 2);
                int curr = 2 * prev;
                Console.Write($"{curr} ");
                return curr;
            }
        }

    }
}
