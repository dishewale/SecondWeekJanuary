namespace SecondWeekJanuary;
using System.Collections;
using System;

class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Please provide me the number.: ");
            double Number = double.Parse(Console.ReadLine());
            validatePositiveNumber(Number);

            Console.WriteLine($"Valid Input: {Number}");
        }
        catch(NegativeNumberException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Format.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }

    public static void validatePositiveNumber(double num)
    {
        if(num <= 0)
        {
            //throw new Exception("Negative number.");
            throw new NegativeNumberException("Negative Number is not Allowed.");
            //Exception NegativeNumberException = new Exception("Negative Number is not Allowed.");
        }

    }
}

class NegativeNumberException: Exception
{
    public NegativeNumberException(string msg) : base(msg)
    {
    }
}