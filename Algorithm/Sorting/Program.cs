using System;
namespace Sorting;

class Program
{
    static void PrintArray<T>(T[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        int[] intArray = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };
        string[] stringArray = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        char[] charArray = { 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };
        double[] doubleArray = { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };


        //Ascending Ordered Algorithms
        System.Console.WriteLine("Ascending Sorted algorithm..");
        // Bubble Sort
        Console.WriteLine("Bubble Sort:");
        AscendingSortingAlgorithms.BubbleSort(intArray);
        PrintArray(intArray);
        AscendingSortingAlgorithms.BubbleSort(stringArray);
        PrintArray(stringArray);
        AscendingSortingAlgorithms.BubbleSort(charArray);
        PrintArray(charArray);
        AscendingSortingAlgorithms.BubbleSort(doubleArray);
        PrintArray(doubleArray);

        // Selection Sort
        intArray = new int[]{ 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };
        stringArray = new string[]{ "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        charArray = new char[]{ 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };
        doubleArray = new double[]{ 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        Console.WriteLine("\nSelection Sort:");
        AscendingSortingAlgorithms.SelectionSort(intArray);
        PrintArray(intArray);
        AscendingSortingAlgorithms.SelectionSort(stringArray);
        PrintArray(stringArray);
        AscendingSortingAlgorithms.SelectionSort(charArray);
        PrintArray(charArray);
        AscendingSortingAlgorithms.SelectionSort(doubleArray);
        PrintArray(doubleArray);

        // Merge Sort
        intArray = new int[]{ 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };
        stringArray = new string[]{ "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        charArray = new char[]{ 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };
        doubleArray = new double[]{ 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        Console.WriteLine("\nMerge Sort:");
        AscendingSortingAlgorithms.MergeSort(intArray);
        PrintArray(intArray);
        AscendingSortingAlgorithms.MergeSort(stringArray);
        PrintArray(stringArray);
        AscendingSortingAlgorithms.MergeSort(charArray);
        PrintArray(charArray);
        AscendingSortingAlgorithms.MergeSort(doubleArray);
        PrintArray(doubleArray);

        // Insertion Sort
        intArray = new int[]{ 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };
        stringArray = new string[]{ "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        charArray = new char[]{ 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };
        doubleArray = new double[]{ 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        Console.WriteLine("\nInsertion Sort:");
        AscendingSortingAlgorithms.InsertionSort(intArray);
        PrintArray(intArray);
        AscendingSortingAlgorithms.InsertionSort(stringArray);
        PrintArray(stringArray);
        AscendingSortingAlgorithms.InsertionSort(charArray);
        PrintArray(charArray);
        AscendingSortingAlgorithms.InsertionSort(doubleArray);
        PrintArray(doubleArray);

        // Quick Sort
        intArray = new int[]{ 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };
        stringArray = new string[]{ "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        charArray = new char[]{ 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };
        doubleArray = new double[]{ 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        Console.WriteLine("\nQuick Sort:");
        AscendingSortingAlgorithms.QuickSort(intArray);
        PrintArray(intArray);
        AscendingSortingAlgorithms.QuickSort(stringArray);
        PrintArray(stringArray);
        AscendingSortingAlgorithms.QuickSort(charArray);
        PrintArray(charArray);
        AscendingSortingAlgorithms.QuickSort(doubleArray);
        PrintArray(doubleArray);
        System.Console.WriteLine("_________________________________________________________________________________________________");

        //Descending Ordering Algorithm
        System.Console.WriteLine("Descending sorted algorithm");
        Console.WriteLine("Bubble Sort:");
        DescendingSortingAlgorithms.BubbleSort(intArray);
        PrintArray(intArray);
        DescendingSortingAlgorithms.BubbleSort(stringArray);
        PrintArray(stringArray);
        DescendingSortingAlgorithms.BubbleSort(charArray);
        PrintArray(charArray);
        DescendingSortingAlgorithms.BubbleSort(doubleArray);
        PrintArray(doubleArray);

        // Selection Sort
        intArray = new int[]{ 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };
        stringArray = new string[]{ "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        charArray = new char[]{ 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };
        doubleArray = new double[]{ 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        Console.WriteLine("\nSelection Sort:");
        DescendingSortingAlgorithms.SelectionSort(intArray);
        PrintArray(intArray);
        DescendingSortingAlgorithms.SelectionSort(stringArray);
        PrintArray(stringArray);
        DescendingSortingAlgorithms.SelectionSort(charArray);
        PrintArray(charArray);
        DescendingSortingAlgorithms.SelectionSort(doubleArray);
        PrintArray(doubleArray);

        // Merge Sort
        intArray = new int[]{ 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };
        stringArray = new string[]{ "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        charArray = new char[]{ 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };
        doubleArray = new double[]{ 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        Console.WriteLine("\nMerge Sort:");
        DescendingSortingAlgorithms.MergeSort(intArray);
        PrintArray(intArray);
        DescendingSortingAlgorithms.MergeSort(stringArray);
        PrintArray(stringArray);
        DescendingSortingAlgorithms.MergeSort(charArray);
        PrintArray(charArray);
        DescendingSortingAlgorithms.MergeSort(doubleArray);
        PrintArray(doubleArray);

        // Insertion Sort
        intArray = new int[]{ 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };
        stringArray = new string[]{ "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        charArray = new char[]{ 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };
        doubleArray = new double[]{ 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        Console.WriteLine("\nInsertion Sort:");
        DescendingSortingAlgorithms.InsertionSort(intArray);
        PrintArray(intArray);
        DescendingSortingAlgorithms.InsertionSort(stringArray);
        PrintArray(stringArray);
        DescendingSortingAlgorithms.InsertionSort(charArray);
        PrintArray(charArray);
        DescendingSortingAlgorithms.InsertionSort(doubleArray);
        PrintArray(doubleArray);

        // Quick Sort
        intArray = new int[]{ 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };
        stringArray = new string[]{ "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        charArray = new char[]{ 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };
        doubleArray = new double[]{ 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        Console.WriteLine("\nQuick Sort:");
        DescendingSortingAlgorithms.QuickSort(intArray);
        PrintArray(intArray);
        DescendingSortingAlgorithms.QuickSort(stringArray);
        PrintArray(stringArray);
        DescendingSortingAlgorithms.QuickSort(charArray);
        PrintArray(charArray);
        DescendingSortingAlgorithms.QuickSort(doubleArray);
        PrintArray(doubleArray);
    }
}