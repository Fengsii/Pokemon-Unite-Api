using Microsoft.EntityFrameworkCore;
using PokemonUniteAPI.Models.DB;

namespace PokemonUniteAPI.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {

        }

        public virtual DbSet<PokemonUnite> PokemonUnites { get; set; }

    }
}
