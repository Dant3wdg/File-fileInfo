using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main (string[] args)
        {
            string path = @"C:\Users\Dante\Desktop\1.txt";
            string newPath = @"C:\Users\Dante\Desktop\2\1.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.MoveTo(destFileName: newPath);
            }
        }
        
    }
}
