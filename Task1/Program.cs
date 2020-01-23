using System;

public class Program
{
    delegate double Result(params double[] num);

    public static void Main()
    {
        bool finish = false;
        Console.Write("Available Actions: +, -, *, / \nTo finish - double-press Enter\n\n");
        Calc.Print();
        Console.Write("Enter the number: ");
        double num = Convert.ToDouble(Console.ReadLine());
        Calc.Add(num);
        do
        {   
            Console.Write("Action: ");
            string action = Console.ReadLine();
            if (!String.IsNullOrEmpty(action))
            {
                Console.Write("Number: ");
                string tmp = Console.ReadLine();
                if (!String.IsNullOrEmpty(tmp))
                {
                    num = Convert.ToDouble(tmp);


                    if (action == "+")
                    {
                        Calc.Add(num);

                    }
                    else if (action == "-")
                    {
                        Calc.Differ(num);

                    }
                    else if (action == "*")
                    {
                        Calc.Multiplication(num);

                    }
                    else if (action == "/")
                    {
                        try
                        {
                            Calc.Division(num);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("ERROR: Division by zero");
                        }

                    }
                    Calc.Print();

                }
                else
                {
                    finish = true;
                }
            }
            else
            {
                finish = true;
            }

        } while (!finish);

     Console.ReadLine();
    }
}

public static class Calc
{
   public static double state = 0;

    public static double Add(double num)
    {
        state += num;
        return state;
    }

    public static double Differ(double num)
    {
        state -= num;
        return state;
    }

    public static double Multiplication(double num)
    {
        state *= num;
        return state;
    }

    public static double Division(double num)
    {
        if (num == 0)
        {
            throw new DivideByZeroException();
        }
        state /= num;
        return state;
    }

    public static void Print()
    {
        Console.WriteLine($"Result: {state} \n");
    }
}