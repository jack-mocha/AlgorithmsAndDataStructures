using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BubbleSort
    {
        /// <summary>
        /// Every iteration, we bring the next biggest item to the correct position. (to the right end)
        /// 
        /// Time Complexity:
        ///     Best Case: O(1) pass * O(n) comparison = O(n)
        ///     Worst Case: O(n) pass * O(n) comparison = O of n square
        ///     
        /// Without optimization, it is always O of n square.
        /// </summary>
        /// <param name="array"></param>
        public void SortAsc(int[] array)
        {
            if (array == null)
                return;

            var isSorted = true; //Optimization1: if the array is already sorted, we don't need to compare elements anymore.

            for(int i = 0; i < array.Length; i++) //array.Length of iterations
            {
                isSorted = true;
                for(int j = 1; j < array.Length - i; j++) //Optimization2: We don't need to compare those which are already sorted.
                {
                    if (array[j] < array[j - 1])
                    {
                        Swap(array, j, j - 1);
                        isSorted = false;
                    }
                }

                if (isSorted)
                    return;
            }
        }

        public void SortDesc(int[] array)
        {
            if (array == null)
                return;

            var isSorted = true; //Optimization1: if the array is already sorted, we don't need to compare elements anymore.

            for (int i = 0; i < array.Length; i++)
            {
                isSorted = true;
                for (int j = 1; j < array.Length - i; j++) //Optimization2: We don't need to compare those which are already sorted.
                {
                    if (array[j] > array[j - 1])
                    {
                        Swap(array, j, j - 1);
                        isSorted = false;
                    }
                }

                if (isSorted)
                    return;
            }
        }

        private void Swap(int[] array, int idx1, int idx2)
        {
            var temp = array[idx1];
            array[idx1] = array[idx2];
            array[idx2] = temp;
        }
    }
}
