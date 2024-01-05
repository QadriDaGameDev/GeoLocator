using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMapform
{
    internal class InterpolationSearch
    {
        static int InterpolationSearchAlgorithm(int[] sortedArray, int target)
        {
            int low = 0;
            int high = sortedArray.Length - 1;

            while (low <= high && target >= sortedArray[low] && target <= sortedArray[high])
            {
                if (low == high)
                {
                    if (sortedArray[low] == target)
                        return low;
                    return -1;
                }

                int pos = low + (((high - low) /
                    (sortedArray[high] - sortedArray[low])) * (target - sortedArray[low]));

                if (sortedArray[pos] == target)
                    return pos;

                if (sortedArray[pos] < target)
                    low = pos + 1;
                else
                    high = pos - 1;
            }
            return -1;
        }

    }
}