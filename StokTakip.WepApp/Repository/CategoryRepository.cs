using StokTakip.WepApp.Models;
using StokTakip.WepApp.Repository.EFRepository;

namespace StokTakip.WebApp.Repository;
//S single responsibility
// O open closed
//L liskov subtition
// i interface ayrışması
//D dependency inversion 
public class CategoryRepository : EfRepositoryBase<Category>, ICategoryRepository
{
    public CategoryRepository(BaseDbContext context): base(context)
    {

    }
}
//--EFRepository kullandığımız için bu sınıfın içini boşaltırız.
//private readonly BaseDbContext _baseDbContext;
//public CategoryRepository(BaseDbContext baseDbContext)
//{
//    _baseDbContext = baseDbContext;
//}

//public void Add(Category category)
//{
//    _baseDbContext.Categories.Add(category);
//    _baseDbContext.SaveChanges();
//}

//public void Delete(int id)
//{
//    Category category = _baseDbContext.Categories.Find(id);
//    _baseDbContext.Categories.Remove(category);
//    _baseDbContext.SaveChanges();
//}

//public List<Category> GetAll()
//{
//    return _baseDbContext.Categories.ToList();
//}

//public Category GetById(int id)
//{
//    return _baseDbContext.Categories.Find(id);
//}

//public void Update(Category category)
//{
//    _baseDbContext.Categories.Update(category);
//    _baseDbContext.SaveChanges();
//}