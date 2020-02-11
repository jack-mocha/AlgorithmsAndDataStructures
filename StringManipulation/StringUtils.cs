using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public class StringUtils
    {
        public static string ReverseString(string input)
        {
            if (input == null)
                return "";

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
    }
}
