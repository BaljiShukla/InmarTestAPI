using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmarTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private OfferService _offerService { get; set; }
        public TestController(OfferService offerService)
        {
            this._offerService = offerService;
        }

        [HttpGet]
        public async Task<List<Product>> Get()
        {
            var products = _offerService.GetAllProducts();

            products = products.OrderBy(z => z.Price).Take(3).ToList();

            return products;
        }

        [HttpGet]
        public async Task<List<Product>> GetFilterWithSecondLowest()
        {
            var products = _offerService.GetAllProducts();

            products = products.OrderBy(z => z.Price).Take(1).ToList();

            var result = products.Where(s => s.Price == products[0].Price);

            return result;
        }
    }
}
