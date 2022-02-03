using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmarTestAPI
{
    public class OfferService
    {
        private List<Product> Inventory { get; set; }

        public OfferService()
        {
            this.Inventory = this.CreateProducts();
        }
        private List<Product> CreateProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("P1", 1000, "P1 Desc"));
            products.Add(new Product("P2", 200, "P2 Desc"));
            products.Add(new Product("P3", 400, "P3 Desc"));
            products.Add(new Product("P4", 700, "P4 Desc"));
            products.Add(new Product("P5", 600, "P5 Desc"));
            products.Add(new Product("P6", 800, "P6 Desc"));

            return products;
        }

        public List<Product> GetAllProducts()
        {
            return Inventory.Select(s => s).ToList();
        }

        public Product GetTodaysOffers()
        {

        }
    }
}
