using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]           // api/commands
    [Route("api/commands")]
    public class CommandsController : ControllerBase
    {
        // Prepare Data
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommand()
        {
            var commandItems = _repository.GetCommands();

            return Ok(commandItems);
        }

        [HttpGet("{id}")]                   // GET api/commands/{id}
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);
        }
    }
}