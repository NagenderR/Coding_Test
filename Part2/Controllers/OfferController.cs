using Microsoft.AspNetCore.Mvc;
using Part2.Models;
using System.Linq;

namespace Part2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OfferController : ControllerBase
    {
        OfferService _OfrService;
        public OfferController(OfferService offerService)
        {
            this._OfrService = offerService;
        }

        [HttpGet]
        [ActionName("GetTodaysOffers")]
        public List<Offer> GetTodaysOffers()
        {
            return this._OfrService.GetTodaysOffers();
        }

        [HttpGet]
        [ActionName("GetProductsWithLowestPrice")]
        public List<Product> GetProductsWithLowestPrice()
        {
            return this._OfrService.GetAllProducts().OrderByDescending(p=>p._Price).Take(3).ToList();
        }

        [HttpGet]
        [ActionName("GetProductWithSecondLowestPrice")]
        public Product GetProductWithSecondLowestPrice()
        {
            return this._OfrService.GetAllProducts().OrderByDescending(p => p._Price).Skip(1).First();
        }

    }
}