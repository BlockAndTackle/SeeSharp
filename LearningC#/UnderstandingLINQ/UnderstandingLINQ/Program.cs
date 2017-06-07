using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{ 
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // LINQ: Language-Integrated Query framework
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() // create & fill a colleciton of Car class objects with values
            {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2011},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2007},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            // 2 ways to form query syntax for LINQ: 1) Query 2) Method //

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // LINQ QUERY
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            - LINQ QUERY syntax - sample code to find all of the BMWs in the collection we have made:
            - bmws is a subset collection variable (var) created and filled by methods inside of System/Linq classes we can use to do queries
            - the var keyword in C# has a special meaning - it means that we are going to let the compiler figure out the appropriate data type for this collection...
            */

            /*
            var bmws = from qCar in myCars
                       where qCar.Make == "BMW" && qCar.Year == 2010
                       select qCar;
            */

            // order the elements of a collection
            // order the list of the cars by Year via LINQ METHOD syntax
            /*
            var orderedCars = from qCar in myCars
                              orderby qCar.Year descending
                              select qCar;
            */

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // LINQ QUERY
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            - LINQ METHOD syntax (uses <collection>.Where method) - sample code to find all of the BMWs in the collection we have made:
            - bmws is a subset collection variable (again using the var keyword) that is created and filled by methods inside of System/Linq classes we can use to do queries
            - the below method is called a Lambda expression in math (a mini-method for code) - where p is an arbitrary value/variable that represents the collection you created above in the code - can be anything...
            - basically this code below says, use the var to create a query where in myCars collection the collection item (p) is equal to or greater than
            */
            // var bmws = myCars.Where(p => p.Make == "BMW");

            // var bmws = myCars.Where(x => x.Make == "BMW"); // x works as well as a variable that represents the collection of cars in myCars

            // another version using yet another variable fr the collection (myCars) that also only returns BMWs where the Year = 2010:
            // var bmws = myCars.Where(ThismyCarsItem => ThismyCarsItem.Make == "BMW" && ThismyCarsItem.Year == 2010);

            // order the elements of a collection
            // order the list of the cars by Year via LINQ METHOD syntax
            // var orderedCars = myCars.OrderByDescending(x => x.Year);

            // find just the first item in the collection where the Make is BMW
            // var firstBMW = myCars.First(x => x.Make == "BMW"); //returns single car

            // now return the first car (in desc
            var firstBMW = myCars.OrderByDescending(x => x.Year).First(x => x.Make == "BMW");
            Console.WriteLine(firstBMW.VIN);

            // print out results
            // foreach (var qCar in bmws)
            /*
             * foreach (var qCar  in orderedCars)
	        {
		        Console.WriteLine("{0} {1} {2} {3}", qCar.Year, qCar.Make, qCar.Model, qCar.VIN);
	        }
            */

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}

