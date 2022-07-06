namespace Burger.Entities
{
    public class MenuItem : BaseEntity
    {
        public int UrunId { get; set; }
        public Urun Urun { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
    }
}