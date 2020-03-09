using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class QuickSort
    {
        /// <summary>
        /// Quick Sort first set a pivot and based on the pivot partition left and right. 
        /// Everything left is smaller than the pivot. Everything right is bigger than the pivot. 
        /// The order of the item in the partition does not matter.
        /// This implementation set the pivot at the end of the 
        /// Because space complexity is better than Merge Sort, Quick Sort is used more often.
        /// Time Complexity:
        ///     [1] Best Case: Partitioning O(n) # of times O of log of n => O(nlogn).
        ///     [2] Worst Case: Partitioning O(n) # of times O(n) e.g. when the array is already sorted. => O of n square.
        ///     To reduce the likelyhood of worst case, you can use the following to pick the pivot.
        ///         [1]Pick randomly
        ///         [2]Use the middle index
        ///         [3]Average of first, middle, and last item
        /// Space Complexity:
        ///     Quick Sort does not require additional space to store the array. it is in line.
        ///     [1] Best Case: O(log) (recursion => memory on stack)
        ///     [2] Worst Case: O(n) (recursion => memory on stack)
        /// </summary>
        /// <param name="array"></param>
        public void SortAsc(int[] array)
        {
            if (array == null)
                return;

            SortAsc(array, 0, array.Length - 1);
        }

        private void SortAsc(int[] array, int start, int end)
        {
            //Base Case
            if (start >= end) //1 element, or no element in the partition.
                return;

            //Partition
            var boundary = PartitionAsc(array, start, end);

            //Sort Left
            SortAsc(array, start, boundary - 1);
            //Sort Right
            SortAsc(array, boundary + 1, end);
        }

        private int PartitionAsc(int[] array, int start, int end)
        {
            var pivot = array[end]; 
            var boundary = start - 1; //boundary is the index of the last element of the partition that is smaller than pivot
            for (int i = start; i <= end; i++)
            {
                if (array[i] <= pivot)
                    Swap(array, i, ++boundary);
            }

            return boundary;
        }

        private void Swap(int[] array, int idx1, int idx2)
        {
            var temp = array[idx1];
            array[idx1] = array[idx2];
            array[idx2] = temp;
        }
    }
}
