using Microsoft.AspNetCore.Mvc;
using Restaurante_API.Models;
using Restaurante_API.Repositories;

namespace Restaurante_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantesControllers : ControllerBase
    {
        private readonly IRestauranteRepository _restauranteRepository;

        public RestaurantesControllers(IRestauranteRepository restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }

        // /api/restaurantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Restaurantes>>> GetRestaurantes()
        {
            var restaurantes = await _restauranteRepository.GetRestaurantes();
            return Ok(restaurantes);
        }

        // /api/restaurantes/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Restaurantes>> GetRestauranteById(int id)
        {
            var restaurante = await _restauranteRepository.GetByIdRestaurante(id);

            if (restaurante == null)
            {
                return NotFound();
            }

            return Ok(restaurante);
        }

        // api/restaurantes
        [HttpPost]
        public async Task<ActionResult<Restaurantes>> PostRestaurante([FromBody] Restaurantes restaurantes)
        {
            await _restauranteRepository.AddAsync(restaurantes);
            return CreatedAtAction(nameof(GetRestauranteById), new { id = restaurantes.Id }, restaurantes);
        }

        // api/restaurantes/id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRestaurantes([FromBody] Restaurantes restaurantes, int id)
        {
            if (id != restaurantes.Id)
            {
                return BadRequest("ID do restaurante não corresponde ao parâmetro de URL.");
            }

            await _restauranteRepository.UpdateAsync(restaurantes);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurantes(int id)
        {
            var restaurante = await _restauranteRepository.GetByIdRestaurante(id);

            if (restaurante == null)
            {
                return NotFound();
            }

            await _restauranteRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
