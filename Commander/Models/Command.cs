namespace Commander.Models
{
    /*  A model is a representation of the data in our application
        Below is a definition of the data(s) in our Commander application in the form of property definitions
        Therefore each "command" will be comprised of: Id, HowTo, Line, and Platform
        It is much like we would define an empty object variable in javascript (var person = {name:"brian", age:55,city:"Raleigh" }) etc...
          
        This is a simple example in terms of data - you can have multiple domain objects that include parent/child objects, etc.,etc. - 
        This can obviously became VERY complicated and require additional definitions/models etc...
    */
    
    public class Command
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }
    }
}