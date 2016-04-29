using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            string content = File.ReadAllText(@"C:\Lesson\Example.txt");
            Console.WriteLine(content);
            Console.ReadLine();
        }
    }
}
