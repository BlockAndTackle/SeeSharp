using System;
/* we are able to remove all of the other previously-provided using statements since we are not using them ha...
   Those are added as a convenience by Microsoft when we create a new project based on the console application template
   there are pre-created using statments for each kind of template for new projects in Microsoft Visual Studio when making C# projects
*/
using System.IO; // Add back System.IO since we need it again
using System.Net; // Add back System.Net since we need it

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Example 1
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // sample code borrowed from MSDN article about how to write to a text file in C#:

            /* Example #2: Write one string to a text file.
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text); 
            */

            // - Notice the entire namespace is included in the command - we can remove this and add this using steatement for System.IO:
            // - Below we remove the namespace reference and simplify the text string to make the code our own:

            /* string text = "We want to write this to our file.";
            File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text); //arbitrary folder location
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Example 2
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Another example concerning NameSpaces - borrowed from MSDN as well - this will get all of the HTML behind the page specified...
            // when the 2 lines below are originally pasted, we get an error because we did not have a reference to the System.Net assembly.
            // We need to add a using statment for that using System.Net etc
            WebClient client = new WebClient(); 
            string strReply = client.DownloadString("http://www.wix.com");

            // write all of that HTML to our text file as well:
            string text = "We want to write this to our file.";
            File.WriteAllText(@"C:\Users\brian\testfolder\WriteText.txt", text + strReply);

            // call my output method to display what we get back
            CreateTestOutput(strReply);
    
        }

        private static void CreateTestOutput(string strOutPut)
        {
            // write to the debug output window (seen after code is done running)
            // using Debug class requires a Using statment for using System.Diagnostics
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("------------");
            System.Diagnostics.Debug.WriteLine("DEBUG OUTPUT FOR TESTING PURPOSES...");
            System.Diagnostics.Debug.WriteLine(strOutPut);
            System.Diagnostics.Debug.WriteLine("------------");
            System.Diagnostics.Debug.WriteLine("");

            // write to the console window
            Console.WriteLine("");
            Console.WriteLine("output: ");
            Console.WriteLine(strOutPut);
            Console.WriteLine("");
            Console.WriteLine("Check output window in IDE for more output - Press any key to return...");
            Console.ReadKey();
        }
    }
}
