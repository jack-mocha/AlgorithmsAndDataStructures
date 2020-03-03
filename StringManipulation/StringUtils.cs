using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        /// <summary>
        /// This method split the input string by a delimiter and iterate through the array from the tail to the head.
        /// During the iteration, each string is added to the StringBuilder.
        /// References:
        /// [1] https://www.geeksforgeeks.org/collections-in-c-sharp/
        /// [2] https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ReverseWords(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return String.Empty;

            var words = input.Trim().Split(new char[] { ' ' });
            var sb = new StringBuilder(input.Length);
            for(int i = words.Length - 1; i >= 0; i--)
            {
                sb.Append(words[i]);
                if(i != 0) //Instead of doing this, we can also use TrimEnd().
                    sb.Append(" ");
            }

            return sb.ToString();
        }

        /// <summary>
        /// This method split the input string by a delmiter, and uses the Array utility method to reverse the array.
        /// Once the array is reversed, it uses the Join method to concatenate each string.
        /// References:
        /// [1] https://www.geeksforgeeks.org/c-sharp-arrays/
        /// [2] https://www.geeksforgeeks.org/c-sharp-array-class/
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ReverseWords2(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return String.Empty;

            var words = input.Trim().Split(new char[] { ' ' });
            Array.Reverse(words);
            
            return String.Join(" ", words);
        }

        /// <summary>
        /// This method determines whether 2 strings are rotations
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public bool AreRotations(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                return false;
            if (str1.Length != str2.Length)
                return false;

            if (!(str1 + str1).Contains(str2))
                return false;

            return true;
        }

        /// <summary>
        /// This method removes duplicate char of the input string by 
        /// iterating through the string and check if the current char is in the set.
        /// None duplicate char are saved to the set and the StringBuilder.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string RemoveDuplicates(string str)
        {
            if (String.IsNullOrEmpty(str))
                return String.Empty;

            var seen = new HashSet<char>();
            var sb = new StringBuilder(str.Length);

            foreach(var s in str)
            {
                if (!seen.Contains(s))
                {
                    seen.Add(s);
                    sb.Append(s);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// This method finds the most repeated char in an input string
        /// by first storing the frequency of the char in a dictionary, and
        /// by iterating through the dictionary to find the highest frequency/char;
        /// 
        /// Note:
        ///     Keep in mind that Dictionary.ContainsValue is O(n);
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public char FindMostRepeatedChar(string str)
        {
            if (String.IsNullOrEmpty(str))
                throw new ArgumentException();

            var dictionary = new Dictionary<char, int>();

            foreach(var s in str)
            {
                if (!dictionary.ContainsKey(s))
                    dictionary.Add(s, 1);
                else
                    dictionary[s]++;
            }

            var max = 0;
            var result = '\0';
            foreach(var d in dictionary)
            {
                if (d.Value > max)
                {
                    max = d.Value;
                    result = d.Key;
                }
            }

            return result;
        }

        /// <summary>
        /// This method finds the most repeated char in an input string
        /// by first storing the frequency of the char in a ASCII_Table array, and
        /// by iterating through the array to find the highest frequency/char;
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public char FindMostRepeatedChar2(string str)
        {
            if (String.IsNullOrEmpty(str))
                throw new ArgumentException();

            var ASCIISize = 256; //Because the size of ASCII table is 256.
            int[] frequecy = new int[ASCIISize];
            
            foreach(var s in str)
            {
                frequecy[s]++;
            }

            var max = 0;
            var result = '\0';
            for(int i = 0; i < frequecy.Length; i++)
            {
                if(frequecy[i] > max)
                {
                    max = frequecy[i];
                    result = (char)i;
                }
            }

            return result;
        }

        /// <summary>
        /// This method capitalize every word of a sentence, but does not lowercase the rest of the word.
        /// For example, trees ARE beautiful. -> Trees ARE Beautiful.
        /// It uses ASCII to convert lower case character to upper case, 
        /// and an index to trace the first char of a string.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string CapitalizeSentence(string str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return String.Empty;

            var words = str.Trim().Split(new char[] { ' ' }); //To trim leading and tailing white space.
            var sb = new StringBuilder(str.Length);
            var idx = 0; //To keep track of which character to capitalize.
            for(int i = 0; i < words.Length; i++)
            {
                if(!words[i].Equals(String.Empty))
                {
                    sb.Append(words[i]);
                    if(!(sb[idx] >= 65 && sb[idx] <= 90)) //Check if first char is already upper case.
                        sb[idx] = (char)(sb[idx] - 32);
                    
                    if (i != words.Length - 1)
                        sb.Append(" ");

                    idx += (words[i].Length + 1); //1 is the legnth of space.
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// This method capitalize every word of a sentence and lower case the rest of the word.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string CapitalizeSentence2(string str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return String.Empty;

            str = str.Trim();
            var reg = new Regex(" +"); //one ore more space
            str = reg.Replace(str, " ");

            var words = str.Split(new char[] { ' ' });
            for (int i = 0; i < words.Length; i++)
            {
                if (!words[i].Equals(String.Empty))
                    words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
            }

            return String.Join(" ", words);
        }

        /// <summary>
        /// This method finds out if the input strings are anagrams
        /// by first storing every char and the frequency of the first string in a dictionary.
        /// Then subtract the frequency of the char when iterating through the second string.
        /// Finally, if the count of the key value pair in the dictionary is 0, these 2 strings are anagrams.
        /// 
        /// Note:  
        ///     str1 and str2 are case sensitive. e.g.abc != ABC
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public bool AreAnagrams(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                return false;
            if (str1.Length != str2.Length)
                return false;

            var dictionary = new Dictionary<char, int>();
            foreach(var s in str1)
            {
                if (!dictionary.ContainsKey(s))
                    dictionary.Add(s, 1);
                else
                    dictionary[s]++;
            }

            foreach(var s in str2)
            {
                if (!dictionary.ContainsKey(s))
                    return false;
                else
                {
                    dictionary[s]--;
                    if (dictionary[s] == 0)
                        dictionary.Remove(s);
                }
            }

            if (dictionary.Count != 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// This method finds out if the input strings are anagrams
        /// by first sorting str1 and str2.
        /// Then compare two arrays.
        /// 
        /// Note: 
        ///     str1 and str2 are case insensitive. e.g.abc == ABC
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public bool AreAnagrams2(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                return false;
            if (str1.Length != str2.Length)
                return false;

            var arr1 = str1.ToLower().ToCharArray();
            Array.Sort(arr1);

            var arr2 = str2.ToLower().ToCharArray();
            Array.Sort(arr2);

            for(int i=0; i<arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// This method determines if an input string is palindrome by having 2 pointers. 
        /// 1 from the begining of the string and the other form the end of the string.
        /// 
        /// Solution is case sensitive.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IsPalindrome(string str)
        {
            if (str == null)
                return false;
            if (String.IsNullOrWhiteSpace(str))
                return true;

            var left = 0;
            var right = str.Length - 1;

            while(right > left)
            {
                if (str[left] != str[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
