namespace Restaurante_API.Models
{
    public class Restaurantes
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public required string Numero { get; set; }
        public List<Pratos> Pratos { get; set; } = new List<Pratos>();
    }
}
