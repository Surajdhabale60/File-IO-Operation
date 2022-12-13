using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    public class FileOperation
    {
        string filePath = @"C:\Users\suraj\source\repos\217 .Net\File-IO-Operation\FileIO\FileIO\Operation.txt";
        public void FileExist() 
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("Given File Exists");
            }
            else
            {
                Console.WriteLine("File Does not Exists");
            }
        }
    }
}
