using System;
using System.Net;

class Program
{
    static void Main()
    {
        // Prompt the user to input URLs, one URL per line, and press Enter to complete
        Console.WriteLine("Input the URLs (one URL per line, press Enter to complete):");

        try
        {
            while (true)
            {
                // Read the URL entered by the user
                string url = "https://drive.google.com/uc?export=download&id=1uzvIOWVVnxCNdBNDdnaKOVamoJXliFhx";

                // Check if the entered URL is null, empty, or contains only whitespace
                if (string.IsNullOrWhiteSpace(url))
                {
                    // Break out of the loop if the entered URL is empty or whitespace
                    break;
                }

                // Call the method to download content from the specified URL
                string localFilePathString = DownloadContent(url);
                StreamReader localFileRead = new StreamReader(localFilePathString);
                string read = localFileRead.ReadToEnd();
                Console.WriteLine(read);
            }
        }
        catch (WebException ex)
        {
            // Catch block for handling WebException when accessing URLs
            Console.WriteLine("Error accessing URL: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Catch block for handling other types of exceptions
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    // Method to download content from a specified URL and display it
    static string DownloadContent(string url)
    {
        // Create a new instance of WebClient to download content
        WebClient webClient = new WebClient();
        string localFilePath = @"D:\Sample Download.xlsx";
        webClient.DownloadFile(url, localFilePath);
        string TextInFile = File.ReadAllText(localFilePath);
        Console.WriteLine(TextInFile);
        //TextInFile.();

        return localFilePath;
    }
}