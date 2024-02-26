using Microsoft.AspNetCore.Mvc;
using WebAPIPlayer.Models;

namespace WebAPIPlayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public static List<Product> products = new List<Product>()
        {
            new Product{PId=211, PName="Lame", Price=1202.41},
            new Product{PId=221, PName="OSL", Price=1122.41},
            new Product{PId=231, PName="MRF", Price = 1402.41}

        };
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return products;
        }
    }

}
