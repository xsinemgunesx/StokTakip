using StokTakip.WepApp.Models;

namespace StokTakip.WepApp.Repository
{
    public interface IProductRepository:IBaseRepository<Product>
    {
        List<Product> GetByStockRange(int min, int max);
        List<Product> GetByContainsName(string name);
    }
}
