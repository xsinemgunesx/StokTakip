using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using StokTakip.WepApp.Models;

namespace StokTakip.WebApp.Repository
{//db ile iletişime geçtiğimiz yer
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions opt) : base(opt) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Stok_Takip_Db; Trusted_Connection=true");//true=> güvenli bağlantı

        }
        public DbSet<Product> Products { get; set; }//db tables
        public DbSet <Category> Categories { get; set; }

    }
}