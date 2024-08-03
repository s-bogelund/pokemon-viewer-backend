namespace PokemonViewerBackend.Models;

public class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Height { get; set; }
    public int Weight { get; set; }
    public string Types { get; set; } = string.Empty;
}