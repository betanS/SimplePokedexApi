using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokedexApi.Models;

namespace PokedexApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly AppDbContext _context;
        public PokemonController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetPokemons")]
        public async Task<IActionResult> GetPokemon()
        {
            var result = await _context.Pokemon.Select(x => new Pokemon
            {
                Id = x.Id,
                Name = x.Name,
                Type = x.Type,
                Weight = x.Weight,
                Height = x.Height
            }).ToListAsync();

            return Ok(result);
        }

        [HttpPost("CreatePokemon")]
        public async Task<IActionResult> CreatePokemon([FromBody] Pokemon pokemon)
        {
            _context.Pokemon.Add(pokemon);
            await _context.SaveChangesAsync();

            return Ok(pokemon);
        }

        [HttpPut("EditPokemon/{id}")]
        public async Task<IActionResult> EditPokemon(int id, [FromBody] Pokemon pokemon)
        {
            var rows = await _context.Pokemon.Where(x => x.Id == id)
                .ExecuteUpdateAsync(x => x
                    .SetProperty(x => x.Name, pokemon.Name)
                    .SetProperty(x => x.Type, pokemon.Type)
                    .SetProperty(x => x.Height, pokemon.Height)
                    .SetProperty(x => x.Weight, pokemon.Weight));

            return Ok(pokemon);
        }

        [HttpGet("DeletePokemon")]
        public async Task<IActionResult> DeletePokemon(int id)
        {
            var rows = await _context.Pokemon.Where(x => x.Id == id).ExecuteDeleteAsync();

            return Ok(true);
        }
    }
}
