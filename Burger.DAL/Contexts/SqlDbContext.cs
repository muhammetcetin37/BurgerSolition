using Burger.Entities;
using Microsoft.EntityFrameworkCore;

namespace Burger.DAL.Contexts
{
    public class SqlDbContext : DbContext
    {
        //public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        //{

        //}
        public SqlDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Burger;Trusted_Connection=true");
        }
        public DbSet<Adres> Adresler { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<Menu> Menuler { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
}
