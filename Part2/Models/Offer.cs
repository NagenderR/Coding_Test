using System.Runtime.CompilerServices;

namespace Part2.Models
{
    public class Offer 
    {
        private string _OfferName;
        private List<Product> _Products;

        public Offer(string offerName, List<Product> products)
        {
            this._OfferName = offerName;
            this._Products = products;
        }
    }
}
