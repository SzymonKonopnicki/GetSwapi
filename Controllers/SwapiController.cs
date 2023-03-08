using System.Numerics;

namespace GetSwapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SwapiController : ControllerBase
    {
        private readonly IPersonService _personService;
        public SwapiController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("People")]
        public ActionResult<List<Person>> GetPersons()
        {
            var persons = _personService.GetPersons();

            return Ok(persons);
        }

        [HttpGet("People/{id}")]
        public ActionResult<Person> GetPerson([FromRoute]int id)
        {
            if(id <= 0)
                return BadRequest("ID requires to be Greater than zero");

            var person = _personService.GetPerson(id);

            return Ok(person);
        }

        [HttpGet("Film")]
        public ActionResult<List<Film>> GetFilms()
        {
            throw new NotImplementedException();
        }
        [HttpGet("Planet")]
        public ActionResult<List<Planet>> GetPlanets()
        {
            throw new NotImplementedException();
        }
        [HttpGet("Species")]
        public ActionResult<List<Specie>> GetSpecies()
        {
            throw new NotImplementedException();
        }
        [HttpGet("Starships")]
        public ActionResult<List<Starship>> GetStarships()
        {
            throw new NotImplementedException();
        }
        [HttpGet("Vehicles")]
        public ActionResult<List<Vehicle>> GetVehicles()
        {
            throw new NotImplementedException();
        }
    }
}
