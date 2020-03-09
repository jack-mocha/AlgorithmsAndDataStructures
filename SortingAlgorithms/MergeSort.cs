using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class MergeSort
    {
        /// <summary>
        /// The real sorting actually happens at the merging stage.
        /// Time Complexity: (Recursively divide the problem into half is O of logarithmic time)
        ///     [1] Best Case: Dividing O of log n, Merging O of n => O of n log n.
        ///     [2] Worst Case: Dividing O of log n, Merging O of n => O of n log n.
        /// Space Complexity:
        ///     O of n.
        /// </summary>
        /// <param name="array"></param>
        public void SortAsc(int[] array)
        {
            //Base case
            if (array == null || array.Length < 2)
                return;

            //Divide this array into half
            var middle = array.Length / 2;

            int[] left = new int[middle];
            for(int i = 0; i < middle; i++)
                left[i] = array[i];

            int[] right = new int[array.Length - middle];
            for(int i = middle; i < array.Length; i++)
                right[i - middle] = array[i];

            //Sort each half
            SortAsc(left);
            SortAsc(right);

            //Merge the result
            MergeAsc(left, right, array);
        }

        public void SortDesc(int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            var middle = array.Length / 2;
            var left = new int[middle];
            for (int i = 0; i < middle; i++)
                left[i] = array[i];

            var right = new int[array.Length - middle];
            for (int i = middle; i < array.Length; i++)
                right[i - middle] = array[i];

            SortDesc(left);
            SortDesc(right);

            MergeDesc(left, right, array);
        }

        private void MergeAsc(int[] left, int[] right, int[] result)
        {
            var i = 0;
            var j = 0;
            var k = 0;

            while(i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                    result[k++] = left[i++];
                else
                    result[k++] = right[j++];
            }

            while(i < left.Length)
                result[k++] = left[i++];

            while (j < right.Length)
                result[k++] = right[j++];
        }

        private void MergeDesc(int[] left, int[] right, int[] result)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] > right[j])
                    result[k++] = left[i++];
                else
                    result[k++] = right[j++];
            }

            while (i < left.Length)
                result[k++] = left[i++];

            while (j < right.Length)
                result[k++] = right[j++];
        }
    }
}
