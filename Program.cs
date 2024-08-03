using PokemonViewerBackend.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<PokemonService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHttpsRedirection();
}

// Define routes
app.MapGet("/", () => "Hello, Pokémon Viewer!");

app.MapGet("/pokemon/{name}", (string name, PokemonService pokemonService) =>
{
    var pokemon = pokemonService.GetByName(name);
    if (pokemon == null)
        return Results.NotFound($"Pokémon {name} not found");
    return Results.Ok(pokemon);
});

app.Run();