namespace AmyCherrez_EjercicioCF.Models
{
    public class Promo
    {
        public int PromoId { get; set; }
        public string? PromoName { get; set; }
        public string? PromoDescription { get; set;}
        public int ID { get; set; }
        public Burgeer? Burger { get; set; }
    }
}
