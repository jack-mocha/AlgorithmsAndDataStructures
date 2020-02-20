using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    /// <summary>
    /// First Attempt
    /// Note:
    ///     [1] Convert input string to char array is already O(n)
    ///     [2] Checking whether the input string is odd or even in length is redundant.
    /// </summary>
    public class StringUtils
    {
        public string ReverseString(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return String.Empty;

            var arr = input.ToCharArray();
            var center = arr.Length / 2;
            var last = arr.Length - 1;

            if(center % 2 == 0)
            {
                for (int i = 0; i < center; i++)
                {
                    var temp = arr[i];
                    arr[i] = arr[last];
                    arr[last] = temp;
                    
                    last--;
                }
            }
            else
            {
                for (int i = 0; i <= center; i++)
                {
                    var temp = arr[i];
                    arr[i] = arr[last];
                    arr[last] = temp;

                    last--;
                }
            }

            return new string(arr);
        }

        /// <summary>
        /// This method traverse from the head of input string until the middle of the input string.
        /// In each traversal, the first and the last char are saved in the char array.
        /// Pro: 
        ///     Only needs to traverse to the middle point of the input string. O(n/2)
        ///     
        /// References:
        ///     [1] string VS String: https://programmingwithmosh.com/net/difference-between-string-and-string-in-c/
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ReverseString2(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return String.Empty;

            var last = input.Length - 1;
            var reversed = new char[input.Length];

            for(int i = 0; i <= (input.Length - 1) / 2; i++)
            {
                reversed[i] = input[last];
                reversed[last] = input[i];
                last--;
            }

            return new string(reversed);
        }

        /// <summary>
        /// This method reads from the tail to head of the input string, and append each char to a StringBuilder.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ReverseString3(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return String.Empty;

            var last = input.Length - 1;
            var sb = new StringBuilder(input.Length); //Initialize a StringBuilder with the initial capacity equal to input.Length

            for(int i = last; i >= 0; i--)
                sb.Append(input[i]);

            return sb.ToString();
        }

        /// <summary>
        /// This method uses a hashset to store vowels and iterate through the input string to find vowels.
        /// 
        /// References:
        /// [1] 5 C# Collections that every C# Developer Must Know https://programmingwithmosh.com/net/csharp-collections/
        /// [2] HashTable vs Dictionary: https://www.geeksforgeeks.org/difference-between-hashtable-and-dictionary-in-c-sharp/
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int CountVowels(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return 0;

            var count = 0;
            var vowelsSet = new HashSet<char>()
            {
                'a',
                'e',
                'i',
                'o',
                'u',
            };

            foreach(var i in input.ToLower())
            {
                if (vowelsSet.Contains(i))
                    count++;
            }

            return count;
        }
    }
}
