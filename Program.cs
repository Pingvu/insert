using System;
using System.Diagnostics;
using System.Threading;

namespace insert
{
    class InsertionSort
    {
        void sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i) {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key) {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
 
        Console.Write("\n");
    }
 
  
    public static void Main()
    {{int []arr = new int[8000];
    Random rnd = new Random();
    for (int i = 0; i < 8000; i++) {
  arr[i] = rnd.Next(0,1000) ;
}
   Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
        InsertionSort ob = new InsertionSort();
        ob.sort(arr);
         stopwatch.Stop();
        printArray(arr);
        Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
    }
}
    }}
