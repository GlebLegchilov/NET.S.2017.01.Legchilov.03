using System;
using NUnit.Framework;
using static TaskOne.IndexSearcher;

namespace TaskOneTest
{
    [TestFixture]
    public class IndexSearcherTest
    {
        [TestCase(null)]
        public void Search_ThrowArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => Search(array));
        }

        [TestCase(new int[] { 1, 2, 3, 4, 3, 2, 1 }, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 100, 50, -51, 1, 1 }, ExpectedResult = 1)]
        public int SearchMaster_PositivTest(int[] array)
        {
            return SearchMaster(array);
        }

    }
}