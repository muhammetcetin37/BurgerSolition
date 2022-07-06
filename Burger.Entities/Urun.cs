namespace Burger.Entities
{
    public enum Birim
    {
        Adet,
        Gram,
        Mililitre,
        Duzine,
        Palet
    }

    public class Urun : BaseEntity
    {
        public string UrunAdi { get; set; }
        public string? Aciklama { get; set; }
        public decimal? Adet { get; set; }
        public decimal? Fiyat { get; set; }
        public Birim Birim { get; set; } = Birim.Adet;
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
    }
}
