using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string str = "Hello World!";

        Console.WriteLine($"Initial string: {str}");
        Console.WriteLine($"Substring: {str.SubstringNew(2, 5)}\n");

        string animal1 = "fox";
        string animal2 = "dog";

        string strTarget = String.Format("The {0} jumps over the {1}", animal1, animal2);
        strTarget = strTarget.Insert(strTarget.IndexOfNew(animal1), "smart ");

        Console.WriteLine(strTarget);

        Console.ReadLine();

    }
}

public static class MySubstring
{
    public static string SubstringNew(this string str, int startIndex)
    {
        List<char> charsList = new List<char>();
        for (int i = 0; i < startIndex; i++)
        {
            charsList.Add(str[i]);
        }

        string newStr = str.TrimStart(charsList.ToArray());
        return newStr;
    }

    public static string SubstringNew(this string str, int startIndex, int length)
    {
        string newStr = null;
        for (int i = startIndex; i < length + startIndex; i++)
        {
            newStr += str[i];
        }
        return newStr;
    }

}

public static class MyIndexOf
{
    public static int IndexOfNew(this string str, string keyWord)
    {
        int result = -1;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == keyWord[0])
            {
                result = i;
                break;
            }
        }
        return result;
    }
}
