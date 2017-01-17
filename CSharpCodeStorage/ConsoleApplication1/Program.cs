using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
namespace HelloWorld    
{
    class Program
    {
        static void Main(string[] args)
        {
            // a simple Hello World app
            Console.WriteLine("Hello World");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");Console.ReadKey();            

        }
    }
}

namespace AreAnagramTestNameSpace
{
    // To execute C#, please define "static void Main" on a class
    // named Solution.

    class AreAnagramTestClass
    {
        static void FuncAreAnagrams(string[] args)
    {
        AreAnagram("abc", "bgd");
    }

        // Example Anagrams
        // "abc" && "cba" && "bca"
        // “slot machines” & “cash lost in 'em”
        // “Mother-in-law” & “Woman Hitler”
        // "DorMiToRY” & “Dirty room”

        static bool AreAnagram(string s1, string s2)
        {

            if (s1.Length != s2.Length)
                return false;

            foreach (char c in s1)
            {
                int ix = s2.IndexOf(c);

                if (ix == -1)
                    return false;
            }

            return true;
        }
        // TODO
    class Solution
    {
        static void Main()
        {
            /*
             * stuff to add
             * sdfs
             * fsdfs
             * dfds
             * fsd
             * f
            */
        }
    }
    }

}

