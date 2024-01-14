namespace SecondWeekJanuary;
using System.Collections;
using System;
using System.IO;

class Program
{
    public static void Main()
    {
        Console.Write("Please provide me any number: ");
        int number = int.Parse(Console.ReadLine());

        try
        {
            validateWithinRange(number);
            Console.WriteLine("Number is within Limit.");
        }
        catch (validateRange ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
    public static void validateWithinRange(int num)
    {
        if (num < 0 || num > 1000)
        {
            throw new validateRange("Not Within Limit.");
        }
    }
}

public class validateRange: Exception
{
    public validateRange(string msg): base(msg)
    {

    }
}