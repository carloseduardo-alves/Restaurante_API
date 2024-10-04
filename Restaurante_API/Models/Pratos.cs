namespace Restaurante_API.Models
{
    public class Pratos
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
