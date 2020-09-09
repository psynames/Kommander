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
        #region PRIVATE READ ONLY FIELDS

        private readonly IKommanderRepo _repo;
        private readonly IMapper _mapper;

        #endregion

        #region CONSTRUCTORS

        public CommandsController(
            IKommanderRepo repo,
            IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        #endregion

        #region METHODS

        #region GetAllCommands()

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commands = _repo.GetAllCommands();
            var commandsdto = _mapper.Map<IEnumerable<CommandReadDto>>(commands);
            return Ok(commandsdto);
        }

        #endregion

        #region GetCommandById(int id)

        //GET api/commands/{id}
        [HttpGet("{id}", Name = "GetCommandById")]
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

        #endregion

        //POST api/commands

        [HttpPost]
        public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto)
        {
            var commandModel = _mapper.Map<Command>(commandCreateDto);
            _repo.CreateCommand(commandModel);
            _repo.SaveChanges();

            var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);

            return CreatedAtRoute(nameof(GetCommandById),
                new {Id = commandReadDto.Id}, commandReadDto);
        }

        #endregion
    }
}
