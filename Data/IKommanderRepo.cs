﻿using Kommander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kommander.Data
{
    public interface IKommanderRepo
    {
        //    Task<IEnumerable<Command>> GetAllCommands();
        //    Task<Command> GetCommandById(int id);

        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        bool SaveChanges();

    }
}
