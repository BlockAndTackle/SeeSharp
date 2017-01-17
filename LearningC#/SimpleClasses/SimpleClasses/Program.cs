using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // create instance of the car class object
            Car myNewCar = new Car(); // this is a new instance of an object of the type Car
            
            // populate it's properties
            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas Supreme";
            myNewCar.Year = 1996;
            myNewCar.Color = "Silver";

            // print out (get) the values of the properties for this new class instance (class object)
            string strMyNewCarInfo = myNewCar.Year + " " + myNewCar.Make + " " + myNewCar.Model + " - color: " + myNewCar.Color;
            CreateOutputAndFinish(strMyNewCarInfo);
            
            //////////////////////////////////////////////////////////////////////////////////////
            // 2 ways to call a method to get a number for car value
            // 1) we can create a helper method (as we have done below - determineMarketValue ) that returns the value somehow
            // OR
            // 2) we can create a class method - which we have created in the class and it is called DetermineMarketValue

            // 1) call a helper method to get the car value
            /*
            // call the helper method and pass it the car class instance object
            double dblHelperMethodDerivedMarketValueOfCar = determineMarketValue(myNewCar);
            // print out car value after returned from helper function
            string strHelperMethodDerivedMarketValueOfCar = string.Format("Car value = {0:C}", dblHelperMethodDerivedMarketValueOfCar);
            CreateOutputAndFinish(strHelperMethodDerivedMarketValueOfCar);
            */
            // 2) or call a class method to get the car value
            /*
            // call the class method - notice we do not pass anything we simply ask the class to return the value by calling the method on the class object
            double dblClassMethodDerivedMarketValueOfCar = myNewCar.DetermineMarketValue();
            string strClassMethodDerivedMarketValueOfCar = string.Format("Car value = {0:C}", dblClassMethodDerivedMarketValueOfCar);
            // print out car value after returned from helper function
            CreateOutputAndFinish(strClassMethodDerivedMarketValueOfCar);
            */
        }
        private static double determineMarketValue(Car car)
        // helper method for determining car value that will allow the user to pass in an instance of the car class
        // this is demonstrating that an object instance of the new care class can be used anywhere in code
        // even as an input parameter into a helper method
        {
            // just hardcoding the value below, but someday writing some code that retrieves the valus from the internet or an API would be what is needed
            // that value would then be returned as the car's value variable
            double carValue = 1000.0;
            return carValue;
        }

        private static void CreateOutputAndFinish(string strOutPut)
        {
            // write to the debug output window (seen after code is done running)
            // using Debug class requires a Using statment for using System.Diagnostics
            Debug.WriteLine("");
            Debug.WriteLine("------------");
            Debug.WriteLine("DEBUG OUTPUGT FOR TESTING PURPOSES TYPICALLY");
            Debug.WriteLine(strOutPut);
            Debug.WriteLine("------------");
            Debug.WriteLine("");

            // write to the console window
            Console.WriteLine(strOutPut);
            Console.WriteLine("");
            Console.WriteLine("Check output window in IDE for more output example");
            Console.WriteLine("");
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
    }

    class Car
    // create a class that can represent a basic car object type
    {
        // classes can contain code (methods), properties, or other classes - we call all of these: members or members of the class

        // class properties
        // there are many ways to define a property, this is a simple one in a class
        // using tab tab (macro in C#) we type the word Prop and then do tab, tab, which results in a new Property created that looks like this:
        // public int MyProperty { get; set; }
        // we will use that as a foundation to create a new peoperty in our class, then we will make 3 more properties of the car class using this method and populate as we go along...

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // class method
        // does the same thing as determineMarketValue helper method above

        public double DetermineMarketValue()
        {
            // again hard-code the value for now
            double carValue = 0.00;

            if (this.Year > 1990) // the "this" keyword allows you access all of the private and public members of a class
                carValue = 10000.00;
            else
                carValue = 2000.00;
                return carValue;
        }

    }
}
