using Part2.Models;

namespace Part2
{
    public interface IOfferService
    {
        public List<Product> GetAllProducts();
        public List<Offer> GetTodaysOffers();
    }
}
