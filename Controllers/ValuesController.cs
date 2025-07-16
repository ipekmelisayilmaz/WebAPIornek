
using Microsoft.AspNetCore.Mvc;

namespace WebAPIornek.Controllers
{
    [Route("api/Values/[action]")]
    [ApiController]
    public sealed class ValuesController:ControllerBase
    {
        [HttpGet]//DB'den veri alınacak,okunacak örneğin liste döndürülecekse
        //[HttpPost]//karşı taraftan yapılan istekle DB'e veri eklenecekse,kayıt yapılacaksa 
        //[HttpPut]//karşı taraftan yapılan istekle DB'deki veri güncellenecekse,güncelleme işlemleri yapılacaksa
        //[HttpDelete]//karşı taraftan yapılan istekle DB'deki veri silinecekse,silme işlemleri yapılacaksa
        //yukarıda seçilen tipler bir kesinlik belirtmez temsilidir farklı işlemlerde kullanılabilirler.
        //post vea put işlemlerinde genellikle body'den veri alınır.endpoint yazıldığında metoda parametre verilecekse endpointin devamına ?x=1&y=2 gibi yazılır.buna query params denir.
        //GET'de olan tüm özellikler hepsinde vardır en alt basamak GET'dir
        //GET'de olmayan ise parametre bir obje olarak gönderilmek istenirse body'de json html xml formatlarında parametre gönderilebilir GET body'de taşınamaz POST veya PUT seçilmeli
        public IActionResult Hello(int x, int y)
        {
            return  Ok(new{ Message= (x+y)*10 });
        }

        [HttpPost]//GET ile body taşınamaz
        public IActionResult CreateProduct(CreateProductDto request)//Prosuct tipinde obje istenecek ama birden fazla obje istenemez
        {
            return StatusCode(200,new { Message = "Hello World!" });
        }

    }
    //body istemek için,class tanımlanır

    public class CreateProductDto//iki isteği tek objede getirmek için kullanılabilir
    {
        public Product Product { get; set; }
        public Category Category { get; set; } 
   

    }
    public class Product
    {
        public string Name { get; set; }=string.Empty;
    }
    public class  Category
    {
        public string Name { get; set; } = string.Empty;

    }
}
