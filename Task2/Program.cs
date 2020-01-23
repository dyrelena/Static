using System;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[7] { 6, 3, 7, 1, 9, 2, 1 };
        ArrExtension.Sorting(arr);

        foreach (int elem in arr)
        {
            Console.WriteLine(elem);
        }

        Console.ReadLine();
    }
}

public static class ArrExtension
{
    public static int[] Sorting(this int[] arr)
    {
        int temp;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        return arr;
    }
}
