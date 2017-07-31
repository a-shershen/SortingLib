using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingLib.TEST
{
    [TestClass]
    public class SorterTests
    {
        [TestMethod]
        public void BubbleSortTest()
        {
            int[] unsortedArray = { 5, 1, 3, 2, 4, 4 };

            int[] expected = { 1, 2, 3, 4, 4, 5 };

            int[] actual = SortingLib.LIB.Sorter.BubbleSort(unsortedArray);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
