using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        //проверка собственной реализации Substring(int, int)
        string str = "Hello World!";

        Console.WriteLine("The Example of Substring(int, int):");
        Console.WriteLine($"Initial string: {str}");
        Console.WriteLine($"Substring: {str.SubstringNew(10, 2)}\n");

        //проверка собственной реализации IndexOf(string)
        string animal1 = "fox";
        string animal2 = "dog";

        string strTarget = String.Format("The {0} jumps over the {1}", animal1, animal2);


        Console.WriteLine("The Example of IndexOf(string):");
        Console.WriteLine($"The string {animal1} occurs at position(s) {strTarget.IndexOfNew("fox")} in \"{strTarget}\"");


    //проверка собственной реализации Replace(string)
        string stringToReplace = "one two one one";
        string searchWord = "one"; //что заменять
        string wordToReplace = "three"; //чем заменять

        Console.WriteLine("\nThe Example of Replace(string):");
        Console.WriteLine($"The source string is <{stringToReplace}>");
        Console.WriteLine($"The updated string is <{stringToReplace.ReplaceNew(searchWord, wordToReplace)}>");
        Console.ReadLine();

    }
}

public static class MySubstring
{
    public static string SubstringNew(this string str, int startIndex)
    {
        string result = "";
        for (int i = startIndex; i < str.Length; i++)
        {
            result += str[i];
        }

        return result;
    }

    public static string SubstringNew(this string str, int startIndex, int length)
    {
        string newStr = "";
        for (int i = startIndex; i < length + startIndex; i++)
        {
            newStr += str[i];
        }
        return newStr;
    }



    public static int IndexOfNew(this string str, string keyWord)
    {
        int result = -1;
        for (int i = 0; i <= str.Length - keyWord.Length; i++)
        {
            if (str[i] == keyWord[0])
            {
                if (str.SubstringNew(i, keyWord.Length) == keyWord)
                {
                    result = i;
                    break;
                }
            }
        }
        return result;
    }

 public static string ReplaceNew(this string str, string searchWord, string wordToReplace)
    {
        /*string searchWord = "one"; //что заменять
        string wordToReplace = "three"; //чем заменять*/

        string result = "";
        int index;

        do
        {
            index = str.IndexOfNew(searchWord);
            if (index == -1)
            {
                result += str;
                return result;
            }

            if (index == 0)
            {
                result += wordToReplace;
            }
            else
            {
                result += str.SubstringNew(0, index) + " " + wordToReplace;
            }

            str = str.SubstringNew(index + searchWord.Length);


        } while (true);
    }
}
