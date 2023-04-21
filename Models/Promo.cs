namespace GG_Ejercicio2tablas.Models
{
    public class Promo
    {
        public int PromoID { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaPromo { get; set; }

        public int BurgerId { get; set; }
        public Burger? Burger { get; set;}

    }
}
