using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kommander.Data;
using Kommander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kommander.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase //without views support 
    {
        private readonly MockCommanderRepo _repo = new MockCommanderRepo();

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commands = _repo.GetAppCommands();
            return Ok(commands);
        }

        //GET api/commands/{int}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var command = _repo.GetCommandById(id);
            return Ok(command);
        }
    }
}
