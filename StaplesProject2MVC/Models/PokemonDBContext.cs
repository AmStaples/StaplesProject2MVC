using Microsoft.EntityFrameworkCore;

namespace StaplesProject2MVC.Models
{
    public class PokemonDBContext : DbContext
    {
        public PokemonDBContext(DbContextOptions<PokemonDBContext> options) : base(options) {
        
        }

        public DbSet<Pokemon> Pokemons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pokemon>().HasData(
                new Pokemon {Id = 815, Name = "Cinderace", Hp = 80, Attack = 116, Defense = 75, SpAttack = 65, SpDefense = 75, Speed = 119 },
                new Pokemon {Id = 812, Name = "Rillaboom", Hp = 100, Attack = 125, Defense = 90, SpAttack = 60, SpDefense = 70, Speed = 85},
                new Pokemon {Id = 818, Name = "Inteleon", Hp = 70, Attack = 85, Defense = 65, SpAttack = 125, SpDefense = 65, Speed =  120});
        }
    }
}
