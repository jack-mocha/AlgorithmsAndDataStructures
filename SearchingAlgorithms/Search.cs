using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    public class Search
    {
        public int LinearSearch(int[] array, int target)
        {
            if (array == null)
                return -1;
            if (array.Length == 0)
                return -1;

            for(int i=0; i<array.Length; i++)
            {
                if (array[i] == target)
                    return i;
            }

            return -1;
        }
    }
}
