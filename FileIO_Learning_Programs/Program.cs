using System;
namespace FileIO_Learning_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The File IO Learning Programs\n========================================");
            string filePath = @"D:\RFP BATCH 157\FileIO Learning Prorams\FileIO_Learning_Programs\FileIO_Learning_Programs\FileIO.txt";
            DoesFileExist(filePath);
            ReadLineByLine(filePath);
        }
        
        public static bool DoesFileExist(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("File Exists ");
                return true;
            }
            else
            {
                Console.WriteLine("File Does Not Exist");
                return false;
            }
        }
        public static void ReadLineByLine(string filePath)
        {
            if (DoesFileExist(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                //return true
            }
        }
    }
}