namespace SecondWeekJanuary;
using System.Collections;
using System;


class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Welcome to the New Application.");

            //takeInputsAgain:
            Console.WriteLine("Please enter the first Number.: ");
            double Num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Second Number.:");
            double Num2 = double.Parse(Console.ReadLine());

            if (Num2 != 0)
            {
                double Result = Num1 / Num2;
                Console.WriteLine($"Result is {Result}");
            }
            else
            {
                Console.WriteLine("Division by zero is not possible.");
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Error: Non numberic value.");
            //goto takeInputAgain;
        }
        catch(Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
