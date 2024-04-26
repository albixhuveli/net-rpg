using net_RPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace net_RPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>() {
            new Character(),
            new Character { Id = 1, Name = "Ron"}
        };

        [HttpGet("GetAll")]
        
        public ActionResult<List<Character>> Get() 
        {
            return Ok(characters);
        }
        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id) 
        {      //method returns first character where id of the chracters equals given id
            return Ok(characters.FirstOrDefault(c => c.Id == id)); 
        }
        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return Ok(characters);
        }
        [HttpDelete]
        public ActionResult<List<Character>> DeleteCharacter(Character delCharacter)
        {
            characters.Remove(delCharacter);
            return Ok(characters);
        }
    }
}