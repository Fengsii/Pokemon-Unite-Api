using PokemonUniteAPI.Models;
using PokemonUniteAPI.Models.DB;

namespace PokemonUniteAPI.Services
{
    public class PokemonUniteService
    {
        private readonly ApplicationContext _context;

        public PokemonUniteService(ApplicationContext context)
        {
            _context = context;
        }

        public List<PokemonUnite> GetlistPokemonUnite()
        {
            var data = _context.PokemonUnites.ToList();
            return data;
        }
    }
}
