using System.Numerics;

namespace GetSwapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SwapiController : ControllerBase
    {
        private readonly ISwapiService _personService;
        private readonly SwapiUrl _url;
        public SwapiController(ISwapiService personService, SwapiUrl url)
        {
            _personService = personService;
            _url = url;
        }

        [HttpGet("People")]
        public ActionResult<List<Person>> GetPerson()
        {
            var persons = _personService.GetList<Person>(_url.People);
            return Ok(persons);
        }
        [HttpGet("People/{id}")]
        public ActionResult<Person> GetPerson([FromRoute] int id)
        {
            var person = _personService.GetPerson<Person>(id, _url.People);
            return Ok(person);
        }

        [HttpGet("Films")]
        public ActionResult<List<Film>> GetFilms()
        {
            var persons = _personService.GetList<Film>(_url.Films);
            return Ok(persons);
        }
        [HttpGet("Films/{id}")]
        public ActionResult<List<Film>> GetFilms([FromRoute] int id)
        {
            var persons = _personService.GetPerson<Film>(id , _url.Films);
            return Ok(persons);
        }

        [HttpGet("Planet")]
        public ActionResult<List<Planet>> GetPlanets()
        {
            var persons = _personService.GetList<Planet>(_url.Planets);
            return Ok(persons);
        }
        [HttpGet("Planet/{id}")]
        public ActionResult<List<Planet>> GetPlanets([FromRoute] int id)
        {
            var persons = _personService.GetPerson<Planet>(id, _url.Films);
            return Ok(persons);
        }

        [HttpGet("Species")]
        public ActionResult<List<Specie>> GetSpecies()
        {
            var persons = _personService.GetList<Specie>(_url.Species);
            return Ok(persons);
        }
        [HttpGet("Species/{id}")]
        public ActionResult<List<Specie>> GetSpecies([FromRoute] int id)
        {
            var persons = _personService.GetPerson<Specie>(id, _url.Films);
            return Ok(persons);
        }

        [HttpGet("Starships")]
        public ActionResult<List<Starship>> GetStarships()
        {
            var persons = _personService.GetList<Starship>(_url.Starships);
            return Ok(persons);
        }
        [HttpGet("Starships/{id}")]
        public ActionResult<List<Starship>> GetStarships([FromRoute] int id)
        {
            var persons = _personService.GetPerson<Starship>(id, _url.Films);
            return Ok(persons);
        }

        [HttpGet("Vehicles")]
        public ActionResult<List<Vehicle>> GetVehicles()
        {
            var persons = _personService.GetList<Vehicle>(_url.Vehicles);
            return Ok(persons);
        }
        [HttpGet("Vehicles/{id}")]
        public ActionResult<List<Vehicle>> GetVehicles([FromRoute] int id)
        {
            var persons = _personService.GetPerson<Vehicle>(id, _url.Vehicles);
            return Ok(persons);
        }
    }
}
