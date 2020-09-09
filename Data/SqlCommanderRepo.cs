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
        #region PRIVATE FIELDS

        private readonly CommanderContext _dbContext;

        #endregion

        #region CONSTRUCTORS

        public SqlCommanderRepo(CommanderContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        #endregion

        #region METHODS

        #region CreateCommand(Command cmd)

        public void CreateCommand(Command cmd)
        {
           if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _dbContext.Commands.Add(cmd);
        }

        #endregion

        #region  UpdateCommand(Command cmd)

        public void UpdateCommand(Command cmd)
        {
            //doing nothing
        }

        #endregion

        #region GetAllCommands()

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = _dbContext.Commands.ToList();
            return commands;
        }

        #endregion

        #region GetCommandById(int id)

        public Command GetCommandById(int id)
        {
            var command = _dbContext.Commands.FirstOrDefault(p => p.Id == id);
            return command;
        }

        #endregion

        #region  SaveChanges()

        public bool SaveChanges()
        {
            return (_dbContext.SaveChanges() >= 0);
        }





        #endregion

        #region DeleteCommand(Command cmd) 

        public void DeleteCommand(Command cmd)
        {
            if(cmd == null)
            {
                 throw new ArgumentNullException(nameof(cmd));
            }
            _dbContext.Commands.Remove(cmd);

        }

        #endregion



        #endregion

        #region Try Code // commented out

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

        #endregion
    }
}
