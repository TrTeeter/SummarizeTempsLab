using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
  
            string filepath = "temps.txt";
            int tempthresh;
            string input = ("");

            
            Console.WriteLine("***Average Temperature**");
            Console.ReadLine();

            if (File.Exists(filepath))
            { 
                Console.WriteLine("Enter Temperature Threshold");
                Console.WriteLine();

                tempthresh = int.Parse(input);

                using (var writer = new StreamWriter()) ;

            }
            else 
            {
                Console.WriteLine("File Does Not Exist");
                Console.ReadLine();
            }
        }
    }
}
