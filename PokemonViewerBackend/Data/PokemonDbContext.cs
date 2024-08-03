using Microsoft.EntityFrameworkCore;
using PokemonViewerBackend.Models;

namespace PokemonViewerBackend.Data;

public class PokemonDbContext : DbContext
{
    public PokemonDbContext(DbContextOptions<PokemonDbContext> options)
        : base(options)
    {
    }

    public DbSet<Pokemon> Pokemon => Set<Pokemon>();
}