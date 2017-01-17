using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new instance of class object
            // the parentheses Car below indicates the invocation of a method to create a new instance - this is referred to as a Constructor
            // This basically calls the Car() method
            Car myCar = new Car();

            // create a reference to the new myCar object (adds 1 to the reference count in C#)
            // does not use the constructor since it is a reference to the first already constructed class object
            Car myOtherCar = myCar;

            // call overloaded method and pass variables

            Car myThirdCar = new Car("Ford", "Explorer", 1989, "Blue");
            
            // close references to the objects
            myOtherCar = null;
            myCar = null;
        }
    }

    class Car
    {
        // class object properties
        // you can use intellisense to create new properties through the use of "prop <tab> <tab>" to create a new property skeletone that looks like this 
        // public int MyProperty { get; set; } - a nice start for creating new class properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        
        // some more properties
        public double OriginalPrice { get; set; } // additional proprty added for this exmaple
        public int MyProperty { get; set; }

        public Car()
        // constructor method of the car class
        // assigns or gets a default value for a property of the class object (in this case assigns a value for "Make" property
        {
            // you could load this from a configuration file or database but we will hard code the value
            // inherent value of the Car class can be established as follows so that whenever a new instance of this class is instantiated, 
            // it already has the property value of .Make set to "Nissan"
            this.Make = "Nissan";
        }

        public Car(string strMake, string strModel, int intYear, string strColor)
        // overloaded constructor method of the Car class
        {
            Make = strMake;
            Model = strModel;
            Year = intYear;
            Color = strColor;
        }

        // very simple class method - returns a value or reference when called fomr another place in code
        private static double DetermineMarketValueRef(Car _car)
        {
            // hard-code value of carValue
            double carValue = 100.00;
            return carValue;
        }


        // another class method - returns a value or reference when called fomr another place in code
        // takes no passed 
        public double DetermineMarketValue()
        {
            // hard-code value of carValue
            double carValue = 0.00;

            if (this.Year > 1990) // the "this" keyword allows you access all of the private and public members of a class
                carValue = 10000.00;
            else
                carValue = 2000.00;
            return carValue;
        }
    }
}
