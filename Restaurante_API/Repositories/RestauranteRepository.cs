using Microsoft.EntityFrameworkCore;
using Restaurante_API.Data;
using Restaurante_API.Models;

namespace Restaurante_API.Repositories
{
    public class RestauranteRepository : IRestauranteRepository
    {
        private readonly AppDbContext _context;

        public RestauranteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Restaurantes>> GetRestaurantes()
        {
            return await _context.Restaurantes.Include(p => p.Pratos).ToListAsync();
        }

        public async Task<Restaurantes> GetByIdRestaurante(int id)
        {
            var restaurante = await _context.Restaurantes.Include(p => p.Pratos).FirstOrDefaultAsync(r => r.Id == id);

            if (restaurante == null)
            {
                throw new KeyNotFoundException($"Restaurante com ID {id} não encontrado.");
            }

            return restaurante;
        }

        public async Task AddAsync(Restaurantes restaurantes)
        {
            await _context.Restaurantes.AddAsync(restaurantes);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Restaurantes restaurantes)
        {
            _context.Restaurantes.Update(restaurantes);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var restaurante = await _context.Restaurantes.FindAsync(id);
            if (restaurante != null)
            {
                _context.Restaurantes.Remove(restaurante);
                await _context.SaveChangesAsync();
            }
        }
    }
}
