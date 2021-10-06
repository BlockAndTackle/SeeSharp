using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    // class that implements the ICommanderRepo interface
    // below class is using implementation, not inheritance... though it might look like it
    // this is a not a derived class (which is inheritance)
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            throw new System.NotImplementedException();
        }

        public Command GetCommandById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetCommandsByPlatform(string Platform)
        {
            throw new System.NotImplementedException();
        }
    }

}