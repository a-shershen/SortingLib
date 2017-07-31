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
    }
}
