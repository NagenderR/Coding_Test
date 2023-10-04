using System.Runtime.CompilerServices;

namespace Part2.Models
{
    public class Product 
    {
        public string _ProductName;
        public decimal _Price;
        public string _Description;

        public Product(string productName, decimal price, string description)
        {
            this._ProductName = productName;
            this._Price = price;
            this._Description = description;
        }
    }
}
