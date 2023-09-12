using StokTakip.WepApp.Models;

namespace StokTakip.WepApp.Repository;
//concrete class = new olan classlar
public interface IBaseRepository<TEntity>where TEntity : Entity,new()
    //buraya gelen tiplerden new'lenen classları getir.
    //generic programlama-tentity = her türlü değeri alabilir rastgele isim
    //db  için ortak kolon tanımı tip genel tenttiy
{
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(int id);
    TEntity GetById(int id);
    List<TEntity> GetAll(); 
}
