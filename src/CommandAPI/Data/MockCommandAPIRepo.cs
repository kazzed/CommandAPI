using CommandAPI.Models;
using System.Collections.Generic;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void CreateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command
                {
                    Id = 0,
                    HowTo = "How to generate a migration",
                    CommandLine = "dotnet ef migrations add <Name of Migration>",
                    Platform = ".NET Core EF"
                },
                new Command
                {
                    Id = 1,
                    HowTo = "How to run migrations",
                    CommandLine = "dotnet ef database update",
                    Platform = ".NET Core EF"
                },
                new Command
                {
                    Id = 2,
                    HowTo = "How to list active migrations",
                    CommandLine = "dotnet ef migrations list",
                    Platform = ".NET Core EF"
                }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 0,
                HowTo = "How to generate a migration",
                CommandLine = "dotnet ef migrations add <Name of Migration>",
                Platform = ".NET Core EF"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }
    }
}
