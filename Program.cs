using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        int sum = 0;

        Console.WriteLine("Original array: [{0}]", string.Join(", ", arr));

        // Compute the sum of the middle elements
        for (int i = 1; i < arr.Length - 1; i++)
        {
            sum += arr[i];
        }

        // Divide the sum by 2 and update the array
        int middleSum = sum / 2;
        for (int i = 1; i < arr.Length - 1; i++)
        {
            arr[i] = middleSum;
        }

        Console.WriteLine("Array after replacement: [{0}]", string.Join(", ", arr));
    }
}






