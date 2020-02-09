using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Average Temperature**");



            int tempthresh, temp, avg;





            string input = ("");

            string filepath = ("");

            string line = "";



            Console.WriteLine("Enter File Name");

            filepath = Console.ReadLine();



            bool Again = true;

            while (Again)

            {









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

                    using (StreamReader sr = File.OpenText(filepath))

                    {

                        int sum = 0;
                        int day = 0;

                        Console.WriteLine("Average Temperature:");

                        while ((line = sr.ReadLine()) != null)

                        {
                            day++;
                            temp = int.Parse(line);



                            sum = temp + sum;

                        }

                        avg = sum / day;

                        Console.WriteLine(avg);



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

                    Console.WriteLine("File Does Not Exist " +

                        "Please Try Again");



                    filepath = Console.ReadLine();

                }





            }

        }
    }
}
