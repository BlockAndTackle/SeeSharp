using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);

            myTimer.Elapsed += myTimer_Elapsed;

            myTimer.Start();

            Console.ReadLine();

        }

        static void myTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Elapsed: {0:HH:mm:ss.ffff}", e.SignalTime);
            // throw new NotImplementedException();
        }
    }
}
