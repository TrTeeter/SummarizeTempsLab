using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
  
       
            int tempthresh;
            int temp;
           
            string input = ("");
            string filepath = ("");
            string line = "";


            Console.WriteLine("***Average Temperature**");
            Console.WriteLine("Enter File Name");

            filepath = Console.ReadLine();

            if (File.Exists(filepath))
            {
                Console.WriteLine("Enter Temperature Threshold");
                input = Console.ReadLine();
                tempthresh = int.Parse(input);


                using (StreamReader sr = File.OpenText(filepath))
                {
                    Console.WriteLine("Temperature above Threshhold:");

                    while ((line = sr.ReadLine()) != null)
                    {
                        temp = int.Parse(line);




                        if (temp >= tempthresh)
                        {
                            
                            Console.WriteLine(temp);

                        }

                    }

                   

                }
                using (StreamReader sr = File.OpenText(filepath))
                {
                    Console.WriteLine("Temperature at or Below Threshhold:");
                    while ((line = sr.ReadLine()) != null)
                    {
                        temp = int.Parse(line);




                        if (temp <= tempthresh)
                        {
                           
                            Console.WriteLine(temp);

                        }


                    }
                }


                Console.WriteLine("Thank You! Have a Nice Day");
            }
            else
            {
                Console.WriteLine("File Does Not Exist " +
                    "Please Try Again");
                Console.ReadLine();
            }
        }
    }
}
