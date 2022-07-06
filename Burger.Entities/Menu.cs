namespace Burger.Entities
{
    public class Menu : BaseEntity
    {
        public string MenuAdi { get; set; }
        public string Tanimlama { get; set; }
        public decimal Fiyat { get; set; }
        public IList<MenuItem> MenuItems { get; set; }
    }
}
