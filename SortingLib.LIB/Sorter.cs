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
    public static class Sorter<T> where T:IComparable
    {
        /// <summary>
        /// Swap elements
        /// </summary>
        /// <param name="array">The array which elements will be swapped</param>
        /// <param name="leftIndex">Left index</param>
        /// <param name="rightIndex">Right index</param>
        private static void Swap(T[] array, int leftIndex, int rightIndex)
        {
            T temp = array[leftIndex];

            array[leftIndex] = array[rightIndex];

            array[rightIndex] = temp;
        }

        /// <summary>
        /// Realizes the bubble sort algorithm
        /// </summary>
        /// <param name="array">The array for sotring</param>
        /// <returns>The sorted array</returns>
        /// <exception cref="ArgumentNullException">Throws when the array is null</exception>
        public static T[] BubbleSort(T[] array)
        {   
            if(array == null)
            {
                throw new ArgumentNullException();
            }            

            bool wasSwapped = false;

            for(int i=0;i<array.Length-1;i++)
            {
                for(int j=0;j< array.Length-i-1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Swap(array, j, j + 1);
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
        /// <exception cref="ArgumentNullException">Throws when the array is null</exception>
        public static T[] ShakerSort(T[] array)
        {
            if(array==null)
            {
                throw new ArgumentNullException();
            }

            int left = 0;
            int right = array.Length-1;

            bool swapped = true;

            while (swapped)
            {
                swapped = false;

                for (int i = 0; i < right; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        Swap(array, i, i + 1);
                        swapped = true;
                    }
                }

                left++;

                for (int j = right; j > left; j--)
                {
                    if (array[j].CompareTo(array[j - 1]) < 0)
                    {
                        Swap(array, j, j - 1);
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
        /// <exception cref="ArgumentNullException">Throws when the array is null</exception>
        public static T[] CombSort(T[] array)
        {
            if(array==null)
            {
                throw new ArgumentNullException();
            }

            double f = 1.247;

            int step = array.Length - 1;

            while(step>1)
            {
                for (int i = 0; i + step < array.Length; i++)
                {
                    if (array[i].CompareTo(array[i + step]) > 0)
                    {
                        Swap(array, i, i + step);
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
        /// <exception cref="ArgumentNullException">Throws when the array is null</exception>
        public static T[] QuickSort(T[] array)
        {
            if(array==null)
            {
                throw new ArgumentNullException();
            }

            Quick(array, 0, array.Length - 1);

            return array;
        }

        private static void Quick(T[] array, int left, int right)
        {
            int i = left;

            int j = right;

            T pivot = array[(left + right) / 2];

            while(i<j)
            {
                while(array[i].CompareTo(pivot)<0)
                {
                    i++;
                }

                while(array[j].CompareTo(pivot)>0)
                {
                    j--;
                }

                if(i<=j)
                {
                    Swap(array, i, j);
                    i++;
                    j--;
                }
            }

            if(left<right)
            {
                Quick(array, left, j);   

                Quick(array, i, right);
            }
        }



        /// <summary>
        /// Realizes the selection sort algorithm 
        /// </summary>
        /// <param name="array">The unsorted array</param>
        /// <returns>The sorted array</returns>
        /// <exception cref="ArgumentNullException">Throws when the array is null</exception>
        public static T[] SelectionSort(T[] array)
        {
            if(array==null)
            {
                throw new ArgumentNullException();
            }

            int minIndex;

            for(int i=0;i<array.Length;i++)
            {
                minIndex = i;

                for(int j=i;j<array.Length;j++)
                {
                    if(array[j].CompareTo(array[minIndex])<0)
                    {
                        minIndex = j;
                    }
                }

                Swap(array, i, minIndex);
            }

            return array;
        }

        /// <summary>
        /// Realizes the insertion sort algorithm
        /// </summary>
        /// <param name="array">The unsorted array</param>
        /// <returns>The sorted array</returns>
        /// <exception cref="ArgumentNullException">Throws when the array is null</exception>
        public static T[] InsertionSort(T[] array)
        {
            if(array==null)
            {
                throw new ArgumentNullException();
            }

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j - 1] .CompareTo( array[j])>0)
                    {
                        Swap(array, j-1, j);
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
        /// <exception cref="ArgumentNullException">Throws when the array is null</exception>
        public static T[] ShellSort(T[] array)
        {
            if(array ==null)
            {
                throw new ArgumentNullException();
            }

            int d = array.Length;

            while (d > 0)
            {
                d /= 2;

                for (int i = 0; i < array.Length - d; i++)
                {
                    for (int j = i + d; j > 0; j -= d)
                    {
                        if (array[j - 1] .CompareTo( array[j])>0)
                        {
                            Swap(array, j - 1, j);
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
        /// <exception cref="ArgumentNullException">Throws when the array is null</exception>
        public static T[] MergeSort(T[] array)
        {          
            if(array==null)
            {
                throw new ArgumentNullException();
            }

            DivideAndMerge(array, 0, array.Length-1);

            return array;
        }

        private static void DivideAndMerge(T[] array, int left, int right)
        {
            if(left>=right)
            {
                return;
            }

            int middle = (left + right + 1) / 2;

            DivideAndMerge(array, left, middle-1);
            DivideAndMerge(array, middle, right);

            int i = left;
            int j = middle;

            T[] buffer = new T[right - left+1];
            int c = 0;
            

            while (i<middle && j<=right)
            {
                if(array[i].CompareTo(array[j])<0)
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
