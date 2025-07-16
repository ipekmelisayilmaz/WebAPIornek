using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIornek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController1 : ControllerBase
    {
        public static List<Product> Products { get; set; } = new(); //static olarak tanımlanırsa uygulama çalıştığı sürece bellekte tutulur DB gibi çalışır

        [HttpPost]//kayıt
        public IActionResult Create(Product product)
        {
            Products.Add(product);
            return Created();
        }
        [HttpGet]//listeleme
        public IActionResult Get()

        { 
            return Ok(Products);
        }

    }








}
