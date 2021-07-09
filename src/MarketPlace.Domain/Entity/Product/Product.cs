using System;

namespace MarketPlace.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }
        public Guid ProductCategoryId { get; private set; }
        public ProductCategory ProductCategory { get; private set; }

        public static Product Create(string name, string description, double price)
        {
            Product product = new Product()
            {
                Name = name,
                Description = description,
                Price = price
            };
            return product;
        }
    }
}