using System.Runtime.CompilerServices;

namespace Part2.Models
{
    public class OfferService : IOfferService
    {
        private List<Product> _Inventory = new List<Product>();

        public OfferService()
        {
            this.CreateInventory();
        }

        private void CreateInventory()
        {
            _Inventory = new List<Product>
            {
                new Product("P1",1000,"P1 Desc" ),
                new Product("P2",200,"P2 Desc" ),
                new Product("P3",400,"P3 Desc" ),
                new Product("P4",700,"P4 Desc" ),
                new Product("P5",600,"P5 Desc" ),
                new Product("P6",800,"P6 Desc" )
            };
        }

        public List<Product> GetAllProducts()
        {
            return _Inventory;
        }

        public List<Offer> GetTodaysOffers()
        {
            List<Offer> offers = new List<Offer>();
            offers.Add(new Offer("ComboPackage1", new List<Product>() { _Inventory[0], _Inventory[4], _Inventory[3] }));
            offers.Add(new Offer("ComboPackage2", new List<Product>() { _Inventory[3], _Inventory[0], _Inventory[5] }));
            offers.Add(new Offer("ComboPackage3", new List<Product>() { _Inventory[6], _Inventory[1], _Inventory[0] }));
            offers.Add(new Offer("ComboPackage4", new List<Product>() { _Inventory[5], _Inventory[2], _Inventory[3] }));
            return offers;
        }
    }
}
