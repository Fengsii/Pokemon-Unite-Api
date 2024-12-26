using Microsoft.AspNetCore.Mvc;
using PokemonUniteAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PokemonUniteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonUniteController : ControllerBase
    {
        private readonly PokemonUniteService _PokemonUniteservice;
        public PokemonUniteController(PokemonUniteService pokemonUniteService)
        {
            _PokemonUniteservice = pokemonUniteService;
        }

        // GET: api/<PokemonUniteController>
        [HttpGet]
        public IActionResult Get()
        {
            var pokemonUniteList = _PokemonUniteservice.GetlistPokemonUnite();
            return Ok(pokemonUniteList);
        }

        // GET api/<PokemonUniteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PokemonUniteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PokemonUniteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PokemonUniteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
