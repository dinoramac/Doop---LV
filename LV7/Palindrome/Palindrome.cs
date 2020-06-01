using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Palindrome
{
    public class Palindrome
    {
        public string IsPalindrome(string myString)
        {
            if (string.IsNullOrEmpty(myString)) return "empty string";
            string temp = myString.ToLower();
            int len = temp.Length;

            string stringBuilder = "";
            for (int i = 0; i < len; i++)
            {
                if (temp[i] >= 'a' && temp[i] <= 'z') stringBuilder+=(temp[i]);
            }

            int length = stringBuilder.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (stringBuilder[i] != stringBuilder[length - i - 1])
                    return "false";
            }
            return "true";
        }
    }
}
