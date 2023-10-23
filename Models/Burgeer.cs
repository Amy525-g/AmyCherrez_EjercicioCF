using System.ComponentModel.DataAnnotations;

namespace AmyCherrez_EjercicioCF.Models
{
    public class Burgeer
    {
        public int ID { get; set; }

        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }

        [ValidarRango]
        public decimal Precio { get; set; }
        public List<Promo>? Promo { get; set; }
    }

    public class ValidarRango:ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            decimal valor = (decimal)value;
            if (valor < 10) 
            { 
                return false; 
            }
            else
            { 
                return true; 
            }  
        }
    }
}
