using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Kommander.Data;
using Kommander.Dtos;
using Kommander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kommander.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase //without views support 
    {
        private readonly IKommanderRepo _repo;
        private readonly IMapper _mapper;

        public CommandsController(
            IKommanderRepo repo,
            IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commands = _repo.GetAllCommands();
            var commandsdto = _mapper.Map<IEnumerable<CommandReadDto>>(commands);
            return Ok(commandsdto);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {
            var command = _repo.GetCommandById(id);
            if (command != null)
            {
                var commanddto = _mapper.Map<CommandReadDto>(command);
                return Ok(commanddto);
            }
            return NotFound();
        }
    }
}
