namespace PreCourse2;

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 50, 60, 60, 70 };
        Console.WriteLine(BinarySearch(arr, 50));

    }

    public static bool BinarySearch(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;

        while(low <= high)
        {
            int mid = low + (high -low) / 2;

            if(arr[mid] == target)
            {
                return true;

            } else if(arr[mid] > target)
            {
                high = mid - 1;
            } else
            {
                low = mid + 1;
            }
        }

        return false;
    }
}