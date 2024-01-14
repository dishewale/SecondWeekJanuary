namespace SecondWeekJanuary;
using System.Collections;
using System;
using System.IO;

class Program
{
    public static void Main()
    {
        Console.Write("Provide the file Path: ");
        string FilePath = Console.ReadLine();

        try
        {
            StreamReader readFile = new StreamReader(FilePath);
            {
                Console.WriteLine("File opened Successfully");
            }
            
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("File not Found.");
        }
        catch(IOException ex)
        {
            Console.WriteLine("Error occured while accessing the file: " + ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}