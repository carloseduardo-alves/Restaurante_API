using Restaurante_API.Models;

namespace Restaurante_API.Repositories
{
    public interface IRestauranteRepository
    {
        Task<IEnumerable<Restaurantes>> GetRestaurantes();
        Task<Restaurantes> GetByIdRestaurante(int id);
        Task AddAsync(Restaurantes restaurantes);
        Task UpdateAsync(Restaurantes restaurantes);
        Task DeleteAsync(int id);
    }
}
