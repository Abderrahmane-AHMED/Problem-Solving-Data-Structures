using System;


class LinearSearchEtargetample
{

    static int LinearSearch<T>(T[] arr, T target)
    {
      
        for (int i = 0; i < arr.Length; i++)
        {
            if (EqualityComparer<T>.Default.Equals(arr[i] , target))
                return i;
        }
        return -1;
    }


    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        int target = 12;


        Console.WriteLine("Original Array : ");
        foreach (var item in arr)
        {
            Console.WriteLine(item);
         
        }

        int result = LinearSearch(arr, target);

        if (result == -1)

            Console.WriteLine("Element not found in the array .");
        else
            Console.WriteLine("Element fount at inde target : " + result);

        Console.ReadKey();

    }
}