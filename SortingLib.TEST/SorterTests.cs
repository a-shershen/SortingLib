using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Linq;

using sorterInt = SortingLib.LIB.Sorter<int>;


namespace SortingLib.TEST
{
    [TestClass]
    public class SorterTests
    {
        private int size = 10000;

        private int[] unsorted;

        private int[] expected;

        private int[] GenerateArray(int size)
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
        [ExpectedException(typeof(ArgumentNullException))]
        public void BubbleSortNullArrayTest()
        {
            sorterInt.BubbleSort(null);                        
        }

        [TestMethod]
        public void BubbleSortTest()
        {
            unsorted = GenerateArray(size);

            expected = unsorted.OrderBy(i => i).ToArray();

            CollectionAssert.AreEqual(expected, sorterInt.BubbleSort(unsorted));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShakerSortNullArrayTest()
        {
            sorterInt.ShakerSort(null);
        }

        [TestMethod]
        public void ShakerSortTest()
        {
            unsorted = GenerateArray(size);

            expected = unsorted.OrderBy(i => i).ToArray();

            CollectionAssert.AreEqual(expected, sorterInt.ShakerSort(unsorted));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CombSortNullArrayTest()
        {
            sorterInt.CombSort(null);
        }

        [TestMethod]
        public void CombSortTest()
        {
            unsorted = GenerateArray(size);

            expected = unsorted.OrderBy(i => i).ToArray();

            CollectionAssert.AreEqual(expected, sorterInt.CombSort(unsorted));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuickSortNullArrayTest()
        {
            sorterInt.QuickSort(null);
        }

        [TestMethod]
        public void QuickSortTest()
        {
            unsorted = GenerateArray(size);

            expected = unsorted.OrderBy(i => i).ToArray();

            CollectionAssert.AreEqual(expected, sorterInt.QuickSort(unsorted));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SelectionNullArrayTest()
        {
            sorterInt.SelectionSort(null);
        }

        [TestMethod]
        public void SelectedSortTest()
        {
            unsorted = GenerateArray(size);

            expected = unsorted.OrderBy(i => i).ToArray();

            CollectionAssert.AreEqual(expected, sorterInt.SelectionSort(unsorted));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void InsertionSortNullArrayTest()
        {
            sorterInt.InsertionSort(null);
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            unsorted = GenerateArray(size);

            expected = unsorted.OrderBy(i => i).ToArray();

            CollectionAssert.AreEqual(expected, sorterInt.InsertionSort(unsorted));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShellSortNullArrayTest()
        {
            sorterInt.ShellSort(null);
        }

        [TestMethod]
        public void ShellSortTest()
        {
            unsorted = GenerateArray(size);

            expected = unsorted.OrderBy(i => i).ToArray();

            CollectionAssert.AreEqual(expected, sorterInt.ShellSort(unsorted));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MergeSortNullArrayTest()
        {
            sorterInt.MergeSort(null);
        }

        [TestMethod]
        public void MergeSortTest()
        {
            unsorted = GenerateArray(size);

            expected = unsorted.OrderBy(i => i).ToArray();

            CollectionAssert.AreEqual(expected, sorterInt.MergeSort(unsorted));
        }
    }
}
