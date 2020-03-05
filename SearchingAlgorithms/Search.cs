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

        /// <summary>
        /// This binary search uses recursion.
        /// To avoid too many parameters, the implementation detail is done by using a private method.
        /// Note:
        ///     Binary Search requires the array being sorted already.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int BinarySearchRecursive(int[] array, int target)
        {
            if (array == null)
                return -1;

            return BinarySearchRecursive(array, target, 0, array.Length - 1);
        }

        private int BinarySearchRecursive(int[] array, int target, int left, int right)
        {
            if (right < left)
                return -1;

            var middle = (left + right) / 2;
            if (target == array[middle])
                return middle;

            if (target < array[middle])
                return BinarySearchRecursive(array, target, left, middle - 1);

            return BinarySearchRecursive(array, target, middle + 1, right);
        }

        /// <summary>
        /// Iterative ver of Binary Search.
        /// Note:
        ///     Binary Search requires the array being sorted already.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int BinarySearchIterative(int[] array, int target)
        {
            if (array == null || array.Length == 0)
                return -1;

            var left = 0;
            var right = array.Length - 1;
            var middle = 0;

            while(right >= left)
            {
                middle = (left + right) / 2;
                if (target == array[middle])
                    return middle;

                if(target < array[middle])
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            return -1;
        }
    }
}
