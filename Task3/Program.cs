using System;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[7] { 6, 3, 7, 1, 9, 2, 1 };
        bool asc = false;
        Console.WriteLine("Sorting direction: ascending (asc), descending (des)");
        string sortDirect = Console.ReadLine();

        if (sortDirect == "asc") { asc = true; }
        arr.Sorting( asc);

        foreach (int elem in arr)
        {
            Console.WriteLine(elem);
        }

        Console.ReadLine();
    }
}

public static class ArrExtension
{
    public static int[] Sorting(this int[] arr, bool asc)
    {
        int temp;
        
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                bool swap = asc ?
                arr[i] > arr[j] : arr[i] < arr[j];
                if (swap)    
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
