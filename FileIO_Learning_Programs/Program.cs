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
        }
        
        public static void DoesFileExist(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("File Exists ");
            }
            else
            {
                Console.WriteLine("File Does Not Exist");
            }
        }
    }
}