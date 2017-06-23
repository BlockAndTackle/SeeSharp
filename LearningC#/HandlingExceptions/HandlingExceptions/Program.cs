using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string strContent = File.ReadAllText(@"C:\home\brian\DEV\SeeSharp\LearningC#\Lessons from Bob Tabor (C# Fundamentals for Absolute Beginners)\Lesson_22\Exampl.txt");
                Console.WriteLine(strContent); Console.WriteLine(""); Console.WriteLine("Press any key to end..."); Console.ReadKey();
            }
            catch (FileNotFoundException exError)
            {
                Console.WriteLine("There was a problem...");
                Console.WriteLine("");
                Console.WriteLine();
                Console.ReadLine();
                // ErrorCatchAndRelease(exError);
            }
            catch (DirectoryNotFoundException exError)
            {
                
                // ErrorCatchAndRelease(exError);
            }
            catch (Exception exError)
            {
                
                // ErrorCatchAndRelease(exError);
            }

        }

        static void ErrorCatchAndRelease(Exception exFoo)
        {

            if (exFoo = FileNotFoundException)
            {
                string exMessage = "The file was not found - be sure to type the correct filename";
            }
            Console.WriteLine("There was a problem...");
            Console.WriteLine("");
            Console.WriteLine();
            Console.ReadLine();
            // throw;
        }

    }
}
