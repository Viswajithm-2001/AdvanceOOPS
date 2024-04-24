using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorting
{
    public static class AscendingSortingAlgorithms
    {
        // Bubble Sort
        public static void BubbleSort<T>(T[] array) where T : IComparable<T>
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        // Selection Sort
        public static void SelectionSort<T>(T[] array) where T : IComparable<T>
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }
                T temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }

        // Merge Sort
        public static void MergeSort<T>(T[] array) where T : IComparable<T>
        {
            MergeSort(array, 0, array.Length - 1);
        }

        public static void MergeSort<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);
                Merge(array, left, mid, right);
            }
        }

        public static void Merge<T>(T[] array, int left, int mid, int right) where T : IComparable<T>
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            T[] L = new T[n1];
            T[] R = new T[n2];

            Array.Copy(array, left, L, 0, n1);
            Array.Copy(array, mid + 1, R, 0, n2);

            int i = 0, j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (L[i].CompareTo(R[j]) <= 0)
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }

        // Insertion Sort
        public static void InsertionSort<T>(T[] array) where T : IComparable<T>
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                T key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        // Quick Sort
        public static void QuickSort<T>(T[] array) where T : IComparable<T>
        {
            QuickSort(array, 0, array.Length - 1);
        }

        public static void QuickSort<T>(T[] array, int low, int high) where T : IComparable<T>
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        static int Partition<T>(T[] array, int low, int high) where T : IComparable<T>
        {
            T pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (array[j].CompareTo(pivot) < 0)
                {
                    i++;
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            T temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;
            return i + 1;
        }
    }
}