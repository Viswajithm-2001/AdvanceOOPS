using System;
namespace Searching;

class Program
{
    static void Sort(int[]arr)
    {
        for(int i=0;i<arr.Length-1;i++)
        {
            for(int j=0;j<arr.Length-1;j++)
            {
                if(arr[j]>arr[j+1])
                {
                    int temp = arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                }
            }
        }
        
    }
    static void Sort(char[]arr)
    {
        for(int i=0;i<arr.Length-1;i++)
        {
            for(int j=0;j<arr.Length-1;j++)
            {
                if(arr[j]>arr[j+1])
                {
                    char temp = arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                }
            }
        }
        
    }
    static void Sort(double[]arr)
    {
        for(int i=0;i<arr.Length-1;i++)
        {
            for(int j=0;j<arr.Length-1;j++)
            {
                if(arr[j]>arr[j+1])
                {
                    double temp = arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                }
            }
        }
        
    }
    static void Sort(string[]arr)
    {
        for(int i=0;i<arr.Length-1;i++)
        {
            for(int j=0;j<arr.Length-1;j++)
            {
                if(arr[j].CompareTo(arr[j+1])>0)
                {
                    string temp = arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                }
            }
        }
        
    }
    
    public static void Main(string[] args)
    {
        int []integerArray = {45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77 };
        string[] stringArray = {"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        char[] charArray = {'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d' };
        double[] doubleArray = {1.1,65.3,93.9,55.5,3.5,6.9};

        
        //Since it is not possible for binary searching an unsorted array we are going to sort both and compare them now
        //finding 66 in Integer Array
        System.Console.WriteLine("____________________________________________________________");
        System.Console.WriteLine("We are in Integer Array");
        Sort(integerArray); 
        int linearSearchIndex = ArraySearching.LinearSearching(integerArray,66);
        System.Console.WriteLine($"Index Position be {linearSearchIndex}");
        int binarySearchIndex = ArraySearching.BinarySearch(integerArray,66);
        System.Console.WriteLine($"Index Position be {binarySearchIndex}");
        System.Console.WriteLine("____________________________________________________________");

        //finding "SF3067" in in string Array
        System.Console.WriteLine("____________________________________________________________");
        System.Console.WriteLine("We are in string Array");
        Sort(stringArray); 
        linearSearchIndex = ArraySearching.LinearSearching(stringArray,"SF3067");
        System.Console.WriteLine($"Index Position be {linearSearchIndex}");
        binarySearchIndex = ArraySearching.BinarySearch(stringArray,"SF3067");
        System.Console.WriteLine($"Index Position be {binarySearchIndex}");
        System.Console.WriteLine("____________________________________________________________");

        //finding 'm' character in char Array
        System.Console.WriteLine("____________________________________________________________");
        System.Console.WriteLine("We are in char Array");
        Sort(charArray); 
        linearSearchIndex = ArraySearching.LinearSearching(charArray,'m');
        System.Console.WriteLine($"Index Position be {linearSearchIndex}");
        binarySearchIndex = ArraySearching.BinarySearch(charArray,'m');
        System.Console.WriteLine($"Index Position be {binarySearchIndex}");
        System.Console.WriteLine("____________________________________________________________");

        //finding 3.5 in double Array
        System.Console.WriteLine("____________________________________________________________");
        System.Console.WriteLine("we are in double array");
        Sort(doubleArray); 
        linearSearchIndex = ArraySearching.LinearSearching(doubleArray,3.5);
        System.Console.WriteLine($"Index Position be {linearSearchIndex}");
        binarySearchIndex = ArraySearching.BinarySearch(doubleArray,3.5);
        System.Console.WriteLine($"Index Position be {binarySearchIndex}");
        System.Console.WriteLine("____________________________________________________________");



        /// <summary>
        /// After Reviewed all these cases we have found that Binary Search is more efficient than Linear Search if it is a sorted array
        /// Whereas in Unsorted array Linear is the only better Option.
        /// Coming to Worst Case scenario
        /// Binary Search's big O notation is O(log n)
        /// Linear Search's Big O Notation is O(n)
        /// Which means Binary takes lesser Time complexity</summary>
        /// 

        //Conclusion : For sorted Array Binary Search is Better, For Unsorted Array Linear Search is Better

    }
}