using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]           // api/commands
    [Route("api/commands")]
    public class CommandsController : ControllerBase
    {
        // Prepare repository using mock Data
        // private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        // Prepare repository using Dependency injection
        // Create Dependency injection
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }        
        
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDto>> GetAllCommand()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
        }

        [HttpGet("{id}", Name ="GetCommandById")]                   // GET api/commands/{id}
        public ActionResult <CommandReadDto> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            if(commandItem != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }

            return NotFound();
        }

        // POST api/commands
        [HttpPost]
        public ActionResult <CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto)
        {
            var  commandModel = _mapper.Map<Command>(commandCreateDto);

            _repository.CreatingCommand(commandModel);
            _repository.SaveChanges();

            var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);

            // return Ok(CommandReadDto);
            return CreatedAtRoute(
                nameof(GetCommandById), 
                new {Id = commandReadDto.Id},
                commandReadDto            
            );
        }
    }
}