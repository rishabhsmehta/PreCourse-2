namespace PreCourse2;

using System;

class QuickSort
{
    /* This function takes last element as pivot, 
       places the pivot element at its correct 
       position in sorted array, and places all 
       smaller (smaller than pivot) to left of 
       pivot and all greater elements to right 
       of pivot */
    void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    int partition(int[] arr, int low, int high)
    {
        
        int pivot = high;
        int i = low - 1;
        for(int j = low; j < high ; j++)
        {
            if(arr[j] <= arr[pivot])
            {
                i += 1;
                swap(arr, i, j);
            }
        }
        swap(arr, i + 1, pivot);
        return i + 1;
    }

    /* A utility function to print array of size n */
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.WriteLine(arr[i] + " ");
        Console.WriteLine();
    }

    /* The main function that implements QuickSort() 
     arr[] --> Array to be sorted, 
     low  --> Starting index, 
     high  --> Ending index */
    void sort(int[] arr, int low, int high)
    {
        if(low >= high)
        {
            return;
        }
        int p = partition (arr, low, high);
        sort(arr, low, p-1);
        sort(arr, p + 1, high);
    }

    public static void Main(string[] args)
    {
        int[] arr = new int[]{ 10, 7, 8, 9, 1, 5 };
        int n = arr.Length;

        QuickSort ob = new QuickSort();
        ob.sort(arr, 0, n - 1);

        Console.WriteLine("sorted array");
        printArray(arr);
    } 
}
