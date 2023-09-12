using Microsoft.AspNetCore.Mvc;
using StokTakip.WebApp.Repository;
using StokTakip.WepApp.Models;
using StokTakip.WepApp.Models.Dtos;

namespace StokTakip.WebApp.Controllers;

public class ProductController : Controller
{
    private readonly BaseDbContext _baseDbContext;//runtimeda asla değiştirilmez table sutun vs.

    public ProductController(BaseDbContext baseDbContext)
    {
        _baseDbContext = baseDbContext;
    }
    public IActionResult Index()
    {
        var products = _baseDbContext.Products.ToList();
        List<ProductDto> productDtoList = new List<ProductDto>();
        foreach (var product in products)
        {
            ProductDto productDto = new ProductDto()//her seferinde product göster
            {
                Id = product.Id,
                Name = product.Name,
                Dealer = product.Dealer,
                Description = product.Description,
                Price = product.Price,
                Stock = product.Stock,
               
            };
            productDtoList.Add(productDto);
        }
        ProductViewModel viewModel = new ProductViewModel()
        {
            ProductDtos = productDtoList,
            TotalStock = products.Sum(x => x.Stock),
        };
        return View(viewModel);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(ProductCreateDto product)
    {
        //Product product = new Product()
        //{
        //    Dealer=productDto.Dealer,
        //    Description = productDto.Description,   
        //    Name = productDto.Name, 
        //    Price = productDto.Price,
        //    Stock = productDto.Stock    

        //};
        Product product = productDto;
        _baseDbContext.Add(product);
        _baseDbContext.SaveChanges();
        return RedirectToAction("Index", "Product");
        
    }
    [HttpGet]
    public IActionResult Update(int id)
    {
        var product = _baseDbContext.Products.Find(id);
        return View(product);
    }
    [HttpPost]
    public IActionResult Update(Product product)
    {
        _baseDbContext.Products.Update(product);
        _baseDbContext.SaveChanges();

        return RedirectToAction("Details", "Product", new { id = product.Id });
    }
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var productId = _baseDbContext.Products.Find(id);
        _baseDbContext.Products.Remove(productId);
        _baseDbContext.SaveChanges();
        return RedirectToAction("Index", "Product");
    }
    [HttpGet]
    public IActionResult Details(int id)
    {
        Product? product = _baseDbContext.Products.SingleOrDefault(x => x.Id == id);
        return View(product);//gelen degeri view'e aktarma
    }
}