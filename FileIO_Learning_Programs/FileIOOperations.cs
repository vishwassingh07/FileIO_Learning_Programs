using System;
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
    }
}
