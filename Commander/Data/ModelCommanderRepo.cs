using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data 
{
    public class ModelCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id = 0, HowTo="Nesto napisano", Line="Nesto",Platform="Bla bla"},
                new Command {Id = 1, HowTo="Napisano", Line="NeNap",Platform="Bla"},
                new Command {Id = 2, HowTo="NestoNapisano", Line="NestoNap",Platform="Alooha"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
           return new Command {Id = 0, HowTo="Nesto napisano", Line="Nesto",Platform="Bla bla"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}