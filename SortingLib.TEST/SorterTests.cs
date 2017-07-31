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

        [TestMethod]
        public void ShakerSortTest()
        {
            int[] unsorted = { 5, 3, 1, 4, 4, 2 };

            int[] expected = { 1, 2, 3, 4, 4, 5 };

            int[] actual = SortingLib.LIB.Sorter.ShakerSort(unsorted);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CombSortTest()
        {
            int[] unsorted = { 5, 3, 1, 4, 4, 2 };

            int[] expected = { 1, 2, 3, 4, 4, 5 };

            int[] actual = SortingLib.LIB.Sorter.CombSort(unsorted);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
