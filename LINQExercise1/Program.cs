using System;
using System.Linq;
using System.Collections;
using System.Collections.Concurrent;
using System.Text;
using System.IO;

namespace SecondWeekJanuary
{
    class Program
    {
        public static void Main()
        {
            string[] Files = Directory.GetFiles(@"D:\study\NEW FILES\ABFM CAIIB");
            double TotalLength = 0;
            
            foreach(string File in Files)
            {
                TotalLength += File.Length;
            }

            Console.WriteLine(TotalLength);
            Console.WriteLine("new line");
        }
    }
}
