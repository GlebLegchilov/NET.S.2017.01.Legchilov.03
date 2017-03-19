using System;
using NUnit.Framework;
using static TaskTwo.ArraysSort;

namespace TaskTwoTest
{
    [TestFixture]
    public class ArraySortTest
    {
        [TestCase("qwerty", null)]
        [TestCase(null, "qwerty")]
        [TestCase(null, null)]
        public void Longest_ThrowArgumentNullException(string strOne, string strTwo)
        {
            Assert.Throws<ArgumentNullException>(()=> Longest(strOne, strTwo));
        }

        [TestCase("Qwerty", "qwerty")]
        [TestCase("qwerty", "qwert7y")]
        [TestCase("-_-", "a 13")]
        public void Longest_ThrowArgumentException(string strOne, string strTwo)
        {
            Assert.Throws<ArgumentException>(() => Longest(strOne, strTwo));
        }

        [TestCase("xyaabbbccccdefww", "xxxxyyyyabklmopq", ExpectedResult = "abcdefklmopqwxy")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz", ExpectedResult = "abcdefghijklmnopqrstuvwxyz")]
        public string ConcatStr_PositivTest(string strOne, string strTwo)
        {
            return ConcatStr(strOne, strTwo);
        }

    }
}
