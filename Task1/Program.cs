using System;
using System.Collections.Generic;

public class Program
{
    delegate double Result(params double[] num);

    public static void Main()
    {
        List<double> numbersSet = new List<double>();
        bool finish = false;

        Console.WriteLine("Select action: \t+ \t- \t* \t:");
        string action = Console.ReadLine();

        do
        {
            Console.WriteLine("Enter the number or press 'Enter' to display the result:");
            string tmp = Console.ReadLine();
            if (!String.IsNullOrEmpty(tmp))
            {
                numbersSet.Add(Convert.ToDouble(tmp));
            }
            else
            {
                finish = true;
            }
        } while (!finish);

        if (action == "+")
        {
            Result res = Calc.Add;
            Console.WriteLine($" Result: {res(numbersSet.ToArray())}");
        }
        else if (action == "-")
        {
            Result res = Calc.Differ;
            Console.WriteLine($" Result: {res(numbersSet.ToArray())}");
        }
        else if (action == "*")
        {
            Result res = Calc.Multiplication;
            Console.WriteLine($" Result: {res(numbersSet.ToArray())}");
        }
        else if (action == ":")
        {
            Result res = Calc.Division;
            try
            {
                Console.WriteLine($" Result: {res(numbersSet.ToArray())}");
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR: Division by zero");                
            }
            
        }

        Console.ReadLine();
    }
}

public static class Calc
{
    public static double Add(params double[] num)
    {
        double result = 0;
        foreach (double elem in num)
        {
            result += elem;
        }
        return result;
    }

    public static double Differ(params double[] num)
    {
        double result = num[0];
        for (int i = 1; i < num.Length; i++)
        {
            result -= num[i];
        }
        return result;
    }

    public static double Multiplication(params double[] num)
    {
        double result = 1;
        foreach (double elem in num)
        {
            result *= elem;
        }
        return result;
    }

    public static double Division(params double[] num)
    {
        double result = num[0];
        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] == 0)
            {
                throw new DivideByZeroException();
            }
            result /= num[i];
        }
        return result;
    }
}