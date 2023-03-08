using GetSwapi.Interfaces;
using GetSwapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace GetSwapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public ActionResult<List<Person>> GetPersons()
        {
            var persons = _personService.GetPersons();

            return Ok(persons);
        }

        [HttpGet("{id}")]
        public ActionResult<Person> GetPerson([FromRoute]int id)
        {
            if(id <= 0)
                return BadRequest("ID requires to be Greater than zero");

            var person = _personService.GetPerson(id);

            return Ok(person);
        }
    }

}
