using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fFolder = "F:\\";
            string newDir;
            Console.WriteLine("enter new directory name:");
            newDir = Console.ReadLine();
            string fPath = fFolder + newDir;
            DirectoryInfo directoryInfo = new DirectoryInfo(fPath);
            if (directoryInfo.Exists)
            {
                Console.WriteLine($"directory {newDir} already exist");
            }
            else
            {
                directoryInfo.Create();
                Console.WriteLine($"directory {newDir} creation on {fPath} success");
            }
            Console.ReadKey();


        }
    }
}
