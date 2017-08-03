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

        /// <summary>
        /// Realizes the quick sort algorithm
        /// </summary>
        /// <param name="array">The array for sorting</param>
        /// <returns>The sorted array</returns>
        public static int[] QuickSort(int[] array)
        {
            quick(array, 0, array.Length - 1);

            return array;
        }

        private static void quick(int[] array, int start, int end)
        {
            int i = start;

            int j = end;

            int pivot = array[(start + end) / 2];

            while(i<j)
            {
                while(array[i]<pivot)
                {
                    i++;
                }

                while(array[j]>pivot)
                {
                    j--;
                }

                if(i<=j)
                {
                    swap(array, i, j);
                    i++;
                    j--;
                }
            }

            if(start<j)
            {
                quick(array, start, j);
            }

            if(i<end)
            {
                quick(array, i, end);
            }
        }



        /// <summary>
        /// Realizes the selection sort algorithm 
        /// </summary>
        /// <param name="array">The unsorted array</param>
        /// <returns>The sorted array</returns>
        public static int[] SelectionSort(int[] array)
        {
            int minIndex;

            for(int i=0;i<array.Length;i++)
            {
                minIndex = i;

                for(int j=i;j<array.Length;j++)
                {
                    if(array[j]<array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                swap(array, i, minIndex);
            }

            return array;
        }

        /// <summary>
        /// Realizes the heapsort (pyramid) sort algorithm
        /// </summary>
        /// <param name="array">The unsorted array</param>
        /// <returns>The sorted array</returns>
        public static int[] HeapSort(int[] array)
        {
            return array;
        }

        /// <summary>
        /// Realizes the insertion sort algorithm
        /// </summary>
        /// <param name="array">The unsorted array</param>
        /// <returns>The sorted array</returns>
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        swap(array, j-1, j);
                    }

                    else
                    {
                        break;
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// Realizes Shell sort algorithm
        /// </summary>
        /// <param name="array">The unsorted array</param>
        /// <returns>The sorted array</returns>
        public static int[] ShellSort(int[] array)
        {
            int d = array.Length;

            while (d > 0)
            {
                d /= 2;

                for (int i = 0; i < array.Length - d; i++)
                {
                    for (int j = i + d; j > 0; j -= d)
                    {
                        if (array[j - 1] > array[j])
                        {
                            swap(array, j - 1, j);
                        }

                        else
                        {
                            break;
                        }
                    }
                }

                if(d==1)
                {
                    break;
                }
            }

            return array;
        }


        /// <summary>
        /// Realizes merge sort algorithm
        /// </summary>
        /// <param name="array">The unsorted array</param>
        /// <returns>The sorted array</returns>
        public static int[] MergeSort(int[] array)
        {            
            divideAndMerge(array, 0, array.Length-1);

            return array;
        }

        private static void divideAndMerge(int[] array, int left, int right)
        {
            if(left>=right)
            {
                return;
            }

            int middle = (left + right + 1) / 2;

            divideAndMerge(array, left, middle-1);
            divideAndMerge(array, middle, right);

            int i = left;
            int j = middle;

            int[] buffer = new int[right - left+1];
            int c = 0;
            

            while (i<middle && j<=right)
            {
                if(array[i]<array[j])
                {
                    buffer[c] = array[i];
                    c++;
                    i++;
                }
                else
                {
                    buffer[c] = array[j];
                    c++;
                    j++;
                }
            }

            if (i < middle)
            {
                while(i<middle)
                {
                    buffer[c] = array[i];
                    c++;
                    i++;
                }
            }

            if (j <= right)
            {
                while(j<=right)
                {
                    buffer[c] = array[j];
                    c++;
                    j++;
                }
            }           
            

            for(i=0;i<buffer.Length;i++)
            {
                array[left + i] = buffer[i];
            }
        }        
    }
}
