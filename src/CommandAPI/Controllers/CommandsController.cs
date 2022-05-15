using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CommandAPI.Data;
using CommandAPI.Models;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandAPIRepo Repository;

        public CommandsController(ICommandAPIRepo repository)
        {
            Repository = repository;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commands = Repository.GetAllCommands();
            return Ok(commands);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var command = Repository.GetCommandById(id);
            
            if (command == null)
            {
                return NotFound();
            }

            return Ok(command);
        }
    }
}
