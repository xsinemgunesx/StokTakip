using System.ComponentModel.DataAnnotations;
using StokTakip.WepApp.Models.Dtos;

namespace StokTakip.WepApp.Models;

public class ProductViewModel//poduct class'ı tablo burası göstrlck kısım
{
    
   public List<ProductDto> ProductDtos { get; set; }    
    public int TotalStock { get; set; }
    public string SearchName { get; set; }
    public int PageSize { get; set; }
}
