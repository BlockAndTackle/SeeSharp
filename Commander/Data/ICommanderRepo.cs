using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo // our method signatures or definitions
    {   
        // method that gives the consumer back a list of all commands that we ave in our data repo
        // it is an enumerable return type because it is an enumerable list
        // so an enumerable list <returned from a command> called "GetAppCommands"
        IEnumerable<Command> GetAppCommands();
        
        // method that returns a single command by Id
        // a basic command called "GetCommandById" that takes an integer called Id that correlates to the command...
        Command GetCommandById(int Id);

        // we can add more methods to this interface here as we move along and they are needed

        // I made this one - it might be wrong lol...
        IEnumerable<Command> GetCommandsByPlatform(string Platform);
    }
}