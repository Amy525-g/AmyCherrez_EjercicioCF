using System.ComponentModel.DataAnnotations;

namespace AmyCherrez_EjercicioCF.Models
{
    public class Burgeer
    {
        public int ID { get; set; }

        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }

        [Range(0.01,99.99)]
        public decimal Precio { get; set; }
        public List<Promo>? Promo { get; set; }
    }
}
