using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmarTestAPI
{
    public class Offer
    {
        public string OfferName { get; set; }
        public List<Product> Products { get; set; }

        public Offer(string offerName, List<Product> products)
        {
            this.OfferName = offerName;
            this.Products = products;
        }
    }
}
