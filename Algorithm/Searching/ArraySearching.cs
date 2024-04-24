using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Searching
{
    public static class ArraySearching
    {
        //Linear Search
        //Linear Searching for Integer Array
        public static int LinearSearching(int[]arr,int n)
        {
            int count =0;
            int index = -1;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]==n)
                {
                    index = i;
                    break;
                }
                count++;
            }
            System.Console.WriteLine($"Takes {count} number of Iteration");
            return index;

        }

        //Linear Search for String Array
        public static int LinearSearching(string[]arr,string n)
        {
            int count=0;
            int index = -1;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]==n)
                {
                    index = i;
                    break;
                }
                count++;
            }
            System.Console.WriteLine($"Takes {count} number of Iteration");
            return index;

        }

        //Linear Search for Character Array
        public static int LinearSearching(char[]arr,char n)
        {
            int count=0;
            int index = -1;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]==n)
                {
                    index = i;
                    break;
                }
                count++;
            }
            System.Console.WriteLine($"Takes {count} number of Iteration");
            return index;

        }

        //Linear Search for Double Array
        public static int LinearSearching(double[]arr,double n)
        {
            int count=0;
            int index = -1;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]==n)
                {
                    index = i;
                    break;
                }
                count++;
            }
            System.Console.WriteLine($"Takes {count} number of Iteration");
            return index;

        }



        //Binary Search
        //Binary Search for Integer Array
        public static int BinarySearch(int[]arr,int n)
        {
            int count =0;
            int index = -1;
            int start = 0;
            int end = arr.Length-1;
            
            while(start<=end)
            {
                int middle = (start+end)/2;
                if(arr[middle]==n)
                {
                    index = middle;
                    break;
                }
                else if (arr[middle]>n)
                {
                    end = middle-1;
                }
                else
                {
                    start = middle+1;
                }
                count++;
            }
            System.Console.WriteLine($"It takes {count} no of iterations");
            return index;
        }

        //Binary Search for Double valued Array

        public static int BinarySearch(double[]arr,double n)
        {
            int count =0;
            int index = -1;
            int start = 0;
            int end = arr.Length-1;
            
            while(start<=end)
            {
                int middle = (start+end)/2;
                if(arr[middle]==n)
                {
                    index = middle;
                    break;
                }
                else if (arr[middle]>n)
                {
                    end = middle-1;
                }
                else
                {
                    start = middle+1;
                }
                count++;
            }
            System.Console.WriteLine($"It takes {count} no of iterations");
            return index;
        }

        //Binary Search for String Array

        public static int BinarySearch(string[]arr,string n)
        {
            int count =0;
            int index = -1;
            int start = 0;
            int end = arr.Length-1;
            
            while(start<=end)
            {
                int middle = (start+end)/2;
                if(arr[middle].Equals(n))
                {
                    index = middle;
                    break;
                }
                else if (arr[middle].CompareTo(n)>0)
                {
                    end = middle-1;
                }
                else
                {
                    start = middle+1;
                }
                count++;
            }
            System.Console.WriteLine($"It takes {count} no of iterations");
            return index;
        }

        //Binary Search for Character Array
        public static int BinarySearch(char[]arr,char n)
        {
            int count =0;
            int index = -1;
            int start = 0;
            int end = arr.Length-1;
            
            while(start<=end)
            {
                int middle = (start+end)/2;
                if(arr[middle]==n)
                {
                    index = middle;
                    break;
                }
                else if (arr[middle]>n)
                {
                    end = middle-1;
                }
                else
                {
                    start = middle+1;
                }
                count++;
            }
            System.Console.WriteLine($"It takes {count} no of iterations");
            return index;
        }
    }
}