using System;
namespace FileIO_Learning_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The File IO Learning Programs\n========================================");
            string filePath = @"D:\RFP BATCH 157\FileIO Learning Prorams\FileIO_Learning_Programs\FileIO_Learning_Programs\FileIO.txt";
            bool end = true;
            Console.WriteLine("1. Checking File Exists Or Not\n2. Reading Line By Line\n3. Reading All Lines At Once\n4. " +
                "End The Program");
            while (end)
            {
                Console.Write("Choose an option to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FileIOoperations.DoesFileExist(filePath);
                        break;
                    case 2:
                        FileIOoperations.ReadLineByLine(filePath);
                        break;
                    case 3:
                        FileIOoperations.ReadAtOnce(filePath);
                        break;
                    case 4:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option ");
                        break;
                       
                }
            }
        }
        
       
       
       
       
    }
}