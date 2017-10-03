using System;

namespace ConsoleAppSample
{
    class Program
    {
        static void Main(string[] args)
        {
			string strName;
			Console.WriteLine("Please enter your name below:");
			strName = Console.ReadLine();
			Console.WriteLine($"Hello {strName}!!!");
        }
    }
}
