using Kommander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kommander.Data
{
    public class MockCommanderRepo : IKommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command
                {
                Id = 0,
                HowTo = "boil an egg ",
                Line = "boil water",
                Platform = "Kettle and pan"
                },
                new Command
                {
                Id = 2,
                HowTo = "do something cool  ",
                Line = "start doing it",
                Platform = "mind and matter"
                },
                new Command
                {
                Id = 3,
                HowTo = "get rich ",
                Line = "get knowledge",
                Platform = "good books"
                }

            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 0,
                HowTo = "boil an egg ",
                Line = "boil water",
                Platform = "Kettle and pan"
            };
        }
    }
}
