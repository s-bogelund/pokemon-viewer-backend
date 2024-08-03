using PokemonViewerBackend.Models;

namespace PokemonViewerBackend.Services;

public class PokemonService
{
    private List<Pokemon> _pokemon = new List<Pokemon>
    {
        new Pokemon { Id = 1, Name = "Bulbasaur", Height = 7, Weight = 69, Types = "Grass,Poison" },
        new Pokemon { Id = 2, Name = "Charmander", Height = 6, Weight = 85, Types = "Fire" },
        new Pokemon { Id = 3, Name = "Squirtle", Height = 5, Weight = 90, Types = "Water" }
    };

    public Pokemon? GetByName(string name)
    {
        return _pokemon.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
}