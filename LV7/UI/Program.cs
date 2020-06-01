using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Palindrome;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var palindrom = new Palindrome.Palindrome();
            Console.WriteLine(palindrom.IsPalindrome("Ana voli Milovana."));
        }
    }
}
