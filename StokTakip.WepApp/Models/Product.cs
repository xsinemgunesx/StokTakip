namespace StokTakip.WepApp.Models;

public class Product:Entity
{
    //[Required]=>solid prensibine aykırı sadece tablo olmalı-degerler girilmeli zorunlu kılar   
   
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Dealer { get; set; }



    
}
