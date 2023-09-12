using StokTakip.WebApp.Repository;
using StokTakip.WepApp.Models;
using StokTakip.WepApp.Repository.EFRepository;

namespace StokTakip.WepApp.Repository;

public class ProductRepository : EfRepositoryBase<Product>, IProductRepository
{

    public ProductRepository(BaseDbContext baseDbContext):base(baseDbContext)
    {
        
    }

    public List<Product> GetByContainsName(string name)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetByStockRange(int min, int max)
    {
        throw new NotImplementedException();
    }
}
