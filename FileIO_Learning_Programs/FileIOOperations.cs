﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Learning_Programs
{
    public class FileIOoperations
    {
        //Checking Whether File Exists Or NOt
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
        //Reading Line By Line
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
        //Reading All Line At Once
        public static void ReadAtOnce(string filePath)
        {
            if (DoesFileExist(filePath))
            {
                string line = File.ReadAllText(filePath);
                Console.WriteLine(line);
            }
        }
        //Copying The File
        public static void CopyFile(string filePath)
        {
            string path = @"D:\RFP BATCH 157\FileIO Learning Prorams\FileIO_Learning_Programs\FileIO_Learning_Programs\FileIOForCopy.txt";
            string copiedFilePath = @"D:\RFP BATCH 157\FileIO Learning Prorams\FileIO_Learning_Programs\FileIO_Learning_Programs\CopiedFile2IO.txt";
            File.Copy(path, copiedFilePath);
            Console.ReadKey();
        }
        //Deleting The File
        public static void DeleteFile(string filePath)
        {
            if (DoesFileExist(filePath))
            {
                File.Delete(filePath);
            }
            else
            {
                Console.WriteLine("File Does Not Exist");
            }
        }
        //Reading File From StreamReader
        public static void ReadFromStreamReader(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                reader.Close();
            }
        }
        //Writing File From StreamWriter
        public static void WriteFromStreamWriter(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Bangalore's weather is awesome");
                writer.Close();

                Console.WriteLine(File.ReadAllText(filePath));
            }
        }
    }
}
