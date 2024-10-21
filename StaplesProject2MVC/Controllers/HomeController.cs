using Microsoft.AspNetCore.Mvc;
using StaplesProject2MVC.Models;
using System.Diagnostics;

namespace StaplesProject2MVC.Controllers
{
    public class HomeController : Controller
    {
        private PokemonDBContext Pokedex {  get; set; }

        public HomeController(PokemonDBContext context)
        {
            Pokedex = context;
        }

        public IActionResult Index()
        {
            var pokemon = Pokedex.Pokemons.OrderBy(p => p.Id).ToList();
            return View();
        }

        public IActionResult Delete(int id) {
            Pokemon del = Pokedex.Pokemons.Find(id);
            Pokedex.Pokemons.Remove(del);
            Pokedex.SaveChanges();
            var p = Pokedex.Pokemons.ToList();
            return View("Index", p);
        }

        [HttpGet]
        public IActionResult Edit(int id) {
            var p = Pokedex.Pokemons.Find(id);
            return View("PokemonBuilder", p);
        }

        [HttpPost]
        public IActionResult Edit(Pokemon p)
        {
            if(ModelState.IsValid)
            {
                var pokemonList = Pokedex.Pokemons.ToList();
                List<int> IDlist = new List<int>();

                foreach (var pokemon in pokemonList) { 
                    IDlist.Add(pokemon.Id);
                }

                if(IDlist.Contains(p.Id)) {
                    Pokedex.Pokemons.Update(p);
                } else { 
                    Pokedex.Pokemons.Add(p);
                }

                return View("Index");
            }
        }
    }
}
