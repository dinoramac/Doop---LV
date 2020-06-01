using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Test
{
    [TestFixture]
    public class PalindromeTest
    {
        Palindrome palindrom = new Palindrome();

        //private static string[] inputStrings = new string[]
        //{
        //    "ovojejovo", "anavolimilovana"
        //};

        //[TestCaseSource("inputStrings")]
        [TestCase("ovojejovo")]
        [TestCase("anavolimilovana")]
        [TestCase("sirimamiris")]
        public void IsPalindrome_WhenAllLowerCase(string input)
        {
            //Arrange
            string expected = "true";
            //Act
            string actual = palindrom.IsPalindrome(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }



        [TestCase("OvoJeJovo")]
        [TestCase("AnaVoliMilovana")]
        [TestCase("SirImaMiris")]
        public void IsPalindrome_WhenExistsUpperCase(string input)
        {
            //Arrange
            string expected = "true";
            //Act
            string actual = palindrom.IsPalindrome(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase("Ovo je Jovo")]
        [TestCase("Ana voli Milovana")]
        [TestCase("Sir ima miris")]
        public void IsPalindrome_WhenSpaceBetweenWords(string input)
        {
            //Arrange
            string expected = "true";
            //Act
            string actual = palindrom.IsPalindrome(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Ovo je Jovo.")]
        [TestCase("Ana voli Milovana.")]
        [TestCase("Sir ima miris!")]
        public void IsPalindrome_WhenSpecialChars(string input)
        {
            //Arrange
            string expected = "true";
            //Act
            string actual = palindrom.IsPalindrome(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("")]
        public void IsPalindrome_WhenStringNull(string input)
        {
            //Arrange
            string expected = "empty string";
            //Act
            string actual = palindrom.IsPalindrome(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
