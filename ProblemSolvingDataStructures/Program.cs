using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 , 24 , 25, 26, 27, 28, 29, 30};

        int linear = 27;
        int binary = 27;


        Console.WriteLine("Original Array : ");
        foreach (var item in arr)
        {
            Console.WriteLine(item);

        }

        int TrialsLinearSearch;
        int linearSearch = LinearSearchExample.LinearSearch(arr, linear , out TrialsLinearSearch);


        int TrialsBinarySearch;
        int binarySearch = BinarySearchExample.BinarySearch(arr, binary , out TrialsBinarySearch);

        if (linearSearch == -1)

            Console.WriteLine("Element Linear Search  not found in the array .");
        else
            Console.WriteLine("Element Linear Search  fount at index  : " + linearSearch);

        Console.WriteLine("Trials Linear Search :" + TrialsLinearSearch);

        Console.WriteLine(binarySearch != -1
      ? $"Element Binary Search found at index: {binarySearch}"
      : $"Element Binary Search  not found in the array");

        Console.WriteLine("Trials Binary Search :" + TrialsBinarySearch);


        Console.ReadKey();
    }

    
}
