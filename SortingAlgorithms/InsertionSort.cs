using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class InsertionSort
    {
        /// <summary>
        /// Insertion Sort compares the current item with everything to the left of the array until it finds the right position to insert the current element.
        /// In every comparison, if the element is bigger than current, it is copied to the right.
        /// Time Complexity:
        ///     [1] Best Case: Iteration O(n), Shift Item O(1) => O(n)
        ///     [2] Worst Case: Iteration O(n), Shift Item O(n) => O of n square.
        /// </summary>
        /// <param name="array"></param>
        public void SortAsc(int[] array)
        {
            if (array == null || array.Length == 0)
                return;

            for(int i = 1; i < array.Length; i++)
            {
                var current = array[i];
                for(int j = i - 1; j >= 0; j--)
                {
                    if(current < array[j])
                    {
                        array[j + 1] = array[j];
                        array[j] = current;
                    }
                }
            }
        }

        /// <summary>
        /// Mosh's solution uses a while loop instead of a for loop during comparison.
        /// </summary>
        /// <param name="array"></param>
        public void SortAsc2(int[] array)
        {
            if (array == null || array.Length == 0)
                return;

            for (int i = 1; i < array.Length; i++)
            {
                var current = array[i];
                var j = i - 1;
                while(j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = current;
            }
        }

        public void SortDesc(int[] array)
        {
            if (array == null || array.Length == 0)
                return;

            for(int i = 1; i < array.Length; i++)
            {
                var current = array[i];
                var j = i - 1;
                while (j >= 0 && array[j] < current)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = current;
            }
        }
    }
}
