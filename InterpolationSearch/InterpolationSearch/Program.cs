using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolationSearch
{
    class Program
    {
        public static int IntpSearch(int[] arr, int n, int x)
        {
            int lo = 0;
            int hi = n - 1;
            double pos = 0.0;
            while (lo <= hi && x >= arr[lo] && x <= arr[hi])
            {
                pos = lo + (Convert.ToDouble((hi - lo) / (arr[hi] - arr[lo]) * (x - arr[lo])));

                if (arr[Convert.ToInt16(pos)] == x)
                    return Convert.ToInt16(pos);
                else if (arr[Convert.ToInt16(pos)] < x)
                    lo = Convert.ToInt16(pos) + 1;
                else
                    hi = Convert.ToInt16(pos) - 1;
            }
            return Convert.ToInt16(pos);
        }
        public static int interpolationSearch(int[] arr, int n, int x)
        {
            // Find indexes of two corners
            int lo = 0, hi = (n - 1);

            // Since array is sorted, an element present
            // in array must be in range defined by corner
            while (lo <= hi && x >= arr[lo] && x <= arr[hi])
            {
                // Probing the position with keeping
                // uniform distribution in mind.
                double pos = lo + (((double)(hi - lo) /
                      (arr[hi] - arr[lo])) * (x - arr[lo]));

                // Condition of target found
                if (arr[Convert.ToInt16(pos)] == x)
                    return Convert.ToInt16(pos);

                // If x is larger, x is in upper part
                if (arr[Convert.ToInt16(pos)] < x)
                    lo = Convert.ToInt16(pos) + 1;

                // If x is smaller, x is in lower part
                else
                    hi = Convert.ToInt16(pos) - 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5,25,30,35,40,45 };
            int x = 40;
            int res = IntpSearch(arr, arr.Length, x);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
