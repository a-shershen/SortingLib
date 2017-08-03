using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Linq;

namespace SortingLib.TEST
{
    [TestClass]
    public class SorterTests
    {
        private int[] generateArray(int size)
        {
            int[] array = new int[size];

            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(int.MaxValue - 1);
            }

            return array;
        }

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

        [TestMethod]
        public void QuickSortTest()
        {
            int[] unsorted = { 5, 3, 1, 4, 4, 2 };

            int[] expected = { 1, 2, 3, 4, 4, 5 };

            int[] actual = SortingLib.LIB.Sorter.QuickSort(unsorted);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SelectedSortTest()
        {
            int[] unsorted = { 5, 3, 1, 4, 4, 2 };

            int[] expected = { 1, 2, 3, 4, 4, 5 };

            int[] actual = SortingLib.LIB.Sorter.SelectionSort(unsorted);

            CollectionAssert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void HeapSortTest()
        {
            int[] unsorted = { 5, 3, 1, 4, 4, 2 };

            int[] expected = { 1, 2, 3, 4, 4, 5 };

            int[] actual = SortingLib.LIB.Sorter.HeapSort(unsorted);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            int[] unsorted = { 5, 3, 1, 4, 4, 2 };

            int[] expected = { 1, 2, 3, 4, 4, 5 };

            int[] actual = SortingLib.LIB.Sorter.InsertionSort(unsorted);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShellSortTest()
        {
            int[] unsorted = { 5, 3, 1, 4, 4, 2};

            int[] expected = { 1, 2, 3, 4, 4, 5};

            int[] actual = SortingLib.LIB.Sorter.ShellSort(unsorted);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeSortTest()
        {
            int[] unsorted = { 5, 3, 1, 4, 4, 2 };

            int[] expected = { 1, 2, 3, 4, 4, 5 };

            int[] actual = SortingLib.LIB.Sorter.MergeSort(unsorted);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
