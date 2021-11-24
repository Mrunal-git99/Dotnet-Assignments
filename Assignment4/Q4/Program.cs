using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileandDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("D:\\C# Program\\Assignments\\Assignmnet4\\FileDemo");
            if (dir.Exists)
            {
                Console.WriteLine("******Directory Info******");
                Console.WriteLine("Full Name= "+ dir.FullName);
                Console.WriteLine("Creation Time= "+ dir.CreationTime);
                Console.WriteLine("Last Written Time= " + dir.LastWriteTime);
                Console.WriteLine("Last Access Time= " + dir.LastAccessTime);
                Console.WriteLine("Parent= " + dir.Parent);
                Console.WriteLine("**************");
                Console.WriteLine("\n\n");

                FileInfo[] fi = dir.GetFiles();
                foreach (FileInfo fi2 in fi)
                {
                    Console.WriteLine("******File Info******");
                    Console.WriteLine("Name = "+ fi2.Name);
                    Console.WriteLine("Creation Time = "+ fi2.CreationTime);
                    Console.WriteLine("Last Written Time= "+ fi2.LastWriteTime);
                    Console.WriteLine("Extension = " + fi2.Extension);
                    Console.WriteLine("Directory Name = " + fi2.DirectoryName);
                    Console.WriteLine("Length = " + fi2.Length);
                    Console.WriteLine("**************");
                    Console.WriteLine("\n\n");

                }
            }
            else
            {
                dir.Create();
                Console.WriteLine("Directory Created");
            }
            Console.ReadKey();

        }
    }
}
