using Kommander.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kommander.Data
{
    public class SqlCommanderRepo : IKommanderRepo
    {
        private readonly CommanderContext _dbContext;

        public SqlCommanderRepo(CommanderContext dbcontext)
        {
            _dbContext = dbcontext;
        }


        public IEnumerable<Command> GetAllCommands()
        {
            var commands = _dbContext.Commands.ToList();
            return commands;
        }

        public Command GetCommandById(int id)
        {
            var command = _dbContext.Commands.FirstOrDefault(p => p.Id == id);
            return command;
        }





        //public async Task<IEnumerable<Command>> GetAllCommands()
        //{
        //    var commands = await _dbContext.Commands.ToListAsync();
        //    return commands;
        //}

        //public async Task<Command> GetCommandById(int id)
        //{
        //    return await _dbContext.Commands.FindAsync(id);
        //}

        //public async Task<Command> GetCommandById(int id)
        //{
        //    return await _dbContext.Commands.FirstOrDefaultAsync(p => p.Id ==id);
        //}
    }
}
