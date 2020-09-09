using AutoMapper;
using Kommander.Dtos;
using Kommander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kommander.Profiles
{
    public class CommandsProfile : Profile //from automaper
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
        }
    }
}
