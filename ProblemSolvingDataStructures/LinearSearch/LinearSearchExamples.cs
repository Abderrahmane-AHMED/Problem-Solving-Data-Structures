using System;


class LinearSearchExample
{

   public static int LinearSearch<T>(T[] arr, T target , out int trials)
    {

         trials = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (EqualityComparer<T>.Default.Equals(arr[i], target))
                return i;
            trials++;
        }
        return -1;
    }



}