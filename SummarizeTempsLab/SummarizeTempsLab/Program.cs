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
                    string line = "";
                        
                    while ((line = sr.ReadLine()) != null)
                    {
                        temp = int.Parse(line);

                       
                          
                            
                        if (temp>tempthresh)
                        {
                            Console.WriteLine("Temperature above Threshhold");
                            Console.WriteLine(temp);
                            
                        }
                        
                    }
                       
                
                }

            }
            else 
            {
                Console.WriteLine("File Does Not Exist");
                Console.ReadLine();
            }
        }
    }
}
