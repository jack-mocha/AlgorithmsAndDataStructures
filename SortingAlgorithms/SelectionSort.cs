using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class SelectionSort
    {
        /// <summary>
        /// Selection Sort finds the smallext element in each pass and put it in the right position.(to the left end)
        /// The direction is the opposite of Bubble Sort.
        /// Time Complexity:
        ///     [1] Best Case: O(n) pass, O(n) comparison
        ///     [2] Worst Case: O(n) pass, O(n) comparison
        /// </summary>
        /// <param name="array"></param>
        public void SortAsc(int[] array)
        {
            if (array == null || array.Length == 0)
                return;

            for(int i = 0; i < array.Length; i++)
            {
                var minIdx = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIdx])
                        minIdx = j;
                }

                Swap(array, i, minIdx);
            }
        }

        public void SortDesc(int[] array)
        {
            if (array == null || array.Length == 0)
                return;

            for(int i=0; i<array.Length; i++)
            {
                var maxIdx = i;
                for(int j=i+1; j<array.Length; j++)
                {
                    if (array[j] > array[maxIdx])
                        maxIdx = j;
                }

                Swap(array, i, maxIdx);
            }
        }

        private void Swap(int[] array, int idx1, int idx2)
        {
            var temp = array[idx2];
            array[idx2] = array[idx1];
            array[idx1] = temp;
        }
    }
}
