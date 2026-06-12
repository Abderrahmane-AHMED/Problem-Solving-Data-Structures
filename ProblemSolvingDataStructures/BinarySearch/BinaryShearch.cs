using System;
using System.Reflection;



class BinarySearchExample
{
    public static int BinarySearch<T>(T[] arr, T target ,out int trials) where T : IComparable<T>
    {
       

        int Start = 0, End = arr.Length - 1;
        trials = 0;

        while (Start <= End)
        {
             int Middle = Start + (End - Start) / 2;
            int comparison = target.CompareTo(arr[Middle]);
            trials++;

            if (comparison == 0)
            
                return Middle;
            

            if(comparison > 0)
            
                Start = Middle + 1;
            
            else 
                End = Middle -1;

        }
        return -1;

    }


}