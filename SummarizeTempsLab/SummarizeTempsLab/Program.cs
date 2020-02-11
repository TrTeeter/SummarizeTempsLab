using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Average Temperature***");


            int tempthresh, temp, avg, above, below;

            string input = ("");
            string filepath = ("");
            string line = ("");
            bool Again = true;
            above = 0;
            below = 0;
            int sum = 0;
            int day = 0;
            



            Console.WriteLine("Enter File Name");
            filepath = Console.ReadLine();


            while (Again)

            {
                if (File.Exists(filepath))

                {
                    Console.WriteLine("Enter Temperature Threshold");
                    input = Console.ReadLine();


                    tempthresh = int.Parse(input);

                    using (StreamReader sr = File.OpenText(filepath))

                    {

                        while ((line = sr.ReadLine()) != null)

                        {
                            temp = int.Parse(line);

                            sum = temp + sum;
                            day++;

                            if (temp > tempthresh)

                            {
                                above++;
                            }
                            else
                            {
                                below++;
                            }
                            
                            
                        }
                        Console.WriteLine("Temperatures above the Threshold: " + above);
                        Console.WriteLine("Temperatures Equal or Below the Threshold: " + below);
                        avg = sum / day;

                        Console.WriteLine("Average Temperature: " + avg);
                    }
                    Console.WriteLine("Would You Like to Save your Values? yes or no");
                    input = Console.ReadLine();
                    
                    if (input=="yes")
                    {
                        using (var writer = new StreamWriter("Output.txt"))

                        {
                            writer.WriteLine("Temperatures above the Threshold: " + above);
                            writer.WriteLine("Temperatures Equal or Below the Threshold: " + below);
                            writer.WriteLine("Average Temperature: " + avg);
                        }
                    }
                    Console.WriteLine("Would You Like to Change Your Temperature? yes or no?");
                    input = Console.ReadLine();

                    if (input == "no")
                    {

                        Again = false;

                        Console.WriteLine("Thank You!");

                    }

                }
                else
                {

                    Console.WriteLine("File Does Not Exist, Please Try Again");


                    filepath = Console.ReadLine();

                }





            }

        }
    }
}
