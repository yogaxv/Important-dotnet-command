using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreatingCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            // throw new NotImplementedException();
            var commands = new List<Command> {
                new Command{Id=1, HowTo="Boil an egg", Line=" Boil Water", Platform = "Ketty & Pan"},
                new Command{Id=2, HowTo="Cut Bread", Line=" Get a Knife", Platform = "Knife & Chopping Board"},
                new Command{Id=3, HowTo="Make coffe", Line=" Get Torakbika", Platform = "Cup"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            //throw new NotImplementedException();
            return new Command
            {
                Id = 0,
                HowTo = "Boil and egg",
                Line = "BoilWater",
                Platform = "ketti & "
            };
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
