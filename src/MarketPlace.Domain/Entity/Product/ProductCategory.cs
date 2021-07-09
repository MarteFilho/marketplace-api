using System.Collections.Generic;

namespace MarketPlace.Domain.Entities
{
    public class ProductCategory : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<Product> Products { get; private set; }
    }
}