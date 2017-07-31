using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLib.LIB
{
    /// <summary>
    /// Contains different sorting algorithm methods
    /// </summary>
    public static class Sorter
    {
        /// <summary>
        /// Swap elements
        /// </summary>
        /// <param name="array">The array which elements will be swapped</param>
        /// <param name="leftIndex">Left index</param>
        /// <param name="rightIndex">Right index</param>
        private static void swap(int[] array, int leftIndex, int rightIndex)
        {
            int temp = array[leftIndex];

            array[leftIndex] = array[rightIndex];
            array[rightIndex] = temp;
        }

        /// <summary>
        /// Realizes the bubble sort algorithm
        /// </summary>
        /// <param name="array">The array for sotring</param>
        /// <returns>The sorted array</returns>
        public static int[] BubbleSort(int[] array)
        {                      
            bool wasSwapped = false;

            for(int i=0;i<array.Length-1;i++)
            {
                for(int j=0;j< array.Length-i-1; j++)
                {
                    if(array[j]>array[j+1])
                    {
                        swap(array, j, j+1);
                        wasSwapped = true;
                    }
                }

                if(!wasSwapped)
                {
                    break;
                }
            }

            return array;
        }

        /// <summary>
        /// Realizes the shaker sort algorithm
        /// </summary>
        /// <param name="array">The array for sotring</param>
        /// <returns>The sorted array</returns>
        public static int[] ShakerSort(int[] array)
        {
            int left = 0;
            int right = array.Length-1;

            bool swapped = true;

            while (swapped)
            {
                swapped = false;

                for (int i = 0; i < right; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        swap(array, i, i + 1);
                        swapped = true;
                    }
                }

                left++;

                for (int j = right; j > left; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        swap(array, j, j - 1);
                        swapped = true;
                    }
                }

                right--;
            }

            return array;
        }

        /// <summary>
        /// Realizes the comb sort algorithm
        /// </summary>
        /// <param name="array">The array for sorting</param>
        /// <returns>The sorted array</returns>
        public static int[] CombSort(int[] array)
        {
            double f = 1.247;

            int step = array.Length - 1;

            while(step>1)
            {
                for (int i = 0; i + step < array.Length; i++)
                {
                    if (array[i] > array[i + step])
                    {
                        swap(array, i, i + step);
                    }
                }

                step = (int)(step / f);
            }

            BubbleSort(array);

            return array;
        }
    }
}
