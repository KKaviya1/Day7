using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dircreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fpath;
            Console.WriteLine("enter diectory path");
            fpath = Console.ReadLine(); 
            DirectoryInfo di = new DirectoryInfo(fpath);   
            foreach (FileInfo fi in di.GetFiles())
            {
                Console.WriteLine("file name: \t" + fi.FullName);
                Console.WriteLine("\t file length:" + fi.Length);
                Console.WriteLine("\t file creationtime:" + fi.CreationTime);
                Console.ReadKey();  
            }

        }
    }
}
