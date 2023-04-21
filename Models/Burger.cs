namespace GG_Ejercicio2tablas.Models
{
    public class Burger
    {
        public int BurgerId { get; set; }
        public string? Name { get; set; }
        public bool WithCheese { get; set; }

        public List<Promo>? Promos { get; set; }
    }

}
