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
            try
            {
                string content = File.ReadAllText(@"C:\Lesson\Example.txt"); 
                // Find all possible exceptions for the method File.ReadAllText
                // Create sensible human-readable messages to help the user troubleshoot the issue
                // Send the information back to yourself for future bug fixing or giving the user a solution.
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("The file may not exist or is not named 'Example.txt'.");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(@"The directory C:\Lesson\ may not exist or is not named correctly.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                // Cleaning up, setting values to null, closing database connections.
                Console.WriteLine("The application will close.");
            }
            Console.ReadLine();
        }
    }
}
