namespace SecondWeekJanuary;
using System;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Please provide me the Number to find the Factorial: ");
            int NumberToFactorial = int.Parse(Console.ReadLine());

            FactorialResult(NumberToFactorial);

            string stringname = Console.ReadLine();
            validateDigitAvailableOrNot(stringname);
            string saveString = stringname.ToUpper();
            Console.WriteLine(saveString);  
        }
        catch(OverflowException)
        {
            Console.WriteLine("Result is overflow the maximum limit.");
        }
        catch(UpperCaseHandling ex)
        {
            Console.WriteLine(ex.Message);
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

    public static void FactorialResult(int num)
    {
        int FactorialResult = 1;

        {
            for (int i = 1; i <= num; i++)
            {
                FactorialResult = FactorialResult * i;
                if(FactorialResult > byte.MaxValue)
                {
                    throw new OverflowException();
                }
            }
        }
        Console.WriteLine(FactorialResult);
    }
    public static void validateDigitAvailableOrNot(string msg)
    {
        if (msg.Any(char.IsDigit))
        {
            throw new UpperCaseHandling("Error: String contain Digit.");

        }
    }
}

public class UpperCaseHandling: Exception
{
    public UpperCaseHandling(string msg): base(msg)
    {
    }
}